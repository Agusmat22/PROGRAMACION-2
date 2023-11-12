namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;

        public Persona(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public override string ToString()
        {
            return $"Nombre: {this.nombre} {this.apellido} | Edad: {this.edad}";
        }
    }
}