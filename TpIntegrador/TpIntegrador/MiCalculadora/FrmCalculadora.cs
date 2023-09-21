using Entidades;

namespace MiCalculadora
{
    /*PREGUNTAR
     -La calculadora realiza calculos con numeros binarios o solo decimal?

     -Cuando nos pide inicializar el componente porque tiene la opcion de recibir un binario
    si no tenemos forma de identificarlo ya que con el metodo es binario no seria suficiente.?

     -El sistema es solo para luego mostrar el resultado o es para seleccionar el tipo de numero
    que va ingresar?

    -Y se puede hacer algun metodo extra del que esta en el tp o tiene que ser todo tal cual las consignas.

     
     */
    public partial class FrmCalculadora : Form
    {
        Numeracion operadorUno;
        Numeracion operadorDos;
        Numeracion resultado;
        Operacion calculadora;
        ESistema sistema;


        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            List<string> operadores = new List<string>() { "+", "-", "*", "/" };

            //Le agrego la lista de operadores
            this.cmbTipoOperacion.DataSource = operadores;
            //con selectIndex le indico en que posicion debe empezar
            this.cmbTipoOperacion.SelectedIndex = 0;

            //Selecciono de forma predeterminada un radioButton
            this.rdbDecimal.Checked = true;

            //OCULTO EL RESULTADO
            this.lblResultado.Visible = false;

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {

            if (int.TryParse(this.txbPrimerOperando.Text, out int primerOperado) &&
                int.TryParse(this.txbSegundoOperando.Text, out int segundoOperando))
            {

                //LO HARCODEO
                operadorUno = new Numeracion(primerOperado, ESistema.Decimal);
                operadorDos = new Numeracion(segundoOperando, ESistema.Decimal);

                calculadora = new Operacion(operadorUno, operadorDos);

                //Resultado es del tipo numeracion
                resultado = calculadora.Operar(this.cmbTipoOperacion.Text[0]);

                //AL INDICAR LA POSICION DE UN STIRNG LO ESTARIA LEYENDO COMO UN CHAR
                this.lblResultado.Text = resultado.ValorNumerico;


                //recorro el group box para obtener que button fue seleccionado
                foreach (Control item in this.grbTipoSistema.Controls)
                {
                    if (item is RadioButton radioButton && radioButton.Checked)
                    {
                        if (radioButton == this.rdbDecimal)
                        {
                            //Muestro el resultado en decimal
                            this.lblResultado.Text = resultado.ValorNumerico;

                        }
                        else
                        {
                            //Muestro el resultado en binario
                            this.lblResultado.Text = resultado.ConvertirA(ESistema.Binario);

                        }

                        this.lblResultado.Visible = true;
                        break;
                    }
                }
            }
            else
            {
                this.lblResultado.Text = "Error";
                this.lblResultado.Visible = true;
            }



        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txbPrimerOperando.Clear();
            this.txbSegundoOperando.Clear();

            this.lblResultado.Visible = false;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Estas seguro ? ","Cerrar",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel =true;
            }
        }
    }
}