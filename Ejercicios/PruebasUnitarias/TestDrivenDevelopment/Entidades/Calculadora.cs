using System.Text.RegularExpressions;

namespace Entidades
{
    public class Calculadora
    {


        public int Add(string numero)
        {
            string[] listaNumeros;
            string[] listaNumerosConSaltoLinea;
            int sumaTotal = 0;

            if (!Regex.IsMatch(numero,"-"))
            {


                if (Regex.IsMatch(numero, "[0-9]+,+"))
                {
                    listaNumeros = numero.Split(',');

                    for (int i = 0; i < listaNumeros.Length; i++)
                    {
                        if (Regex.IsMatch(listaNumeros[i], "\n+"))
                        {
                            listaNumerosConSaltoLinea = listaNumeros[i].Split("\n");

                            for (int j = 0; j < listaNumerosConSaltoLinea.Length; j++)
                            {
                                sumaTotal += int.Parse(listaNumerosConSaltoLinea[j]);
                            }
                        }
                        else
                        {
                            sumaTotal += int.Parse(listaNumeros[i]);
                        }
                    }

                    return sumaTotal;

                }
                else if (int.TryParse(numero, out int numeroCasteado))
                {
                    return numeroCasteado;

                }
                return 0;

            }
            else
            {
                throw new ExcepcionNegativoNoPermitido("Error, no se aceptan numeros negativos");
            }
        }

        
    }
}