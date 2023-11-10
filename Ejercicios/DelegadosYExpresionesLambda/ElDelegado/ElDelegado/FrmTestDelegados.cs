using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElDelegado
{
    //creo el delegado
    public delegate void ActualizarNombreDelegate(string nombre);
    public partial class FrmTestDelegados : Form
    {
        

        private ActualizarNombreDelegate actualizarNombreDelegate;

        public FrmTestDelegados(ActualizarNombreDelegate actualizarNombreDelegate)
        {
            InitializeComponent();
            this.actualizarNombreDelegate = actualizarNombreDelegate;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //invoco el delegado
            this.actualizarNombreDelegate(txtNombre.Text);
        }
    }
}
