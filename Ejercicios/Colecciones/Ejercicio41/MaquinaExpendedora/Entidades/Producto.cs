using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private string nombre;
        private double precio;
        private string codigo;

        private Producto()
        {
            precio = 0;
            codigo = "";
        }

        public Producto(string nombre):this()
        {
            this.nombre = nombre;
        }

        public Producto(string nombre, double precio,string codigo):this(nombre)
        {
            this.precio = precio;
            this.codigo = codigo;
        }


        public string Nombre
        {
            get
            {
                return this.nombre; 
            }
        }

        public double Precio
        { 
            get 
            { 
                return this.precio; 
            } 
        }

        public string Codigo
        {
            get
            {
                return this.codigo;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Producto: {Nombre} - Precio ${Precio}");

            return sb.ToString();
        }


        public static bool operator ==(Producto p1, Producto p2)
        {
            return p1.Codigo == p2.Codigo;
        }

       



        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

       
    }
}
