using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Posee dos atributos privados. Uno será un entero que indicará la ubicación del estante 
y el otro es un array de tipo Producto.
El constructor de instancia privado será el único que incializará el array. 
La sobrecarga pública del constructor inicializará la ubicación del estante, recibiendo como parámetros la capacidad 
y la ubicación. Reutilizar código.
El método público GetProductos, retornará el array de productos.
El método público de clase (estático) MostrarEstante, retornará una cadena con toda la información
del estante incluyendo el detalle de cada uno de sus productos. Reutilizar código.
Posee las siguientes sobrecargas de operadores:
==: Retornará true si es que el producto ya se encuentra en el estante, false caso contrario.
+: Retornará true y agregará el producto si el estante posee capacidad de almacenar al menos un producto más 
y dicho producto no se encuentra en el estante, false caso contrario. Reutilizar código.
-: Retornará un estante sin el producto, siempre y cuando el producto se encuentre en el listado. Reutilizar código.

*/
namespace Entidades
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        //Constructor privado
        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }

        //Constructor publico y llama al constructor privado
        public Estante(int capacidad,int ubicacion) :this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos() 
        { return productos; }

        /// <summary>
        /// Retornara una cadena con todos los productos en el estante
        /// </summary>
        /// <param name="estante"></param>
        /// <returns></returns>
        public static string MostrarEstante(Estante estante)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Todos los productos del estante");

            for(int i = 0; i < estante.GetProductos().Length; i++)
            {
                sb.AppendLine($"Ubicacion: {i} | Producto {Producto.MostrarProducto(estante.GetProductos()[i])}");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Retornara true si el producto ya se encuentra dentro del estante (dentro del array de productos)
        /// </summary>
        /// <param name="estante"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator ==(Estante estante, Producto producto)
        {
            Producto[] productosEstante = estante.GetProductos();


            for (int i = 0; i < productosEstante.Length; i++)
            {
                if (productosEstante[i] is not null && productosEstante[i] == producto)
                {
                    return true; 
                }
            }

            return false;
        }

      
        public static bool operator !=(Estante estante, Producto producto)
        {
            return !(estante == producto);
        }

        /// <summary>
        /// Retorna true si hay un estante vacio y el producto no se encuentra en la estanteria
        /// </summary>
        /// <param name="estante"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator +(Estante estante, Producto producto)
        {

            if (estante != producto)
            {
                for (int i = 0; i < estante.GetProductos().Length; i++)
                {
                    //Con IS null pregunto si es null
                    if (estante.GetProductos()[i] is null)
                    {
                        estante.GetProductos()[i] = producto;
                        return true;
                    }

                }
            }

            return false;

        }

        /// <summary>
        /// Busca si el producto se encuentra en el estante y retorna el estante con un lugar null
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Estante operator -(Estante e, Producto p)
        {
            for (int i = 0; i < e.GetProductos().Length; i++)
            {
                if (e == p)
                {
                    e.GetProductos()[i] = null;
                    break;
                }
            }
            return e;

        }


    }

    


}

