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
namespace Entidades
{
    public static class Validador
    {

        public static bool Validar(int valor,int min,int max)
        {
            return valor > min && valor < max;
        }

        

    }
}