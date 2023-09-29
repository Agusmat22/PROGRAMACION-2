using Entidades;

namespace HerenciaDeportiva
{
    public class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador = new Jugador(41765, "agustin", 10, 50);
            DirectorTecnico dt = new DirectorTecnico("jorge",DateTime.Now);

            Console.WriteLine(jugador.MostrarDatos());
            Console.WriteLine(dt.MostrarDatos());
        }
    }
}