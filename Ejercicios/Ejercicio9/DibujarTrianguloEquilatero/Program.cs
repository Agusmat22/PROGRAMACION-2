/*
Escribir un programa que imprima por consola un triángulo como el siguiente:

        *
       ***
      *****
     *******
    *********

El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. 
Para el ejemplo anterior, la altura ingresada fue de 5.

*/
namespace DibujarTrianguloEquilatero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string simbolo = "*";
            int numero;

            Console.WriteLine("Ingrese un numero: ");
            string numIngresado = Console.ReadLine();

            while(!int.TryParse(numIngresado,out numero))
            {
                Console.WriteLine("Error, Ingrese un numero: ");
                numIngresado = Console.ReadLine();
            }
            
            

            for (int i = 0; i < numero; i++)
            {
                if (i!=0)
                {
                    simbolo += "**";
                }
                
                Console.WriteLine(simbolo.PadLeft(numero + i));
            }

            Console.ReadKey();
        }
    }
}