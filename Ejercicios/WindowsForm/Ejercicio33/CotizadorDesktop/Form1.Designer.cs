namespace CotizadorDesktop
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txbEuroIngresado = new TextBox();
            txbDolarIngresado = new TextBox();
            txbPesoIngresado = new TextBox();
            btnEuro = new Button();
            btnDolar = new Button();
            btnPeso = new Button();
            txbPesoE = new TextBox();
            txbDolarE = new TextBox();
            txbEuroE = new TextBox();
            txbPesoD = new TextBox();
            txbDolarD = new TextBox();
            txbEuroD = new TextBox();
            txbPesoP = new TextBox();
            txbDolarP = new TextBox();
            txbEuroP = new TextBox();
            txbCotzPeso = new TextBox();
            txbCotzDolar = new TextBox();
            txbCotzEuro = new TextBox();
            btnBloquear = new Button();
            candadoCerrado = new ImageList(components);
            lbCotizador = new Label();
            label1 = new Label();
            lbDolar = new Label();
            lbPeso = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txbEuroIngresado
            // 
            txbEuroIngresado.Location = new Point(78, 117);
            txbEuroIngresado.Name = "txbEuroIngresado";
            txbEuroIngresado.Size = new Size(100, 23);
            txbEuroIngresado.TabIndex = 0;
            // 
            // txbDolarIngresado
            // 
            txbDolarIngresado.Location = new Point(78, 177);
            txbDolarIngresado.Name = "txbDolarIngresado";
            txbDolarIngresado.Size = new Size(100, 23);
            txbDolarIngresado.TabIndex = 1;
            // 
            // txbPesoIngresado
            // 
            txbPesoIngresado.Location = new Point(78, 239);
            txbPesoIngresado.Name = "txbPesoIngresado";
            txbPesoIngresado.Size = new Size(100, 23);
            txbPesoIngresado.TabIndex = 2;
            // 
            // btnEuro
            // 
            btnEuro.Location = new Point(226, 117);
            btnEuro.Name = "btnEuro";
            btnEuro.Size = new Size(75, 23);
            btnEuro.TabIndex = 3;
            btnEuro.Text = "->";
            btnEuro.UseVisualStyleBackColor = true;
            btnEuro.Click += btnEuro_Click;
            // 
            // btnDolar
            // 
            btnDolar.Location = new Point(226, 178);
            btnDolar.Name = "btnDolar";
            btnDolar.Size = new Size(75, 23);
            btnDolar.TabIndex = 4;
            btnDolar.Text = "->";
            btnDolar.UseVisualStyleBackColor = true;
            btnDolar.Click += btnDolar_Click;
            // 
            // btnPeso
            // 
            btnPeso.Location = new Point(226, 239);
            btnPeso.Name = "btnPeso";
            btnPeso.Size = new Size(75, 23);
            btnPeso.TabIndex = 5;
            btnPeso.Text = "->";
            btnPeso.UseVisualStyleBackColor = true;
            btnPeso.Click += btnPeso_Click;
            // 
            // txbPesoE
            // 
            txbPesoE.Location = new Point(363, 239);
            txbPesoE.Name = "txbPesoE";
            txbPesoE.Size = new Size(100, 23);
            txbPesoE.TabIndex = 8;
            // 
            // txbDolarE
            // 
            txbDolarE.Location = new Point(363, 177);
            txbDolarE.Name = "txbDolarE";
            txbDolarE.Size = new Size(100, 23);
            txbDolarE.TabIndex = 7;
            // 
            // txbEuroE
            // 
            txbEuroE.Location = new Point(363, 117);
            txbEuroE.Name = "txbEuroE";
            txbEuroE.Size = new Size(100, 23);
            txbEuroE.TabIndex = 6;
            // 
            // txbPesoD
            // 
            txbPesoD.Location = new Point(510, 239);
            txbPesoD.Name = "txbPesoD";
            txbPesoD.Size = new Size(100, 23);
            txbPesoD.TabIndex = 11;
            // 
            // txbDolarD
            // 
            txbDolarD.Location = new Point(510, 177);
            txbDolarD.Name = "txbDolarD";
            txbDolarD.Size = new Size(100, 23);
            txbDolarD.TabIndex = 10;
            // 
            // txbEuroD
            // 
            txbEuroD.Location = new Point(510, 117);
            txbEuroD.Name = "txbEuroD";
            txbEuroD.Size = new Size(100, 23);
            txbEuroD.TabIndex = 9;
            // 
            // txbPesoP
            // 
            txbPesoP.Location = new Point(665, 239);
            txbPesoP.Name = "txbPesoP";
            txbPesoP.Size = new Size(100, 23);
            txbPesoP.TabIndex = 14;
            // 
            // txbDolarP
            // 
            txbDolarP.Location = new Point(665, 177);
            txbDolarP.Name = "txbDolarP";
            txbDolarP.Size = new Size(100, 23);
            txbDolarP.TabIndex = 13;
            // 
            // txbEuroP
            // 
            txbEuroP.Location = new Point(665, 117);
            txbEuroP.Name = "txbEuroP";
            txbEuroP.Size = new Size(100, 23);
            txbEuroP.TabIndex = 12;
            // 
            // txbCotzPeso
            // 
            txbCotzPeso.Location = new Point(665, 49);
            txbCotzPeso.Name = "txbCotzPeso";
            txbCotzPeso.Size = new Size(100, 23);
            txbCotzPeso.TabIndex = 17;
            // 
            // txbCotzDolar
            // 
            txbCotzDolar.Location = new Point(510, 49);
            txbCotzDolar.Name = "txbCotzDolar";
            txbCotzDolar.Size = new Size(100, 23);
            txbCotzDolar.TabIndex = 16;
            // 
            // txbCotzEuro
            // 
            txbCotzEuro.Location = new Point(363, 49);
            txbCotzEuro.Name = "txbCotzEuro";
            txbCotzEuro.Size = new Size(100, 23);
            txbCotzEuro.TabIndex = 15;
            // 
            // btnBloquear
            // 
            btnBloquear.ImageIndex = 0;
            btnBloquear.ImageList = candadoCerrado;
            btnBloquear.Location = new Point(226, 49);
            btnBloquear.Name = "btnBloquear";
            btnBloquear.Size = new Size(75, 23);
            btnBloquear.TabIndex = 18;
            btnBloquear.UseVisualStyleBackColor = true;
            btnBloquear.Click += btnBloquear_Click;
            // 
            // candadoCerrado
            // 
            candadoCerrado.ColorDepth = ColorDepth.Depth8Bit;
            candadoCerrado.ImageStream = (ImageListStreamer)resources.GetObject("candadoCerrado.ImageStream");
            candadoCerrado.TransparentColor = Color.Transparent;
            candadoCerrado.Images.SetKeyName(0, "pngwing.com (1).png");
            candadoCerrado.Images.SetKeyName(1, "pngwing.com.png");
            // 
            // lbCotizador
            // 
            lbCotizador.AutoSize = true;
            lbCotizador.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCotizador.Location = new Point(92, 47);
            lbCotizador.Name = "lbCotizador";
            lbCotizador.Size = new Size(86, 21);
            lbCotizador.TabIndex = 19;
            lbCotizador.Text = "Cotizacion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 115);
            label1.Name = "label1";
            label1.Size = new Size(43, 21);
            label1.TabIndex = 20;
            label1.Text = "Euro";
            // 
            // lbDolar
            // 
            lbDolar.AutoSize = true;
            lbDolar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbDolar.Location = new Point(12, 175);
            lbDolar.Name = "lbDolar";
            lbDolar.Size = new Size(49, 21);
            lbDolar.TabIndex = 21;
            lbDolar.Text = "Dolar";
            // 
            // lbPeso
            // 
            lbPeso.AutoSize = true;
            lbPeso.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbPeso.Location = new Point(12, 238);
            lbPeso.Name = "lbPeso";
            lbPeso.Size = new Size(44, 21);
            lbPeso.TabIndex = 22;
            lbPeso.Text = "Peso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(389, 9);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 23;
            label2.Text = "Euro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(535, 9);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 24;
            label3.Text = "Dolar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(693, 9);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 25;
            label4.Text = "Peso";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 291);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbPeso);
            Controls.Add(lbDolar);
            Controls.Add(label1);
            Controls.Add(lbCotizador);
            Controls.Add(btnBloquear);
            Controls.Add(txbCotzPeso);
            Controls.Add(txbCotzDolar);
            Controls.Add(txbCotzEuro);
            Controls.Add(txbPesoP);
            Controls.Add(txbDolarP);
            Controls.Add(txbEuroP);
            Controls.Add(txbPesoD);
            Controls.Add(txbDolarD);
            Controls.Add(txbEuroD);
            Controls.Add(txbPesoE);
            Controls.Add(txbDolarE);
            Controls.Add(txbEuroE);
            Controls.Add(btnPeso);
            Controls.Add(btnDolar);
            Controls.Add(btnEuro);
            Controls.Add(txbPesoIngresado);
            Controls.Add(txbDolarIngresado);
            Controls.Add(txbEuroIngresado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbEuroIngresado;
        private TextBox txbDolarIngresado;
        private TextBox txbPesoIngresado;
        private Button btnEuro;
        private Button btnDolar;
        private Button btnPeso;
        private TextBox txbPesoE;
        private TextBox txbDolarE;
        private TextBox txbEuroE;
        private TextBox txbPesoD;
        private TextBox txbDolarD;
        private TextBox txbEuroD;
        private TextBox txbPesoP;
        private TextBox txbDolarP;
        private TextBox txbEuroP;
        private TextBox txbCotzPeso;
        private TextBox txbCotzDolar;
        private TextBox txbCotzEuro;
        private Button btnBloquear;
        private Label lbCotizador;
        private Label label1;
        private Label lbDolar;
        private Label lbPeso;
        private Label label2;
        private Label label3;
        private Label label4;
        private ImageList candadoCerrado;
    }
}