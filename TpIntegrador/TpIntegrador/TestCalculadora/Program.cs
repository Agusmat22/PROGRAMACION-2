using Entidades;

namespace TestCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numeracion operador1 = new Numeracion(100, ESistema.Decimal);
            Numeracion operador2 = new Numeracion(50, ESistema.Decimal);
            Numeracion operador3 = new Numeracion(4, ESistema.Binario);
            Numeracion operador4 = new Numeracion(4, ESistema.Binario);

            Operacion calculadora = new Operacion(operador1, operador3);

            Operacion calculadora2 = new Operacion(operador4, operador3);

            Numeracion resultado = calculadora2.Operar('a');

            Console.WriteLine(resultado.ValorNumerico);
        }
    }
}