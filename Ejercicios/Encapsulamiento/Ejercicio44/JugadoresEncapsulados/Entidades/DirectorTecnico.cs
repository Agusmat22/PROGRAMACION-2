using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        DateTime fechaNacimiento;
        public DirectorTecnico(string nombre) : base(nombre)
        {

        }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento):this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos()); // llamo al metodo padre
            sb.AppendLine($"Fecha Nacimiento: {this.fechaNacimiento.ToString("dd/MM/yyyy")}");
            

            return sb.ToString();
        }

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return dt1.Dni == dt2.Dni;
        }

        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
    }
}
