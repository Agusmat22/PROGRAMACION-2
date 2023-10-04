using Entidades;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c = 12345678;
            Comida h = new Hamburguesa("Doble cuarto de libra", true);
            Console.WriteLine(h + Comida.EIngredientes.PANCETA);
            Console.WriteLine(h + Comida.EIngredientes.ADHERESO);
            Console.WriteLine(h + Comida.EIngredientes.TOMATE);
            Console.WriteLine(h + Comida.EIngredientes.PANCETA);
            Console.WriteLine("hamburguesa");
            Console.WriteLine(h.Descripcion);
            Comida g = new Guarnicion();
            Console.WriteLine(g + Comida.EIngredientes.LECHUGA);
            Console.WriteLine(g + Comida.EIngredientes.QUESO);
            Console.WriteLine("Guarnicion");
            Console.WriteLine(g.Descripcion);

            if (c + h)
            {
                Console.WriteLine("Se pudo agregar la comida");
            }
            else
            {
                Console.WriteLine("No se pudo agregar la comida ");

            }
            if (c + g)
            {
                Console.WriteLine("Se pudo agregar la guarnicion ");

            }
            else
            {
                Console.WriteLine("No se pudo agregar la guarnicion ");

            }

            Console.WriteLine("Cliente");
            Console.WriteLine(Cliente.ImprimirTicket(c));
        }
    }
}