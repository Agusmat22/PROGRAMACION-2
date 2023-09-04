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

namespace Entidades
{
    public class Calculadora
    {


        public static int PedirNumero(string mensaje)
        {
            int numeroParse;
            Console.WriteLine(mensaje);
            bool estadoParse = ParseNumeroEntero(Console.ReadLine(), out numeroParse);

            while (!estadoParse)
            {
                Console.WriteLine("Error, "+mensaje);
                estadoParse = ParseNumeroEntero(Console.ReadLine(), out numeroParse);
            }

            return numeroParse;
        }

        public static string PedirTipoOperacion(string mensaje, params string[] tipos)
        {
            Console.WriteLine(mensaje);
            string operacion = Console.ReadLine();

            while (!tipos.Contains(operacion))
            {
                Console.WriteLine("Error, " + mensaje);
                operacion = Console.ReadLine();
            }

            return operacion;
        }

        private static bool ParseNumeroEntero(string numero,out int numParse)
        {
            return int.TryParse(numero, out numParse);
        }

        public static double Calcular(int priNumero,int segNumero,string operacionMatematica)
        {
            double resultadoOperacion = 0;

            switch(operacionMatematica)
            {
                case "+":

                    resultadoOperacion = Sumar(priNumero, segNumero);
                    break;

                case "-":

                    resultadoOperacion = Restar(priNumero, segNumero);
                    break;

                case "*":

                    resultadoOperacion = Multiplicar(priNumero, segNumero);
                    break;

                case "/":
                    resultadoOperacion = Dividir(priNumero, segNumero);                    
                    break;
            }

            return resultadoOperacion;

        }

        private static double Sumar(int priNumero,int segNumero)
        {

            return priNumero + segNumero;
        }

        private static double Restar(int priNumero, int segNumero)
        {
            return priNumero - segNumero;   
        }

        private static double Dividir(int priNumero, int segNumero)
        {
            return priNumero / segNumero;
        }

        private static double Multiplicar(int priNumero, int segNumero)
        {
            return priNumero * segNumero;
        }


        /// <summary>
        /// Valida si un numero es distinto de 0
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Retorna true si es distinto y false si es igual</returns>
        public static bool Validar(int numero)
        {
            return numero != 0;
        }
    }
}