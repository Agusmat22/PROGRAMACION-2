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


using Entidades;

namespace ReciboDeSueldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int DESCUENTOS = 13;

            string nombre;

            double valorHora;
            int antiguedad;
            int cantidadHoras;
            int cantidadEmpleados;
            double sueldoBruto;
            double sueldoNeto;

            nombre = Liquidacion.PedirDato("Ingrese su nombre: ");

            Liquidacion.PedirDatoLiquidacion(out valorHora, "Ingrese el valor $ de la hora: ");
            Liquidacion.PedirDatoLiquidacion(out antiguedad, "Ingrese su antiguedad: ");
            Liquidacion.PedirDatoLiquidacion(out cantidadHoras, "Ingrese la cantidad de horas trabajadas: ");
            Liquidacion.PedirDatoLiquidacion(out cantidadEmpleados, "Ingrese la cantidad de empleados: ");

            sueldoBruto = Liquidacion.CalcularSueldoBruto(valorHora, cantidadHoras, antiguedad);

            sueldoNeto = Liquidacion.CalcularSueldoNeto(sueldoBruto, DESCUENTOS);


            Console.WriteLine($"El nombre de la empresa es: {nombre}\n" +
                $"Valor x hora: {valorHora}\n" +
                $"Antiguedad: {antiguedad} anios\n" +
                $"Horas trabajadas: {cantidadHoras}\n" +
                $"Sueldo Bruto: {sueldoBruto}\n" +
                $"Sueldo Neto: {sueldoNeto}\n" +
                $"Cantidad Abonar a todos los empleados: {sueldoNeto*cantidadEmpleados}"
                
                
                
                );


        }
    }
}