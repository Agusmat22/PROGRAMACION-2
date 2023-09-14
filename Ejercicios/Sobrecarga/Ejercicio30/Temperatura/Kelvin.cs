using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    public class Kelvin
    {
        private double temperatura;
        static double tempPuntoPartida;

        static Kelvin()
        {
            //Temperatura en relacion a temperatura inicial
            tempPuntoPartida = 273.15;
        }

        //Convierto en privado para que unicamente se instancie implicitamente
        private Kelvin(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public double GetTemperatura()
        { return temperatura; }

        public static double GetTemperaturaInicial()
        { return tempPuntoPartida; }

        //SOBRECARGA DE OPERADORES DE CONVERSION


        public static implicit operator Kelvin(double temperatura)
        {
            return new Kelvin(temperatura); 
        }

        public static explicit operator Kelvin(Celsius celsius)
        {
            //K = c + 273.15
            Kelvin temperaturaConvertida = celsius.GetTemperatura() + Kelvin.GetTemperaturaInicial();

            return temperaturaConvertida;
        }

        public static explicit operator Kelvin(Fahrenheit fahrenheit)
        {
            //K = (F - 32) * (9/5) + 273.15 
            Kelvin temperaturaConvertida = (fahrenheit.GetTemperatura() - Fahrenheit.GetTemperaturaInicial()) * (5/9) + Kelvin.GetTemperaturaInicial() ;

            return temperaturaConvertida;
        }

        


        //SOBRECARGA DE OPERADORES
        public static Kelvin operator +(Kelvin tempKelvin, Fahrenheit tempFahrenheit)
        {
            Kelvin temperaturaConvertida = (Kelvin)tempFahrenheit;

            return tempKelvin.GetTemperatura() + temperaturaConvertida.GetTemperatura();
        }

        public static Kelvin operator +(Kelvin tempKelvin, Celsius tempCelsius)
        {
            Kelvin temperaturaConvertida = (Kelvin)tempCelsius;

            return tempKelvin.GetTemperatura() + temperaturaConvertida.GetTemperatura();
        }

        public static Kelvin operator -(Kelvin tempKelvin, Fahrenheit tempFahrenheit)
        {
            Kelvin temperaturaConvertida = (Kelvin)tempFahrenheit;

            return tempKelvin.GetTemperatura() - temperaturaConvertida.GetTemperatura();
        }

        public static Kelvin operator -(Kelvin tempKelvin, Celsius tempCelsius)
        {
            Kelvin temperaturaConvertida = (Kelvin)tempCelsius;

            return tempKelvin.GetTemperatura() - temperaturaConvertida.GetTemperatura();
        }
    }
}
