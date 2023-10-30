using Entidades;

namespace LaReceta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona per1 = new Persona("Agustin", "Garcia",22);
            
            Console.WriteLine(Persona.Guardar(per1));

            Console.WriteLine(Persona.Leer());
            
        }
    }
}