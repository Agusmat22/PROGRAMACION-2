using Centralita;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmMostrar : Form
    {
        private Centralitaa centralita;
        private string tipoGanancia;

        public FrmMostrar(Centralitaa centralita, string tipoGanancia)
        {
            InitializeComponent();
            this.centralita = centralita;
            this.tipoGanancia = tipoGanancia;
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            if (tipoGanancia == "total")
            {
                this.rtbFacturacion.Text = $"GANANCIA TOTAL \nPESOS: ${centralita.GananciasPorTotal}";
            }
            else if (tipoGanancia == "local")
            {
                this.rtbFacturacion.Text = $"GANANCIA LOCAL\nPESOS: ${centralita.GananciasPorLocal}";

            }
            else if (tipoGanancia == "provincial")
            {
                this.rtbFacturacion.Text = $"GANANCIA PROVINCIAL\nPESOS: ${centralita.GananciasPorProvincial}";
            }
        }
    }
}
