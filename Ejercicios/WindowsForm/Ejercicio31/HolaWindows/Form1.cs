namespace HolaWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre = this.txbNombre.Text;
            string apellido = this.txbApellido.Text;

            if (!(string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(apellido)))
            {
                DialogResult resultado = MessageBox.Show("Datos correctamente, desea visualizar el mensaje?","Informacion",
                    MessageBoxButtons.YesNo , MessageBoxIcon.Information);

                if (resultado == DialogResult.Yes)
                {
                    MessageBox.Show($"Hola {nombre}, muy lindo apellido es {apellido}");
                }
            }
            else
            {
                MessageBox.Show("Error","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}