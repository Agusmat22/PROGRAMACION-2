using Entidades;

namespace Restaurante
{
    public partial class Login : Form
    {
        private List<Empleado> empleados;

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Estas seguro de cerrar?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Al pasar el mouse cambia el fondo de un color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pcbCerrar_MouseHover(object sender, EventArgs e)
        {

            this.pcbCerrar.BackColor = Color.Aquamarine;

        }

        private void pcbMinimizar_MouseHover(object sender, EventArgs e)
        {
            this.pcbMinimizar.BackColor = Color.Aquamarine;

        }

        private void pcbMinimizar_Click(object sender, EventArgs e)
        {
            //Propiedad para minizar el formulario
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Al pasar el mouse vuelve a color el color inicial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pcbCerrar_MouseLeave(object sender, EventArgs e)
        {
            this.pcbCerrar.BackColor = Color.Transparent;

        }

        private void pcbMinimizar_MouseLeave(object sender, EventArgs e)
        {
            this.pcbMinimizar.BackColor = Color.Transparent;
        }

        private void linkLabel1_MouseHover(object sender, EventArgs e)
        {
            this.linklblRegistrarse.LinkColor = Color.Aqua;
        }

        private void linklblRegistrarse_MouseLeave(object sender, EventArgs e)
        {
            this.linklblRegistrarse.LinkColor = Color.PaleTurquoise;
        }

        private void linklblRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrarUsuario registrarUsuario = new RegistrarUsuario();

            DialogResult resultado = registrarUsuario.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                empleados.Add(registrarUsuario.Empleado);
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            empleados = new List<Empleado>();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (empleados.Count > 0)
            {
                foreach (Empleado item in empleados)
                {
                    if (item.ValidarCuenta(this.txtUsuario.Text,this.txtUsuario.Text))
                    {
                        MessageBox.Show("Inicio de sesion correctamente");
                    }
                }


            }
        }
    }
}