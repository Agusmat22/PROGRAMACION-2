using Entidades;
namespace PracticandoHilos
{

    public partial class Form1 : Form
    {
        private CancellationTokenSource cancellation;
        private List<int> agregarNumeros;

        public Form1()
        {
            InitializeComponent();
            this.agregarNumeros = new List<int>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }


        private void btnAtender_Click(object sender, EventArgs e)
        {
            List<int> lista = new List<int>() {5,2,3,1,0,65,11,0,1,6 };
            //List<int> agregarNumeros = new List<int>();

            this.cancellation = new CancellationTokenSource();

            Task terea = Task.Run(() => CargarNumeros(lista, cancellation));

          
        }

        private void CargarNumeros(int numero)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(() => CargarNumeros(numero));
            }
            else
            {
                this.agregarNumeros.Add(numero);
                this.lstbPersonas.DataSource = null;
                this.lstbPersonas.DataSource = this.agregarNumeros;
            }
        }

        private void CargarNumeros(List<int> numero, CancellationTokenSource cancellation)
        {
           
                foreach (int item in numero)
                {
                    if (!cancellation.IsCancellationRequested)
                    {
                        this.CargarNumeros(item);
                        Thread.Sleep(1000);
                    }

                }
            

        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.cancellation.Cancel();
        }
    }
}