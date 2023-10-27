
namespace Entidades
{
    public enum EEstaciones
    {
        Verano = 12,
        Primavera = 9,
        Invierno = 6,
        Otonio = 3
    }
    public static class MetodosDeExtension
    {
        
        public static string ObtenerPlacaCronicaTV(this DateTime fecha, EEstaciones estacion)
        {

            DateTime estacionDelAnio = new DateTime(fecha.Year, (int)estacion, 21);

            if (fecha.Month >= estacionDelAnio.Month && fecha.Day >= estacionDelAnio.Day)
            {
                estacionDelAnio = estacionDelAnio.AddYears(1);
            }

            TimeSpan diferenciaDeTiempo = estacionDelAnio - fecha ;

            return ((int)diferenciaDeTiempo.TotalDays).ToString();
                               
        }
        
    }
}