using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        protected Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string FechaCreacion { get => fechaCreacion.ToString("dd/MM/yyyy");}

        public static bool operator ==(Equipo equipo1, Equipo equipo2)
        {
            return equipo1.Nombre == equipo2.Nombre && equipo1.FechaCreacion == equipo2.FechaCreacion; 
        }

        public static bool operator !=(Equipo equipo1, Equipo equipo2)
        {
            return !(equipo1 == equipo2);
        }

        //METODOS
        public string Ficha()
        {
            return $"{this.Nombre} fundado el {this.FechaCreacion}";
        }
    }
}
