using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticandoHilos
{
    public partial class FormMostrar : Form
    {
        //private ActualizarListaPacientes actualizarPaciente;
        List<string> listaPacientes;
        CancellationTokenSource cancellation;

        public FormMostrar(List<string> listaPacientes)
        {
            InitializeComponent();
            this.listaPacientes = listaPacientes;
        }

        private void FormMostrar_Load(object sender, EventArgs e)
        {
            //this.actualizarPaciente(this.lstbPacientes);

            cancellation = new CancellationTokenSource();

            Task tarea = Task.Run(() => this.RefresarListaConstante(cancellation),cancellation.Token);


        }

        private void RefresarListaConstante(CancellationTokenSource cancelar)
        {
            while(true)
            {
                if (!cancelar.IsCancellationRequested)
                {
                    this.ActualizarListBox();
                }
                else
                {
                    break;
                }
                Thread.Sleep(1000);
            }

            
            
            
        }

        private void ActualizarListBox()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(ActualizarListBox);
            }
            else
            {
                this.lstbPacientes.DataSource = null;
                this.lstbPacientes.DataSource = this.listaPacientes;
            }
            
        }
    }
}
