namespace Login
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCorreo = new TextBox();
            txtPass = new TextBox();
            btnIngresar = new Button();
            linkLabel1 = new LinkLabel();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(108, 47);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 171);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 85);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 2;
            label3.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(30, 116);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(397, 39);
            txtCorreo.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(30, 202);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(397, 39);
            txtPass.TabIndex = 4;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(192, 255, 192);
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.Location = new Point(30, 269);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(397, 64);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.Location = new Point(30, 372);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(104, 25);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "REGISTRAR";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.Control;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(255, 350);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(172, 64);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 426);
            Controls.Add(btnSalir);
            Controls.Add(linkLabel1);
            Controls.Add(btnIngresar);
            Controls.Add(txtPass);
            Controls.Add(txtCorreo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += Login_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCorreo;
        private TextBox txtPass;
        private Button btnIngresar;
        private LinkLabel linkLabel1;
        private Button btnSalir;
    }
}