using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        static double cotzRespectoDolar;

        static Euro()
        {
            cotzRespectoDolar = 1.17;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad,double cotizacion) :this(cantidad)
        {
            cotzRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        { return cantidad; }

        public static double GetCotizacion()
        { return cotzRespectoDolar; }

        //SOBRECARGA DE OPERADOR DE CONVERSION EXPLICITO

        /// <summary>
        /// Convierto explicitamente un Euro a Dolar.
        /// </summary>
        /// <param name="euro"></param>
        public static explicit operator Dolar(Euro euro)
        {
            double euroADolar = euro.GetCantidad() * Euro.GetCotizacion();

            return new Dolar(euroADolar);
        }

        /// <summary>
        /// Convierto explicitamente un Euro a Peso.
        /// </summary>
        /// <param name="euro"></param>
        public static explicit operator Peso(Euro euro)
        {
            double euroAPeso = euro.GetCantidad() * Euro.GetCotizacion() * Peso.GetCotizacion();

            return new Peso(euroAPeso);
        }

        //SOBRECARGA DE OPERADOR DE CONVERSION IMPLICITO

        public static implicit operator Euro (double dinero)
        {
            return new Euro(dinero);
        }

        public static implicit operator string(Euro euro)
        {
            return euro.GetCantidad().ToString();
        }


        //SOBRECARGA DE OPERADORES

        public static bool operator !=(Euro euro, Dolar dolar)
        {
            Dolar conversionEuro = (Dolar)euro;

            return conversionEuro.GetCantidad() != dolar.GetCantidad();
        }

        public static bool operator !=(Euro euro, Peso peso)
        {
            Peso conversionEuro = (Peso)euro;

            return conversionEuro.GetCantidad() != peso.GetCantidad();
        }

        public static bool operator !=(Euro euro, Euro euro2)
        {
            return euro.GetCantidad() != euro2.GetCantidad();
        }

        //Reutilizo la sobre carga de != y le agrego una negacion para no sobreescribir codigo 
        public static bool operator ==(Euro euro, Dolar dolar)
        {
            return !(euro != dolar);
        }

        public static bool operator ==(Euro euro, Peso peso)
        {
            return !(euro != peso);
        }

        public static bool operator ==(Euro euro, Euro euro2)
        {
            return !(euro != euro2);
        }


        public static Euro operator +(Euro euro, Peso peso)
        {
            Euro conversionPeso = (Euro)peso;

            return euro.GetCantidad() + conversionPeso.GetCantidad();
        }

        public static Euro operator +(Euro euro, Dolar dolar)
        {
            Euro conversionDolar = (Euro)dolar;

            return euro.GetCantidad() + conversionDolar.GetCantidad();
        }

        public static Euro operator -(Euro euro, Peso peso)
        {
            Euro conversionPeso = (Euro)peso;

            return euro.GetCantidad() - conversionPeso.GetCantidad();
        }

        public static Euro operator -(Euro euro, Dolar dolar)
        {
            Euro conversionDolar = (Euro)dolar;

            return euro.GetCantidad() - conversionDolar.GetCantidad();
        }

        //-----------------------metodo estatico------------------------

        public static void SetCotizacion(double cotizacion)
        {
            if (cotizacion >= 0)
            {
                cotzRespectoDolar = cotizacion;    
            }

        }
    }
}
