using System.Text;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private string direccion;
        private int edad;
        private string genero;
        private string[] cursos;
        private string nacionalidad;

        public Persona()
        { }

        public Persona(string nombre, string direccion, int edad, string genero, string[] cursos, string nacionalidad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.cursos = cursos;
            this.nacionalidad = nacionalidad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Direccion: {this.direccion}");
            sb.AppendLine($"Edad: {this.edad}");
            sb.AppendLine($"Genero: {this.genero}");
            sb.Append($"Cursos: ");
            foreach (string curso in cursos)
            {
                sb.Append($"{curso} ");      
            }
            sb.AppendLine($"\nNacionalidad: {this.nacionalidad}");

            return sb.ToString();
        }
    }
}