/*
Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos 
(excluido el mismo) que son divisores del número.

El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

Escribir una aplicación que encuentre los 4 primeros números perfectos.

*/
namespace UnNumeroPerfecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int number = 1;

            Console.WriteLine("Los primeros 4 números perfectos son:");

            while (count < 4)
            {
                if (IsPerfectNumber(number))
                {
                    Console.WriteLine(number);
                    count++;
                }
                number++;
            }

        }

        static bool IsPerfectNumber(int num)
        {
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            return sum == num;
        }
    }
}