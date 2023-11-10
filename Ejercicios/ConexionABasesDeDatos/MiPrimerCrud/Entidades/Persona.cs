namespace Entidades
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Persona(string nombre, string apellido, int id) : this(nombre,apellido)
        {
            this.id = id;          
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return $"ID: {this.id} | {this.nombre} {this.apellido}";
        }
    }
}