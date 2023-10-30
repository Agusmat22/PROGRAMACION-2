namespace Cartelera
{
    partial class FormCartelera
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            grpContenido = new GroupBox();
            label3 = new Label();
            rtxtMensaje = new RichTextBox();
            label2 = new Label();
            txtTitulo = new TextBox();
            btnColorTitulo = new Button();
            btnColorMensaje = new Button();
            btnColorFondoPanel = new Button();
            btnGuardarConfiguracion = new Button();
            btnImportarConfiguracion = new Button();
            btnEliminarConfiguracion = new Button();
            pnlCartelera = new Panel();
            lblMensaje = new Label();
            lblTitulo = new Label();
            colorDialog1 = new ColorDialog();
            grpContenido.SuspendLayout();
            pnlCartelera.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 25);
            label1.Name = "label1";
            label1.Size = new Size(282, 28);
            label1.TabIndex = 0;
            label1.Text = "Opciones de personalizacion";
            // 
            // grpContenido
            // 
            grpContenido.Controls.Add(label3);
            grpContenido.Controls.Add(rtxtMensaje);
            grpContenido.Controls.Add(label2);
            grpContenido.Controls.Add(txtTitulo);
            grpContenido.Location = new Point(12, 68);
            grpContenido.Name = "grpContenido";
            grpContenido.Size = new Size(327, 233);
            grpContenido.TabIndex = 1;
            grpContenido.TabStop = false;
            grpContenido.Text = "Contenido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 103);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 2;
            label3.Text = "Mensaje";
            // 
            // rtxtMensaje
            // 
            rtxtMensaje.Location = new Point(6, 121);
            rtxtMensaje.Name = "rtxtMensaje";
            rtxtMensaje.Size = new Size(315, 96);
            rtxtMensaje.TabIndex = 3;
            rtxtMensaje.Text = "";
            rtxtMensaje.TextChanged += rtxtMensaje_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 34);
            label2.Name = "label2";
            label2.Size = new Size(42, 17);
            label2.TabIndex = 2;
            label2.Text = "Titulo";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(6, 52);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(315, 23);
            txtTitulo.TabIndex = 0;
            txtTitulo.TextChanged += txtTitulo_TextChanged_1;
            // 
            // btnColorTitulo
            // 
            btnColorTitulo.Location = new Point(12, 322);
            btnColorTitulo.Name = "btnColorTitulo";
            btnColorTitulo.Size = new Size(155, 23);
            btnColorTitulo.TabIndex = 2;
            btnColorTitulo.Text = "Configurar color titulo";
            btnColorTitulo.UseVisualStyleBackColor = true;
            btnColorTitulo.Click += btnColorTitulo_Click;
            // 
            // btnColorMensaje
            // 
            btnColorMensaje.Location = new Point(184, 322);
            btnColorMensaje.Name = "btnColorMensaje";
            btnColorMensaje.Size = new Size(155, 23);
            btnColorMensaje.TabIndex = 3;
            btnColorMensaje.Text = "Configurar Color Mensaje";
            btnColorMensaje.UseVisualStyleBackColor = true;
            btnColorMensaje.Click += btnColorMensaje_Click;
            // 
            // btnColorFondoPanel
            // 
            btnColorFondoPanel.Location = new Point(12, 351);
            btnColorFondoPanel.Name = "btnColorFondoPanel";
            btnColorFondoPanel.Size = new Size(327, 23);
            btnColorFondoPanel.TabIndex = 4;
            btnColorFondoPanel.Text = "Elegir color de fondo del panel";
            btnColorFondoPanel.UseVisualStyleBackColor = true;
            btnColorFondoPanel.Click += btnColorFondoPanel_Click;
            // 
            // btnGuardarConfiguracion
            // 
            btnGuardarConfiguracion.BackColor = SystemColors.ActiveCaption;
            btnGuardarConfiguracion.FlatStyle = FlatStyle.Popup;
            btnGuardarConfiguracion.Location = new Point(12, 453);
            btnGuardarConfiguracion.Name = "btnGuardarConfiguracion";
            btnGuardarConfiguracion.Size = new Size(327, 23);
            btnGuardarConfiguracion.TabIndex = 5;
            btnGuardarConfiguracion.Text = "Guardar Configuracion";
            btnGuardarConfiguracion.UseVisualStyleBackColor = false;
            btnGuardarConfiguracion.Click += btnGuardarConfiguracion_Click;
            // 
            // btnImportarConfiguracion
            // 
            btnImportarConfiguracion.BackColor = SystemColors.ActiveBorder;
            btnImportarConfiguracion.FlatStyle = FlatStyle.Popup;
            btnImportarConfiguracion.Location = new Point(12, 490);
            btnImportarConfiguracion.Name = "btnImportarConfiguracion";
            btnImportarConfiguracion.Size = new Size(145, 23);
            btnImportarConfiguracion.TabIndex = 6;
            btnImportarConfiguracion.Text = "Importar configuracion";
            btnImportarConfiguracion.UseVisualStyleBackColor = false;
            btnImportarConfiguracion.Click += btnImportarConfiguracion_Click;
            // 
            // btnEliminarConfiguracion
            // 
            btnEliminarConfiguracion.BackColor = Color.IndianRed;
            btnEliminarConfiguracion.FlatStyle = FlatStyle.Popup;
            btnEliminarConfiguracion.Location = new Point(194, 490);
            btnEliminarConfiguracion.Name = "btnEliminarConfiguracion";
            btnEliminarConfiguracion.Size = new Size(145, 23);
            btnEliminarConfiguracion.TabIndex = 7;
            btnEliminarConfiguracion.Text = "Eliminar configuracion";
            btnEliminarConfiguracion.UseVisualStyleBackColor = false;
            btnEliminarConfiguracion.Click += btnEliminarConfiguracion_Click;
            // 
            // pnlCartelera
            // 
            pnlCartelera.Controls.Add(lblMensaje);
            pnlCartelera.Controls.Add(lblTitulo);
            pnlCartelera.Location = new Point(361, 12);
            pnlCartelera.Name = "pnlCartelera";
            pnlCartelera.Size = new Size(544, 501);
            pnlCartelera.TabIndex = 8;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensaje.Location = new Point(25, 108);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(104, 32);
            lblMensaje.TabIndex = 10;
            lblMensaje.Text = "Mensaje";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(15, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(124, 54);
            lblTitulo.TabIndex = 9;
            lblTitulo.Text = "Titulo";
            // 
            // FormCartelera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 525);
            Controls.Add(pnlCartelera);
            Controls.Add(btnEliminarConfiguracion);
            Controls.Add(btnImportarConfiguracion);
            Controls.Add(btnGuardarConfiguracion);
            Controls.Add(btnColorFondoPanel);
            Controls.Add(btnColorMensaje);
            Controls.Add(btnColorTitulo);
            Controls.Add(grpContenido);
            Controls.Add(label1);
            Name = "FormCartelera";
            Text = "Cartelera";
            Load += FormCartelera_Load;
            grpContenido.ResumeLayout(false);
            grpContenido.PerformLayout();
            pnlCartelera.ResumeLayout(false);
            pnlCartelera.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox grpContenido;
        private Label label3;
        private RichTextBox rtxtMensaje;
        private Label label2;
        private TextBox txtTitulo;
        private Button btnColorTitulo;
        private Button btnColorMensaje;
        private Button btnColorFondoPanel;
        private Button btnGuardarConfiguracion;
        private Button btnImportarConfiguracion;
        private Button btnEliminarConfiguracion;
        private Panel pnlCartelera;
        private Label lblMensaje;
        private Label lblTitulo;
        private ColorDialog colorDialog1;
    }
}