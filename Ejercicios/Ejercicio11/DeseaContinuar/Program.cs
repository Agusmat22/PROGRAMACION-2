/*
Consigna
Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje 
"¿Desea continuar? (S/N)".

Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.

Resolución

*/

using Entidades;

namespace DeseaContinuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            bool valorParse = false;
            int sumaTotal = 0;
            int numero;

            while (flag) 
            {
                valorParse = Funciones.ParseNumero(Funciones.PedirDato("Ingrese un numero entero: "),out numero);

                while (!valorParse)
                {
                    valorParse = Funciones.ParseNumero(Funciones.PedirDato("Error, Re ingrese un numero entero: "), out numero);
                }

                sumaTotal += numero;

                flag = Validador.ValidarRespuesta(Funciones.PedirDato("¿Desea continuar? (S/N) "), "s");

            }

            Console.WriteLine("La suma total es: " + sumaTotal);
        }
    }
}