using Entidades;

namespace VolvarYVolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TorreDeControl torreDeControl = new TorreDeControl();

            torreDeControl.AgregarVoladores(new Boing747(10));
            torreDeControl.AgregarVoladores(new BuzzLightyear(50));
            torreDeControl.AgregarVoladores(new Pato(30));


            torreDeControl.VuelenTodos();   
        }
    }
}