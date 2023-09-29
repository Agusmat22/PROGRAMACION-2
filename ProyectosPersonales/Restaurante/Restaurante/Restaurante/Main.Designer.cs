namespace Restaurante
{
    partial class Main
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pcbCerrar = new PictureBox();
            pcbMinimizar = new PictureBox();
            button1 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            lblNombre = new Label();
            button2 = new Button();
            dgvMesas = new DataGridView();
            Mesa = new DataGridViewTextBoxColumn();
            Turno = new DataGridViewTextBoxColumn();
            cantPersonas = new DataGridViewTextBoxColumn();
            Propina = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbMinimizar).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMesas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pcbCerrar);
            panel1.Controls.Add(pcbMinimizar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(937, 57);
            panel1.TabIndex = 1;
            // 
            // pcbCerrar
            // 
            pcbCerrar.Cursor = Cursors.Hand;
            pcbCerrar.Image = Properties.Resources.cerrar;
            pcbCerrar.Location = new Point(883, 3);
            pcbCerrar.Name = "pcbCerrar";
            pcbCerrar.Size = new Size(51, 44);
            pcbCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbCerrar.TabIndex = 2;
            pcbCerrar.TabStop = false;
            // 
            // pcbMinimizar
            // 
            pcbMinimizar.Cursor = Cursors.Hand;
            pcbMinimizar.Image = Properties.Resources.minimizar;
            pcbMinimizar.Location = new Point(841, 9);
            pcbMinimizar.Name = "pcbMinimizar";
            pcbMinimizar.Size = new Size(36, 32);
            pcbMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbMinimizar.TabIndex = 1;
            pcbMinimizar.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(55, 63);
            button1.Name = "button1";
            button1.Size = new Size(162, 37);
            button1.TabIndex = 2;
            button1.Text = "ASIGNAR MESA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblNombre);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(699, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(238, 507);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuBar;
            label1.Location = new Point(13, 62);
            label1.Name = "label1";
            label1.Size = new Size(165, 25);
            label1.TabIndex = 5;
            label1.Text = "Mesas atendidas: ";
            label1.Click += label1_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.DarkSlateGray;
            lblNombre.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.MenuBar;
            lblNombre.Location = new Point(13, 18);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(83, 25);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkSlateGray;
            button2.Location = new Point(487, 63);
            button2.Name = "button2";
            button2.Size = new Size(162, 37);
            button2.TabIndex = 5;
            button2.Text = "QUITAR MESA";
            button2.UseVisualStyleBackColor = true;
            // 
            // dgvMesas
            // 
            dgvMesas.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMesas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMesas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMesas.Columns.AddRange(new DataGridViewColumn[] { Mesa, Turno, cantPersonas, Propina });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMesas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMesas.EnableHeadersVisualStyles = false;
            dgvMesas.Location = new Point(73, 200);
            dgvMesas.Name = "dgvMesas";
            dgvMesas.RowTemplate.Height = 25;
            dgvMesas.Size = new Size(543, 207);
            dgvMesas.TabIndex = 6;
            // 
            // Mesa
            // 
            Mesa.HeaderText = "Mesa";
            Mesa.Name = "Mesa";
            // 
            // Turno
            // 
            Turno.HeaderText = "Turno";
            Turno.Name = "Turno";
            // 
            // cantPersonas
            // 
            cantPersonas.HeaderText = "Cantidad Personas";
            cantPersonas.Name = "cantPersonas";
            cantPersonas.Width = 205;
            // 
            // Propina
            // 
            Propina.HeaderText = "Propina";
            Propina.Name = "Propina";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(937, 564);
            Controls.Add(dgvMesas);
            Controls.Add(button2);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            Text = "Main";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbMinimizar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMesas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pcbCerrar;
        private PictureBox pcbMinimizar;
        private Button button1;
        private Panel panel2;
        private Button button2;
        private Label label1;
        private Label lblNombre;
        private DataGridView dgvMesas;
        private DataGridViewTextBoxColumn Mesa;
        private DataGridViewTextBoxColumn Turno;
        private DataGridViewTextBoxColumn cantPersonas;
        private DataGridViewTextBoxColumn Propina;
    }
}