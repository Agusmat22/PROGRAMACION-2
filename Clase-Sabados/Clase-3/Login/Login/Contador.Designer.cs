namespace Login
{
    partial class Contador
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
            Button btnContador;
            lblContador = new Label();
            label2 = new Label();
            lbkActualizar = new LinkLabel();
            listBoxRanking = new ListBox();
            btnSalir = new Button();
            lblContadorNumero = new Label();
            btnContador = new Button();
            SuspendLayout();
            // 
            // btnContador
            // 
            btnContador.BackColor = Color.RoyalBlue;
            btnContador.FlatStyle = FlatStyle.Flat;
            btnContador.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnContador.Location = new Point(47, 85);
            btnContador.Name = "btnContador";
            btnContador.Size = new Size(693, 66);
            btnContador.TabIndex = 0;
            btnContador.Text = "CONTADOR";
            btnContador.UseVisualStyleBackColor = false;
            btnContador.Click += btnContador_Click;
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblContador.Location = new Point(47, 28);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(173, 38);
            lblContador.TabIndex = 1;
            lblContador.Text = "CONTADOR:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(47, 188);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 2;
            label2.Text = "RANKING";
            // 
            // lbkActualizar
            // 
            lbkActualizar.AutoSize = true;
            lbkActualizar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbkActualizar.Location = new Point(643, 188);
            lbkActualizar.Name = "lbkActualizar";
            lbkActualizar.Size = new Size(96, 25);
            lbkActualizar.TabIndex = 3;
            lbkActualizar.TabStop = true;
            lbkActualizar.Text = "Actualizar";
            lbkActualizar.LinkClicked += lbkActualizar_LinkClicked;
            // 
            // listBoxRanking
            // 
            listBoxRanking.FormattingEnabled = true;
            listBoxRanking.ItemHeight = 20;
            listBoxRanking.Location = new Point(47, 224);
            listBoxRanking.Name = "listBoxRanking";
            listBoxRanking.Size = new Size(693, 304);
            listBoxRanking.TabIndex = 4;
            listBoxRanking.Format += listBoxRanking_Format;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Tomato;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(46, 547);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(693, 55);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblContadorNumero
            // 
            lblContadorNumero.AutoSize = true;
            lblContadorNumero.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblContadorNumero.Location = new Point(271, 33);
            lblContadorNumero.Name = "lblContadorNumero";
            lblContadorNumero.Size = new Size(27, 32);
            lblContadorNumero.TabIndex = 6;
            lblContadorNumero.Text = "0";
            // 
            // Contador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 614);
            Controls.Add(lblContadorNumero);
            Controls.Add(btnSalir);
            Controls.Add(listBoxRanking);
            Controls.Add(lbkActualizar);
            Controls.Add(label2);
            Controls.Add(lblContador);
            Controls.Add(btnContador);
            Name = "Contador";
            Text = "Contador";
            FormClosing += Contador_FormClosing;
            Load += Contador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnContador;
        private Label lblContador;
        private Label label2;
        private LinkLabel lbkActualizar;
        private ListBox listBoxRanking;
        private Button btnSalir;
        private Label lblContadorNumero;
    }
}