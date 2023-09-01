/*
Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

Validar que el dato ingresado por el usuario sea un número.

Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

Si ingresa "salir", cerrar la consola.

Al finalizar, preguntar al usuario si desea volver a operar. 
Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.

*/

using LosPrimos;
using Logica;

namespace LosPrimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Funciones.NumerosPrimos(20);

            foreach(int n in list)
            {
                Console.WriteLine(n);
            }

            
        }
    }
}