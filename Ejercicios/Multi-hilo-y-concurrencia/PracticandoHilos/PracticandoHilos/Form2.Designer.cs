namespace PracticandoHilos
{
    partial class Form2
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
            btnCancelar = new Button();
            lblHora = new Label();
            lstbPersonas = new ListBox();
            btnAtender = new Button();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(423, 60);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 22);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar hora";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(109, 44);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(33, 15);
            lblHora.TabIndex = 7;
            lblHora.Text = "Hora";
            // 
            // lstbPersonas
            // 
            lstbPersonas.FormattingEnabled = true;
            lstbPersonas.ItemHeight = 15;
            lstbPersonas.Location = new Point(25, 101);
            lstbPersonas.Margin = new Padding(3, 2, 3, 2);
            lstbPersonas.Name = "lstbPersonas";
            lstbPersonas.Size = new Size(669, 319);
            lstbPersonas.TabIndex = 6;
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(577, 60);
            btnAtender.Margin = new Padding(3, 2, 3, 2);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(82, 22);
            btnAtender.TabIndex = 5;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 465);
            Controls.Add(btnCancelar);
            Controls.Add(lblHora);
            Controls.Add(lstbPersonas);
            Controls.Add(btnAtender);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Label lblHora;
        private ListBox lstbPersonas;
        private Button btnAtender;
    }
}