namespace FormsAtrapame
{
    partial class Form
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
            txtKilometros = new TextBox();
            txtLitros = new TextBox();
            btnCalcular = new Button();
            lblKilometros = new Label();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // txtKilometros
            // 
            txtKilometros.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtKilometros.Location = new Point(25, 51);
            txtKilometros.Name = "txtKilometros";
            txtKilometros.Size = new Size(164, 30);
            txtKilometros.TabIndex = 0;
            // 
            // txtLitros
            // 
            txtLitros.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtLitros.Location = new Point(25, 119);
            txtLitros.Name = "txtLitros";
            txtLitros.Size = new Size(164, 30);
            txtLitros.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(25, 184);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(164, 39);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblKilometros
            // 
            lblKilometros.AutoSize = true;
            lblKilometros.Location = new Point(25, 28);
            lblKilometros.Name = "lblKilometros";
            lblKilometros.Size = new Size(81, 20);
            lblKilometros.TabIndex = 3;
            lblKilometros.Text = "Kilometros";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 96);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 4;
            label1.Text = "Litros";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(299, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(301, 211);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 235);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(lblKilometros);
            Controls.Add(btnCalcular);
            Controls.Add(txtLitros);
            Controls.Add(txtKilometros);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKilometros;
        private TextBox txtLitros;
        private Button btnCalcular;
        private Label lblKilometros;
        private Label label1;
        private RichTextBox richTextBox1;
    }
}