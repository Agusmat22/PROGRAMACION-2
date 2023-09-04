/*
Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años) y 
la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.

Se pide calcular el importe a cobrar teniendo en cuenta que el total 
(que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), 
hay que sumarle la cantidad de años trabajados multiplicados por $150, 
y al total de todas esas operaciones restarle el 13% en concepto de descuentos.

Mostrar el recibo correspondiente con el nombre, la antigüedad, 
el valor hora, el total a cobrar en bruto y el total a cobrar neto de todos los empleados ingresados.



*/

namespace Entidades
{
    public class Liquidacion
    {

        public static string PedirDato(string mensaje)
        {
            Console.WriteLine(mensaje);
            string dato = Console.ReadLine();
            return dato;
        }

        public static void PedirDatoLiquidacion(out int numero, string mensaje)
        {
            string input = Liquidacion.PedirDato(mensaje);

            while (!Validador.ParsearNumero(input, out numero))
            {
                input = Liquidacion.PedirDato($"ERROR,Re {mensaje}");
            }
        }

        public static void PedirDatoLiquidacion(out double numero, string mensaje)
        {
            string input = Liquidacion.PedirDato(mensaje);

            while (!Validador.ParsearNumero(input, out numero))
            {
                input = Liquidacion.PedirDato($"ERROR,Re {mensaje}");
            }
        }


        public static double CalcularSueldoBruto(double precioHora, int cantidadHoras,int antiguedad)
        {
            int VALOR_ANTIGUEDAD = 150;

            double sueldoBruto = ((precioHora * cantidadHoras) + antiguedad * VALOR_ANTIGUEDAD);

            return sueldoBruto;

        }

        public static double CalcularSueldoNeto(double sueldoBruto,int descuento)
        {

            double sueldoNeto = sueldoBruto - (sueldoBruto * descuento) / 100;

            return sueldoNeto;

        }

    }
}