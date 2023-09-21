using System.Text;

namespace Entidades
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        private AutoF1()
        {
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }

        public AutoF1(short numero,string escuderia):this()
        { 
            this.numero = numero;
            this.escuderia = escuderia;
        }

        public short Numero
        {
            get
            {
                return this.numero;
            }
        }

        public string Escuderia
        {
            get
            {
                return this.escuderia;
            }
        }

        public short VueltasRestantes
        {
            get 
            {
                return this.vueltasRestantes;
            }

            set
            {
                if (value > 0 && value < 20)
                {
                    this.vueltasRestantes = value; 
                }

            }
        }

        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }

            set
            {
                if (value > 0 && value < 100)
                {
                    this.cantidadCombustible = value;
                }
            }
        }

        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }

            set
            {
                
                this.enCompetencia = value;
            }
        }


        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Numero: {this.numero}");
            sb.AppendLine($"Vueltas restantes: {this.vueltasRestantes}");
            sb.AppendLine($"Cantidad de combustible: {this.cantidadCombustible}");
            sb.AppendLine($"Escuderia: {this.escuderia}");

            return sb.ToString();
        }

        public static bool operator ==(AutoF1 a1,AutoF1 a2)
        {
            return a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

    }
}