namespace PracticandoHilos
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
            btnAtender = new Button();
            lstbPersonas = new ListBox();
            lblHora = new Label();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(642, 74);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(94, 29);
            btnAtender.TabIndex = 1;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // lstbPersonas
            // 
            lstbPersonas.FormattingEnabled = true;
            lstbPersonas.ItemHeight = 20;
            lstbPersonas.Location = new Point(12, 129);
            lstbPersonas.Name = "lstbPersonas";
            lstbPersonas.Size = new Size(764, 424);
            lstbPersonas.TabIndex = 2;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(108, 54);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(42, 20);
            lblHora.TabIndex = 3;
            lblHora.Text = "Hora";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(466, 74);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(126, 29);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar hora";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 562);
            Controls.Add(btnCancelar);
            Controls.Add(lblHora);
            Controls.Add(lstbPersonas);
            Controls.Add(btnAtender);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAtender;
        private ListBox lstbPersonas;
        private Label lblHora;
        private Button btnCancelar;
    }
}