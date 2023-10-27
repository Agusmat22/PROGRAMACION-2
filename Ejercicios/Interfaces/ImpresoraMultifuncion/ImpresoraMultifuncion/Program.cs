using Entidades;

namespace ImpresoraMultifuncion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Impresoraa impresora = new Impresoraa();

            impresora.AgregarImprimible(new Contrato());
            impresora.AgregarImprimible(new Documento());
            impresora.AgregarImprimible(new Foto());

            impresora.ImprimirTodo();
        }
    }
}