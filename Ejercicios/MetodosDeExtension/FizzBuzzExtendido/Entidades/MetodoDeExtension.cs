using System.Text;

namespace Entidades
{
    public static class MetodoDeExtension
    {

        public static string FizzBuzz(this int valor)
        {
            StringBuilder sb = new StringBuilder();

            if (valor % 15 == 0)
            {
                sb.Append("FizzBuzz");
            }
            else if (valor % 3 == 0)
            {
                sb.Append("Fizz");
            }
            else if (valor % 5 == 0)
            {
                sb.Append("Buzz");
            }
            else
            {
                sb.Append(valor.ToString());
            }

            return sb.ToString();   
        }

    }
}