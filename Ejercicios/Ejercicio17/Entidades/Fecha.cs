/*
Crear un método estático que reciba una fecha y calcule el número de días que pasaron 
desde esa fecha hasta la fecha actual. Tener en cuenta los años bisiestos.

Pedir por consola la fecha de nacimiento de una persona (día, mes y año) y 
calcule el número de días vividos por esa persona hasta la fecha actual utilizando el método desarrollado anteriormente.

Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio.


*/
namespace Entidades
{
    public static class Fecha
    {

        public static string PedirDato(string mensaje)
        {
            Console.WriteLine(mensaje);
            string dato = Console.ReadLine();
            return dato;
        }

        public static DateTime PedirFechaNacimiento()
        {
            DateTime fechaNacimiento;

            int dia = PedirFecha("Ingrese el dia: ", 1, 31);

            int mes = PedirFecha("Ingrese el mes: ", 1, 12);

            int anio = PedirFecha("Ingrese el año: ", 1900,2023);

            fechaNacimiento = new DateTime(anio, mes, dia);

            return fechaNacimiento;

        }

        public static int PedirFecha(string mensaje,int fechaMinima,int fechaMaxima)
        {
            string anio = PedirDato(mensaje);
            int fecha;

            while (!int.TryParse(anio, out fecha) || !ValidarAnio(fecha, fechaMinima,fechaMaxima))
            {
                anio = PedirDato("ERROR,"+mensaje);
            }

            return fecha;

        }

        /// <summary>
        /// Valida la fecha ingresada respecto a un tope establecido, ejemplo "Fecha minima 1900 ya que no hay personas de mas de 120 anios"
        /// </summary>
        /// <param name="anio"></param>
        /// <param name="minAnio"></param>
        /// <param name="maxAnio"></param>
        /// <returns>Retorna un booleano</returns>
        public static bool ValidarAnio(int anio,int minAnio,int maxAnio)
        {
            return anio >= minAnio && anio <= maxAnio;

        }

        public static string CambiarFormatoFecha(DateTime fecha)
        {
            string fechaFormato = fecha.ToString("dd/MM/yyyy");
            return fechaFormato;

        }


        /// <summary>
        /// Calcula la edad en base a una fecha determinada
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns></returns>
        public static int CalcularEdad(DateTime fecha)
        {
            DateTime fechaActual = DateTime.Now;

            int edad = fechaActual.Year - fecha.Year;

            if (fechaActual.Month >= fecha.Month && fechaActual.Day >= fecha.Day)
            {
                edad++;
            }

            return edad;


        }



    }
}