/*
Crear un proyecto de consola y un proyecto de biblioteca de clases. 
Agregar al último tres clases Fahrenheit, Celsius y Kelvin.

Realizar la implementación necesaria para poder convertir una temperatura en sus distintas 
unidades de medida (Fahrenheit, Celsius y Kelvin).

Utilizar sobrecargas de métodos, operadores y/o conversiones.

*/

using Temperatura;

namespace Fahrenheit_451
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celsius temperaturaCelsius = 0;
            Fahrenheit temperaturaFahrenheit = 32;
            Kelvin tempertauraKelvin = 273.15;

            /*
            temperaturaCelsius = (Celsius)temperaturaFahrenheit;

            Console.WriteLine($"La temp {temperaturaFahrenheit.GetTemperatura()} fahrenheit pasado " +
                $"a celsius son: {temperaturaCelsius.GetTemperatura()} celsius");*/

            /*
            temperaturaFahrenheit = (Fahrenheit)temperaturaCelsius;

            Console.WriteLine($"La temp {temperaturaCelsius.GetTemperatura()} Celsius pasado " +
                $"a fahrenheit son: {temperaturaFahrenheit.GetTemperatura()} fahrenheit");

            temperaturaFahrenheit = (Fahrenheit)tempertauraKelvin;

            Console.WriteLine($"La temp {tempertauraKelvin.GetTemperatura()} kelvin pasado " +
                $"a fahrenheit son: {temperaturaFahrenheit.GetTemperatura()} fahrenheit"); */
            /*
            tempertauraKelvin = (Kelvin)temperaturaFahrenheit;

            Console.WriteLine($"La temp {temperaturaFahrenheit.GetTemperatura()} fahrenheit pasado " +
                $"a kelvin son: {tempertauraKelvin.GetTemperatura()} kelvin");

            tempertauraKelvin = (Kelvin)temperaturaCelsius;

            Console.WriteLine($"La temp {temperaturaCelsius.GetTemperatura()} celsius pasado " +
                $"a kelvin son: {tempertauraKelvin.GetTemperatura()} kelvin");
            */
            tempertauraKelvin += temperaturaCelsius;

            Console.WriteLine($"La suma de las temperaturas de celsius y kelvin {tempertauraKelvin.GetTemperatura()}");
        }
    }
}