using System.Text;

namespace Centralita
{
    public class Centralitaa
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralitaa()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralitaa(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        /// <summary>
        /// Calcula las ganancias segun el tipo de llamada ingresado
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancia = 0f;

            if(listaDeLlamadas.Count > 0)
            {
                foreach (Llamada llamada in listaDeLlamadas)
                {
                    if ((tipo == Llamada.TipoLlamada.Local || tipo == Llamada.TipoLlamada.Todas) && llamada is Local local)
                    {
                        //acumulo el costo de llamda local
                        ganancia += local.CostoLlamada;
                    }
                    else if ((tipo == Llamada.TipoLlamada.Provincial || tipo == Llamada.TipoLlamada.Todas) && llamada is Provincial provincial)
                    {
                        ganancia += provincial.CostoLlamada;
                    }
                }
            }
           
            

            return ganancia;    
        }

        //PROPERTY

        public float GananciasPorLocal //calcula la ganancia unicamente de las llamadas locales
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);

            }
        }
        public float GananciasPorProvincial //calcula la ganancia unicamente de las llamadas provinciales
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
                
            }
        }

        public float GananciasPorTotal //calcula la ganancia unicamente de las llamadas provinciales
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);

            }
        }

        public List<Llamada> Llamadas
        {
            get { return listaDeLlamadas; }

        }

        //OVERLOAD

        public static bool operator ==(Centralitaa centralita,Llamada llamada)
        {
            bool valor = false;

            if (centralita.Llamadas.Count > 0)
            {
                foreach (Llamada item in centralita.Llamadas)
                {
                    if (item == llamada)
                    {
                        valor = true;
                        break;
                    }
                }
            }

            return valor;
        }

        public static bool operator !=(Centralitaa centralita,Llamada llamada)
        {
            return !(centralita == llamada);
        }


        public static bool operator +(Centralitaa centralita, Llamada llamada)
        {
            bool valor = false;

            if (centralita != llamada)
            {
                centralita.AgregarLlamada(llamada);
                valor = true;
            }

            return valor;
        }


        //METHOD

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Razon social: {this.razonSocial}");
            sb.AppendLine($"Ganancia llamadas locales {this.GananciasPorLocal}");
            sb.AppendLine($"Ganancia llamadas provincial {this.GananciasPorProvincial}");
            sb.AppendLine($"Ganancia llamadas total {this.GananciasPorTotal}");

            return sb.ToString();   
        }

        /// <summary>
        /// Ordena la lista de llamadas mediante el metodo comparison
        /// </summary>
        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        
        /// <summary>
        /// Agrega una llamada a la lista validando que no este dentro
        /// </summary>
        /// <param name="llamada"></param>
        private void AgregarLlamada(Llamada llamada)
        {
           
            this.listaDeLlamadas.Add(llamada);
            
                
        }

        //POLIMORFISMO

        public override string ToString()
        {
            return Mostrar();
        }


    }
}