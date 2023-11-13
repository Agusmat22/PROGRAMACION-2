using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace PracticandoHilos
{
    public partial class Form2 : Form
    {
        private List<Persona> personas;
        private CancellationTokenSource cancellation;
        public Form2()
        {
            InitializeComponent();
            this.personas = new List<Persona>();
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            Persona per1 = new Persona("agustin", "garcia", 21);
            Persona per2 = new Persona("rodolfo", "garcia", 35);
            Persona per3 = new Persona("marcelo", "garcia", 40);
            Persona per4 = new Persona("irene", "garcia", 60);
            Persona per5 = new Persona("agustin", "garcia", 77);

            List<Persona> listaNueva = new List<Persona>();

            listaNueva.Add(per1);
            listaNueva.Add(per2);
            listaNueva.Add(per3);
            listaNueva.Add(per4);
            listaNueva.Add(per5);

            this.cancellation = new CancellationTokenSource();

            Task tarea = Task.Run(() => CargarPersonasListBox(listaNueva, cancellation));


        }

        private void GuardarPersona(Persona persona)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(() => GuardarPersona(persona));
            }
            else
            {
                this.personas.Add(persona);
                this.lstbPersonas.DataSource = null;
                this.lstbPersonas.DataSource = personas;
            }
        }

        private void CargarPersonasListBox(List<Persona> persona, CancellationTokenSource cancellation)
        {
            foreach (Persona item in persona)
            {
                if (!cancellation.IsCancellationRequested)
                {
                    this.GuardarPersona(item);


                }
                else
                {
                    break;
                }
                Thread.Sleep(1000);

            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.cancellation.Cancel();
        }
    }
}
