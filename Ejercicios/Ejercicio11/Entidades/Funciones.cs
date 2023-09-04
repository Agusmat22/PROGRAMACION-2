using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Funciones
    {
        
        public static string PedirDato(string mensaje)
        {
            Console.WriteLine(mensaje);
            string dato = Console.ReadLine();

            return dato;
        }

        public static bool ParseNumero(string cadena,out int numero)
        {
            return int.TryParse(cadena,out numero);
        }
    }
}
