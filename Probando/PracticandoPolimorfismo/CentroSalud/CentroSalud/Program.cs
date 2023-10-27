using Empresa;

namespace CentroSalud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            DateTime fechaNacimiento = DateTime.Parse("2001/02/24");

            Administrativo admin = new Administrativo("Agustin",fechaNacimiento,1145,120000);

            if (admin + 101)
            {
                Console.WriteLine(admin.ToString());
            }
            else
            {
                Console.WriteLine("Supero el limite de expedientes");
                Console.WriteLine(admin.ToString());
            }*/
            Class1 prueba = new Class1();
            Class1 prueba2 = new Class1();
            IProbandoInterfaz asa = prueba2;

            Console.WriteLine(((IProbandoInterfaz)prueba).SumarNumeros(10,10));
            Console.WriteLine(prueba.SumarNumeros(10,10));
            Console.WriteLine(prueba.prueba(prueba2));

        }
    }
}