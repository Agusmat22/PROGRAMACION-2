using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    public class Administrativo : Empleado
    {
        private int cantidadExpedientes;


        public Administrativo(string nombre, DateTime fechaNacimiento, short legajo, double sueldo)
            : base(nombre,fechaNacimiento,legajo,sueldo)
        {

        }

        private int CantidadExpedientes
        {
            get { return cantidadExpedientes;}

            set { this.cantidadExpedientes = value; }
        }

        protected override double Sueldo 
        {
            get
            {
                return this.sueldo;
            }            
            
            set
            {
                this.sueldo = value;
            }
        
        }

        public static bool operator +(Administrativo admin, int expendiente)
        {
            bool valor = false;

            if (expendiente > 0  && admin.CantidadExpedientes + expendiente < 101)
            {
                admin.CantidadExpedientes += expendiente;
                valor = true;
            }

            return valor;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine("Cantidad Expendientes: " + this.CantidadExpedientes);
            
            return sb.ToString();   
        }

        public override void Almuerzo()
        {
            if (cantidadExpedientes < 50)
            {
                this.Almorzando = true;
            }
            else
            {
                this.Almorzando = false;
            }
        }

        public override bool Equals(object? obj)
        {
            if (obj is Administrativo admin)
            {
                return this.Legajo == admin.Legajo;
            }

            return false;
        }

        public override string ToString()
        {
            return Mostrar();
        }

    }
}
