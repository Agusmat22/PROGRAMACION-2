using Entidades;
namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneo1 = new Torneo<EquipoFutbol>("Libertadores");
            Torneo<EquipoBasquet> torneo2 = new Torneo<EquipoBasquet>("League Basquet");

            //EQUIPOS DE FUTBOL
            EquipoFutbol equipoFutbol1 = new EquipoFutbol("River",DateTime.Now);
            EquipoFutbol equipoFutbol2 = new EquipoFutbol("Boca",DateTime.Now);
            EquipoFutbol equipoFutbol3 = new EquipoFutbol("Racing",DateTime.Now);

            //EQUIPOS DE BASQUET
            EquipoBasquet equipoBasquet1 = new EquipoBasquet("Argentina", DateTime.Now);
            EquipoBasquet equipoBasquet2 = new EquipoBasquet("Brasil", DateTime.Now);
            EquipoBasquet equipoBasquet3 = new EquipoBasquet("Eeuu", DateTime.Now);


            if (torneo1 + equipoFutbol1 && torneo1 + equipoFutbol2 && torneo1 + equipoFutbol3)
            {
                Console.WriteLine("Los Equipos de futbol se agregaron al torneo correctamente");
                Console.WriteLine(torneo1.JugarPartido);
            }

            if (torneo2 + equipoBasquet1 && torneo2 + equipoBasquet2 && torneo2 + equipoBasquet3)
            {
                Console.WriteLine("Los Equipos de basquet se agregaron al torneo correctamente");
                Console.WriteLine(torneo2.JugarPartido);

            }


        }
    }
}