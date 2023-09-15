

using Billetes;

namespace AppCotizador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dolar dolar = new Dolar(100);
            Euro euro = 100;
            Peso peso = (Peso)dolar;

            /*
             *FUNCIONA TODO CORRECTAMENTE 
             
            peso = (Peso)dolar;
            Console.WriteLine($"Dolares: {dolar.GetCantidad()} pasados a pesos son: {peso.GetCantidad()}");

            euro = (Euro)dolar;
            Console.WriteLine($"Dolares: {dolar.GetCantidad()} pasados a euros son: {euro.GetCantidad().ToString("0.00")}");

            dolar = (Dolar)peso;
            Console.WriteLine($"Pesos: {peso.GetCantidad()} pasados a dolares son: {dolar.GetCantidad().ToString("0.00")}");
            
            
            bool valor = euro == dolar;

            Console.WriteLine($"Son iguales la cantidad de euro y dolares? {euro == dolar}");
            Console.WriteLine($"Son distintos la cantidad de euro y dolares? {euro != dolar}");

            Console.WriteLine($"Son iguales la cantidad de dolares y pesos? {peso == dolar}");
            */

            Euro sumaTotal = euro + dolar;
            Console.WriteLine($"La suma entre {euro.GetCantidad()} euros y " +
                $"{dolar.GetCantidad()} dolares es: {sumaTotal.GetCantidad()}");

            Peso sumaTotal2 = peso + dolar;
            Console.WriteLine($"La suma entre {peso.GetCantidad()} pesos y " +
                $"{dolar.GetCantidad()} dolares es: {sumaTotal2.GetCantidad()}");

            sumaTotal2 = peso + euro;

            Console.WriteLine($"La suma entre {peso.GetCantidad()} pesos y " +
                $"{euro.GetCantidad()} euros es: {sumaTotal2.GetCantidad()}");
        }
    }
}