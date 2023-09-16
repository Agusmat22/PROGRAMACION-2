using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Registro : Form
    {
        private Login login;
        private Usuario usuario;
        public Registro(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            //OCULTO EL LOGIN
            this.login.Hide();

            //Predetermino un radio buttonm
            this.rdbMasculino.Checked = true;

            //Cargo el enumerado
            this.cmbColor.DataSource = Enum.GetValues(typeof(Colores));
            //Cargo un color predeterminado
            this.cmbColor.TabIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = "";
            string correo = "";
            string password = "";
            DateTime fechaNacimiento = new DateTime();
            int codSeguridad = 0;
            Colores color = new Colores();
            string sexo = "";


            bool valorMayorEdad = false;
            bool valorEstudiar = false;
            bool valorTrabajar = false;

            //------- LOGICA DEL PRIMER GROUPBOX ---------//
            foreach (Control item in grbDatos.Controls)
            {
                //Pregunto si el textbox es nulo o vacio, lo casteo a item ya que es del tipo CONTROL
                if (item is TextBox && !string.IsNullOrEmpty(((TextBox)item).Text))
                {
                    //Cada vez que registre va resetar el color de fondo
                    ((TextBox)item).BackColor = Color.White;

                    if (((TextBox)item) == this.txbNombre)
                    {
                        nombre = ((TextBox)item).Text;
                    }
                    else if (((TextBox)item) == this.txbCorreo)
                    {
                        correo = ((TextBox)item).Text;
                    }
                    else if (((TextBox)item) == this.txbPassword)
                    {
                        password = ((TextBox)item).Text;
                    }
                    else if (((TextBox)item) == this.txbRePassword)
                    {
                        if (this.txbRePassword.Text != this.txbPassword.Text)
                        {
                            password = "";
                            ((TextBox)item).BackColor = Color.Salmon;
                            ((TextBox)item).Text = "";
                            ((TextBox)item).PlaceholderText = "Error, las contraseñas deben coincidir";
                        }
                        
                    }



                }
                else
                {
                    ((TextBox)item).BackColor = Color.Salmon;
                    ((TextBox)item).PlaceholderText = "Error, campo obligatorio";
                }



            }


            //------- LOGICA DEL GROUP BOX INFORMACION ----//

            foreach (Control item in grbInformacionExtra.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                {
                    if (((RadioButton)item) == this.rdbMasculino)
                    {
                        sexo = "masculino";
                    }
                    else if (((RadioButton)item) == this.rdbFemenino)
                    {
                        sexo = "femenino";
                    }
                    else
                    {
                        sexo = "no binario";
                    }
                }
                else if (item is CheckBox && ((CheckBox)item).Checked)
                {

                    if (((CheckBox)item) == this.chkEdad)
                    {
                        valorMayorEdad = true;
                    }
                    else if (((CheckBox)item) == this.chkEstudiar)
                    {
                        valorEstudiar = true;
                    }
                    else
                    {
                        valorMayorEdad = true;
                    }

                }
                else if (item is DateTimePicker)
                {
                    fechaNacimiento = ((DateTimePicker)item).Value;
                }
                else if (item is ComboBox)
                {
                    //Tengo que castear el ENUMERADO
                    color = (Colores)((ComboBox)item).SelectedItem;
                }


            }


            //-------INSTANCIO LA CLASE USUARIO--------//
            usuario = new Usuario(nombre, correo, password, fechaNacimiento, codSeguridad, color, sexo);
            usuario.SetTrabajar(valorTrabajar);
            usuario.SetEstudiar(valorEstudiar);
            usuario.SetMayorDeEdad(valorMayorEdad);

            if (password != "" && login.listaUsuarios + usuario  )
            {
                MessageBox.Show("Registro exitoso", "Registro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txbNombre.Text = "Agustin";
            this.txbCorreo.Text = "agustin@hotmail.com";
            this.txbPassword.Text = "123";
            this.txbRePassword.Text = "123";

            this.chkEdad.Checked = true;
        }
    }
}
