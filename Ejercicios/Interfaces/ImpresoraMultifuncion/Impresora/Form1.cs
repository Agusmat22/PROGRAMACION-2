using Entidades;

namespace Impresora
{
    public partial class Form1 : Form
    {
        private Impresoraa impresora;

        public Form1()
        {
            InitializeComponent();
            impresora = new Impresoraa();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            impresora.AgregarImprimible(new Contrato());
            impresora.AgregarImprimible(new Documento());
            impresora.AgregarImprimible(new Foto());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = 
        }
    }
}