namespace Entidades.Excepciones
{
    public class ParametrosVaciosException : Exception
    {
        public ParametrosVaciosException(string mensaje):base(mensaje) 
        { 
        
        }

        public ParametrosVaciosException(string mensaje,Exception ex) : base(mensaje,ex)
        { }
    }
}