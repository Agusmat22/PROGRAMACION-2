/*
La cantidad máxima de tinta para todos los bolígrafos será de 100. 
Generar una constante cantidadTintaMaxima en Boligrafo donde se guardará dicho valor.
Generar los métodos getter GetColor y GetTinta para los correspondientes atributos (sólo retornarán el valor de los mismos).
Generar un método setter privado SetTinta que valide el nivel de tinta y, si es válido, modifique el valor del atributo tinta.
El argumento tinta contedrá la cantidad de tinta a agregar o quitar. 
Podrá ser positivo (cargar tinta) o negativo (gastar tinta).

Se deberá validar que el nivel de tinta resultante sea mayor o igual a cero y menor o igual a cantidadTintaMaxima. 
Si no es válido, no se deberá modificar el atributo ni realizar ninguna acción.
El método Recargar colocará la tinta en su nivel máximo. Reutilizar código.
El método Pintar restará la tinta gastada (reutilizar código). 
El parámetro gasto representará la cantidad de unidades de tinta a utilizar 
y utilizará tanta tinta como tenga disponible sin quedar en negativo. 

Utilizando el parámetro dibujo informará el resultado retornando tantos * como unidades de tinta haya gastado, por ejemplo:
Si no había nada de tinta retornará una cadena de texto vacía.
Si el nivel de tinta era 10 y la cantidad a gastar 2, entonces retonará **.
Si el nivel de tinta era 3 y la cantidad a gastar 10, entonces retornará ***.
Agregar un proyecto de consola.

En el método Main, crear un bolígrafo de tinta azul (ConsoleColor.Blue) 
y una cantidad inicial de tinta de 100 y otro de tinta roja (ConsoleColor.Red) y 50 de tinta.
Utilizar todos los métodos y mostrar los resultados por consola.
Al utilizar el método Pintar, si corresponde, se deberá dibujar por pantalla con el color de dicho bolígrafo.
Resolución 
*/
using System.Drawing;

namespace Entidades
{
    public class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        //GETTER Y SETTER
        public ConsoleColor GetColor() 
        { 
            return this.color;
        }

        public void SetColor(ConsoleColor color)
        {
            this.color = color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            int cantidaTotalTinta = this.tinta + tinta;

            if (cantidaTotalTinta > cantidadTintaMaxima)
            {
                this.tinta = tinta;       
            }
            else if(cantidaTotalTinta < 0)
            {
                this.tinta = 0;
            }
            else
            {
                this.tinta += tinta;
            }
        }

        /// <summary>
        /// Recarga la cantidad de tinta maxima
        /// </summary>
        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        /*
            El método Pintar restará la tinta gastada (reutilizar código). 
            El parámetro gasto representará la cantidad de unidades de tinta a utilizar y utilizará tanta tinta 
            como tenga disponible sin quedar en negativo. Utilizando el parámetro dibujo informará 
            el resultado retornando tantos * como unidades de tinta haya gastado, por ejemplo:
            Si no había nada de tinta retornará una cadena de texto vacía.
            Si el nivel de tinta era 10 y la cantidad a gastar 2, entonces retonará **.
            Si el nivel de tinta era 3 y la cantidad a gastar 10, entonces retornará ***.

        */
        public bool Pintar(short gasto,out string dibujo)
        {
            bool returValor = false;
            string asteriscosDibujados = "";

            if (this.tinta == 0 || gasto == 0)
            {
                dibujo = "";
            }
            else
            {
                while (gasto > 0 && this.tinta > 0)
                {
                    asteriscosDibujados += "*";
                    gasto--;
                    SetTinta(-1);
                }
                dibujo = asteriscosDibujados;
                returValor = true;
            }
  
            return returValor;

        }



    }
}