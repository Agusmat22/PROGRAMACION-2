/*
 Escribir un programa que imprima por consola un triángulo como el siguiente:
*
***
*****
*******
*********

El usuario indicará cuál será la altura del triángulo
ingresando un número entero positivo. Para el ejemplo anterior, la altura ingresada fue de 5.


*/

namespace DibujarTrianguloRectangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ast = "*";
            for (int i = 0; i < 5; i++)
            {
                if (i != 0)
                {
                    ast += "**";
                }

                Console.WriteLine(ast);
            }
        }
    }
}