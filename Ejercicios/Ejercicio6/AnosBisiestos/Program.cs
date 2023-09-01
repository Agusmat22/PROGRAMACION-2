/*
Escribir un programa que determine si un año es bisiesto.

Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, 
salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.

Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.


*/
using Entidades;

namespace AnosBisiestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mensaje = "Ingrese el año de inicio: ";

            int anoBisiesto = 4;

            int pFecha;
            int uFecha;

            //string primerFecha = ;

            while (!int.TryParse(Funciones.PedirDato(mensaje), out pFecha))
            {
                mensaje = "ERROR, Re ingrese el año de inicio: ";
            }

            mensaje = "Ingrese el año final: ";

            while (!int.TryParse(Funciones.PedirDato(mensaje), out uFecha))
            {
                mensaje = "ERROR, Re ingrese el año final: ";
            }

            for (int i = pFecha;  i <= uFecha; i++) 
            {

                if (!Funciones.CalcularMultiplo(i, 100) && Funciones.CalcularMultiplo(i, anoBisiesto) || Funciones.CalcularMultiplo(i, 400))
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}