/*
Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
*/

using Entidades;

namespace ErrorAlCubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCast;
            while (true)
            {
                string numIngresado = Funciones.PedirDato("Ingrese un numero: ");

                

                while (!int.TryParse(numIngresado,out numCast)) 
                {
                    numIngresado = Funciones.PedirDato("Error, Ingrese un numero: ");
                }

                double numCuadrado = Funciones.CalcularPotencia(numCast,2);
                double numCubo = Funciones.CalcularPotencia(numCast,3);

                Console.WriteLine($"Numero Cuadrado: {numCuadrado}\nNumero Cubo: {numCubo}\n\n");

                string continuar = Funciones.PedirDato("Desea continuar( Presione cualquier tecla para continuar o Z para salir )");
                if (!string.IsNullOrEmpty(continuar) && continuar.ToString() == "z")
                {
                    break;
                }
            }
        }
    }
}