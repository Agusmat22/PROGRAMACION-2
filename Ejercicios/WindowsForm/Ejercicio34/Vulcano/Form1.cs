using Temperatura;
namespace Vulcano
{
    public partial class Form1 : Form
    {
        Fahrenheit tempFahrenheit;
        Celsius tempCelsius;
        Kelvin tempKelvin;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            bool validacion = double.TryParse(txtFahrenheit.Text, out double temperatura);

            if (validacion)
            {
                tempFahrenheit = temperatura;

                this.txtFahrenAFahren.Text = tempFahrenheit.GetTemperatura().ToString();
                this.txtFahrenACels.Text = ((Celsius)tempFahrenheit).GetTemperatura().ToString();
                this.txtFahrenAKelvin.Text = ((Kelvin)tempFahrenheit).GetTemperatura().ToString();
            }
            else
            {
                MessageBox.Show("Error, no ingreso un numero");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox && ((TextBox)control) != this.txtCelsius
                    && ((TextBox)control) != this.txtFahrenheit && ((TextBox)control) != this.txtKelvin)
                {
                    ((TextBox)control).Enabled = false;
                }
            }
        }

        private void btnCelsius_Click(object sender, EventArgs e)
        {
            bool validacion = double.TryParse(txtCelsius.Text, out double temperatura);

            if (validacion)
            {
                tempCelsius = temperatura;

                this.txtCelsAFahren.Text = ((Fahrenheit)tempCelsius).GetTemperatura().ToString();
                this.txtCelsACels.Text = tempCelsius.GetTemperatura().ToString();
                this.txtCelsAKel.Text = ((Kelvin)tempCelsius).GetTemperatura().ToString();
            }
            else
            {
                MessageBox.Show("Error, no ingreso un numero");
            }

        }

        private void btnKelvin_Click(object sender, EventArgs e)
        {
            bool validacion = double.TryParse(txtKelvin.Text, out double temperatura);

            if (validacion)
            {
                tempKelvin = temperatura;

                this.txtKelAFahren.Text = ((Fahrenheit)tempKelvin).GetTemperatura().ToString();
                this.txtKelACels.Text = ((Celsius)tempKelvin).GetTemperatura().ToString();
                this.txtKelAKel.Text = tempKelvin.GetTemperatura().ToString();
            }
            else
            {
                MessageBox.Show("Error, no ingreso un numero");
            }
        }
    }
}