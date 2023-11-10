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
    public partial class FrmMostrar : Form
    {
        public FrmMostrar()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Modificara el label nombre con el argumento pasado por parametro    
        /// </summary>
        /// <param name="valor"></param>
        public void ActualizarNombre(string valor)
        {
            this.lblNombre.Text = valor;    
        }
    }
}
