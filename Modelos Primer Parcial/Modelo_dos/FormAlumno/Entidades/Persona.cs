using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        protected int dni;
        private string nombre;


        protected Persona(int dni)
        {
            this.dni = dni;
        }


        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public abstract string Informacion { get; }

        public static bool operator ==(Persona a, Persona b) 
        {
            return a.dni == b.dni;
        }

        public static bool operator !=(Persona a, Persona b)
        {
            return !(a == b);
        }

        public override bool Equals(object? obj)
        {
            return obj is not null && obj is Persona p && p == this;
        }

        public override int GetHashCode()
        {
            return this.dni.GetHashCode();
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Dni: {this.dni}");
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Apellido: {this.Apellido}");

            return sb.ToString();
        }
    }
}