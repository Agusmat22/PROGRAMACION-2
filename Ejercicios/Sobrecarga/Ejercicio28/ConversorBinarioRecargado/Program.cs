using Entidades;

namespace ConversorBinarioRecargado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumeroBinario numBinario = "1001";

            NumeroDecimal numDecimal = 10;

            Console.WriteLine(Conversor.ConvertirBinarioADecimal(numBinario));
            Console.WriteLine($"El numero decimal y binario tienen el mismo valor? {numBinario == numDecimal}");

        }
    }
}