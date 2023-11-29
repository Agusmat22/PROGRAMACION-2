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
    public partial class FormAgregar : Form
    {
        private AgregarPaciente agregarPaciente;
        public FormAgregar(AgregarPaciente agregarPaciente)
        {
            InitializeComponent();
            this.agregarPaciente = agregarPaciente;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.agregarPaciente(this.txtPaciente.Text);
        }

        
    }
}
