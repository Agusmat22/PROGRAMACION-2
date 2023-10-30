using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaListaDelSuper
{
    public partial class FormAltModificacion : Form
    {
        private string nombreTxt; //--> el nombre que tenga aparecera en el txt
        private string textoBtn; //--> el nombre en el btn confirmar
        private string tituloForm; //--> nombre del titulo de la app
        public FormAltModificacion(string textoBtn, string tituloForm, string nombreTxt)
        {
            InitializeComponent();
            this.nombreTxt = nombreTxt;
            this.tituloForm = tituloForm;
            this.textoBtn = textoBtn;
        }

        public string Objeto
        {
            get { return this.txtObjeto.Text; }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (this.txtObjeto.Text != string.Empty)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("El campo se encuentra vacio, ingrese un producto");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //pregunto si se presiono escape --> 27 en la tabla ascii es escape
            if (e.KeyChar == (char)27)
            {
                this.btnCancelar_Click(sender, e);
            }
        }

        private void FormAltModificacion_Load(object sender, EventArgs e)
        {
            this.Text = tituloForm;
            this.btnConfirmar.Text = textoBtn;
            this.txtObjeto.Text = nombreTxt;
        }
    }
}
