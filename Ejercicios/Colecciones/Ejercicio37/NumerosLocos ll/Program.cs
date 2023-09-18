/*
Crear una aplicación de consola que cargue en una Lista, Pila y Cola 20 números enteros (positivos y negativos)
distintos de cero de forma aleatoria utilizando la clase Random.

Mostrar la colección tal como fue cargada.
Luego mostrar los positivos ordenados en forma decreciente.
Por último, mostrar los negativos ordenados en forma creciente.


*/
namespace NumerosLocos_ll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroRandom;

            List<int> listaNumeros = new List<int>();
            Queue<int> colaNumeros = new Queue<int>();
            Stack<int> pilaNumeros = new Stack<int>();


            for(int i = 0; i < 20; i++)
            {
                do
                {
                    numeroRandom = random.Next(-20, 20);

                } while (numeroRandom == 0);

                listaNumeros.Add(numeroRandom);
                //agrego un elemento a la cola
                colaNumeros.Enqueue(numeroRandom);
                //agrego un elemento a la pila
                pilaNumeros.Push(numeroRandom);
            }

            //ORDENO LA LISTA
            listaNumeros.Sort(FuncionCriterio);

            Console.WriteLine("Lista ordenada decreciente");
            foreach (int item in listaNumeros)
            {
                if (item > -1)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("Queue (cola) -> NO SE PUEDEN ORDENAR YA QUE SU LOGICA ES DEL TIPO FIFO");

            foreach (int item in colaNumeros)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Seleccion con el metodo peek al elemento: {colaNumeros.Peek()}" +
                $"\nPeek en la colas selecciona el primer elemento que ingreso y va salir");

            Console.WriteLine("Stack (pila) -> NO SE PUEDEN ORDENAR YA QUE SU LOGICA ES DEL TIPO LIFO");

            foreach (int item in pilaNumeros)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Seleccion con el metodo peek al elemento: {pilaNumeros.Peek()}" +
                $"\nPeek en la pilas selecciona al ultimo elemento que ingreso y va salir");




            Console.WriteLine("Hello, World!");
        }

        private static int FuncionCriterio(int a,int b)
        {
            return a - b;
        }
    }
}