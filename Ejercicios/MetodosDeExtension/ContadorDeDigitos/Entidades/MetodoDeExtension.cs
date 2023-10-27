namespace Entidades
{
    public static class MetodoDeExtension
    {
        public static int ContarCantidadDeDigitos(this Int64 numero)
        {
            return numero.ToString().Length;
        }
    }
}