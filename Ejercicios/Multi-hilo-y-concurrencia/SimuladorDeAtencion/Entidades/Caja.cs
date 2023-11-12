using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{

    public class Caja
    {
        public delegate void DelegadoClienteAtendido(Caja caja, string valor);


        static Random random;
        public Queue<string> clientesALaEspera;
        private string nombreCaja;
        private DelegadoClienteAtendido delagadoCliente;

        static Caja() 
        { 
            Caja.random = new Random();
        }

        public Caja(string nombreCaja,DelegadoClienteAtendido delegadoCliente)
        {
            this.clientesALaEspera = new Queue<string>();   
            this.nombreCaja = nombreCaja;
            this.delagadoCliente = delegadoCliente;
            
            
        }

        public string NombreCaja 
        { 
            get => nombreCaja; 
             
        }

        public int CantidadDeClientesALaEspera
        {
            get { return clientesALaEspera.Count; }

        }

        //metodos

        internal void AgregarCliente(string cliente)
        {
            this.clientesALaEspera.Enqueue(cliente);
        }

        internal Task IniciarAtencion()
        {
            Task tarea = Task.Run(this.AtenderCliente);

            return tarea;

        }

        private void AtenderCliente()
        {
           
            while(true)
            {
                if (this.clientesALaEspera.Any())
                {
                    string cliente = this.clientesALaEspera.Dequeue();
                    this.delagadoCliente(this, cliente);
                    Thread.Sleep(random.Next(1000,5000));   
                }
                

            }
            
        }
    }
}