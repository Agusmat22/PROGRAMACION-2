using System.Text;

namespace ContarPalabras
{
    public partial class FormContarPalabras : Form
    {
        private Dictionary<string, int> contadorPalabra;
        private string[] listaPalabras;
        private string palabra;
        public FormContarPalabras()
        {
            InitializeComponent();
        }

        private void FormContarPalabras_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Estas seguro de cerrar?", "CERRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();

            palabra = this.RichTxt.Text.Trim();
            listaPalabras = palabra.Split(" ");

            foreach (string cadena in listaPalabras)
            {
                if (contadorPalabra.ContainsKey(cadena))
                {
                    contadorPalabra[cadena]++;
                }
                else
                {
                    contadorPalabra[cadena] = 1;
                }
            }

            foreach (KeyValuePair<string, int> item in contadorPalabra)
            {
                sb.AppendLine(item.Key + ": " + item.Value);
                
            }
            MessageBox.Show(sb.ToString());
        }

        private void FormContarPalabras_Load(object sender, EventArgs e)
        {
            contadorPalabra = new Dictionary<string, int>();
        }
    }
}