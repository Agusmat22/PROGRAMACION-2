/*
Se debe lograr que los objetos de estas clases se puedan sumar, restar y comparar entre sí con total normalidad 
como si fueran tipos numéricos, teniendo presente que 1 Euro equivale a 1,17 Dólares y 1 Dólar equivale a 102,65 Pesos.

*/
namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        static double cotzRespectoDolar;

        static Dolar()
        {
            cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public double GetCantidad()
        { return cantidad; }

        public static double GetCotizacion()
        { return cotzRespectoDolar;}

        //SOBRECARGA OPERADOR DE CONVERSION EXPLICITO

        /// <summary>
        /// Convierto explicitamente un Dolar a Euro.
        /// </summary>
        /// <param name="dolar"></param>
        public static explicit operator Euro(Dolar dolar)
        {
            double dolarAEuro = dolar.GetCantidad() / Euro.GetCotizacion();

            return new Euro(dolarAEuro);
        }

        /// <summary>
        /// Convierto explicitamente un Dolar a Peso.
        /// </summary>
        /// <param name="dolar"></param>

        public static explicit operator Peso(Dolar dolar)
        {
            double dolarAPeso = dolar.GetCantidad() * Peso.GetCotizacion();

            return new Peso(dolarAPeso);
        }

        //SOBRECARGA DE OPERADOR DE CONVERSION IMPLICITO

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dinero"></param>
        public static implicit operator Dolar(double dinero)
        {
            return new Dolar(dinero);
        }

        public static implicit operator string(Dolar dolar)
        {
            return dolar.GetCantidad().ToString();
        }

        //SOBRECARGA DE OPERADORES

        public static bool operator !=(Dolar dolar, Peso peso)
        {
            Peso conversionDolar = (Peso)dolar;

            return conversionDolar.GetCantidad() != peso.GetCantidad();
        }

        public static bool operator !=(Dolar dolar, Euro euro)
        {
            Euro conversionDolar = (Euro)dolar;

            return conversionDolar.GetCantidad() != euro.GetCantidad();
        }

        public static bool operator !=(Dolar dolar, Dolar dolar2)
        {
            return dolar.GetCantidad() != dolar2.GetCantidad();
        }

        //Reutilizo la sobre carga de != y le agrego una negacion para no sobreescribir codigo 
        public static bool operator ==(Dolar dolar, Peso peso)
        {
            return !(dolar != peso);
        }

        public static bool operator ==(Dolar dolar, Euro euro)
        {
            return !(dolar != euro);
        }

        public static bool operator ==(Dolar dolar, Dolar dolar2)
        {
            return !(dolar != dolar2);
        }

        public static Dolar operator +(Dolar dolar, Peso peso)
        {
            Dolar conversionPeso = (Dolar)peso;

            return dolar.GetCantidad() + conversionPeso.GetCantidad();
        }

        public static Dolar operator +(Dolar dolar, Euro euro)
        {
            Dolar conversionEuro = (Dolar)euro;

            return euro.GetCantidad() + conversionEuro.GetCantidad();
        }

        public static Dolar operator -(Dolar dolar, Peso peso)
        {
            Dolar conversionPeso = (Dolar)peso;

            return dolar.GetCantidad() - conversionPeso.GetCantidad();
        }

        public static Dolar operator -(Dolar dolar, Euro euro)
        {
            Dolar conversionEuro = (Dolar)euro;

            return euro.GetCantidad() - conversionEuro.GetCantidad();
        }

        
    }
}