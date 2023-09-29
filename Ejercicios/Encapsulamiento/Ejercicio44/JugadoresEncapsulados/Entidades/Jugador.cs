using System.Runtime.InteropServices;
using System.Text;

namespace Entidades
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;


        public Jugador(int dni, string nombre) : base(dni, nombre)
        {
            
        }

        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles):this(dni,nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }

        public int PartidosJugados
        {
            get { return this.partidosJugados; }
        }

        public int TotalGoles
        {
            get { return this.totalGoles; }
        }

        public double PromedioGoles
        {
            get
            {
                return (double)TotalGoles / PartidosJugados;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos()); // llamo al metodo padre
            sb.AppendLine($"Partidos jugados: {PartidosJugados}");
            sb.AppendLine($"Total Goles: {TotalGoles}");
            sb.AppendLine($"Promedio de gol: {PromedioGoles}");

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2); 
        }

    }
}