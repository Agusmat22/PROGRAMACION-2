using System.Text;

namespace Entidades
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public AutoF1(string escuderia, short numero):base(escuderia,numero)
        {
            
        }

        public AutoF1(string escuderia,short numero,short caballosDeFuerza): this(escuderia,numero)
        {
            this.CaballosDeFuerza = caballosDeFuerza;
        }

        public short CaballosDeFuerza 
        {
            get
            {
                return caballosDeFuerza;
            }

            set
            {
                caballosDeFuerza = value;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Caballos de fuerza: {this.CaballosDeFuerza}");

            return sb.ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return a1.CaballosDeFuerza == a2.CaballosDeFuerza;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

    }
}