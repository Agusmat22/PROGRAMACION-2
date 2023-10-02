using Centralita;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmLlamador : Form
    {
        private Centralitaa centralita;
        private Provincial llamadaProvincial;
        private Local llamadaLocal;
        private Provincial.Franja franjaHoraria;

        public FrmLlamador(Centralitaa centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }

        //PROPERTY
        /// <summary>
        /// Retornara de nuevo la centralita para que el menu pueda obtenerla de nuevo con los cambios realizados
        /// </summary>
        public Centralitaa Centralita
        {
            get { return centralita; }
        }

        /// <summary>
        /// Se le aplicara a cada boton recorriendolos con un foreach y cuando se presione
        /// cualquier boton agregara ese valor al textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonNumero_Click(object sender, EventArgs e)
        {
            Button botonPresionado = sender as Button;

            if (botonPresionado != null)
            {
                string numero = botonPresionado.Tag.ToString();
                txtDestino.Text += numero;
            }
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            //ASIGNO LOS ENUMERADOS AL COMBOBOX
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));

            //ASIGNO LOS VALORES A CADA BOTON
            this.btnCero.Tag = '0';
            this.btnUno.Tag = '1';
            this.btnDos.Tag = '2';
            this.btnTres.Tag = '3';
            this.btnCuatro.Tag = '4';
            this.btnCinco.Tag = '5';
            this.btnSeis.Tag = '6';
            this.btnSiete.Tag = '7';
            this.btnOcho.Tag = '8';
            this.btnNueve.Tag = '9';
            this.btnAsterisco.Tag = '*';
            this.btnNumeral.Tag = '#';

            //Recorro el groupBox y le asigno el metodo a cada boton
            foreach (Control item in grbPanel.Controls)
            {
                if (item is Button boton)
                {
                    boton.Click += new EventHandler(BotonNumero_Click);

                }
            }


        }



        private void txtDestino_TextChanged(object sender, EventArgs e)
        {
            Random random = new Random();

            // #significa que es una llamada provincial

            string texto = txtDestino.Text;

            if (Regex.IsMatch(texto, "^#"))
            {
                if (this.cmbFranja.Enabled == false)
                {
                    this.cmbFranja.Enabled = true; //bloqueo el comboBox ya que es local
                }

                //Instancio la llamada provincial
                llamadaProvincial = new Provincial(txtOrigen.Text, franjaHoraria, random.Next(1, 50), texto);
            }
            else
            {//si no tiene # es una llamada local


                float costoLlamadaRandom = (float)(random.NextDouble() * (5.6 - 0.5) + 0.5);

                llamadaLocal = new Local(txtOrigen.Text, random.Next(1, 50), texto, costoLlamadaRandom);
            }
        }

        /// <summary>
        /// Cada vez que seleccione una franja la almacenara
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbFranja_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(cmbFranja.SelectedValue.ToString(), out franjaHoraria);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //LIMPIO LA PARTE VISUAL
            this.txtDestino.Clear();
            this.txtOrigen.Clear();
            this.cmbFranja.SelectedIndex = 0;

            if (cmbFranja.Enabled == true)
            {
                this.cmbFranja.Enabled = false;
            }
            //LIMPIO LAS LLAMADAS
            llamadaLocal = null;
            llamadaProvincial = null;


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            if (llamadaLocal is not null && centralita + llamadaLocal || 
                        llamadaProvincial is not null && centralita + llamadaProvincial )
            {
                this.txtDestino.Text = "En llamada";
            }
            else
            {
                this.txtDestino.Text = "Error, no se pudo llamar";

            }
        }
    }
}
