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
            //recorro el group box para guardar el radioButtons seleccionado
            foreach (Control item in this.grbTipoSistema.Controls)
            {
                if (item is RadioButton radioButton && radioButton.Checked)
                {
                    if (radioButton == this.rdbDecimal)
                    {
                        //Asigno el sistema seleccionado para mostrar resultado
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

            calculadora = new Operacion(operadorUno, operadorDos);

            resultado = calculadora.Operar(this.cmbTipoOperacion.Text[0]);

            //AL INDICAR LA POSICION DE UN STIRNG LO ESTARIA LEYENDO COMO UN CHAR
            this.lblResultado.Text = resultado.GetValorNumerico();
            this.lblResultado.Visible = true;



        }

    }
}