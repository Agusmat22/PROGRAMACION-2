using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    public class Fahrenheit
    {
        private double temperatura;
        static double tempPuntoPartida;

        static Fahrenheit()
        {
            //Temperatura en relacion a temperatura inicial
            tempPuntoPartida = 32;
        }

        //Convierto en privado para que unicamente se instancie implicitamente
        private Fahrenheit(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public double GetTemperatura()
        { return this.temperatura; }

        public static double GetTemperaturaInicial()
        {
            return tempPuntoPartida;
        }

        public static implicit operator Fahrenheit (double temperatura) 
        {
            return new Fahrenheit(temperatura);
        }

        public static explicit operator Fahrenheit(Celsius celsius)
        {
            //F = C * (9/5) + 32
            Fahrenheit temperaturaConvertida = (celsius.GetTemperatura() * 1.8) + Fahrenheit.GetTemperaturaInicial();

            return temperaturaConvertida;
        }

        public static explicit operator Fahrenheit(Kelvin kelvin)
        {
            //F = K - 273.15 * (9/5) + 32

            //Fahrenheit temperaturaConvertida = (kelvin.GetTemperatura() - Kelvin.GetTemperaturaInicial()) * (9/5) 
            //+ Fahrenheit.GetTemperaturaInicial();

            Fahrenheit temperaturaConvertida = 1.8 * (kelvin.GetTemperatura() - 273.15) + 32;

            return temperaturaConvertida;
        }

        public static Fahrenheit operator +(Fahrenheit tempFahrenheit, Celsius tempcelsius)
        {
            Fahrenheit temperaturaConvertida = (Fahrenheit)tempcelsius;

            return tempFahrenheit.GetTemperatura() + temperaturaConvertida.GetTemperatura();
        }

        public static Fahrenheit operator +(Fahrenheit tempFahrenheit, Kelvin tempKelvin)
        {
            Fahrenheit temperaturaConvertida = (Fahrenheit)tempKelvin;

            return tempFahrenheit.GetTemperatura() + temperaturaConvertida.GetTemperatura();
        }

        public static Fahrenheit operator -(Fahrenheit tempFahrenheit, Celsius tempcelsius)
        {
            Fahrenheit temperaturaConvertida = (Fahrenheit)tempcelsius;

            return tempFahrenheit.GetTemperatura() - temperaturaConvertida.GetTemperatura();
        }

        public static Fahrenheit operator -(Fahrenheit tempFahrenheit, Kelvin tempKelvin)
        {
            Fahrenheit temperaturaConvertida = (Fahrenheit)tempKelvin;

            return tempFahrenheit.GetTemperatura() - temperaturaConvertida.GetTemperatura();
        }
    }
}
