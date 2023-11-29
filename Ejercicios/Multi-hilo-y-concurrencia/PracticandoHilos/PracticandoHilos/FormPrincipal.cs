using Entidades;
namespace PracticandoHilos
{
    public delegate void AgregarPaciente(string nombre);
    public partial class FormPrincipal : Form
    {
        List<string> listaPacientes;
        AgregarPaciente agregadorPaciente;
        public FormPrincipal()
        {
            InitializeComponent();
            this.listaPacientes = new List<string>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.agregadorPaciente = this.AgregarPersona;

        }

        private void AgregarPersona(string nombre)
        {
            this.listaPacientes.Add(nombre);

        }

        

        private void MostrarFormulario(Panel panel, Form formulario)
        {
            this.LimpiarPanel(panel);

            formulario.TopLevel = false;
            //agrego el form
            panel.Controls.Add(formulario);

            //quito los bordes al form

            formulario.FormBorderStyle = FormBorderStyle.None;

            //indico que se expanda en todo el contenedor
            formulario.Dock = DockStyle.Fill;

            formulario.Show();

        }

        private void LimpiarPanel(Panel panel)
        {
            //limpia los controles del panel
            panel.Controls.Clear();
        }

        private void btnPrimer_Click(object sender, EventArgs e)
        {
            FormAgregar formAgregar = new FormAgregar(this.agregadorPaciente);
            this.MostrarFormulario(this.panel1, formAgregar);
        }

        private void btnSegundo_Click(object sender, EventArgs e)
        {
            FormMostrar formMostrar = new FormMostrar(this.listaPacientes);
            this.MostrarFormulario(this.panel2, formMostrar);
        }
    }
}