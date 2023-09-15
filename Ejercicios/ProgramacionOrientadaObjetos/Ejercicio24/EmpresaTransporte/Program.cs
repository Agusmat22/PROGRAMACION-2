
using Entidades;
namespace EmpresaTransporte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chofer chofer1 = new Chofer("Agustin");

            chofer1.AsignarDescansoSemanal(5);
            chofer1.CargarKilometrosRecorridos(4, 100);
            chofer1.CargarKilometrosRecorridos(6, 500);

            Chofer chofer2 = new Chofer("Sofia");

            chofer2.AsignarDescansoSemanal(7);
            chofer2.CargarKilometrosRecorridos(4, 100);
            chofer2.CargarKilometrosRecorridos(6, 500);
            chofer2.CargarKilometrosRecorridos(1, 2);
            Chofer chofer3 = new Chofer("Roberto");

            chofer3.AsignarDescansoSemanal(2);
            chofer3.CargarKilometrosRecorridos(4, 100);
            chofer3.CargarKilometrosRecorridos(6, 500);
            chofer3.CargarKilometrosRecorridos(1, 498);
            chofer3.CargarKilometrosRecorridos(7, 4000);


            Empresa empresaTransporte = new Empresa();

            empresaTransporte.AgregarChofer(chofer1);
            empresaTransporte.AgregarChofer(chofer2);
            empresaTransporte.AgregarChofer(chofer3);

            Console.WriteLine(empresaTransporte.Mostrar());
            Console.WriteLine("\nEl chofer que hizo mas km el dia 7 es: " + empresaTransporte.CalcularKmDiario("+",7).GetNombre());
            Console.WriteLine("\nEl chofer que hizo menos km el dia 1 es: " + empresaTransporte.CalcularKmDiario("-",1).GetNombre());


        }
    }
}