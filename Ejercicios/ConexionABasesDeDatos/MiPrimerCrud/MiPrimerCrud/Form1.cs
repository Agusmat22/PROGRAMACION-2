using Entidades;
using Entidades.BasesDeDatos;
namespace MiPrimerCrud
{
    public partial class Form1 : Form
    {
        private Persona persona;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            this.lstbPersonas.DataSource = null;
            this.lstbPersonas.DataSource = ADOpersonas.Leer();
        }

        private void lstbPersonas_DoubleClick(object sender, EventArgs e)
        {
            this.persona = (Persona)lstbPersonas.SelectedItem;

            this.txtNombre.Text = persona.Nombre;
            this.txtApellido.Text = persona.Apellido;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text != string.Empty && this.txtApellido.Text != string.Empty)
            {
                this.persona.Nombre = this.txtNombre.Text;
                this.persona.Apellido = this.txtApellido.Text;
                if(ADOpersonas.Modificar(this.persona))
                {
                    MessageBox.Show("Se modifico correctamente");

                }
                else
                {
                    MessageBox.Show("Error al modificar");

                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text != string.Empty && this.txtApellido.Text != string.Empty)
            {
                if(ADOpersonas.Guardar(new Persona(this.txtNombre.Text, txtApellido.Text)))
                {
                    MessageBox.Show("Se guardo correctamente");
                }
                else
                {
                    MessageBox.Show("Error al guardar");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(ADOpersonas.Borrar(this.persona.Id))
            {
                MessageBox.Show("Se elimino correctamente");
            }
            else
            {
                MessageBox.Show("Error al eliminar");

            }
        }
    }
}