using System.Text;

namespace Conversor
{
    public static class Numero
    {
        public static string DecimalABinario(double numero)
        {
            StringBuilder numeroBinario = new StringBuilder();

            int dividendo = (int)numero;
            int divisor = 2;
            int resto;

            while (true)
            {
                if (dividendo >= divisor)
                {
                    resto = dividendo % divisor;
                    dividendo /= divisor;

                    numeroBinario.Append(resto);
                    
                }
                else 
                {
                    numeroBinario.Append(dividendo);
                    break;  
                }

            }

            return InvertirCadena(numeroBinario.ToString());

        }

        public static double BinarioADecimal(string binario)
        {
            int cantidadDigitos = binario.Length - 1;
            double numeroDecimal = 0;
            int numero;
            char digito;

           for (int i = cantidadDigitos; i >= 0; i--) 
           { 
                digito = binario[i];
                int.TryParse(digito.ToString(), out numero);
                numeroDecimal += numero * Math.Pow(2,cantidadDigitos - i);
            
           }

           return numeroDecimal;

        }

        public static string InvertirCadena (string cadena)
        {
            StringBuilder cadenaInvertida = new StringBuilder();
            int largoCadena = cadena.Length - 1;

            for (int i = largoCadena; i >= 0; i--)
            {
                cadenaInvertida.Append(cadena[i]);
            }

            return cadenaInvertida.ToString();
        }

    }
}