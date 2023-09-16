using Entidades;

namespace MiCalculadora
{

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

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            //recorro el group box para guardar el radioButtons seleccionado
            foreach (Control item in this.grbTipoSistema.Controls)
            {
                if (item is RadioButton radioButton && radioButton.Checked)
                {
                    if (radioButton == this.rdbDecimal)
                    {
                        //Asigno el sistema seleccionado
                        this.sistema = ESistema.Decimal;
                    }
                    else
                    {
                        this.sistema = ESistema.Binario;
                    }

                    break;
                }
            }

            operadorUno = new Numeracion(this.txbPrimerOperando.Text, sistema);
            operadorDos = new Numeracion(this.txbSegundoOperando.Text, sistema);

            operadorUno += operadorDos;

            MessageBox.Show("El resultado es: " + operadorUno.GetValorNumerico());



        }

    }
}