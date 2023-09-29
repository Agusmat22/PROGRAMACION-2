namespace Restaurante
{
    partial class Login
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
            panel1 = new Panel();
            linklblRegistrarse = new LinkLabel();
            pcbCerrar = new PictureBox();
            pcbMinimizar = new PictureBox();
            btnIngresar = new Button();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbMinimizar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(linklblRegistrarse);
            panel1.Controls.Add(pcbCerrar);
            panel1.Controls.Add(pcbMinimizar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(617, 57);
            panel1.TabIndex = 0;
            // 
            // linklblRegistrarse
            // 
            linklblRegistrarse.AutoSize = true;
            linklblRegistrarse.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            linklblRegistrarse.LinkColor = Color.PaleTurquoise;
            linklblRegistrarse.Location = new Point(12, 9);
            linklblRegistrarse.Name = "linklblRegistrarse";
            linklblRegistrarse.Size = new Size(94, 23);
            linklblRegistrarse.TabIndex = 4;
            linklblRegistrarse.TabStop = true;
            linklblRegistrarse.Text = "Registrarse";
            linklblRegistrarse.LinkClicked += linklblRegistrarse_LinkClicked;
            linklblRegistrarse.MouseLeave += linklblRegistrarse_MouseLeave;
            linklblRegistrarse.MouseHover += linkLabel1_MouseHover;
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
            pcbCerrar.Click += pictureBox2_Click;
            pcbCerrar.MouseLeave += pcbCerrar_MouseLeave;
            pcbCerrar.MouseHover += pcbCerrar_MouseHover;
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
            pcbMinimizar.Click += pcbMinimizar_Click;
            pcbMinimizar.MouseLeave += pcbMinimizar_MouseLeave;
            pcbMinimizar.MouseHover += pcbMinimizar_MouseHover;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Teal;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnIngresar.Location = new Point(246, 311);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(120, 44);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "Ingresar";
            btnIngresar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtUsuario.Location = new Point(191, 150);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(220, 30);
            txtUsuario.TabIndex = 2;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtPassword.Location = new Point(191, 225);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(220, 30);
            txtPassword.TabIndex = 3;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(617, 450);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbMinimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pcbCerrar;
        private PictureBox pcbMinimizar;
        private Button btnIngresar;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private LinkLabel linklblRegistrarse;
    }
}