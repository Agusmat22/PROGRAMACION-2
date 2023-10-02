namespace ControladorDeVehiculos
{
    partial class Form1
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
            label2 = new Label();
            label3 = new Label();
            cmbTipoVehiculo = new ComboBox();
            cmbTipoMoto = new ComboBox();
            txtPatente = new TextBox();
            txtMarca = new TextBox();
            btnAgregar = new Button();
            cmbReparacion = new ComboBox();
            lblReparacion = new Label();
            btnRetirar = new Button();
            rchtListadoVehiculos = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 14);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipo Vehiculo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 14);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Patente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(432, 14);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Marca";
            // 
            // cmbTipoVehiculo
            // 
            cmbTipoVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoVehiculo.FormattingEnabled = true;
            cmbTipoVehiculo.Location = new Point(203, 32);
            cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            cmbTipoVehiculo.Size = new Size(121, 23);
            cmbTipoVehiculo.TabIndex = 3;
            cmbTipoVehiculo.SelectedIndexChanged += cmbTipoVehiculo_SelectedIndexChanged;
            // 
            // cmbTipoMoto
            // 
            cmbTipoMoto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoMoto.FormattingEnabled = true;
            cmbTipoMoto.Location = new Point(396, 61);
            cmbTipoMoto.Name = "cmbTipoMoto";
            cmbTipoMoto.Size = new Size(121, 23);
            cmbTipoMoto.TabIndex = 4;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(20, 32);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(121, 23);
            txtPatente.TabIndex = 5;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(398, 32);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(110, 23);
            txtMarca.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(28, 155);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(113, 35);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar Vehiculo";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cmbReparacion
            // 
            cmbReparacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReparacion.FormattingEnabled = true;
            cmbReparacion.Location = new Point(20, 89);
            cmbReparacion.Name = "cmbReparacion";
            cmbReparacion.Size = new Size(121, 23);
            cmbReparacion.TabIndex = 9;
            // 
            // lblReparacion
            // 
            lblReparacion.AutoSize = true;
            lblReparacion.Location = new Point(49, 71);
            lblReparacion.Name = "lblReparacion";
            lblReparacion.Size = new Size(66, 15);
            lblReparacion.TabIndex = 10;
            lblReparacion.Text = "Reparacion";
            // 
            // btnRetirar
            // 
            btnRetirar.Location = new Point(394, 155);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(113, 35);
            btnRetirar.TabIndex = 11;
            btnRetirar.Text = "Retirar";
            btnRetirar.UseVisualStyleBackColor = true;
            btnRetirar.Click += btnRetirar_Click;
            // 
            // rchtListadoVehiculos
            // 
            rchtListadoVehiculos.Location = new Point(20, 230);
            rchtListadoVehiculos.Name = "rchtListadoVehiculos";
            rchtListadoVehiculos.Size = new Size(487, 233);
            rchtListadoVehiculos.TabIndex = 12;
            rchtListadoVehiculos.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(529, 475);
            Controls.Add(rchtListadoVehiculos);
            Controls.Add(btnRetirar);
            Controls.Add(lblReparacion);
            Controls.Add(cmbReparacion);
            Controls.Add(btnAgregar);
            Controls.Add(txtMarca);
            Controls.Add(txtPatente);
            Controls.Add(cmbTipoMoto);
            Controls.Add(cmbTipoVehiculo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estacionamiento Agustin";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbTipoVehiculo;
        private ComboBox cmbTipoMoto;
        private TextBox txtPatente;
        private TextBox txtMarca;
        private Button btnAgregar;
        private ComboBox cmbReparacion;
        private Label lblReparacion;
        private Button btnRetirar;
        private RichTextBox rchtListadoVehiculos;
    }
}