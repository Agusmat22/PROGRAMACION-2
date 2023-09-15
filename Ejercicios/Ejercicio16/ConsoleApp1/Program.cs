using Entidades;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area del circulo: "+CalculadoraDeArea.CalcularAreaCirculo(5));

            Console.WriteLine("Area del triangulo: " + CalculadoraDeArea.CalcularAreaTriangulo(5,10));

            Console.WriteLine("Area del cuadrado: " + CalculadoraDeArea.CalcularAreaCuadrado(20));
        }
    }
}