using Entidades;
using static Entidades.Numeracion;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Numeracion operador3 = new Numeracion(10, ESistema.Binario);
            Numeracion operador4 = new Numeracion(10, ESistema.Binario);


            Operacion calculadora2 = new Operacion(operador4, operador3);

            Numeracion resultado2 = calculadora2.Operar('+');

            Console.WriteLine(resultado2.ValorNumerico);

            //Console.WriteLine(operador3.ValorNumerico);
            /*
            Console.WriteLine("//------------------------------------------------------------------------//");

            Numeracion operador1 = new Numeracion(100, ESistema.Decimal);
            Numeracion operador2 = new Numeracion(0, ESistema.Decimal);

            Operacion calculadora = new Operacion(operador1, operador2);

            Numeracion resultado = calculadora.Operar('*');

            Console.WriteLine("Multiplicacion: "+resultado.ValorNumerico);

            resultado = calculadora.Operar('/');

            Console.WriteLine("Division: " +resultado.ValorNumerico);

            resultado = calculadora.Operar('+');

            Console.WriteLine("Suma: " +resultado.ValorNumerico);

            resultado = calculadora.Operar('+');

            Console.WriteLine("Suma: " + resultado.ValorNumerico);*/

        }
    }
}