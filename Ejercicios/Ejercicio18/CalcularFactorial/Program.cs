/*
El factorial de un número es una operación que consiste en multiplicar un numero “n” 
por todos los números enteros positivos que estén debajo de él, 
por ejemplo el factorial de 3 es el resultado de multiplicar 3 por 2 por 1.


En una aplicación de consola, desarrollar un método estático que calcule el factorial de un número dado.

*/
namespace CalcularFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(PedirDato("Ingrese un numero: "), out int numero);

            bool flag = true;
            int factorial = 0;

            for(int i = 1; i <= numero; i++)
            {
                if (flag)
                {
                    flag = false;
                    factorial = i * i;
                    
                }
                else 
                { 
                    factorial *= i;
                }

                
            }
            Console.WriteLine(factorial);
        }


        public static string PedirDato(string mensaje)
        {
            Console.WriteLine(mensaje);
            string dato = Console.ReadLine();

            return dato;
        }
    }

    
}