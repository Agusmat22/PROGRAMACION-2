namespace Entidades
{
    public static class Funciones
    {

        public static string PedirDato(string mensaje)
        {
            Console.WriteLine(mensaje);
            string dato = Console.ReadLine();
            return dato;
        }


        /// <summary>
        /// Calcula si son multiplo entre un numero y otro pasados por parametro
        /// </summary>
        /// <param name="num">Numero que contendra coincidencia con el multiplo</param>
        /// <param name="multiplo">Numero para saber el multiplo</param>
        /// <returns>Bool</returns>
        public static bool CalcularMultiplo(int num,int multiplo)
        {

            return (num % multiplo == 0);


        }
    }
}