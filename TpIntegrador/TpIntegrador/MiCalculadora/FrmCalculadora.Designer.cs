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
            txbTipoOperacion = new ComboBox();
            lblPrimerOperando = new Label();
            lblSegundoOperando = new Label();
            txbPrimerOperando = new TextBox();
            label3 = new Label();
            grpMostrarResultado = new GroupBox();
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            label1 = new Label();
            grpMostrarResultado.SuspendLayout();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(281, 367);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(121, 43);
            btnLimpiar.TabIndex = 0;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnOperar
            // 
            btnOperar.Cursor = Cursors.Hand;
            btnOperar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnOperar.Location = new Point(40, 367);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(178, 43);
            btnOperar.TabIndex = 1;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // BtnCerrar
            // 
            BtnCerrar.BackColor = SystemColors.Control;
            BtnCerrar.Cursor = Cursors.Hand;
            BtnCerrar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCerrar.Location = new Point(463, 367);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(178, 43);
            BtnCerrar.TabIndex = 2;
            BtnCerrar.Text = "Cerrar";
            BtnCerrar.UseVisualStyleBackColor = true;
            // 
            // txbSegundoOperando
            // 
            txbSegundoOperando.Cursor = Cursors.IBeam;
            txbSegundoOperando.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txbSegundoOperando.Location = new Point(463, 277);
            txbSegundoOperando.Name = "txbSegundoOperando";
            txbSegundoOperando.Size = new Size(178, 43);
            txbSegundoOperando.TabIndex = 4;
            // 
            // txbTipoOperacion
            // 
            txbTipoOperacion.Cursor = Cursors.Hand;
            txbTipoOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            txbTipoOperacion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txbTipoOperacion.FormattingEnabled = true;
            txbTipoOperacion.Location = new Point(281, 275);
            txbTipoOperacion.Name = "txbTipoOperacion";
            txbTipoOperacion.Size = new Size(121, 45);
            txbTipoOperacion.TabIndex = 5;
            // 
            // lblPrimerOperando
            // 
            lblPrimerOperando.AutoSize = true;
            lblPrimerOperando.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrimerOperando.Location = new Point(38, 244);
            lblPrimerOperando.Name = "lblPrimerOperando";
            lblPrimerOperando.Size = new Size(180, 30);
            lblPrimerOperando.TabIndex = 6;
            lblPrimerOperando.Text = "Primer Operador";
            // 
            // lblSegundoOperando
            // 
            lblSegundoOperando.AutoSize = true;
            lblSegundoOperando.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblSegundoOperando.Location = new Point(452, 242);
            lblSegundoOperando.Name = "lblSegundoOperando";
            lblSegundoOperando.Size = new Size(203, 30);
            lblSegundoOperando.TabIndex = 7;
            lblSegundoOperando.Text = "Segundo Operador";
            // 
            // txbPrimerOperando
            // 
            txbPrimerOperando.Cursor = Cursors.IBeam;
            txbPrimerOperando.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txbPrimerOperando.Location = new Point(40, 277);
            txbPrimerOperando.Name = "txbPrimerOperando";
            txbPrimerOperando.Size = new Size(178, 43);
            txbPrimerOperando.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(281, 242);
            label3.Name = "label3";
            label3.Size = new Size(121, 30);
            label3.TabIndex = 9;
            label3.Text = "Operacion:";
            // 
            // grpMostrarResultado
            // 
            grpMostrarResultado.Controls.Add(rdbBinario);
            grpMostrarResultado.Controls.Add(rdbDecimal);
            grpMostrarResultado.Location = new Point(240, 133);
            grpMostrarResultado.Name = "grpMostrarResultado";
            grpMostrarResultado.Size = new Size(212, 78);
            grpMostrarResultado.TabIndex = 10;
            grpMostrarResultado.TabStop = false;
            grpMostrarResultado.Text = "Representar resultado en:";
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Cursor = Cursors.Hand;
            rdbBinario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rdbBinario.Location = new Point(126, 35);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(69, 23);
            rdbBinario.TabIndex = 1;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Cursor = Cursors.Hand;
            rdbDecimal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rdbDecimal.Location = new Point(19, 35);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(75, 23);
            rdbDecimal.TabIndex = 0;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(41, 29);
            label1.Name = "label1";
            label1.Size = new Size(177, 45);
            label1.TabIndex = 11;
            label1.Text = "Resultado:";
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 429);
            Controls.Add(label1);
            Controls.Add(grpMostrarResultado);
            Controls.Add(label3);
            Controls.Add(txbPrimerOperando);
            Controls.Add(lblSegundoOperando);
            Controls.Add(lblPrimerOperando);
            Controls.Add(txbTipoOperacion);
            Controls.Add(txbSegundoOperando);
            Controls.Add(BtnCerrar);
            Controls.Add(btnOperar);
            Controls.Add(btnLimpiar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            Text = "Calculadora Alumno: Agustin";
            Load += FrmCalculadora_Load;
            grpMostrarResultado.ResumeLayout(false);
            grpMostrarResultado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiar;
        private Button btnOperar;
        private Button BtnCerrar;
        private TextBox txbSegundoOperando;
        private ComboBox txbTipoOperacion;
        private Label lblPrimerOperando;
        private Label lblSegundoOperando;
        private TextBox txbPrimerOperando;
        private Label label3;
        private GroupBox grpMostrarResultado;
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;
        private Label label1;
    }
}