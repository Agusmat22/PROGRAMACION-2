using Entidades;

namespace ContadorDeDigitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("Ingrese un numero: ");
                string numeroIngresado = Console.ReadLine();

                
                if (Int64.TryParse(numeroIngresado, out Int64 numero))
                {
                    Console.WriteLine($"Numero de: {numero.ContarCantidadDeDigitos()}");                   
                }
                else
                {
                    Console.WriteLine("Error, debe ingresar un numero");
                }


            }
        }
    }
}