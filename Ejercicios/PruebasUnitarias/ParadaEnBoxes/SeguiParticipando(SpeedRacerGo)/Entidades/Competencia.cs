using Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace Entidades
{
    public class Competencia
    {
        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }


        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;


        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas,TipoCompetencia tipo):this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            this.tipo = tipo;
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

        public TipoCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }
        }

        /// <summary>
        /// Retorna true si el vehiculo esta dentro de la competencia o si difierente el tipo de competencia con vehiculo
        /// </summary>
        /// <param name="competencia"></param>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public static bool operator == (Competencia competencia, VehiculoDeCarrera vehiculo)
        {

            bool value = false;
            //Valido si la competencia es de f1 y si el vehiculo es del tipo de la class Autof1
            if (competencia.Tipo == Competencia.TipoCompetencia.F1 && vehiculo.GetType() == typeof(AutoF1) ||
                            competencia.Tipo == Competencia.TipoCompetencia.MotoCross && vehiculo.GetType() == typeof(MotoCross))
            {
                if (competencia.competidores.Count > 0)
                {
                    foreach (VehiculoDeCarrera vehiculoGuardado in competencia.competidores)
                    {
                        if (vehiculoGuardado == vehiculo)
                        {
                            value = true;
                            break;
                        }
                    }
                }

            }
            else
            {
                throw new Excepciones.CompetenciaNoDisponibleException("El vehiculo no corresponde a la competencia",
                    "sobrecarga == ", "Competencia");

            }

            return value;
        }

        public static bool operator !=(Competencia competencia, VehiculoDeCarrera vehiculo)
        {
            return !(competencia == vehiculo);
        }

        public static bool operator +(Competencia competencia, VehiculoDeCarrera vehiculo)
        {
            bool value = true;

            try
            {
                if (competencia.competidores.Count < competencia.cantidadCompetidores && competencia != vehiculo)
                {
                    Random random = new Random();

                    competencia.competidores.Add(vehiculo);
                    vehiculo.EnCompetencia = true;
                    vehiculo.VueltasRestantes = competencia.cantidadVueltas;
                    vehiculo.CantidadCombustible = (short)random.Next(15, 100);
                }
                else
                {
                    value = false;
                }

            }
            catch (CompetenciaNoDisponibleException ex)
            {
                throw new CompetenciaNoDisponibleException("Competencia incorrecta", "Competencia", "Sobrecarga +", ex);
            }
            

            return value;
        }
    }
}
