/*
Crear dos constructores:

Sumador(int) inicializa cantidadSumas en el valor recibido por parámetro.
Sumador() inicializa cantidadSumas en cero. Reutilizará al primer constructor.
El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la siguiente lógica:

En el caso de Sumar(long, long) sumará los valores numéricos
En el de Sumar(string, string) concatenará las cadenas de texto.


Generar una conversión explícita que retorne cantidadSumas.

Sobrecargar el operador + (suma) con dos operadores de tipo Sumador. 
El resultado será un long correspondiente al resultado de la suma del atributo cantidadSumas de cada argumento.

Sobrecargar el operador | (pipe) con dos operadores de tipo Sumador. 
Deberá retornar true si ambos sumadores tienen igual valor en el atributo cantidadSumas.


*/
using System.Runtime.CompilerServices;

namespace Entidades
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador()
        {
            this.cantidadSumas = 0;
        }

        public Sumador(int cantidadSumas) 
        { 
        
            this.cantidadSumas = cantidadSumas;
        }

        public long Sumar(long numero1, long numero2)
        {
            cantidadSumas++;
            return numero1 + numero2;
        }

        public string Sumar(string valor1, string valor2)
        {
            cantidadSumas++;
            return valor1 + valor2;
        }

        public static explicit operator int(Sumador sumador)
        {
            return sumador.cantidadSumas;
        }

        public static long operator +(Sumador sumador1,Sumador sumador2)
        {
            return sumador1.cantidadSumas + sumador2.cantidadSumas;
        }

        public static bool operator |(Sumador sumador1,Sumador sumador2)
        {
            return sumador1.cantidadSumas == sumador2.cantidadSumas;
        }
    }
}