namespace Restaurante
{
    partial class RegistrarUsuario
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
            grpRegistroUsuario = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtRePassword = new TextBox();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            grpRegistroInformacion = new GroupBox();
            cmbPuesto = new ComboBox();
            label9 = new Label();
            txtDni = new TextBox();
            label8 = new Label();
            txtApellido = new TextBox();
            label7 = new Label();
            cmbTurno = new ComboBox();
            txtNombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pcbCerrar = new PictureBox();
            pcbMinimizar = new PictureBox();
            label4 = new Label();
            btnRegistrar = new Button();
            button1 = new Button();
            grpRegistroUsuario.SuspendLayout();
            grpRegistroInformacion.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbMinimizar).BeginInit();
            SuspendLayout();
            // 
            // grpRegistroUsuario
            // 
            grpRegistroUsuario.Controls.Add(label3);
            grpRegistroUsuario.Controls.Add(label2);
            grpRegistroUsuario.Controls.Add(label1);
            grpRegistroUsuario.Controls.Add(txtRePassword);
            grpRegistroUsuario.Controls.Add(txtPassword);
            grpRegistroUsuario.Controls.Add(txtUsuario);
            grpRegistroUsuario.ForeColor = SystemColors.ControlLightLight;
            grpRegistroUsuario.Location = new Point(26, 118);
            grpRegistroUsuario.Name = "grpRegistroUsuario";
            grpRegistroUsuario.Size = new Size(302, 174);
            grpRegistroUsuario.TabIndex = 0;
            grpRegistroUsuario.TabStop = false;
            grpRegistroUsuario.Text = "Dato Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(10, 125);
            label3.Name = "label3";
            label3.Size = new Size(44, 19);
            label3.TabIndex = 5;
            label3.Text = "Clave";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(10, 83);
            label2.Name = "label2";
            label2.Size = new Size(44, 19);
            label2.TabIndex = 4;
            label2.Text = "Clave";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(10, 41);
            label1.Name = "label1";
            label1.Size = new Size(58, 19);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // txtRePassword
            // 
            txtRePassword.Location = new Point(74, 124);
            txtRePassword.Name = "txtRePassword";
            txtRePassword.PasswordChar = '*';
            txtRePassword.PlaceholderText = "Repita Contraseña";
            txtRePassword.Size = new Size(204, 24);
            txtRePassword.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(74, 82);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(204, 24);
            txtPassword.TabIndex = 1;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(74, 40);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Nombre Usuario";
            txtUsuario.Size = new Size(204, 24);
            txtUsuario.TabIndex = 0;
            // 
            // grpRegistroInformacion
            // 
            grpRegistroInformacion.Controls.Add(cmbPuesto);
            grpRegistroInformacion.Controls.Add(label9);
            grpRegistroInformacion.Controls.Add(txtDni);
            grpRegistroInformacion.Controls.Add(label8);
            grpRegistroInformacion.Controls.Add(txtApellido);
            grpRegistroInformacion.Controls.Add(label7);
            grpRegistroInformacion.Controls.Add(cmbTurno);
            grpRegistroInformacion.Controls.Add(txtNombre);
            grpRegistroInformacion.Controls.Add(label6);
            grpRegistroInformacion.Controls.Add(label5);
            grpRegistroInformacion.ForeColor = SystemColors.ControlLightLight;
            grpRegistroInformacion.Location = new Point(26, 308);
            grpRegistroInformacion.Name = "grpRegistroInformacion";
            grpRegistroInformacion.Size = new Size(302, 236);
            grpRegistroInformacion.TabIndex = 1;
            grpRegistroInformacion.TabStop = false;
            grpRegistroInformacion.Text = "Informacion Empleado";
            // 
            // cmbPuesto
            // 
            cmbPuesto.Cursor = Cursors.Hand;
            cmbPuesto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPuesto.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            cmbPuesto.FormattingEnabled = true;
            cmbPuesto.Location = new Point(166, 191);
            cmbPuesto.Name = "cmbPuesto";
            cmbPuesto.Size = new Size(121, 25);
            cmbPuesto.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(10, 120);
            label9.Name = "label9";
            label9.Size = new Size(31, 19);
            label9.TabIndex = 11;
            label9.Text = "Dni";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(74, 119);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Numero DNI";
            txtDni.Size = new Size(204, 24);
            txtDni.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(10, 78);
            label8.Name = "label8";
            label8.Size = new Size(61, 19);
            label8.TabIndex = 9;
            label8.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(74, 77);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(204, 24);
            txtApellido.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(10, 36);
            label7.Name = "label7";
            label7.Size = new Size(60, 19);
            label7.TabIndex = 7;
            label7.Text = "Nombre";
            // 
            // cmbTurno
            // 
            cmbTurno.Cursor = Cursors.Hand;
            cmbTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTurno.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            cmbTurno.FormattingEnabled = true;
            cmbTurno.Location = new Point(10, 191);
            cmbTurno.Name = "cmbTurno";
            cmbTurno.Size = new Size(121, 25);
            cmbTurno.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(74, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(204, 24);
            txtNombre.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(199, 169);
            label6.Name = "label6";
            label6.Size = new Size(51, 19);
            label6.TabIndex = 1;
            label6.Text = "Puesto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(19, 169);
            label5.Name = "label5";
            label5.Size = new Size(99, 19);
            label5.TabIndex = 0;
            label5.Text = "Turno Trabajo";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pcbCerrar);
            panel1.Controls.Add(pcbMinimizar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 57);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.cerrar;
            pictureBox1.Location = new Point(300, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.minimizar;
            pictureBox2.Location = new Point(258, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pcbCerrar
            // 
            pcbCerrar.Cursor = Cursors.Hand;
            pcbCerrar.Image = Properties.Resources.cerrar;
            pcbCerrar.Location = new Point(563, 3);
            pcbCerrar.Name = "pcbCerrar";
            pcbCerrar.Size = new Size(51, 44);
            pcbCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbCerrar.TabIndex = 2;
            pcbCerrar.TabStop = false;
            // 
            // pcbMinimizar
            // 
            pcbMinimizar.Cursor = Cursors.Hand;
            pcbMinimizar.Image = Properties.Resources.minimizar;
            pcbMinimizar.Location = new Point(521, 9);
            pcbMinimizar.Name = "pcbMinimizar";
            pcbMinimizar.Size = new Size(36, 32);
            pcbMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbMinimizar.TabIndex = 1;
            pcbMinimizar.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(89, 72);
            label4.Name = "label4";
            label4.Size = new Size(178, 28);
            label4.TabIndex = 6;
            label4.Text = "Registro Empleado";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Teal;
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.Location = new Point(116, 580);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(120, 44);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(100, 639);
            button1.Name = "button1";
            button1.Size = new Size(156, 26);
            button1.TabIndex = 8;
            button1.Text = "AutoCompletar";
            button1.TextImageRelation = TextImageRelation.TextAboveImage;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RegistrarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(355, 677);
            Controls.Add(button1);
            Controls.Add(btnRegistrar);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(grpRegistroInformacion);
            Controls.Add(grpRegistroUsuario);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrarUsuario";
            Load += RegistrarUsuario_Load;
            grpRegistroUsuario.ResumeLayout(false);
            grpRegistroUsuario.PerformLayout();
            grpRegistroInformacion.ResumeLayout(false);
            grpRegistroInformacion.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbMinimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpRegistroUsuario;
        private GroupBox grpRegistroInformacion;
        private Panel panel1;
        private PictureBox pcbCerrar;
        private PictureBox pcbMinimizar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private TextBox txtRePassword;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label6;
        private Label label5;
        private ComboBox cmbPuesto;
        private Label label9;
        private TextBox txtDni;
        private Label label8;
        private TextBox txtApellido;
        private Label label7;
        private ComboBox cmbTurno;
        private TextBox txtNombre;
        private Button btnRegistrar;
        private Button button1;
    }
}