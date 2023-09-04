/*
Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).

Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

Calcular(público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática.
El método devolverá el resultado de la operación.

Validar (privado): Recibirá como parámetro el segundo operando. 
Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. 
Este método devolverá true si el operando es distinto de cero.

Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).

El usuario decidirá cuándo finalizar el programa.
*/

using Entidades;

namespace LaCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int priNumero;
            int segNumero;
            string tipoOperacion;
            double resultado;
            bool run = true;

            while (run) 
            {
                tipoOperacion = Calculadora.PedirTipoOperacion("Ingrese el tipo de operacion: ", "/", "*", "-", "+");

                priNumero = Calculadora.PedirNumero("Ingrese el primer numero");
  
                segNumero = Calculadora.PedirNumero("Ingrese el segundo numero");

                while(tipoOperacion == "/" && !Calculadora.Validar(segNumero))
                {
                    segNumero = Calculadora.PedirNumero("Error,Re ingrese el segundo numero distinto de 0");

                }

                resultado = Calculadora.Calcular(priNumero, segNumero, tipoOperacion);

                Console.WriteLine("El resultado es: " + resultado);

                Console.WriteLine("Desea continuar? (S/N) ");
                run = Validador.SeleccionarOpcion(Console.ReadLine(), "s");

            }
        }
    }
}