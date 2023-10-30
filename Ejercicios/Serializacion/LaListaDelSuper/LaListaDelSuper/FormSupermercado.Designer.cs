namespace LaListaDelSuper
{
    partial class FormSupermercado
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
            lstObjetos = new ListBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            toolTip1 = new ToolTip(components);
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lstObjetos
            // 
            lstObjetos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lstObjetos.FormattingEnabled = true;
            lstObjetos.ItemHeight = 15;
            lstObjetos.Location = new Point(12, 12);
            lstObjetos.Name = "lstObjetos";
            lstObjetos.Size = new Size(378, 454);
            lstObjetos.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(405, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(58, 48);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "+";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(405, 88);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(58, 48);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "-";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModificar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.Location = new Point(405, 164);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(58, 48);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "M";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(405, 237);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(58, 48);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "S";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FormSupermercado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 472);
            Controls.Add(btnGuardar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(lstObjetos);
            Name = "FormSupermercado";
            Text = "Lista del supermercado";
            Load += FormSupermercado_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstObjetos;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
        private ToolTip toolTip1;
        private Button btnGuardar;
    }
}