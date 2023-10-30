using Centralita.Interfaces;
using System.Text;
using Centralita.Excepciones;

namespace Centralita
{
    public class Centralitaa : IGuardar<string>
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
        /// <summary>
        /// El operador == retornará true si la centralita contiene la llamada en su lista genérica
        /// </summary>
        /// <param name="centralita"></param>
        /// <param name="llamada"></param>
        /// <returns></returns>
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

            try
            {
                if (centralita != llamada)
                {
                    centralita.AgregarLlamada(llamada);
                    valor = centralita.Guardar();

                }
                else
                {
                    throw new CentralitaException("La llamada ya se encuentra registrada en la centralita");
                }

            }
            catch (FallaLogException ex) 
            { 
                throw ex;
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

        //APLICANDO EL CONTRATO DE LA INTERFAZ PERO NO LO ENTENDI

        public string RutaDeArchivo { get; set; }
        

        /// <summary>
        /// Guardara la fecha y hora en que se realizo una llamada X
        /// </summary>
        /// <returns></returns>
        /// <exception cref="FallaLogException">Se lanzara cuando la llamada no pueda guardarse</exception>
        public bool Guardar()
        {
            try
            {
                //obtengo el directorio
                this.RutaDeArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                this.RutaDeArchivo = Path.Combine(this.RutaDeArchivo, "Registro de llamadas centralita");

                if (!Directory.Exists(this.RutaDeArchivo))
                {
                    Directory.CreateDirectory(this.RutaDeArchivo);
                }

                string nombreArchivo = "Llamada.txt";

                this.RutaDeArchivo = Path.Combine(this.RutaDeArchivo, nombreArchivo);

                using (StreamWriter streamWriter = new StreamWriter(this.RutaDeArchivo))
                {
                    DateTime fechaActual = DateTime.Now;
                    string mensaje = $"El dia {fechaActual.ToString("dddd")} {fechaActual.Day} de {fechaActual.ToString("MMMM")} de {fechaActual.Year} {fechaActual.ToString("HH,mm,ss")}";

                    streamWriter.Write(mensaje);
                }      
            }
            catch (Exception ex)
            {
                throw new FallaLogException("Error al guardar el archivo", ex);
            }


           return true;
        }

        public string Leer()
        {

            if (Directory.Exists(this.RutaDeArchivo))
            {
                using (StreamReader streamReader = new StreamReader(this.RutaDeArchivo))
                {
                    string archivoLeido = streamReader.ReadToEnd();

                    return archivoLeido;
                }
            }
            else
            {
                throw new FallaLogException("Error, No hay archivos para leer");
            }


        }
    }
}