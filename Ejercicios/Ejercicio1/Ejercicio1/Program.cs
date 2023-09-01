/*
Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.

INFORMACIÓN
Un escalar es una constante o variable que contiene un dato atómico y unidimensional. En contraposición al concepto de escalar, 
están los conceptos de array, lista y objeto, que pueden tener almacenado en su estructura más de un valor.​


*/

using Entidades;
using System;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creo un array de 5 numeros
            int[] arrayNumeros = Logica.SolicitarNumeros(2, "Ingrese un numero");


            double sumaTotal = 0;
            int numeroMenor = 0;
            int numeroMayor = 0;
            double promedio;

            bool flag = true;

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                if (flag)
                {
                    numeroMayor = arrayNumeros[i];
                    numeroMenor = arrayNumeros[i];
                    flag = false;
                }
                else
                {
                    if (numeroMayor < arrayNumeros[i])
                    {
                        numeroMayor = arrayNumeros[i];
                    }
                    else if (numeroMenor > arrayNumeros[i])
                    {
                        numeroMenor = arrayNumeros[i];
                    }
                }

                sumaTotal += arrayNumeros[i];
            }

            promedio = sumaTotal / arrayNumeros.Length;

            Console.WriteLine("Promedio: "+ promedio);
            Console.WriteLine("Numero Mayor ingresado "+ numeroMayor);
            Console.WriteLine("Numero Menor ingresado " + numeroMenor);
        }
    }
}