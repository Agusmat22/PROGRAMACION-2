using Biblioteca;

/*
Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.

Deberá tener los atributos:

titular que contendrá la razón social del titular de la cuenta.
cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.
Construir los siguientes métodos para la clase:

Un constructor que permita inicializar todos los atributos.
Un método getter para cada atributo.
mostrar retornará una cadena de texto con todos los datos de la cuenta.
ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.

*/
namespace CreoNecesitoUnPrestamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Cuenta cuenta = new Cuenta("Ducati",456.15M);

            //Cuenta cuenta1 = new Cuenta("Honda",120.40M);
            
            //Cuenta cuenta2 = new Cuenta("Yamaha",46.15M);

            Console.WriteLine("CUENTA ACTUAL\n" +cuenta.Mostrar());

            cuenta.Ingresar(2000.10M);

            Console.WriteLine("INGRESO DINERO\n" + cuenta.Mostrar());

            cuenta.Retirar(4000M);

            Console.WriteLine("RETIRO DINERO\n" + cuenta.Mostrar());
        }
    }
}