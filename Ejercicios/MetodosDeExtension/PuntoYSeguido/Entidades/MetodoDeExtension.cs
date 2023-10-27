using System.Text.RegularExpressions;

namespace Entidades
{
    public static class MetodoDeExtension
    {
        public static int ContadorSignosDePuntuacion(this string str )
        {
            int cantidadSignos = 0;

            string patron = ",|\\.|;";

            MatchCollection coincidenciasTotales = Regex.Matches(str, patron);

            return coincidenciasTotales.Count;

        }

    }
}