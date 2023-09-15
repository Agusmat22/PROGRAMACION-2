using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empresa
    {
        static List<Chofer> listaChoferes;
        private string nombre;
        private string rubro;

        static Empresa()
        {
            listaChoferes = new List<Chofer>();
        }

        public Empresa()
        {
            this.nombre = "N/A";
            this.rubro = "N/A";
        }

        public Empresa(string nombre, string rubro)
        {
            this.nombre = nombre;
            this.rubro = rubro;
        }

        public void AgregarChofer(Chofer chofer)
        {
            listaChoferes.Add(chofer);
        }

        /// <summary>
        /// Calcular el chofe que contenga max km semanales
        /// </summary>
        /// <returns></returns>
        private Chofer CalcularKmSemanales(string operacion)
        {
            Chofer choferKmRealizados = new Chofer();
            bool flag = true;

            foreach (Chofer chofer in listaChoferes)
            {
                if (flag)
                {
                    choferKmRealizados = chofer;
                    flag = false;
                }
                else
                {
                    if (operacion == "+" && choferKmRealizados < chofer)
                    {
                        choferKmRealizados = chofer;
                    }
                    else if (operacion == "-" && choferKmRealizados > chofer)
                    {
                        choferKmRealizados = chofer;
                    }
                    
                }
            }

            return choferKmRealizados;
        }

        public Chofer CalcularKmDiario(string operacion,int dia)
        {
            Chofer choferKmRealizados = new Chofer();
            bool flag = true;

            foreach (Chofer chofer in listaChoferes)
            {
                if (flag)
                {
                    choferKmRealizados = chofer;
                    flag = false;
                }
                else
                {
                    if (operacion == "+" && choferKmRealizados.GetKilometrosPorDia(dia) < chofer.GetKilometrosPorDia(dia))
                    {
                        choferKmRealizados = chofer;
                    }
                    else if (operacion == "-" && choferKmRealizados.GetKilometrosPorDia(dia) > chofer.GetKilometrosPorDia(dia))
                    {
                        choferKmRealizados = chofer;
                    }

                }
            }

            return choferKmRealizados;
        }

        public string Mostrar()
        {
                StringBuilder sb = new StringBuilder();

            sb.AppendLine("Estadisticas de la empresa de transporte");
            sb.AppendLine($"El chofer con mas KM en la semana: " + CalcularKmSemanales("+").GetNombre());
            sb.AppendLine($"El chofer con menos KM en la semana: " + CalcularKmSemanales("-").GetNombre());

            return sb.ToString();   
        }

    }
}
