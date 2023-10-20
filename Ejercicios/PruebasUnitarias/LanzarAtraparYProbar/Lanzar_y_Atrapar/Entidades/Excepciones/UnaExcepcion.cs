namespace Entidades.Excepciones
{
    public class UnaExcepcion : Exception
    {
        public UnaExcepcion(string mensaje) : base(mensaje) 
        { 
        
        }

        public UnaExcepcion(string mensaje,Exception excepcion) :base(mensaje,excepcion) 
        { 
        
        }
    }
}