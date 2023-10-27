using Entidades;

namespace PlacaDeCronicaTV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = DateTime.Now;


            Console.WriteLine($"Dia de diferencia: {fecha.ObtenerPlacaCronicaTV(Entidades.EEstaciones.Verano)}");
        }
    }
}