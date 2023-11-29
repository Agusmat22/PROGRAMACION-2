namespace PracticandoHilos
{
    partial class FormPrincipal
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
            panel2 = new Panel();
            panel1 = new Panel();
            btnPrimer = new Button();
            btnSegundo = new Button();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Location = new Point(404, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(367, 283);
            panel2.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.Location = new Point(10, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 283);
            panel1.TabIndex = 13;
            // 
            // btnPrimer
            // 
            btnPrimer.Location = new Point(105, 47);
            btnPrimer.Margin = new Padding(3, 2, 3, 2);
            btnPrimer.Name = "btnPrimer";
            btnPrimer.Size = new Size(146, 22);
            btnPrimer.TabIndex = 12;
            btnPrimer.Text = "Primer Form";
            btnPrimer.UseVisualStyleBackColor = true;
            btnPrimer.Click += btnPrimer_Click;
            // 
            // btnSegundo
            // 
            btnSegundo.Location = new Point(521, 47);
            btnSegundo.Margin = new Padding(3, 2, 3, 2);
            btnSegundo.Name = "btnSegundo";
            btnSegundo.Size = new Size(160, 22);
            btnSegundo.TabIndex = 11;
            btnSegundo.Text = "Segundo Form";
            btnSegundo.UseVisualStyleBackColor = true;
            btnSegundo.Click += btnSegundo_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 422);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnPrimer);
            Controls.Add(btnSegundo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormPrincipal";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Button btnPrimer;
        private Button btnSegundo;
    }
}