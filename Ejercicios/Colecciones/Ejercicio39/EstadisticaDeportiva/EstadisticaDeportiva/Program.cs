using Entidades;

namespace EstadisticaDeportiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(10,"boca");

            Jugador j1 = new Jugador(43173652, "Agustin");
            Jugador j2 = new Jugador(43173652, "Agustin");
            Jugador j3 = new Jugador(123456, "Ramon");


            bool sumaJ1 = equipo + j1;

            Console.WriteLine("Primera suma: " + sumaJ1);

            bool sumaJ2 = equipo + j2;

            Console.WriteLine("Segunda suma: " + sumaJ2 + " Tienen el mismo dni");

            bool sumaJ3 = equipo + j3;

            Console.WriteLine("Tercera suma: " + sumaJ3);
        }
    }
}