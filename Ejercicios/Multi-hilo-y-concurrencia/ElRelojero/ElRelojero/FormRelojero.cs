namespace ElRelojero
{
    public partial class FormRelojero : Form
    {
        Task tarea;
        CancellationTokenSource cancellationTokenSource;

        public delegate void MostradorDeHora();
        public FormRelojero()
        {
            InitializeComponent();
        }

        public void AsignarHora()
        {
            if (this.InvokeRequired)
            {
                //PUEDO O NO CREAR UN DELEGADO ES OPCIONAL
                //MostradorDeHora mostrarHora = this.AsignarHora;

                this.BeginInvoke(AsignarHora);
            }
            else
            {
                this.label1.Text = DateTime.Now.ToString();
            }
        }

        private void InciarReloj()
        {
            //valido que no se cancelo el subproceso
            while (true && !cancellationTokenSource.IsCancellationRequested)
            {
                this.AsignarHora();
                Thread.Sleep(1000);
            }
        }

        private void FormRelojero_FormClosing(object sender, FormClosingEventArgs e)
        {
            //cancelo el hilo
            this.cancellationTokenSource.Cancel();
        }


        private void btnComenzar_Click(object sender, EventArgs e)
        {
            this.cancellationTokenSource = new CancellationTokenSource();

            //Task tarea = new Task(this.InciarReloj);
            //tarea.Start();

            Task tarea = Task.Run(() => this.InciarReloj());
 





        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            this.cancellationTokenSource.Cancel();
        }

        private void FormRelojero_Load(object sender, EventArgs e)
        {
            /*
            this.cancellationTokenSource = new CancellationTokenSource();

            Task tarea = new Task(this.InciarReloj);

            tarea.Start();*/

        }
    }
}