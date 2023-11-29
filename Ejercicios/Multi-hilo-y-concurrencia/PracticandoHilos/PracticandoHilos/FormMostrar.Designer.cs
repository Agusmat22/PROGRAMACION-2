namespace PracticandoHilos
{
    partial class FormMostrar
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
            lstbPacientes = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstbPacientes
            // 
            lstbPacientes.FormattingEnabled = true;
            lstbPacientes.ItemHeight = 15;
            lstbPacientes.Location = new Point(12, 51);
            lstbPacientes.Name = "lstbPacientes";
            lstbPacientes.Size = new Size(327, 184);
            lstbPacientes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 23);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Pacientes";
            // 
            // FormMostrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 244);
            Controls.Add(label1);
            Controls.Add(lstbPacientes);
            Name = "FormMostrar";
            Text = "FormMostrar";
            Load += FormMostrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstbPacientes;
        private Label label1;
    }
}