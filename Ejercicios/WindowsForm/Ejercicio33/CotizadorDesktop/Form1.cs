using Billetes;

namespace CotizadorDesktop
{
    public partial class Form1 : Form
    {
        private Dolar dolar;
        private Euro euro;
        private Peso peso;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //El metodo retorna un numero, lo casteo a string ya que los txb reciben string
            txbCotzEuro.Text = Euro.GetCotizacion().ToString();
            txbCotzDolar.Text = Dolar.GetCotizacion().ToString();
            txbCotzPeso.Text = Peso.GetCotizacion().ToString();

            //Desactivo para que se pueda modificar
            BloquearCotzTxbox();
        }

        private void btnBloquear_Click(object sender, EventArgs e)
        {
            if (txbCotzDolar.Enabled == false && txbCotzEuro.Enabled == false
                && txbCotzPeso.Enabled == false)
            {
                this.btnBloquear.ImageIndex = 1;
                ActivarCotzTxbox();

            }
            else
            {
                this.btnBloquear.ImageIndex = 0;

                //CAMBIO EL VALOR DE LA COTIZACION

                double.TryParse(this.txbCotzEuro.Text, out double cotzEuro);

                double.TryParse(this.txbCotzPeso.Text, out double cotzPeso);
                if (cotzEuro != Euro.GetCotizacion() && cotzEuro > 0)
                {
                    Euro.SetCotizacion(cotzEuro);
                }
                else if (cotzPeso != Peso.GetCotizacion() && cotzPeso > 0)
                {
                    Peso.SetCotizacion(cotzPeso);
                }

                //Limpio todos los textBox
                LimpiarTxboxConversion();
                //Bloqueo la modificacion de la cotizacion
                BloquearCotzTxbox();

            }
        }


        //BOTON CONVERTIR EURO
        private void btnEuro_Click(object sender, EventArgs e)
        {
            if (!(double.TryParse(this.txbEuroIngresado.Text, out double dinero)))
            {
                MessageBox.Show("ERROR, debe ingresar un numero", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                euro = dinero;

                txbEuroE.Text = euro;

                txbEuroD.Text = (Dolar)euro;

                txbEuroP.Text = (Peso)euro;
            }

        }

        //BOTON CONVERTIR DOLAR
        private void btnDolar_Click(object sender, EventArgs e)
        {
            if (!(double.TryParse(this.txbDolarIngresado.Text, out double dinero)))
            {
                MessageBox.Show("ERROR, debe ingresar un numero", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                dolar = dinero;

                txbDolarE.Text = (Euro)dolar;

                txbDolarD.Text = dolar;

                txbDolarP.Text = (Peso)dolar;
            }

        }

        //BOTON CONVERTIR PESO
        private void btnPeso_Click(object sender, EventArgs e)
        {
            if (!(double.TryParse(this.txbPesoIngresado.Text, out double dinero)))
            {
                MessageBox.Show("ERROR, debe ingresar un numero", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                peso = dinero;

                txbPesoE.Text = (Euro)peso;

                txbPesoD.Text = (Dolar)peso;

                txbPesoP.Text = peso;
            }

        }


        /// <summary>
        /// Bloquea la modificacion del la cotizacion
        /// </summary>
        private void BloquearCotzTxbox()
        {

            //Recorro los controles
            foreach (Control item in this.Controls)
            {
                //Pregunto si es del tipo TextBox y lo asigno a una variable
                if (item is TextBox textBox && textBox != this.txbEuroIngresado && textBox != this.txbDolarIngresado
                    && textBox != this.txbPesoIngresado)
                {
                    //Bloqueo el permiso de modificar
                    textBox.Enabled = false;

                }

            }


        }

        /// <summary>
        /// Permite modificar la cotizacion de la moneda
        /// </summary>
        private void ActivarCotzTxbox()
        {
            txbCotzEuro.Enabled = true;
            txbCotzPeso.Enabled = true;
        }


        private void LimpiarTxboxConversion()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox textbox && textbox != this.txbCotzDolar
                    && textbox != this.txbCotzEuro && textbox != this.txbCotzPeso)
                {
                    textbox.Text = "";
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea cerrar la app?", "Cerrar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

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