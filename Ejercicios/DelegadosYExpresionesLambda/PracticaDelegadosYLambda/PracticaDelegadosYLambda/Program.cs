using Entidades;

namespace PracticaDelegadosYLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Calculadora calculadora = new Calculadora();

            //agrego los metodos al delegado
            RealizarOperacion mostrarResultado = calculadora.Suma;
            //se lo apendeo ya que hay otro metodo guardado
            mostrarResultado += calculadora.Multiplicar;

            //recorro la lista de referencia de metodos dentro del delegado y los ejecut
            foreach (RealizarOperacion item in mostrarResultado.GetInvocationList())
            {
                Console.WriteLine(item(10, 10));

            }

            //otra manera de usar los metodos
            mostrarResultado.Invoke(10, 5);

            //-----------------------------------------------------------------------------------//

            //creo una funcion lambda
            Action<string,string> saludar = (nombre,apellido) =>
            {
                string saludo = $"Hola como estas {nombre} {apellido}";
                Console.WriteLine(saludo);
            };
            saludar("Agustin", "Garcia");

            Func<int,int,int> caluladora = (multiplicar,valor) => multiplicar* valor;
            Func<int,int,int> caluladoraDivision = (divisor,dividendo) => divisor / dividendo;

            Predicate<int> validarNumeros = (numero) => { return numero == 10; };

            mostrarResultado = (num1, num2) => { return num1 * num2; };

            Console.WriteLine(validarNumeros(10));*/

            Calculadora calculadora = new Calculadora();

            RealizarOperacion realizarOperacion = calculadora.Suma;
            //realizarOperacion += calculadora.Multiplicar;
            /*
            MostrarOperacion mostrarOperacion = mensaje =>
            {
                Console.WriteLine(mensaje);
            };

            mostrarOperacion(realizarOperacion(10, 10));


            Func<int,int,int> calcular = (a,b) => a * b;

            Action<string> mostrar = mensaje => { Console.WriteLine(mensaje); };

            Predicate<int> mayorEdad = edad =>
            {
                return edad > 17 && edad < 100;
            };

            mostrar(calcular(50, 10).ToString());
            mostrar(mayorEdad(15).ToString());

            List<int> numeros = new List<int>() { 1,5,23,6,7,100,4};    

            numeros.Sort((a,b) => b-a);

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }*/
            /*
            RealizarOperacion operacion = (a, b) => { return a * b; };
            RealizarOperacion operacion2 = (a, b) =>  a * b;

            MostrarOperacion muestra = mensaje => { Console.WriteLine(mensaje); };

            MostrarOperacion muestra2 = mensaje => Console.WriteLine(mensaje);

            muestra(operacion(10, 2));
            muestra2(operacion2(50, 10));

            //-----/
            //lambda con delegados

            Func<float, int, float> dividir = (a, b) => a / b;
            Console.WriteLine(dividir(10, 50));

            Predicate<string> validarNombre = nombre => nombre == "agustin";
            Console.WriteLine(validarNombre("agustin"));*/

            Action<int> mostrars = mensaje => Console.WriteLine(mensaje);


            

            //aplicando un predicate LAMBDA

            mostrars(Calculadora.Dividir(a => a != 0, 10, 5));

            //lo mismo de otra manera
            Predicate<int> validador = a => (a != 0);
            mostrars(Calculadora.Dividir(validador, 10, 0));


        }
    }
}