namespace MiCalculadora
{
    partial class FrmCalculadora
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
            btnLimpiar = new Button();
            btnOperar = new Button();
            BtnCerrar = new Button();
            txbSegundoOperando = new TextBox();
            cmbTipoOperacion = new ComboBox();
            lblPrimerOperando = new Label();
            lblSegundoOperando = new Label();
            txbPrimerOperando = new TextBox();
            label3 = new Label();
            grbTipoSistema = new GroupBox();
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            label1 = new Label();
            lblResultado = new Label();
            grbTipoSistema.SuspendLayout();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(321, 489);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(138, 57);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnOperar
            // 
            btnOperar.Cursor = Cursors.Hand;
            btnOperar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnOperar.Location = new Point(46, 489);
            btnOperar.Margin = new Padding(3, 4, 3, 4);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(203, 57);
            btnOperar.TabIndex = 4;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // BtnCerrar
            // 
            BtnCerrar.BackColor = SystemColors.Control;
            BtnCerrar.Cursor = Cursors.Hand;
            BtnCerrar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCerrar.Location = new Point(529, 489);
            BtnCerrar.Margin = new Padding(3, 4, 3, 4);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(203, 57);
            BtnCerrar.TabIndex = 6;
            BtnCerrar.Text = "Cerrar";
            BtnCerrar.UseVisualStyleBackColor = true;
            // 
            // txbSegundoOperando
            // 
            txbSegundoOperando.Cursor = Cursors.IBeam;
            txbSegundoOperando.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txbSegundoOperando.Location = new Point(529, 369);
            txbSegundoOperando.Margin = new Padding(3, 4, 3, 4);
            txbSegundoOperando.Name = "txbSegundoOperando";
            txbSegundoOperando.Size = new Size(203, 52);
            txbSegundoOperando.TabIndex = 3;
            // 
            // cmbTipoOperacion
            // 
            cmbTipoOperacion.Cursor = Cursors.Hand;
            cmbTipoOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoOperacion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoOperacion.FormattingEnabled = true;
            cmbTipoOperacion.Location = new Point(321, 367);
            cmbTipoOperacion.Margin = new Padding(3, 4, 3, 4);
            cmbTipoOperacion.Name = "cmbTipoOperacion";
            cmbTipoOperacion.Size = new Size(138, 53);
            cmbTipoOperacion.TabIndex = 2;
            // 
            // lblPrimerOperando
            // 
            lblPrimerOperando.AutoSize = true;
            lblPrimerOperando.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrimerOperando.Location = new Point(43, 325);
            lblPrimerOperando.Name = "lblPrimerOperando";
            lblPrimerOperando.Size = new Size(221, 37);
            lblPrimerOperando.TabIndex = 6;
            lblPrimerOperando.Text = "Primer Operador";
            // 
            // lblSegundoOperando
            // 
            lblSegundoOperando.AutoSize = true;
            lblSegundoOperando.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblSegundoOperando.Location = new Point(517, 323);
            lblSegundoOperando.Name = "lblSegundoOperando";
            lblSegundoOperando.Size = new Size(249, 37);
            lblSegundoOperando.TabIndex = 7;
            lblSegundoOperando.Text = "Segundo Operador";
            // 
            // txbPrimerOperando
            // 
            txbPrimerOperando.Cursor = Cursors.IBeam;
            txbPrimerOperando.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txbPrimerOperando.Location = new Point(46, 369);
            txbPrimerOperando.Margin = new Padding(3, 4, 3, 4);
            txbPrimerOperando.Name = "txbPrimerOperando";
            txbPrimerOperando.Size = new Size(203, 52);
            txbPrimerOperando.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(321, 323);
            label3.Name = "label3";
            label3.Size = new Size(150, 37);
            label3.TabIndex = 9;
            label3.Text = "Operacion:";
            // 
            // grbTipoSistema
            // 
            grbTipoSistema.Controls.Add(rdbBinario);
            grbTipoSistema.Controls.Add(rdbDecimal);
            grbTipoSistema.Location = new Point(274, 177);
            grbTipoSistema.Margin = new Padding(3, 4, 3, 4);
            grbTipoSistema.Name = "grbTipoSistema";
            grbTipoSistema.Padding = new Padding(3, 4, 3, 4);
            grbTipoSistema.Size = new Size(242, 104);
            grbTipoSistema.TabIndex = 9;
            grbTipoSistema.TabStop = false;
            grbTipoSistema.Text = "Representar resultado en:";
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Cursor = Cursors.Hand;
            rdbBinario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rdbBinario.Location = new Point(144, 47);
            rdbBinario.Margin = new Padding(3, 4, 3, 4);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(84, 27);
            rdbBinario.TabIndex = 8;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Cursor = Cursors.Hand;
            rdbDecimal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rdbDecimal.Location = new Point(22, 47);
            rdbDecimal.Margin = new Padding(3, 4, 3, 4);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(92, 27);
            rdbDecimal.TabIndex = 7;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(47, 39);
            label1.Name = "label1";
            label1.Size = new Size(223, 57);
            label1.TabIndex = 11;
            label1.Text = "Resultado:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(309, 53);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(33, 38);
            lblResultado.TabIndex = 12;
            lblResultado.Text = "0";
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 572);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Controls.Add(grbTipoSistema);
            Controls.Add(label3);
            Controls.Add(txbPrimerOperando);
            Controls.Add(lblSegundoOperando);
            Controls.Add(lblPrimerOperando);
            Controls.Add(cmbTipoOperacion);
            Controls.Add(txbSegundoOperando);
            Controls.Add(BtnCerrar);
            Controls.Add(btnOperar);
            Controls.Add(btnLimpiar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            Text = "Calculadora Alumno: Agustin Garcia Navas";
            Load += FrmCalculadora_Load;
            grbTipoSistema.ResumeLayout(false);
            grbTipoSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiar;
        private Button btnOperar;
        private Button BtnCerrar;
        private TextBox txbSegundoOperando;
        private ComboBox cmbTipoOperacion;
        private Label lblPrimerOperando;
        private Label lblSegundoOperando;
        private TextBox txbPrimerOperando;
        private Label label3;
        private GroupBox grbTipoSistema;
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;
        private Label label1;
        private Label lblResultado;
    }
}