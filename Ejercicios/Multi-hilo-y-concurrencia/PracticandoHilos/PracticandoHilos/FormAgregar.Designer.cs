namespace PracticandoHilos
{
    partial class FormAgregar
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
            txtPaciente = new TextBox();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // txtPaciente
            // 
            txtPaciente.Location = new Point(68, 60);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.PlaceholderText = "Agregar Nombre";
            txtPaciente.Size = new Size(182, 23);
            txtPaciente.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(68, 128);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(182, 45);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 244);
            Controls.Add(btnAgregar);
            Controls.Add(txtPaciente);
            Name = "FormAgregar";
            Text = "FormAgregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPaciente;
        private Button btnAgregar;
    }
}