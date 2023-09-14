namespace HolaWindows
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
            txbNombre = new TextBox();
            txbApellido = new TextBox();
            lbNombre = new Label();
            label1 = new Label();
            btnSaludar = new Button();
            SuspendLayout();
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(40, 82);
            txbNombre.Name = "txbNombre";
            txbNombre.PlaceholderText = "Nombre";
            txbNombre.Size = new Size(125, 23);
            txbNombre.TabIndex = 0;
            // 
            // txbApellido
            // 
            txbApellido.Location = new Point(217, 82);
            txbApellido.Name = "txbApellido";
            txbApellido.PlaceholderText = "Apellido";
            txbApellido.Size = new Size(125, 23);
            txbApellido.TabIndex = 1;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbNombre.Location = new Point(45, 39);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(88, 25);
            lbNombre.TabIndex = 2;
            lbNombre.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(217, 39);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 3;
            label1.Text = "Apellido";
            // 
            // btnSaludar
            // 
            btnSaludar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaludar.Location = new Point(331, 275);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(110, 32);
            btnSaludar.TabIndex = 4;
            btnSaludar.Text = "Saludar";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += btnSaludar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 347);
            Controls.Add(btnSaludar);
            Controls.Add(label1);
            Controls.Add(lbNombre);
            Controls.Add(txbApellido);
            Controls.Add(txbNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbNombre;
        private TextBox txbApellido;
        private Label lbNombre;
        private Label label1;
        private Button btnSaludar;
    }
}