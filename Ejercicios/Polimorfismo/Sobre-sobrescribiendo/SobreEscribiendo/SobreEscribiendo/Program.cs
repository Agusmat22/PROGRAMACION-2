using Entidades;

namespace SobreEscribiendo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Title = "Ejercicio Sobre-Sobrescrito";
            Sobrescrito objetoSobrescrito = new Sobrescrito();

            Console.WriteLine(objetoSobrescrito.ToString());

            string objeto = "¡Este es mi método ToString sobrescrito!";

            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(objetoSobrescrito.Equals(objeto));

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(objetoSobrescrito.GetHashCode());

            Console.ReadKey();
            */
            Console.Title = "Ejercicio Sobre-Sobrescrito";
            SobreSobrescrito objetoSobrescrito = new SobreSobrescrito();
            SobreSobrescrito objetoSobrescrito2 = new SobreSobrescrito();

            Random random = new Random();

            Console.WriteLine(objetoSobrescrito.ToString());

            string objeto = "¡Este es mi método ToString sobrescrito!";

            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(objetoSobrescrito.Equals(objeto));

            Console.WriteLine("----------------------------------------------");

            Console.Write("Comparación Sobrecargas otro objeto: ");
            Console.WriteLine(objetoSobrescrito.Equals(objetoSobrescrito2));

            Console.WriteLine("----------------------------------------------");

            Console.Write("Comparación equals con otro objeto de distinto tipo: ");
            Console.WriteLine(objetoSobrescrito.Equals(random));

            Console.WriteLine("----------------------------------------------");

            


            Console.WriteLine(objetoSobrescrito.GetHashCode());

            Console.ReadKey();

        }
    }
}