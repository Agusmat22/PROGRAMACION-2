namespace Login
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txbNombre = new TextBox();
            label1 = new Label();
            grbDatos = new GroupBox();
            txbRePassword = new TextBox();
            txbPassword = new TextBox();
            txbCorreo = new TextBox();
            grbInformacionExtra = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            grpVarios = new GroupBox();
            chkTrabajar = new CheckBox();
            chkEstudiar = new CheckBox();
            chkEdad = new CheckBox();
            grpGenero = new GroupBox();
            rdbNoBinario = new RadioButton();
            rdbFemenino = new RadioButton();
            rdbMasculino = new RadioButton();
            label3 = new Label();
            cmbColor = new ComboBox();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            btnSalir = new Button();
            button1 = new Button();
            button2 = new Button();
            btnTest = new Button();
            grbDatos.SuspendLayout();
            grbInformacionExtra.SuspendLayout();
            grpVarios.SuspendLayout();
            grpGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // txbNombre
            // 
            txbNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txbNombre.Location = new Point(18, 22);
            txbNombre.Name = "txbNombre";
            txbNombre.PlaceholderText = "Nombre";
            txbNombre.Size = new Size(344, 27);
            txbNombre.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(180, 47);
            label1.TabIndex = 8;
            label1.Text = "REGISTRO";
            // 
            // grbDatos
            // 
            grbDatos.Controls.Add(txbRePassword);
            grbDatos.Controls.Add(txbPassword);
            grbDatos.Controls.Add(txbCorreo);
            grbDatos.Controls.Add(txbNombre);
            grbDatos.Location = new Point(25, 71);
            grbDatos.Name = "grbDatos";
            grbDatos.Size = new Size(380, 226);
            grbDatos.TabIndex = 9;
            grbDatos.TabStop = false;
            grbDatos.Text = "Datos";
            // 
            // txbRePassword
            // 
            txbRePassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txbRePassword.Location = new Point(18, 172);
            txbRePassword.Name = "txbRePassword";
            txbRePassword.PasswordChar = '*';
            txbRePassword.PlaceholderText = "ReContraseña";
            txbRePassword.Size = new Size(344, 27);
            txbRePassword.TabIndex = 11;
            // 
            // txbPassword
            // 
            txbPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txbPassword.Location = new Point(18, 121);
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '*';
            txbPassword.PlaceholderText = "Contraseña";
            txbPassword.Size = new Size(344, 27);
            txbPassword.TabIndex = 10;
            // 
            // txbCorreo
            // 
            txbCorreo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txbCorreo.Location = new Point(18, 73);
            txbCorreo.Name = "txbCorreo";
            txbCorreo.PlaceholderText = "Correo";
            txbCorreo.Size = new Size(344, 27);
            txbCorreo.TabIndex = 9;
            // 
            // grbInformacionExtra
            // 
            grbInformacionExtra.Controls.Add(dateTimePicker1);
            grbInformacionExtra.Controls.Add(label4);
            grbInformacionExtra.Controls.Add(grpVarios);
            grbInformacionExtra.Controls.Add(grpGenero);
            grbInformacionExtra.Controls.Add(label3);
            grbInformacionExtra.Controls.Add(cmbColor);
            grbInformacionExtra.Controls.Add(label2);
            grbInformacionExtra.Controls.Add(numericUpDown1);
            grbInformacionExtra.Location = new Point(25, 318);
            grbInformacionExtra.Name = "grbInformacionExtra";
            grbInformacionExtra.Size = new Size(380, 297);
            grbInformacionExtra.TabIndex = 10;
            grbInformacionExtra.TabStop = false;
            grbInformacionExtra.Text = "Informacion Extra";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Cursor = Cursors.Hand;
            dateTimePicker1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(21, 244);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(341, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 226);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 6;
            label4.Text = "Fecha de Nacimiento";
            // 
            // grpVarios
            // 
            grpVarios.Controls.Add(chkTrabajar);
            grpVarios.Controls.Add(chkEstudiar);
            grpVarios.Controls.Add(chkEdad);
            grpVarios.Location = new Point(177, 103);
            grpVarios.Name = "grpVarios";
            grpVarios.Size = new Size(185, 107);
            grpVarios.TabIndex = 5;
            grpVarios.TabStop = false;
            grpVarios.Text = "Varios";
            // 
            // chkTrabajar
            // 
            chkTrabajar.AutoSize = true;
            chkTrabajar.Cursor = Cursors.Hand;
            chkTrabajar.Location = new Point(16, 76);
            chkTrabajar.Name = "chkTrabajar";
            chkTrabajar.Size = new Size(63, 19);
            chkTrabajar.TabIndex = 2;
            chkTrabajar.Text = "Trabaja";
            chkTrabajar.UseVisualStyleBackColor = true;
            // 
            // chkEstudiar
            // 
            chkEstudiar.AutoSize = true;
            chkEstudiar.Cursor = Cursors.Hand;
            chkEstudiar.Location = new Point(16, 50);
            chkEstudiar.Name = "chkEstudiar";
            chkEstudiar.Size = new Size(64, 19);
            chkEstudiar.TabIndex = 1;
            chkEstudiar.Text = "Estudia";
            chkEstudiar.UseVisualStyleBackColor = true;
            // 
            // chkEdad
            // 
            chkEdad.AutoSize = true;
            chkEdad.Cursor = Cursors.Hand;
            chkEdad.Location = new Point(16, 22);
            chkEdad.Name = "chkEdad";
            chkEdad.Size = new Size(105, 19);
            chkEdad.TabIndex = 0;
            chkEdad.Text = "Mayor de Edad";
            chkEdad.UseVisualStyleBackColor = true;
            // 
            // grpGenero
            // 
            grpGenero.Controls.Add(rdbNoBinario);
            grpGenero.Controls.Add(rdbFemenino);
            grpGenero.Controls.Add(rdbMasculino);
            grpGenero.Location = new Point(21, 103);
            grpGenero.Name = "grpGenero";
            grpGenero.Size = new Size(125, 107);
            grpGenero.TabIndex = 4;
            grpGenero.TabStop = false;
            grpGenero.Text = "Sexo";
            // 
            // rdbNoBinario
            // 
            rdbNoBinario.AutoSize = true;
            rdbNoBinario.Cursor = Cursors.Hand;
            rdbNoBinario.Location = new Point(17, 75);
            rdbNoBinario.Name = "rdbNoBinario";
            rdbNoBinario.Size = new Size(81, 19);
            rdbNoBinario.TabIndex = 2;
            rdbNoBinario.TabStop = true;
            rdbNoBinario.Text = "No Binario";
            rdbNoBinario.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            rdbFemenino.AutoSize = true;
            rdbFemenino.Cursor = Cursors.Hand;
            rdbFemenino.Location = new Point(17, 50);
            rdbFemenino.Name = "rdbFemenino";
            rdbFemenino.Size = new Size(78, 19);
            rdbFemenino.TabIndex = 1;
            rdbFemenino.TabStop = true;
            rdbFemenino.Text = "Femenino";
            rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.Cursor = Cursors.Hand;
            rdbMasculino.Location = new Point(17, 25);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(80, 19);
            rdbMasculino.TabIndex = 0;
            rdbMasculino.TabStop = true;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(194, 27);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 3;
            label3.Text = "Color Favorito";
            // 
            // cmbColor
            // 
            cmbColor.Cursor = Cursors.Hand;
            cmbColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbColor.FormattingEnabled = true;
            cmbColor.Location = new Point(177, 45);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(185, 23);
            cmbColor.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 27);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Cod. Seg.";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Cursor = Cursors.IBeam;
            numericUpDown1.Location = new Point(21, 45);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(125, 23);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.Control;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(251, 694);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(154, 49);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(25, 621);
            button1.Name = "button1";
            button1.Size = new Size(380, 50);
            button1.TabIndex = 8;
            button1.Text = "INGRESAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(25, 694);
            button2.Name = "button2";
            button2.Size = new Size(154, 49);
            button2.TabIndex = 11;
            button2.Text = "HARDCODEAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnTest
            // 
            btnTest.BackColor = SystemColors.Control;
            btnTest.FlatStyle = FlatStyle.Flat;
            btnTest.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnTest.Location = new Point(138, 749);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(154, 49);
            btnTest.TabIndex = 12;
            btnTest.Text = "TEST";
            btnTest.UseVisualStyleBackColor = false;
            btnTest.Click += btnTest_Click;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 802);
            Controls.Add(btnTest);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnSalir);
            Controls.Add(grbInformacionExtra);
            Controls.Add(grbDatos);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            Load += Registro_Load;
            grbDatos.ResumeLayout(false);
            grbDatos.PerformLayout();
            grbInformacionExtra.ResumeLayout(false);
            grbInformacionExtra.PerformLayout();
            grpVarios.ResumeLayout(false);
            grpVarios.PerformLayout();
            grpGenero.ResumeLayout(false);
            grpGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbNombre;
        private Label label1;
        private GroupBox grbDatos;
        private TextBox txbRePassword;
        private TextBox txbPassword;
        private TextBox txbCorreo;
        private GroupBox grbInformacionExtra;
        private Button btnSalir;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label3;
        private ComboBox cmbColor;
        private GroupBox grpVarios;
        private GroupBox grpGenero;
        private RadioButton rdbNoBinario;
        private RadioButton rdbFemenino;
        private RadioButton rdbMasculino;
        private Label label4;
        private CheckBox chkTrabajar;
        private CheckBox chkEstudiar;
        private CheckBox chkEdad;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private Button btnTest;
    }
}