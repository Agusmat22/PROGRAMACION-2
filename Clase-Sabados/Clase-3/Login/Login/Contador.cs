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
    public partial class Contador : Form
    {
        private Login login;
        private Usuario usuario;
        public Contador(Login login, Usuario user)
        {
            InitializeComponent();
            this.login = login;
            this.usuario = user;
        }

        private void Contador_Load(object sender, EventArgs e)
        {
            this.login.Hide();

            listBoxRanking.DataSource = login.listaUsuarios;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Aunque este en otro formulario, el form que cerrara completamente la app
            //Sera el login ya que contiene lo principal
            login.Close();
        }

        private void Contador_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnContador_Click(object sender, EventArgs e)
        {
            this.usuario.contador++;

            lblContadorNumero.Text = usuario.contador.ToString();
        }




        //EL EVENTO FORMAT, Permite formatear los objetos contenidos dentro del listBox
        private void listBoxRanking_Format(object sender, ListControlConvertEventArgs e)
        { 
            if (e.ListItem is Usuario usuario)
            {
                e.Value = usuario.MostrarDatos();
            }
           
        }

        private void lbkActualizar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login.listaUsuarios.Sort(FuncionCriterio);

            //PONIENDO NULL VACIO LA LISTA
            listBoxRanking.DataSource = null;
            //CARGO NUEVAMENTE LA LISTA DE ESE MODO SE REFRESCA

            listBoxRanking.DataSource = login.listaUsuarios;

        }


        private  int FuncionCriterio(Usuario a, Usuario b)
        {
            return b.contador.CompareTo(a.contador);
        }


    }
}
