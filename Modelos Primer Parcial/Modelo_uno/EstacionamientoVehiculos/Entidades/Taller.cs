using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Taller
    {
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Taller(string nombre)
        {
            this.nombre = nombre;
            this.vehiculos = new List<Vehiculo>();  
        }

        public string Nombre 
        { 
            get
            {
                return this.nombre;
            }

        }
        public List<Vehiculo> Vehiculos 
        {
            get
            {
                return this.vehiculos;
            }
        }

        public static implicit operator Taller(string nombre)
        {
            return new Taller(nombre);
        }

        public static string MostrarVehiculosDelTaller(Taller taller)
        {
            StringBuilder sb = new StringBuilder();
            
            if (taller.Vehiculos.Count > 0)
            {
                foreach (Vehiculo item in taller.Vehiculos)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            else
            {
                sb.AppendLine("No hay vehiculo");
            }

            return sb.ToString();   
        }

        public static bool operator ==(Taller taller, Vehiculo vehiculo)
        {
            return taller.Vehiculos.Contains(vehiculo);
        }

        public static bool operator !=(Taller taller, Vehiculo vehiculo)
        {
            return !(taller == vehiculo);
        }

        public static Taller operator +(Taller taller,Vehiculo vehiculo)
        {
            if (taller != vehiculo)
            {
                taller.Vehiculos.Add(vehiculo);   
            }
            return taller;

        }

        public static string operator -(Taller taller, Vehiculo vehiculo)
        {
            if (taller == vehiculo)
            {
                taller.Vehiculos.Remove(vehiculo);
                return "Vehiculo removido";
            }
            else
            {
                return "Vehiculo no encontrado";
            }

        }
    }
}
