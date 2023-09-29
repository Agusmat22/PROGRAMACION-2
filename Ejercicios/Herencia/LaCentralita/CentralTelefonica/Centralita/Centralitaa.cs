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



        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Razon social: {this.razonSocial}");
            sb.AppendLine($"Ganancia llamadas locales {this.GananciasPorLocal}");
            sb.AppendLine($"Ganancia llamadas provincial {this.GananciasPorProvincial}");
            sb.AppendLine($"Ganancia llamadas total {this.GananciasPorTotal}");

            return sb.ToString();   
        }

        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}