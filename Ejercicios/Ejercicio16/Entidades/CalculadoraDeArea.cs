/*
Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase (estáticos) 
que realicen el cálculo del área que corresponda:

public double CalcularAreaCuadrado(double longitudLado) {}

public double CalcularAreaTriangulo(double base, double altura) {}

public double CalcularAreaCirculo(double radio) {}

El ingreso de los datos como la visualización se deberán realizar desde el método Main().
*/
namespace Entidades
{
    public static class CalculadoraDeArea
    {

        public static double CalcularAreaCuadrado(double longitudLado)
        {
            double area = longitudLado * longitudLado;
            return area;
        }

        public static double CalcularAreaTriangulo(double basse,double altura)
        {
            double area = (basse * altura) / 2;

            return area;

        }

        public static double CalcularAreaCirculo(double radio)
        {
            double area = Math.PI * Math.Pow(radio,2);

            return area;
        }


    }
}