using ProbandoEntity.Entity;

namespace ProbandoEntity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PixContext pix = new PixContext();
            List<Producto> products = pix.Productos.ToList();
            Console.WriteLine(products[1].Nombre);
        }
    }
}