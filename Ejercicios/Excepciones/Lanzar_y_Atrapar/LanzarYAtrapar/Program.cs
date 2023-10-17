using Entidades;
using Entidades.Excepciones;

namespace LanzarYAtrapar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                OtraClase otraClase = new OtraClase();


                otraClase.MiMetodoDeInstacia();

            }
            catch (MiExcepcion ex)
            {
                Exception inner = ex.InnerException;

                while (inner != null)
                {
                    Console.WriteLine(inner.Message);
                    inner = inner.InnerException;
                }

            }
            
        }
    }
}