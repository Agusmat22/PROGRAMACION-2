/*
Todos sus atributos son privados.
Posee sólo un constructor de instancia.
El método GetMarca, retornará el valor correspondiente al atributo marca.
También poseerá el atributo codigoDeBarras, el cual se publicará sólo a través de la conversión explícita 
nombrada más adelante.
El método de clase (estático) MostrarProducto es público y retornará una cadena detallando los atributos de la clase.
Posee las siguientes sobrecargas de operadores:
explicit: Realizará la conversión de un objeto Producto a string. 
Sólo retornará el atributo codigoDeBarras del producto.
    == (Producto, Producto): Retornará true si las marcas y códigos de barra son iguales, false caso contrario.
    == (Producto, string): Retornará true si la marca del producto coincide con la cadena pasada como argumento,
false caso contrario.

*/
using System.Text;

namespace Entidades
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;


        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        { return this.marca; }

        public float GetPrecio()
        { return this.precio; }

        /// <summary>
        /// retornará una cadena detallando los atributos de la clase.
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static string MostrarProducto(Producto producto)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {producto.GetMarca()}");
            sb.AppendLine($"Precio: {producto.GetPrecio()}");

            return sb.ToString();
        }

        /// <summary>
        /// Sólo retornará el atributo codigoDeBarras del producto.
        /// </summary>
        /// <param name="producto"></param>
        public static explicit operator string(Producto producto)
        {
            return producto.codigoDeBarra;
        }


        /// <summary>
        /// Retornara true si la marca y el codigo de barra son iguales, caso contrario false
        /// </summary>
        /// <param name="producto1"></param>
        /// <param name="producto2"></param>
        /// <returns></returns>
        public static bool operator ==(Producto producto1, Producto producto2)
        {
            return producto1.GetMarca() == producto2.GetMarca() && producto1.codigoDeBarra == producto2.codigoDeBarra;
        }

        /// <summary>
        /// Retornara true si la marca coincide con la marca del producto
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="marca"></param>
        /// <returns></returns>
        public static bool operator ==(Producto producto, string marca)
        {
            return producto.marca == marca;
        }

        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return !(producto1 == producto2);
        }

        public static bool operator !=(Producto producto, string marca)
        {
            return !(producto == marca);
        }
    }
}