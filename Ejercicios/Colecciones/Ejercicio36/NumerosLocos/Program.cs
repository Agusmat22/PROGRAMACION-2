/*
Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos) 
distintos de cero de forma aleatoria utilizando la clase Random.

Mostrar el vector tal como fue ingresado.
Luego mostrar los positivos ordenados en forma decreciente.
Por último, mostrar los negativos ordenados en forma creciente.


*/
namespace NumerosLocos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vectorNumeros = new int[20];
            Random random = new Random();
            int numero;


            for (int i = 0; i < 20; i++)
            {
                if (vectorNumeros[i] == 0)
                {
                    do
                    {
                        numero = random.Next(-20, 20);


                    } while (numero == 0);

                    vectorNumeros[i] = numero;
                }
            }

            //ordeno el array unidimensional
            Array.Sort(vectorNumeros,FuncionCriterio);

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(vectorNumeros[i]);    
            }




        }

        //ORDENA DE MAYOR A MENOR LA FUNCION CRITERIO
        public static int FuncionCriterio(int a,int b)
        { return b - a ; }
    }
}