using Entidades;

namespace Registrate
{

    public partial class FormRegistro : Form
    {
        private Persona persona;

        public FormRegistro()
        {
            InitializeComponent();
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {

            this.listBoxPaises.DataSource = new string[] { "Argentina", "Brasil", "Bolivia" };


        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string generoSeleccionado = "";
            string nacionalidad = "";
            string[] cursos = new string[3];
            int indice = 0;

            if (!(string.IsNullOrEmpty(this.txbNombre.Text) || string.IsNullOrEmpty(this.txbDireccion.Text)))
            {
                //Recorro los controles de groupBox genero para visualizar cual se selecciono
                foreach (Control item in this.grpGenero.Controls)
                {
                    //Pregunto si el elemento es del tipo radioButton
                    if (item is RadioButton)
                    {
                        RadioButton rdb = (RadioButton)item;

                        //Valido si fue seleccionado el seleccionado el radio button
                        if (rdb.Checked)
                        {
                            generoSeleccionado = item.Text;
                        }
                    }

                }      

                foreach (Control pais in this.grpCursos.Controls)
                {

                    if (pais is CheckBox)
                    {
                        CheckBox chckBox = (CheckBox)pais;

                        if (chckBox.Checked)
                        {
                            cursos[indice] = chckBox.Text;
                        }
                    }
                    indice++;
                }



                persona = new Persona(this.txbNombre.Text, this.txbDireccion.Text, (int)numericUpDownEdad.Value,
                        generoSeleccionado, cursos, this.listBoxPaises.SelectedItem.ToString());

                DialogResult resultado = MessageBox.Show("Desea mostrar la persona?", "Aviso", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultado == DialogResult.Yes)
                {
                    MessageBox.Show(persona.Mostrar());
                }
                
            }
            else
            {
                MessageBox.Show("Campos vacio, complete nuevamente");
            }
        }
    }
}