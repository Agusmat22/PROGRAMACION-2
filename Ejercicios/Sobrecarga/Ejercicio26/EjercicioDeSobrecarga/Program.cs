/*
Crear un proyecto de tipo biblioteca de clases y agregar la clase Sumador.


Generar una conversión explícita que retorne cantidadSumas.

Sobrecargar el operador + (suma) con dos operadores de tipo Sumador. 
El resultado será un long correspondiente al resultado de la suma del atributo cantidadSumas de cada argumento.

Sobrecargar el operador | (pipe) con dos operadores de tipo Sumador. 
Deberá retornar true si ambos sumadores tienen igual valor en el atributo cantidadSumas.

Agregar un segundo objeto del tipo Sumador en el método Main y probar el código.

*/

using Entidades;

namespace EjercicioDeSobrecarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador1 = new Sumador();
            Sumador sumador2 = new Sumador();

            int numero = (int)sumador1;

            Console.WriteLine($"La cantidad de sumas realizadas en el sumador 1 son: {numero}");

            Console.WriteLine($"El sumador 1 y el sumador 2 contienen la misma cantidad de sumas? :{sumador1 | sumador2}");

            long suma = sumador1.Sumar(1230, 546);
            long suma2 = sumador2.Sumar(10, 546);

            Console.WriteLine($"La suma es: {suma}");

            Console.WriteLine($"La cantidad de suma entre los dos sumadores son: {sumador1 + sumador2}");

        }
    }
}