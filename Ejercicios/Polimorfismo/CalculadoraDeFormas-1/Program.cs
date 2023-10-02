using Entidades;

namespace CalculadoraDeFormas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuadrado cuadrado = new Cuadrado(5,5);
            Rectangulo rectangulo = new Rectangulo(5,8);
            Circulo circulo = new Circulo(5);

            List<Figura> listaFiguras = new List<Figura>();

            listaFiguras.Add(cuadrado);
            listaFiguras.Add(rectangulo);
            listaFiguras.Add(circulo);

            foreach (Figura item in listaFiguras)
            {
                Console.WriteLine(item.Mostrar());
            }
        }
    }
}