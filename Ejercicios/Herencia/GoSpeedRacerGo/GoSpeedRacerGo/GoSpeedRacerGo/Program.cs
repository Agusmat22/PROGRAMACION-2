using Entidades;

namespace GoSpeedRacerGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Competencia competenciaF1 = new Competencia(5,10,Competencia.TipoCompetencia.F1);

            AutoF1 auto1 = new AutoF1("River", 1235);
            AutoF1 auto2 = new AutoF1("Boca", 3211);
            AutoF1 auto3 = new AutoF1("Velez", 4412);
            AutoF1 auto4 = new AutoF1("Lanus", 0997);
            AutoF1 auto5 = new AutoF1("Racing", 3232);
            AutoF1 auto6 = new AutoF1("San Lorenzo", 9906);
            AutoF1 auto7 = new AutoF1("San romer", 122);

            MotoCross moto = new MotoCross(123,"waa");

            Console.WriteLine(competenciaF1 + auto1);
            Console.WriteLine(competenciaF1 + auto2);
            Console.WriteLine(competenciaF1 + auto3);
            Console.WriteLine(competenciaF1 + auto4);
            Console.WriteLine(competenciaF1 + auto5);
            Console.WriteLine(competenciaF1 + auto6);
            Console.WriteLine(competenciaF1 + auto7);
            Console.WriteLine(competenciaF1 + moto);

        }
    }
}