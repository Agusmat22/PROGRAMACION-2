/*
Crear una aplicación de consola que permita al usuario ingresar un número entero.

Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación de ese número
en formato string.

Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.

Mostrar en la consola el resultado.

Por ejemplo, si se ingresa el número 2 la salida deberá ser:

*/
using System.Text;

namespace Entidades
{
    public class Matematica
    {


        public static int PedirNumero(string mensaje)
        {
            Console.WriteLine(mensaje);
            int.TryParse(Console.ReadLine(), out int numero);

            return numero;
        }

        public static string TablaMultiplicar(int numero)
        {
            string tabla;

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"La tabla de multiplicar del numero {numero} es: \n");

            for (int i = 1; i < 10; i++)
            {
                stringBuilder.AppendLine($"{numero} x {i} = {numero * i}");
            }

            return stringBuilder.ToString();

        }

    }
}