using Biblioteca;

namespace Login
{
    public partial class Login : Form
    {
        public List<Usuario> listaUsuarios;

        public Login()
        {
            InitializeComponent();
            listaUsuarios = new List<Usuario>();
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Le paso la clase LOGIN osea esta misma
            Registro registro = new Registro(this);

            //Muestro el registro, ya que el formulario login lo oculte dentro de registro
            registro.Show();




        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea cerrar la apliacion?", "CERRAR",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public List<Usuario> GetUsuarios()
        {
            return listaUsuarios;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string correo = this.txtCorreo.Text;
            string password = this.txtPass.Text;

            foreach(Usuario user in listaUsuarios)
            {
                if (user.ValidarCorreo(correo) && user.ValidarPassword(password))
                {
                    //Le paso la clase login
                    Contador contador = new Contador(this,user);

                    contador.Show();
                }
                

            }
            MessageBox.Show("ERROR, Ingrese un usuario nuevamente");
        }
    }
}