using Centralita;
using Formularios;

namespace FrmMenu
{
    public partial class FrmMenu : Form
    {
        private Centralitaa centralita;

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //obtengo el directorio
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            ruta = Path.Combine(ruta, "Registro de llamadas centralita");

            centralita = new Centralitaa("Telecom");

            centralita.RutaDeArchivo = ruta;

        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador llamador = new FrmLlamador(this.centralita);

            DialogResult resultado = llamador.ShowDialog();

            if (resultado == DialogResult.Cancel)
            {
                //guardo la centralita de nuevo por si hubieron llamados
                centralita = llamador.Centralita;
            }
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar mensajeMostrar = new FrmMostrar(this.centralita, "total");

            mensajeMostrar.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar mensajeMostrar = new FrmMostrar(this.centralita, "local");

            mensajeMostrar.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar mensajeMostrar = new FrmMostrar(this.centralita, "provincial");

            mensajeMostrar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea cerrar?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }

        }
    }
}