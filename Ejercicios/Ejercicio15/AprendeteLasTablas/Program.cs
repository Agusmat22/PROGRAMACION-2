
using Entidades;

namespace AprendeteLasTablas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado = Matematica.PedirNumero("Ingrese un numero");
            
            string tablaMultiplicar = Matematica.TablaMultiplicar(numeroIngresado);
            Console.WriteLine(tablaMultiplicar);
        }
    }
}