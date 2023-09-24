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

            //LO HARCODEO
            operadorUno = new Numeracion(this.txbPrimerOperando.Text, ESistema.Decimal);
            operadorDos = new Numeracion(this.txbSegundoOperando.Text, ESistema.Decimal);

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
                        //ASIGNO EL SISTEMA QUE SE MOSTRARA DECIMAL
                        sistema = ESistema.Decimal;

                    }
                    else
                    {
                        //ASIGNO EL SISTEMA QUE SE MOSTRARA BINARIO
                        sistema = ESistema.Binario;

                    }
                    break;
                }
            }

            //MUESTRA EL RESULTADO
            SetResultado();

        }
            



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txbPrimerOperando.Clear();
            this.txbSegundoOperando.Clear();
            this.resultado = null;
            this.lblResultado.Visible = false;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Estas seguro ? ", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void txbPrimerOperando_TextChanged(object sender, EventArgs e)
        {
            //FIJARME QUE PUEDE HACER ACA, TODAVIA NO SE
        }

        //PERMITO QUE SOLO SE INGRESEN NUMEROS
        private void txbPrimerOperando_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                //SI NO ES NI UN NUMERO O UN CONTROL ESPECIA EJEMPLO BORRAR, NO PERMITO QUE ESCRIBA
                e.Handled = true;
            }
        }

        private void SetResultado()
        {
            if (sistema == ESistema.Binario)
            {
                this.lblResultado.Text = resultado.ConvertirA(ESistema.Binario);
            }
            else
            {
                this.lblResultado.Text = resultado.ValorNumerico;
            }

            this.lblResultado.Visible = true;

        }
    }
}