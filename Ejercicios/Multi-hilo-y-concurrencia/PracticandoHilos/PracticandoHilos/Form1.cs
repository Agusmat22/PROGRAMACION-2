using Entidades;
namespace PracticandoHilos
{
    public delegate void CargarPersonas(List<Persona> personas, CancellationToken cancelation);
    public delegate void ActualizarHora(DateTime hora);
    public partial class Form1 : Form
    {
        Random random;
        //tengo como parametro un referente de metodos (delegados)
        private CargarPersonas cargarPersonas;
        private List<Persona> personaList;
        private CancellationTokenSource cancellation;

        //HORARIO
        private ActualizarHora actualizarHora;

        public Form1()
        {
            InitializeComponent();
            this.personaList = new List<Persona>();
            this.cancellation = new CancellationTokenSource();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cargarPersonas = this.CargarPersonasEnListBox;

        }

        private void GuardarPersona(Persona persona)
        {
            this.personaList.Add(persona);

        }

        private void CargarPersonasEnListBox(List<Persona> listaPersonas, CancellationToken cancelation)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(this.cargarPersonas, listaPersonas, cancelation);
            }
            else
            {

                foreach (Persona per in listaPersonas)
                {
                    if (!cancellation.IsCancellationRequested)
                    {
                        this.GuardarPersona(per);
                        this.lstbPersonas.DataSource = null;
                        this.lstbPersonas.DataSource = this.personaList;
                        Thread.Sleep(100);
                    }
                }

            }
        }



        private void btnAtender_Click(object sender, EventArgs e)
        {
            /*Persona per1 = new Persona("Agustin", "Ramon", 20);
            Persona per2 = new Persona("Lucas", "GImenez", 33);
            Persona per3 = new Persona("Sofia", "Isunza", 10);
            Persona per4 = new Persona("Marcelo", "Garcia", 22);
            Persona per5 = new Persona("Vanesa", "Pinto", 80);
            Persona per6 = new Persona("Lucia", "Irine", 44);
            Persona per7 = new Persona("Romina", "Lida", 94);
            Persona per8 = new Persona("Juli", "Prime", 11);

            List<Persona> listaPrueba = new List<Persona>(); 

            listaPrueba.Add(per1);
            listaPrueba.Add(per2);
            listaPrueba.Add(per3);
            listaPrueba.Add(per4);
            listaPrueba.Add(per5);
            listaPrueba.Add(per6);
            listaPrueba.Add(per7);
            listaPrueba.Add(per8);

            Task tarea = Task.Run(() => this.cargarPersonas(listaPrueba, cancellation.Token));
            */

            ActualizarHora actualizarHora = this.ActualizarHoraLabel;

            Task tarea = Task.Run(() => actualizarHora(DateTime.Now),cancellation.Token);


        }

        private void MostrarLaHoraLabel(DateTime hora)
        {
            this.lblHora.Text = hora.ToString("HH/mm/ss");
        }

        private void ActualizarHoraLabel(DateTime hora)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(() => ActualizarHoraLabel(hora));
            }

            while (true && !this.cancellation.IsCancellationRequested)
            {
                this.MostrarLaHoraLabel(hora);
                Thread.Sleep(1000);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.cancellation.Cancel();
        }
    }
}