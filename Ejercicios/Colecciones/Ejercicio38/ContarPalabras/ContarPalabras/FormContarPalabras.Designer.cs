namespace ContarPalabras
{
    partial class FormContarPalabras
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
            RichTxt = new RichTextBox();
            btnCalcular = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // RichTxt
            // 
            RichTxt.Location = new Point(12, 12);
            RichTxt.Name = "RichTxt";
            RichTxt.Size = new Size(583, 368);
            RichTxt.TabIndex = 0;
            RichTxt.Text = "";
            // 
            // btnCalcular
            // 
            btnCalcular.Cursor = Cursors.Hand;
            btnCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.Location = new Point(500, 395);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(95, 33);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSalir
            // 
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(12, 395);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(95, 33);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormContarPalabras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 440);
            Controls.Add(btnSalir);
            Controls.Add(btnCalcular);
            Controls.Add(RichTxt);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormContarPalabras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "A Contar Palabras";
            FormClosing += FormContarPalabras_FormClosing;
            Load += FormContarPalabras_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox RichTxt;
        private Button btnCalcular;
        private Button btnSalir;
    }
}