﻿namespace ElRelojero
{
    partial class FormRelojero
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
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            btnComenzar = new Button();
            btnParar = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 71);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(726, 367);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 20);
            label1.Name = "label1";
            label1.Size = new Size(76, 31);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // btnComenzar
            // 
            btnComenzar.Location = new Point(503, 34);
            btnComenzar.Name = "btnComenzar";
            btnComenzar.Size = new Size(75, 23);
            btnComenzar.TabIndex = 2;
            btnComenzar.Text = "Comenzar";
            btnComenzar.UseVisualStyleBackColor = true;
            btnComenzar.Click += btnComenzar_Click;
            // 
            // btnParar
            // 
            btnParar.Location = new Point(628, 34);
            btnParar.Name = "btnParar";
            btnParar.Size = new Size(75, 23);
            btnParar.TabIndex = 3;
            btnParar.Text = "Parar";
            btnParar.UseVisualStyleBackColor = true;
            btnParar.Click += btnParar_Click;
            // 
            // FormRelojero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 450);
            Controls.Add(btnParar);
            Controls.Add(btnComenzar);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Name = "FormRelojero";
            Text = "Form1";
            FormClosing += FormRelojero_FormClosing;
            Load += FormRelojero_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
        private Button btnComenzar;
        private Button btnParar;
    }
}