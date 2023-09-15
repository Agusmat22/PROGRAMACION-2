using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Enumerado con el tipo de sistema.
    public enum ESistema
    {
        Decimal,
        Binario
    }
    public class Numeracion
    {
        private ESistema ESistema;
        private double valorNumerico;

        public Numeracion()
        {

        }

        //ACA NO SE QUE DEBE HACER ESTE CONSTRUCTOR
        public Numeracion(double valorNumerico, ESistema sistema)
        {
            
        }

        //Sobrecargo el constructor
        
        public Numeracion(string valorNumerico, ESistema sistema)
        {
            //Inicializo todos los atributos
            InicializarValores(valorNumerico, sistema);
        } 

        /// <summary>
        /// Este metodo se encarga de inicializar los valores de los atributos que contiene la clase
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="sistema"></param>
        private void InicializarValores(string valor,ESistema sistema)
        {
            this.ESistema = sistema;

            if (EsBinario(valor))
            {   
                this.valorNumerico = BinarioADecimal(valor);
            }
            else if(double.TryParse(valor, out double numero))
            {
                this.valorNumerico = numero;
            }
            else
            {
                //En caso de no ser un decimal ni un binario, asigno el minimo valor de un double
                this.valorNumerico = double.MinValue;
            }
        }


        //VALIDADORES
        /// <summary>
        /// Valida si el valor ingresado es un numero binario
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>True en caso de ser binario y false en caso contrario</returns>
        private static bool EsBinario(string valor)
        {
            bool esBinario = true;

            if (!string.IsNullOrEmpty(valor))
            {
                foreach(char caracter in valor)
                {
                    if (caracter != '0' && caracter != '1')
                    {
                        esBinario = false;
                        break;
                    }
                }
            }

            return esBinario;   
        }

        //GETTERS
        public ESistema GetSistema()
        { return ESistema; }

        public double GetValorNumerico()
        { return valorNumerico; }

        /// <summary>
        /// Convierte un binario a decimal
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>Retorna un double</returns>
        private static double BinarioADecimal(string valor)
        {
            int cantidadCaracteres = valor.Length -1;
            int digito;
            double numeroDecimal = 0;
            char caracter;

            for(int i = cantidadCaracteres; i >= 0; i--)
            {
                //Ingreso al ultimo caracter
                caracter = valor[i];
                int.TryParse(caracter.ToString(), out digito);

                //A medida que el I decrece aumenta la potencia, esta pensado de derecha a izquierda
                numeroDecimal += digito * Math.Pow(2,(cantidadCaracteres - i));

            }

            return numeroDecimal;
        }
        /// <summary>
        /// Convierte un decimal a binario
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>Retorna un string</returns>
        private static string DecimalABinario(double valor)
        {

            string numeroBinario = "";
            int divisor = 2;
            double resto;
            int dividendo = (int)valor;

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

            //LE INDICO QUE MINIMO DEBE CONTENER 4 CHARS padLeft, SI TIENE MENOS LES VA AGREGAR 0 A LA IZQUIERDA

            return InvertirCadena(numeroBinario).PadLeft(4, '0');
        }
        /// <summary>
        /// Invierte una cadena
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>Retorna un string</returns>
        private static string InvertirCadena(string valor)
        {
            StringBuilder cadenaInvertida = new StringBuilder();

            int largoCadena = valor.Length -1;

            for (int i = largoCadena; i >= 0; i--)
            {
                cadenaInvertida.Append(valor[i]);
            }

            return cadenaInvertida.ToString();
              
        }

    }
}
