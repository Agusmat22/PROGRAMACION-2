using Centralita;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Centralitaa centralita = new Centralitaa(); 

            Local local = new Local("bernal",60,"santiago del estero",10);
            Local local2 = new Local("bernal",60,"santiago del estero",10);
            Provincial provincial = new Provincial("lanus",Provincial.Franja.Franja_3,15,"avellaneda");



            if (centralita + local)
            {
                Console.WriteLine("Se agrego correctamente llamada local");
            }

            if (!(centralita + local2))
            {
                Console.WriteLine("No se pudo agregar ya que existe la llamada dentro de la centralita");

            }

            if (centralita + provincial)
            {
                Console.WriteLine("Se agrego correctamente llamada provincial");
            }


            /*
            Console.WriteLine(local.Equals(local2));
            Console.WriteLine(local.Equals(provincial));*/

            foreach (Llamada item in centralita.Llamadas)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine(item.ToString());
                Console.WriteLine("-----------------------");

                Console.WriteLine($"COMPARACION CON EQUALS: {item.Equals(local)}");
                
            }

            

        }
    }
}