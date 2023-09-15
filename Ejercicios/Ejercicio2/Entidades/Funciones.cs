/*
Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
*/

namespace Entidades
{
    public static class Funciones
    {
        public static string PedirDato(string message)
        {
            Console.WriteLine(message);
            string mensaje = Console.ReadLine();

            return mensaje;
        }

        public static double CalcularPotencia(int numero,int pot)
        {
            //double result = Math.Pow(pot, numero);
            double result = Math.Pow(numero, pot);

            return result;
        }
    }
}