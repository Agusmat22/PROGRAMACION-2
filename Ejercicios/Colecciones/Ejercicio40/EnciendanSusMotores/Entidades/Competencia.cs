using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;


        private Competencia()
        {
            competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas):this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public short CantidadCompetidores
        {
            get
            {
                return cantidadCompetidores;
            }
        }

        public short CantidadVueltas
        {
            get
            {
                return cantidadVueltas;
            }
        }

        public short CompetidoresAnotados
        {
            get
            {
                return (short)competidores.Count;
            }
        }

        public static bool operator == (Competencia competencia, AutoF1 auto)
        {

            bool value = false;

            if (competencia.competidores.Count > 0)
            {
                foreach (AutoF1 auto1 in competencia.competidores)
                {
                    if (auto1 == auto)
                    {
                        value = true;
                        break;
                    }
                }
            }
            
            return value;

        }

        public static bool operator !=(Competencia competencia, AutoF1 auto)
        {
            return !(competencia == auto);
        }

        public static bool operator +(Competencia competencia, AutoF1 auto)
        {
            bool value = true;

            if (competencia.competidores.Count <= competencia.cantidadCompetidores && competencia != auto)
            {
                Random random = new Random();

                competencia.competidores.Add(auto);
                auto.EnCompetencia = true;
                auto.VueltasRestantes = competencia.cantidadVueltas;
                auto.CantidadCombustible = (short)random.Next(15, 100);
            }
            else
            {
                value = false;
            }

            return value;
        }
    }
}
