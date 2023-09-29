using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();

            fila.Cells.Add(new DataGridViewTextBoxCell { Value = "5" });  // Columna 1
            fila.Cells.Add(new DataGridViewTextBoxCell { Value = "Mañana" });  // Columna 2
            fila.Cells.Add(new DataGridViewTextBoxCell { Value = "10" });  // Columna 3

            dgvMesas.Rows.Add(fila);


        }


    }
}
