using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        static double cotzRespectoDolar;

        static Peso()
        {
            cotzRespectoDolar = 102.65;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad,double cotizacion) :this(cantidad)
        {
            cotzRespectoDolar = cotizacion;
        }


        public double GetCantidad()
        { return cantidad; }

        public static double GetCotizacion()
        { return cotzRespectoDolar; }

        //SOBRECARGA DE OPERADOR CONVERSION EXPLICITO

        /// <summary>
        /// Convierto explicitamente un Peso a Dolar.
        /// </summary>
        /// <param name="peso"></param>
        public static explicit operator Dolar(Peso peso)
        {
            double pesoADolar = peso.GetCantidad() / Peso.GetCotizacion();
            
            return new Dolar(pesoADolar);
        }
        /// <summary>
        /// Convierto explicitamente un Peso a Euro.
        /// </summary>
        /// <param name="peso"></param>
        public static explicit operator Euro(Peso peso)
        {

            double pesoAEuro = peso.GetCantidad() / Peso.GetCotizacion() * Euro.GetCotizacion();
            
            return new Euro(pesoAEuro);
        }

        //SOBRECARGA DE OPERADOR CONVERSION IMPLICITO

        public static implicit operator Peso(double dinero)
        {
            return new Peso(dinero);
        }

        
        //SOBRECARGA DE OPERADORES
        public static bool operator !=(Peso peso,Dolar dolar)
        {
            Dolar conversionPesos = (Dolar)peso;

            return conversionPesos.GetCantidad() != dolar.GetCantidad();
        }

        public static bool operator !=(Peso peso, Euro euro)
        {
            Euro conversionPesos = (Euro)peso;

            return conversionPesos.GetCantidad() != euro.GetCantidad();
        }

        public static bool operator !=(Peso peso, Peso peso2)
        {
            return peso.GetCantidad() != peso2.GetCantidad();
        }

        //Reutilizo la sobre carga de != y le agrego una negacion para no sobreescribir codigo 
        public static bool operator ==(Peso peso, Dolar dolar)
        {
            return !(peso != dolar);
        }

        public static bool operator ==(Peso peso, Euro euro)
        {
            return !(peso != euro);
        }

        public static bool operator ==(Peso peso, Peso peso2)
        {
            return !(peso != peso2);
        }

        public static Peso operator +(Peso peso,Euro euro)
        {
            Peso conversionEuro = (Peso)euro;

            return peso.GetCantidad() + conversionEuro.GetCantidad();
        }

        public static Peso operator +(Peso peso, Dolar dolar)
        {
            Peso conversionDolar = (Peso)dolar;

            return peso.GetCantidad() + conversionDolar.GetCantidad();
        }

        public static Peso operator -(Peso peso, Euro euro)
        {
            Peso conversionEuro = (Peso)euro;

            return peso.GetCantidad() - conversionEuro.GetCantidad();
        }

        public static Peso operator -(Peso peso, Dolar dolar)
        {
            Peso conversionDolar = (Peso)dolar;

            return peso.GetCantidad() - conversionDolar.GetCantidad();
        }

    }


}
