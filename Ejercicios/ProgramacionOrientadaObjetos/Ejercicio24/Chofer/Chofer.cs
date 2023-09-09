/*
De una empresa de transporte de cargas se quiere guardar el nombre de los conductores 
y los kilómetros que conducen cada día de la semana.

Para guardar esta información, la empresa de transporte tendrá un array de conductores.

De cada conductor se tendrá la siguiente información:

Nombre del conductor.
Kilometros recorridos por cada día de la semana. Por ejemplo:
Día 1: 200
Día 2: 599
Día 3: 899
Día 4: 0 (tiene franco)
Día 5: 256
Día 6: 0
Día 7: 0

*/
using System.Text;

namespace Entidades
{
    public class Chofer
    {
        private string nombre;
        private int descanso;
        private int[] diasSemana;

        /// <summary>
        /// Sin parametros por defecto asignara un valor
        /// </summary>
        public Chofer()
        {
            this.nombre = "N/A";
        }

        /// <summary>
        /// Inicializar con nombre y descanso
        /// </summary>
        /// <param name="nombre"></param>
        public Chofer(string nombre)
        {
            this.nombre = nombre;
            diasSemana = new int[7];

        }

        public bool AsignarDescansoSemanal(int dia)
        {
            bool valor = false;

            if (dia > 0 && dia < 8)
            {
                this.descanso = dia;
                valor = true;
            }

            return valor;

        }

        /// <summary>
        /// Carga los kilometros recorridos un dia en especifico
        /// </summary>
        /// <param name="dia"></param>
        /// <param name="cantidad"></param>
        public bool CargarKilometrosRecorridos(int dia, int cantidad)
        {
            bool valor = false;

            if (dia > 0 && dia < 8 && cantidad > 0)
            {
                diasSemana[dia - 1] = cantidad;
                valor = true;
            }

            return valor;
        }

        /// <summary>
        /// Retorna los kilometros recorrido en un dia especifico pasado por parametro
        /// </summary>
        /// <param name="dia"></param>
        /// <returns></returns>
        public int GetKilometrosPorDia(int dia)
        {
            int kilometrosRecorridos = -1;

            if (dia > 0 && dia < 8 && dia != this.descanso)
            {
                kilometrosRecorridos = diasSemana[dia -1];
            }

            return kilometrosRecorridos;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Cantidad de kilometros recorridos por dia");

            for (int i = 0; i < diasSemana.Length; i++)
            {
                if (i != this.descanso)
                {
                    sb.AppendLine($"Dia {i + 1}: {diasSemana[i]} KM");
                }
                else
                {
                    sb.AppendLine($"Dia {this.descanso}: {diasSemana[i]} KM / DESCANSO");

                }

            }

            return sb.ToString();
        }

        private int CalcularKilometrosSemanales()
        {
            int sumaTotal = 0;

            for (int i = 0; i < diasSemana.Length; i++)
            {
                sumaTotal += diasSemana[i];
            }

            return sumaTotal;
        }

        /// <summary>
        /// Sobrecarga el operador relacional > <
        /// </summary>
        /// <param name="chofer1"></param>
        /// <param name="chofer2"></param>
        /// <returns></returns>
        public static bool operator > (Chofer chofer1, Chofer chofer2)
        {
            return chofer1.CalcularKilometrosSemanales()  > chofer2.CalcularKilometrosSemanales();
        }

        public static bool operator < (Chofer chofer1, Chofer chofer2)
        {
            return chofer1.CalcularKilometrosSemanales() < chofer2.CalcularKilometrosSemanales();
        }
    }
}