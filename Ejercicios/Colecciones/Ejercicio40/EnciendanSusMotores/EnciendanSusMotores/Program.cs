using Entidades;

namespace EnciendanSusMotores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Competencia competencia = new Competencia(5, 3);

            AutoF1 auto1 = new AutoF1(123,"agustin");
            AutoF1 auto2 = new AutoF1(123,"agustin");
            AutoF1 auto3 = new AutoF1(1089,"romario");
            AutoF1 auto4 = new AutoF1(123,"romario");
            AutoF1 auto5 = new AutoF1(123,"romario");

            Console.WriteLine(competencia+ auto1);
            Console.WriteLine(competencia+ auto2);
            Console.WriteLine(competencia+ auto3);
            Console.WriteLine(competencia+ auto4);
            Console.WriteLine(competencia+ auto5);

            Console.WriteLine("La cantidad de autos anotados son: " +competencia.CompetidoresAnotados);
        }
    }
}