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
                ActivarCotzTxbox();
            }
            else
            {
                BloquearCotzTxbox();
            }
        }


        //BOTON MONEDA EURO
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

                txbEuroE.Text = euro.GetCantidad().ToString();

                dolar = (Dolar)euro;
                txbEuroD.Text = dolar.GetCantidad().ToString();

                peso = (Peso)euro;
                txbEuroP.Text = peso.GetCantidad().ToString();
            }

        }


        /// <summary>
        /// Bloquea la modificacion del la cotizacion
        /// </summary>
        private void BloquearCotzTxbox()
        {
            txbCotzEuro.Enabled = false;
            txbCotzDolar.Enabled = false;
            txbCotzPeso.Enabled = false;
        }

        /// <summary>
        /// Permite modificar la cotizacion de la moneda
        /// </summary>
        private void ActivarCotzTxbox()
        {
            txbCotzEuro.Enabled = true;
            txbCotzPeso.Enabled = true;
        }

        //HACER UN METODO VOID QUE BLOQUEE TODOS LOS TXTBOX QUE REALIZAN LA CONVERSION, DE ESE MODO NO ES NECESARIO
        //eL METODO BLOQUEAR EN EL LOAD, SOLO HAGO UN METODO Y BLOQUEO TODO.


    }
}