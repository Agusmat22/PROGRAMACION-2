using System.Xml.Serialization;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;

        //Me obliga a tener un constructor public sin parametros para serializar XML
        public Persona()
        {

        }

        public Persona(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }

        public static bool Guardar(Persona persona)
        {
            string nombreArchivo = "persona.xml";

            try
            {
                using (StreamWriter streamWriter = new StreamWriter(nombreArchivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));
                    xmlSerializer.Serialize(streamWriter, persona);

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }


        public override string ToString()
        {
            return $"Nombre: {this.nombre}\nApellido: {this.apellido} \nEdad: {this.edad}";
        }

        
        public static bool Leer()
        {
            string nombreArchivo = "persona.xml";

            if (File.Exists(nombreArchivo))
            {
                try
                {
                    using (StreamReader streamReader = new StreamReader(nombreArchivo))
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer (typeof(Persona));

                        Persona archivoDeserializado = xmlSerializer.Deserialize(streamReader) as Persona;

                        Console.WriteLine(archivoDeserializado.ToString());
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine (ex.Message);
                }
            }

            return false;
            

        }
    }
}