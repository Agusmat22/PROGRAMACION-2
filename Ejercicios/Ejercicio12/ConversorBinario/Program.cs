/*
Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):

El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.

    public string ConvertirDecimalABinario(int numeroEntero) {}

El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.

    public int ConvertirBinarioADecimal(int numeroEntero) {}

*/

using Entidades;

namespace ConversorBinario
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Conversor.ConversorDecimalABinario(16));
            Console.WriteLine(Conversor.ConvertirBinarioADecimal("0101"));
        }
    }
}