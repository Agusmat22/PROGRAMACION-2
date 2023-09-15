/*
Crear un método estático que reciba una fecha y calcule el número de días que pasaron 
desde esa fecha hasta la fecha actual. Tener en cuenta los años bisiestos.

Pedir por consola la fecha de nacimiento de una persona (día, mes y año) y 
calcule el número de días vividos por esa persona hasta la fecha actual utilizando el método desarrollado anteriormente.

Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio.


*/

using Entidades;

namespace ElTiempoPasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha;
            string fechaOrdenada;

            fecha = Fecha.PedirFechaNacimiento();
            
            Console.WriteLine("La fecha de nacimiento es: "+ Fecha.CalcularEdad(fecha));
        }
    }
}