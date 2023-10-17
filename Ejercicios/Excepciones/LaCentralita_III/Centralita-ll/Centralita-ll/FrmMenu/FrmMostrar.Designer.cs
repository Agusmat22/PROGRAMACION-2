namespace Formularios
{
    partial class FrmMostrar
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
            rtbFacturacion = new RichTextBox();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // rtbFacturacion
            // 
            rtbFacturacion.Enabled = false;
            rtbFacturacion.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            rtbFacturacion.HideSelection = false;
            rtbFacturacion.Location = new Point(12, 12);
            rtbFacturacion.Name = "rtbFacturacion";
            rtbFacturacion.Size = new Size(321, 205);
            rtbFacturacion.TabIndex = 0;
            rtbFacturacion.Text = "";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(133, 225);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Volver";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // FrmMostrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 260);
            Controls.Add(btnSalir);
            Controls.Add(rtbFacturacion);
            MaximizeBox = false;
            Name = "FrmMostrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle";
            Load += FrmMostrar_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbFacturacion;
        private Button btnSalir;
    }
}