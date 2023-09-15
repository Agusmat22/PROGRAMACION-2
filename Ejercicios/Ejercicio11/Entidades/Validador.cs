/*
Consigna
Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje 
"¿Desea continuar? (S/N)".

Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.

Resolución

*/

namespace Entidades
{
    public static class Validador
    {

        public static bool ValidarRespuesta(string respuesta,string respuestaCorrecta)
        {

            return respuesta.ToString() == respuestaCorrecta.ToString();

        }

    }
}