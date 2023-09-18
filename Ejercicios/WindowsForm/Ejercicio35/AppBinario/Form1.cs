using Conversor;

namespace AppBinario
{
    public partial class Form1 : Form
    {
        private double numeroDecimal; 
      
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBinarioADecimal_Click(object sender, EventArgs e)
        {
            //Restaura el textBox
            RestaurarTextBox();

            if (!string.IsNullOrEmpty(this.txtBinADec.Text))
            {
                numeroDecimal = Numero.BinarioADecimal(this.txtBinADec.Text);

                this.txtResultadoDecimal.Text = numeroDecimal.ToString();
            }
            else
            {
                this.txtBinADec.BackColor = Color.Salmon;
                this.txtBinADec.PlaceholderText = "Error complete el recuadro";

            }
        }

        private void RestaurarTextBox()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox textBox && (textBox == this.txtDecABin || textBox == this.txtBinADec))
                {
                    textBox.BackColor = Color.White;
                    textBox.PlaceholderText = "";
                }
            }
        }

        private void btnDecimalABinario_Click(object sender, EventArgs e)
        {
            RestaurarTextBox();

            if (double.TryParse(this.txtDecABin.Text, out numeroDecimal))
            {
                this.txtResultadoBinario.Text = Numero.DecimalABinario(numeroDecimal);
            }
            else
            {
                this.txtDecABin.BackColor = Color.Salmon;
                this.txtDecABin.PlaceholderText = "Error complete el recuadro";

            }

        }
    }
}