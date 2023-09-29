using Entidades;
namespace JugadoresEncapsulados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(3,"River"); // Inicializo que solo tres jugadores tendran el equipo

            Jugador jugador1 = new Jugador(43173652,"Agustin",10,20);
            Jugador jugador2 = new Jugador(43173652,"Lucas",5,1);
            Jugador jugador3 = new Jugador(1234564,"Ramon");
            Jugador jugador4 = new Jugador(15466,"Jose");
            Jugador jugador5 = new Jugador(234,"Jose");


            Console.WriteLine("Agrego al primer jugador: " + (equipo + jugador1));
            Console.WriteLine("Agrego al segundo jugador: " + (equipo + jugador2));
            Console.WriteLine("Agrego al tercero jugador: " + (equipo + jugador3));
            Console.WriteLine("Agrego al cuarto jugador: " + (equipo + jugador4));
            Console.WriteLine("Agrego al quinto jugador: " + (equipo + jugador5) + "\n");

            Console.WriteLine(jugador1.MostrarDatos());
            Console.WriteLine("------------------------------------");
            Console.WriteLine(jugador2.MostrarDatos());

        }
    }
}