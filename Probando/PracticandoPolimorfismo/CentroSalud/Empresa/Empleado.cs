using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    public abstract class Empleado
    {
        protected string nombre;
        private DateTime fechaNacimiento;
        protected short legajo;
        protected double sueldo;
        protected bool almorzando;

        protected Empleado(string nombre, DateTime fechaNacimiento, short legajo, double sueldo)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.legajo = legajo;
            this.sueldo = sueldo;
        }

        //PROPERTY
        protected short Legajo { get {return this.legajo; } }
        protected string Nombre { get {return this.nombre; } }
        protected bool Almorzando { get {return this.almorzando; } set { this.almorzando = value; } }
        
        public int Edad
        {
            get
            {
                int edad = DateTime.Now.Year - fechaNacimiento.Year;

                if (fechaNacimiento.Month > DateTime.Now.Month || fechaNacimiento.Month == DateTime.Now.Month && fechaNacimiento.Day > DateTime.Now.Day)
                {
                    edad--;
                }

                return edad;


            }
        }
        protected abstract double Sueldo { get; set; }



        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Edad: {this.Edad}");
            sb.AppendLine($"Legajo: {this.Legajo}");
            sb.AppendLine($"Sueldo: {this.Sueldo}");

            return sb.ToString();   
        }

        public abstract void Almuerzo();
    }
}
