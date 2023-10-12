using static Entidades.Numeracion;

namespace Entidades
{
    public class Numeracion
    {
        public enum ESistema
        {
            Decimal,
            Binario
        }

        private ESistema sistema;
        private double valorNumerico;

        //--------------------- CONSTRUCTORES ----------------------------//

        public Numeracion (string valor, ESistema sistema)
        {
            this.InicializarValores(valor, sistema);
        }

        public Numeracion(double valor, ESistema sistema):this(valor.ToString(),sistema)
        {
            
        }


        //----------------------- PROPIEDADES ----------------------------//

        public ESistema Sistema
        {
            get { return sistema; }
        }

        public string ValorNumerico
        {
            get
            {
                string valor;

                if (valorNumerico == double.MinValue) //valido si es infinito para las operaaciones de minValue
                {
                    valor = "Error";
                }
                else if (Sistema == ESistema.Binario)
                {
                    valor = DecimalABinario((int)this.valorNumerico);
                }
                else
                {
                    valor = valorNumerico.ToString();
                }

                return valor;

            }
        }





        //------------------------ METODOS -------------------------------//


        private void InicializarValores(string valor,ESistema sistema)
        {
            this.sistema = sistema;

            if (sistema == ESistema.Binario && Numeracion.EsBinario(valor))
            {
                //Convierto binario a decimal
                this.valorNumerico = BinarioADecimal(valor);
            }
            else if(sistema == ESistema.Decimal && int.TryParse(valor,out int numero))
            {
                this.valorNumerico = numero;
            }
            else
            {
                this.valorNumerico = double.MinValue; //En caso de no ser de ningun sistema el dato ingresado, se asigna el minValue
            }
        }


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
                foreach (char caracter in valor)
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



        /// <summary>
        /// Convierte un binario a decimal
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>Retornara el numero decimal en caso de no poder convertirse retornara 0</returns>
        private static double BinarioADecimal(string valor)
        {
            double numeroDecimal = 0;

            if (Numeracion.EsBinario(valor))
            {
                int cantidadCaracteres = valor.Length - 1;
                int digito; //sera el caracter 'char' luego ser parseado
                char caracter;

                for (int i = cantidadCaracteres; i >= 0; i--)
                {
                    //Ingreso al ultimo caracter
                    caracter = valor[i];

                    if (int.TryParse(caracter.ToString(), out digito))
                    {
                        //A medida que el I decrece aumenta la potencia, esta pensado de derecha a izquierda
                        numeroDecimal += digito * Math.Pow(2, (cantidadCaracteres - i));
                    }
                    else
                    {
                        numeroDecimal = 0;
                        break;
                    }

                }
            }

            return numeroDecimal;
        }

        /// <summary>
        /// Convierte un string numreico a binario
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        private static string DecimalABinario(string valor)
        {

            string numeroBinario = "";
            //valido que sea numerico y que sea mayor a 0 ya que binarios negativos no se puede
            if (int.TryParse(valor, out int numeroDecimal))
            {
                int divisor = 2;
                double resto;
                int dividendo = numeroDecimal;

                while (dividendo > 0)
                {                    
                    resto = dividendo % divisor;
                    dividendo = dividendo / divisor;

                    numeroBinario = resto.ToString() + numeroBinario;                
                }
            }
            else
            {
                numeroBinario = "Numero Invalido";
            }


            return numeroBinario;
        }

        private static string DecimalABinario(int valor)
        {
            return DecimalABinario(valor.ToString());
        }


        /// <summary>
        /// Convierte un numero en el sistema ingresado
        /// </summary>
        /// <param name="sistema"></param>
        /// <returns>Un numero del tipo string</returns>
        public string ConvertirA(ESistema sistema)
        {
            if (sistema == ESistema.Binario && this.Sistema != sistema)
            {
                return DecimalABinario(this.ValorNumerico);
            }
            else if (Sistema == ESistema.Decimal && this.Sistema != sistema)
            {
                return BinarioADecimal(this.ValorNumerico).ToString();
            }
            else
            {
                //return null; //NO RETORNO NULL PORQUE NO ME PARECE OPTIMO, PREFIERO RETORNAR UN MENSAJE
                return "Error en la conversion";
            }
        }


        //-------------------------- SOBRECARGA DE OPERADORES ----------------------//

        public static bool operator ==(ESistema sistema,Numeracion numeracion)
        {
            return numeracion.Sistema == sistema;
        }

        public static bool operator !=(ESistema sistema, Numeracion numeracion)
        {
            return !(sistema == numeracion);
        }

        public static bool operator ==(Numeracion numeracion1,Numeracion numeracion2)
        {
            return numeracion1.Sistema == numeracion2.Sistema;
        }

        public static bool operator !=(Numeracion numeracion1, Numeracion numeracion2)
        {
            return !(numeracion1 == numeracion2);
        }

        public static Numeracion operator +(Numeracion numeracion1,Numeracion numeracion2)
        {
            double suma;

            if (numeracion1 == numeracion2)
            {
                suma = numeracion1.valorNumerico + numeracion2.valorNumerico;

                if (numeracion1.Sistema is ESistema.Binario)
                {
                    return new Numeracion(DecimalABinario((int)suma), ESistema.Binario);
                }
            }
            else
            {
                suma = double.MinValue;
            }

            return new Numeracion(suma, ESistema.Decimal);
        }

        public static Numeracion operator -(Numeracion numeracion1, Numeracion numeracion2)
        {
            double resta;

            if (numeracion1 == numeracion2)
            {
                resta = numeracion1.valorNumerico - numeracion2.valorNumerico;

            }
            else
            {
                resta = double.MinValue;
            }

            return new Numeracion(resta, numeracion1.Sistema);
        }

        public static Numeracion operator *(Numeracion numeracion1, Numeracion numeracion2)
        {
            double multiplicacion;

            if (numeracion1 == numeracion2)
            {
                multiplicacion = numeracion1.valorNumerico * numeracion2.valorNumerico;

            }
            else
            {
                multiplicacion = double.MinValue;
            }

            return new Numeracion(multiplicacion, numeracion1.Sistema);
        }

        public static Numeracion operator /(Numeracion numeracion1, Numeracion numeracion2)
        {
            double division;

            if (numeracion1 == numeracion2)
            {
                division = numeracion1.valorNumerico / numeracion2.valorNumerico;

            }
            else
            {
                division = double.MinValue;
            }

            return new Numeracion(division, numeracion1.Sistema);
        }


    }
}