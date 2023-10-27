using Entidades;

namespace PuntoYSeguido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra = "hola,tengo.mucha;hambre";
            Console.WriteLine(palabra.ContadorSignosDePuntuacion());
        }
    }
}