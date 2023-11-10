namespace ElDelegado
{
    public partial class FormPrincipal : Form
    {
        private FrmMostrar frmMostrar;
        private FrmTestDelegados frmTestDelegados;



        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            frmMostrar = new FrmMostrar();
            //le paso el metodo para que luego lo referencie
            frmTestDelegados = new FrmTestDelegados(frmMostrar.ActualizarNombre);

            frmMostrar.MdiParent = this;
            frmTestDelegados.MdiParent = this;
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestDelegados.Show();

            if (mostrarToolStripMenuItem.Enabled == false)
            {
                this.mostrarToolStripMenuItem.Enabled = true;
            }
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrar.Show();
        }
    }
}