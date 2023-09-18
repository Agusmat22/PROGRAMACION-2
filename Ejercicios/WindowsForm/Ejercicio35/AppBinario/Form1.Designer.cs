namespace AppBinario
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
            label1 = new Label();
            label2 = new Label();
            txtBinADec = new TextBox();
            txtDecABin = new TextBox();
            btnBinarioADecimal = new Button();
            btnDecimalABinario = new Button();
            txtResultadoDecimal = new TextBox();
            txtResultadoBinario = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 0;
            label1.Text = "Binario a decimal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 123);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 1;
            label2.Text = "Decimal a binario";
            // 
            // txtBinADec
            // 
            txtBinADec.Location = new Point(156, 50);
            txtBinADec.Name = "txtBinADec";
            txtBinADec.Size = new Size(125, 27);
            txtBinADec.TabIndex = 2;
            // 
            // txtDecABin
            // 
            txtDecABin.Location = new Point(156, 123);
            txtDecABin.Name = "txtDecABin";
            txtDecABin.Size = new Size(125, 27);
            txtDecABin.TabIndex = 3;
            // 
            // btnBinarioADecimal
            // 
            btnBinarioADecimal.Location = new Point(328, 48);
            btnBinarioADecimal.Name = "btnBinarioADecimal";
            btnBinarioADecimal.Size = new Size(94, 29);
            btnBinarioADecimal.TabIndex = 4;
            btnBinarioADecimal.Text = "->";
            btnBinarioADecimal.UseVisualStyleBackColor = true;
            btnBinarioADecimal.Click += btnBinarioADecimal_Click;
            // 
            // btnDecimalABinario
            // 
            btnDecimalABinario.Location = new Point(328, 123);
            btnDecimalABinario.Name = "btnDecimalABinario";
            btnDecimalABinario.Size = new Size(94, 29);
            btnDecimalABinario.TabIndex = 5;
            btnDecimalABinario.Text = "->";
            btnDecimalABinario.UseVisualStyleBackColor = true;
            btnDecimalABinario.Click += btnDecimalABinario_Click;
            // 
            // txtResultadoDecimal
            // 
            txtResultadoDecimal.Enabled = false;
            txtResultadoDecimal.Location = new Point(462, 48);
            txtResultadoDecimal.Name = "txtResultadoDecimal";
            txtResultadoDecimal.Size = new Size(156, 27);
            txtResultadoDecimal.TabIndex = 6;
            // 
            // txtResultadoBinario
            // 
            txtResultadoBinario.Enabled = false;
            txtResultadoBinario.Location = new Point(462, 123);
            txtResultadoBinario.Name = "txtResultadoBinario";
            txtResultadoBinario.Size = new Size(156, 27);
            txtResultadoBinario.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 177);
            Controls.Add(txtResultadoBinario);
            Controls.Add(txtResultadoDecimal);
            Controls.Add(btnDecimalABinario);
            Controls.Add(btnBinarioADecimal);
            Controls.Add(txtDecABin);
            Controls.Add(txtBinADec);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calculadora de numeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBinADec;
        private TextBox txtDecABin;
        private Button btnBinarioADecimal;
        private Button btnDecimalABinario;
        private TextBox txtResultadoDecimal;
        private TextBox txtResultadoBinario;
    }
}