namespace MiPrimerCrud
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLeer = new Button();
            label1 = new Label();
            label2 = new Label();
            lstbPersonas = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(45, 159);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(196, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(45, 242);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(196, 23);
            txtApellido.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(35, 12);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(113, 38);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(186, 12);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(113, 38);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(337, 12);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(113, 38);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(485, 12);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(113, 38);
            btnLeer.TabIndex = 5;
            btnLeer.Text = "Leer";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 129);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 212);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 7;
            label2.Text = "Apellido";
            // 
            // lstbPersonas
            // 
            lstbPersonas.FormattingEnabled = true;
            lstbPersonas.ItemHeight = 15;
            lstbPersonas.Location = new Point(303, 119);
            lstbPersonas.Name = "lstbPersonas";
            lstbPersonas.Size = new Size(295, 274);
            lstbPersonas.TabIndex = 8;
            lstbPersonas.DoubleClick += lstbPersonas_DoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(422, 101);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 9;
            label3.Text = "Personas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 419);
            Controls.Add(label3);
            Controls.Add(lstbPersonas);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLeer);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLeer;
        private Label label1;
        private Label label2;
        private ListBox lstbPersonas;
        private Label label3;
    }
}