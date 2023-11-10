namespace Entidades
{
    public delegate int RealizarOperacion(int num,int num2);
    public delegate void MostrarOperacion(int valor);

    public  class Calculadora
    {

        public int Suma(int num1,int num2)
        {
            return num1 + num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Dividir(Predicate<int> numeroValido,int a, int b)
        {
            if (numeroValido(b))
            {
                return a / b;
            }

            return -1;
        }

    }
}