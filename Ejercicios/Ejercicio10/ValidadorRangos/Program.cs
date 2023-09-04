/*
Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

bool Validar(int valor, int min, int max)

valor: dato a validar.
min: mínimo valor incluido.
max: máximo valor incluido.

Pedir al usuario que ingrese 10 números enteros. 
Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.


*/
using Entidades;

namespace ValidadorRangos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numMax = 0;
            int numMin = 0;
            int sumaNumerosIngresados = 0;
            bool flag = true;
            int numeroCasteado;
            double promedio;
            for (int i = 0; i < 10; i++)
            {
                string numeroIngresado = Funciones.PedirDato("Ingrese un numero: ");

                while(!int.TryParse(numeroIngresado,out numeroCasteado) && Validador.Validar(numeroCasteado,-100,100))
                {
                    numeroIngresado = Funciones.PedirDato("ERROR, Ingrese un numero: ");
                }

                if(flag)
                {
                    numMax = numeroCasteado;
                    numMin = numeroCasteado;
                    flag = false;
                }
                else if(numeroCasteado > numMax)
                {
                    numMax = numeroCasteado;
                }
                else if(numeroCasteado < numMin)
                {
                    numMin = numeroCasteado;
                }

                sumaNumerosIngresados += numeroCasteado;

            }

            promedio = sumaNumerosIngresados / 10;

            Console.WriteLine($"El numero min: {numMin}\nEl numero max: {numMax}\nEl promedio: {promedio}");



        }
    }


    
}