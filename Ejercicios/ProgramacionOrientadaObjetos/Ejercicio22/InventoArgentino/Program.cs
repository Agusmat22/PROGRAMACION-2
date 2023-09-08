/*
En el método Main, crear un bolígrafo de tinta azul (ConsoleColor.Blue) 
y una cantidad inicial de tinta de 100 y otro de tinta roja (ConsoleColor.Red) y 50 de tinta.
Utilizar todos los métodos y mostrar los resultados por consola.
Al utilizar el método Pintar, si corresponde, se deberá dibujar por pantalla con el color de dicho bolígrafo.
Resolución  
*/
using Entidades;
namespace InventoArgentino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dibujo;

            Boligrafo boligrafoUno = new Boligrafo(ConsoleColor.Red, 100);
            Boligrafo boligrafoDos = new Boligrafo(ConsoleColor.Blue, 50);

            if (boligrafoUno.Pintar(15,out dibujo))
            {
                Console.ForegroundColor = boligrafoUno.GetColor();
                Console.WriteLine("Tinta utilizada en primer boligrafo: "+dibujo);
                Console.ResetColor();
            }

            if(boligrafoDos.Pintar(10, out dibujo))
            {
                Console.ForegroundColor = boligrafoDos.GetColor();
                Console.WriteLine("Tinta utilizada en segundo boligrafo: " + dibujo);
                Console.ResetColor();
            }
        }
    }
}