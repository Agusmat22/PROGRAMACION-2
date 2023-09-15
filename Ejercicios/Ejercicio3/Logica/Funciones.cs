namespace Logica
{
    public static class Funciones
    {

        public static string PedirDato(string mensaje)
        {

            Console.WriteLine(mensaje);
            string dato = Console.ReadLine();

            return dato;
        }

        public static List<int> NumerosPrimos(int topeNumeros)
        {
            List<int> list = new List<int>();

            for (int i = 1; i < topeNumeros; i++) 
            {
                for (int j = 1; j < 10; j++)
                {
                    if(i!=1 && j!=1 && i != j && i % j == 0)
                    {
                        break;
                    }
                    else if(j == 9)
                    {
                        list.Add(i);
                    }
                }
            }

            return list;    

        }

    }
}