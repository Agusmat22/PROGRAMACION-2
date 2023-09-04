/*
Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):

El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.

    public string ConvertirDecimalABinario(int numeroEntero) {}

El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.

    public int ConvertirBinarioADecimal(int numeroEntero) {}

*/

namespace Entidades
{
    public static class Conversor
    {
        /// <summary>
        /// Convierte un numero decimal a binario
        /// </summary>
        /// <param name="numeroDecimal"></param>
        /// <returns>Retorna un numero binario en tipo string</returns>
        public static string ConversorDecimalABinario(int numeroDecimal)
        {
            int dividendo = numeroDecimal;
            int divisor = 2;
            double resto;
            string numeroBinario = "";

            while (true)
            {
                
                if (dividendo >= divisor)
                {
                    resto = dividendo % divisor;
                    dividendo = dividendo / divisor;

                    if (resto == 0 || resto == 1)
                    {
                        numeroBinario += resto.ToString();

                    }
                }
                else
                {
                    numeroBinario += dividendo.ToString();
                    break;
                }
            }

            return InvertirString(numeroBinario);
        }

        /// <summary>
        /// Convierte un binario a decimal
        /// </summary>
        /// <param name="numeroBinario"></param>
        /// <returns>Retorna un numero decimal en tipo int</returns>
        public static int ConvertirBinarioADecimal(string numeroBinario)
        {
            int numeroCaracter;
            int numeroBaseDos = 2;
            int cantidadNumeros = numeroBinario.Length -1;
            double numeroDecimal = 0;

            for (int i = cantidadNumeros ; i >= 0; i--)
            {
                char caracter = numeroBinario[i];
                int.TryParse(caracter.ToString(), out numeroCaracter);

                numeroDecimal += numeroCaracter * Math.Pow(numeroBaseDos, cantidadNumeros-i);
            }

            return (int)numeroDecimal;
        }



        /// <summary>
        /// Esta funcion acepta por parametro unicamente un string y retornara una cadena invertida
        /// </summary>
        /// <param name="dato">Ingresar una cadena</param>
        /// <returns>Retornara la cadena invertida</returns>
        public static string InvertirString(string dato)
        {
            string cadenaInvertida = "";

            for (int i = dato.Length; i > 0 ; i--)
            {
                cadenaInvertida += dato[i-1];
            }
            return cadenaInvertida;

        }
       

    }
}