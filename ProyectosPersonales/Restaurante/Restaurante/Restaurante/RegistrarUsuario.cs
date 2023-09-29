using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Entidades.Empleado;

namespace Restaurante
{
    public partial class RegistrarUsuario : Form
    {
        private string usuario;
        private string password;
        private string nombre;
        private string apellido;
        private short dni;
        private ETurno turno;
        private EPuesto puesto;
        private Empleado empleado;

        public RegistrarUsuario()
        {
            InitializeComponent();
        }
        public Empleado Empleado
        {
            get { return empleado; }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            foreach (Control item in grpRegistroUsuario.Controls)
            {
                if (item is TextBox textBox)
                {
                    if (!string.IsNullOrEmpty(textBox.Text))
                    {
                        //valido el usuario
                        if (textBox == this.txtUsuario)
                        {
                            if (Validaciones.ValidarCaracteres(textBox.Text))
                            {
                                this.txtUsuario.BackColor = Color.White;
                                usuario = textBox.Text;
                            }
                            else
                            {
                                textBox.BackColor = Color.Salmon;
                                textBox.PlaceholderText = "Error, debe ser alfabetico";
                                textBox.Text = "";
                            }
                        }
                        else if (textBox == this.txtRePassword)
                        {
                            if (this.txtPassword.Text == this.txtRePassword.Text)
                            {
                                textBox.BackColor = Color.White;
                                this.txtPassword.BackColor = Color.White;
                                password = textBox.Text; // guardo la clave del textbox
                            }
                            else
                            {
                                textBox.BackColor = Color.Salmon;
                                textBox.PlaceholderText = "La contraseña no coincide";
                                textBox.Text = "";
                            }

                        }
                    }
                    else
                    {
                        textBox.PlaceholderText = "Completar casillero";
                        textBox.BackColor = Color.Salmon;
                    }
                }

            }

            foreach (Control item in grpRegistroInformacion.Controls)
            {
                if (item is TextBox textBox)
                {
                    if (!string.IsNullOrEmpty(textBox.Text))
                    {
                        if (textBox == this.txtNombre || textBox == this.txtApellido)
                        {
                            if (Validaciones.ValidarCaracteres(textBox.Text))
                            {
                                textBox.BackColor = Color.White;
                                nombre = textBox.Text;
                            }
                            else
                            {
                                textBox.BackColor = Color.Salmon;
                                textBox.PlaceholderText = "Error, debe ser alfabetico";
                                textBox.Text = "";
                            }
                        }
                        else //por descarte el ultimo txt que queda es el DNI
                        {
                            if (int.TryParse(textBox.Text, out int numero))
                            {
                                textBox.BackColor = Color.White;
                                dni = (short)numero;

                            }
                            else
                            {
                                textBox.BackColor = Color.Salmon;
                                textBox.PlaceholderText = "Error, debe ser numerico";
                                textBox.Text = "";
                            }
                        }


                    }
                    else
                    {
                        textBox.PlaceholderText = "Completar casillero";
                        textBox.BackColor = Color.Salmon;
                    }
                }
            }

            if (nombre != "" && usuario != "" && password != "" && apellido != "" && dni != 0)
            {
                empleado = new Empleado(usuario, password, nombre, apellido, dni, turno, puesto);
                MessageBox.Show("Empleado registrado correctamente");
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Erro al registrar el empleado");

            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {
            this.cmbPuesto.DataSource = Enum.GetValues(typeof(Empleado.EPuesto));
            this.cmbTurno.DataSource = Enum.GetValues(typeof(Empleado.ETurno));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtUsuario.Text = "Skilltrar";
            this.txtPassword.Text = "123";
            this.txtRePassword.Text = "123";
            this.txtNombre.Text = "Agustin";
            this.txtApellido.Text = "Garcia";
            this.txtDni.Text = "4317325";
            this.cmbPuesto.SelectedItem = EPuesto.mozo;
            this.cmbTurno.SelectedItem = ETurno.mañana;
        }
    }
}
