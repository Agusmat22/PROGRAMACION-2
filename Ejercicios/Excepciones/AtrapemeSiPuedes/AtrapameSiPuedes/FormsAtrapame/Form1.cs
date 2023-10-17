using Entidades;
using Entidades.Excepciones;

namespace FormsAtrapame
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtKilometros.Text != string.Empty && txtLitros.Text != string.Empty)
                {
                    //Aca es lo mismo poner o no el TRY total si hay un error al castear
                    //va lanzar igualmente la excepcion
                    try
                    {
                        int kilometros = int.Parse(txtKilometros.Text);
                        int litros = int.Parse(txtLitros.Text);

                        double resultado = Calculador.Calcular(kilometros, litros);

                        richTextBox1.Text = $"El consumo de gasolina es: {resultado}";

                    }
                    catch(FormatException)
                    {
                        throw;
                    }
                }
                else
                {
                    throw new ParametrosVaciosException("Campos vacios");
                }


            }
            catch(ParametrosVaciosException ex)
            { 
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK);
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);

            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("La cantidad de litros debe ser mayor a 0","Error",MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                while(ex.InnerException != null)
                {
                    MessageBox.Show(ex.Message);
                    ex = ex.InnerException;
                }
            }

        }

        

    }
}