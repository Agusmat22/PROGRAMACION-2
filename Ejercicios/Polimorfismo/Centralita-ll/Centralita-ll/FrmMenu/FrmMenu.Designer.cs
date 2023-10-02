namespace FrmMenu
{
    partial class FrmMenu
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
            btnGenerarLlamada = new Button();
            btnFacturacionTotal = new Button();
            btnFacturacionLocal = new Button();
            btnFacturacionProvincial = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnGenerarLlamada
            // 
            btnGenerarLlamada.Cursor = Cursors.Hand;
            btnGenerarLlamada.FlatAppearance.BorderSize = 2;
            btnGenerarLlamada.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerarLlamada.Location = new Point(27, 31);
            btnGenerarLlamada.Name = "btnGenerarLlamada";
            btnGenerarLlamada.Size = new Size(300, 56);
            btnGenerarLlamada.TabIndex = 0;
            btnGenerarLlamada.Text = "Generar Llamada";
            btnGenerarLlamada.UseVisualStyleBackColor = true;
            btnGenerarLlamada.Click += btnGenerarLlamada_Click;
            // 
            // btnFacturacionTotal
            // 
            btnFacturacionTotal.Cursor = Cursors.Hand;
            btnFacturacionTotal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnFacturacionTotal.Location = new Point(27, 107);
            btnFacturacionTotal.Name = "btnFacturacionTotal";
            btnFacturacionTotal.Size = new Size(300, 56);
            btnFacturacionTotal.TabIndex = 1;
            btnFacturacionTotal.Text = "Facturacion Total";
            btnFacturacionTotal.UseVisualStyleBackColor = true;
            btnFacturacionTotal.Click += btnFacturacionTotal_Click;
            // 
            // btnFacturacionLocal
            // 
            btnFacturacionLocal.Cursor = Cursors.Hand;
            btnFacturacionLocal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnFacturacionLocal.Location = new Point(27, 181);
            btnFacturacionLocal.Name = "btnFacturacionLocal";
            btnFacturacionLocal.Size = new Size(300, 56);
            btnFacturacionLocal.TabIndex = 2;
            btnFacturacionLocal.Text = "Facturacion  Local";
            btnFacturacionLocal.UseVisualStyleBackColor = true;
            btnFacturacionLocal.Click += btnFacturacionLocal_Click;
            // 
            // btnFacturacionProvincial
            // 
            btnFacturacionProvincial.Cursor = Cursors.Hand;
            btnFacturacionProvincial.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnFacturacionProvincial.Location = new Point(27, 257);
            btnFacturacionProvincial.Name = "btnFacturacionProvincial";
            btnFacturacionProvincial.Size = new Size(300, 56);
            btnFacturacionProvincial.TabIndex = 3;
            btnFacturacionProvincial.Text = "Facturacion Provincial";
            btnFacturacionProvincial.UseVisualStyleBackColor = true;
            btnFacturacionProvincial.Click += btnFacturacionProvincial_Click;
            // 
            // btnSalir
            // 
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(27, 334);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(300, 56);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 418);
            Controls.Add(btnSalir);
            Controls.Add(btnFacturacionProvincial);
            Controls.Add(btnFacturacionLocal);
            Controls.Add(btnFacturacionTotal);
            Controls.Add(btnGenerarLlamada);
            MaximizeBox = false;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Central Telefonica";
            FormClosing += FrmMenu_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnGenerarLlamada;
        private Button btnFacturacionTotal;
        private Button btnFacturacionLocal;
        private Button btnFacturacionProvincial;
        private Button btnSalir;
    }
}