namespace Temperatura
{
    public class Celsius
    {
        private double temperatura;
        static double tempPuntoPartida;

        static Celsius()
        {
            //Temperatura en relacion a temperatura inicial
            tempPuntoPartida = 0;
        }

        //Convierto en privado para que unicamente se instancie implicitamente
        private Celsius(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public double GetTemperatura()
        { return temperatura; }

        public static double GetTemperaturaInicial()
        { return tempPuntoPartida; }

        public static implicit operator Celsius(double temperatura)
        {
            return new Celsius(temperatura);
        }

        public static explicit operator Celsius(Fahrenheit fahrenheit)
        {
            //C = (F-32) * 5/9 //PASAJE DE FAHRENHEIT A CELSIUS
            Celsius temperaturaConvertida = (fahrenheit.GetTemperatura() - Fahrenheit.GetTemperaturaInicial()) * 5 / 9;

            return temperaturaConvertida;
        }

        public static explicit operator Celsius(Kelvin kelvin)
        {
            // (K - 273.15)
            Celsius temperaturaConvertida = kelvin.GetTemperatura() - Kelvin.GetTemperaturaInicial();

            return temperaturaConvertida;
        }

        public static Celsius operator +(Celsius tempcelsius, Fahrenheit tempFahrenheit)
        {
            Celsius temperaturaConvertida = (Celsius)tempFahrenheit;

            return tempcelsius.GetTemperatura() + temperaturaConvertida.GetTemperatura();
        }

        public static Celsius operator +(Celsius tempcelsius, Kelvin tempKelvin)
        {
            Celsius temperaturaConvertida = (Celsius)tempKelvin;

            return tempcelsius.GetTemperatura() + temperaturaConvertida.GetTemperatura();
        }

        public static Celsius operator -(Celsius tempcelsius, Fahrenheit tempFahrenheit)
        {
            Celsius temperaturaConvertida = (Celsius)tempFahrenheit;

            return tempcelsius.GetTemperatura() - temperaturaConvertida.GetTemperatura();
        }

        public static Celsius operator -(Celsius tempcelsius, Kelvin tempKelvin)
        {
            Celsius temperaturaConvertida = (Celsius)tempKelvin;

            return tempcelsius.GetTemperatura() - temperaturaConvertida.GetTemperatura();
        }

    }
}