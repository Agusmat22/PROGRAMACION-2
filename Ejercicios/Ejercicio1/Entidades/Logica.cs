


using System;

namespace Entidades
{
     public static class Logica
    {



        public static int[] SolicitarNumeros(int cantidad,string mensaje)
        {
            int[] listaNumeros = new int[cantidad];

            int num;

            for (int i = 0; i < cantidad;  i++)
            {
                string numero = SolicitarDato(mensaje);

                while(!int.TryParse(numero, out num))
                {
                    numero = SolicitarDato("ERROR " + mensaje);
                }

                listaNumeros[i] = num;

            }

            return listaNumeros;

        }


        public static string SolicitarDato(string mensaje)
        {
            Console.WriteLine(mensaje);
            string datoIngreasdo = Console.ReadLine();

            return datoIngreasdo;

        }

    }
}