using Entidades;

namespace ConsultaIndice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Libro libro = new Libro();

            libro[0] = "Hola soy agustin";

            Console.WriteLine(libro[0]);

            libro[12] = "Cambie el valor";

            Console.WriteLine(libro[1]);


        }
    }


    
}