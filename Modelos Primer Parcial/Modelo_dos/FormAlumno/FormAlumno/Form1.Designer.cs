namespace FormAlumno
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
            txtDni = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            grpAltaAlumno = new GroupBox();
            btnCrearAlumno = new Button();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lstAlumnosCreados = new ListBox();
            lstAlumnosInscriptosLaboratorio = new ListBox();
            lstAlumnosInscriptosProgramacion = new ListBox();
            grpAsignaMateria = new GroupBox();
            lblMateria = new Label();
            cmbMaterias = new ComboBox();
            btnAsignar = new Button();
            lblAlumnosCreados = new Label();
            lblInscriptosProgra = new Label();
            lblInscriptosLabo = new Label();
            grpAltaAlumno.SuspendLayout();
            grpAsignaMateria.SuspendLayout();
            SuspendLayout();
            // 
            // txtDni
            // 
            txtDni.Location = new Point(27, 46);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(165, 46);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(299, 46);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            // 
            // grpAltaAlumno
            // 
            grpAltaAlumno.Controls.Add(btnCrearAlumno);
            grpAltaAlumno.Controls.Add(lblNombre);
            grpAltaAlumno.Controls.Add(lblApellido);
            grpAltaAlumno.Controls.Add(lblDni);
            grpAltaAlumno.Controls.Add(txtDni);
            grpAltaAlumno.Controls.Add(txtNombre);
            grpAltaAlumno.Controls.Add(txtApellido);
            grpAltaAlumno.Location = new Point(150, 30);
            grpAltaAlumno.Name = "grpAltaAlumno";
            grpAltaAlumno.Size = new Size(420, 155);
            grpAltaAlumno.TabIndex = 3;
            grpAltaAlumno.TabStop = false;
            grpAltaAlumno.Text = "groupBox1";
            // 
            // btnCrearAlumno
            // 
            btnCrearAlumno.Location = new Point(151, 126);
            btnCrearAlumno.Name = "btnCrearAlumno";
            btnCrearAlumno.Size = new Size(145, 23);
            btnCrearAlumno.TabIndex = 6;
            btnCrearAlumno.Text = "Crear Alumno";
            btnCrearAlumno.UseVisualStyleBackColor = true;
            btnCrearAlumno.Click += btnCrearAlumno_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(327, 28);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(59, 15);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "NOMBRE:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(186, 28);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(63, 15);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "APELLIDO:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(53, 28);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(30, 15);
            lblDni.TabIndex = 3;
            lblDni.Text = "DNI:";
            // 
            // lstAlumnosCreados
            // 
            lstAlumnosCreados.FormattingEnabled = true;
            lstAlumnosCreados.ItemHeight = 15;
            lstAlumnosCreados.Location = new Point(12, 271);
            lstAlumnosCreados.Name = "lstAlumnosCreados";
            lstAlumnosCreados.Size = new Size(149, 244);
            lstAlumnosCreados.TabIndex = 4;
            // 
            // lstAlumnosInscriptosLaboratorio
            // 
            lstAlumnosInscriptosLaboratorio.FormattingEnabled = true;
            lstAlumnosInscriptosLaboratorio.ItemHeight = 15;
            lstAlumnosInscriptosLaboratorio.Location = new Point(387, 271);
            lstAlumnosInscriptosLaboratorio.Name = "lstAlumnosInscriptosLaboratorio";
            lstAlumnosInscriptosLaboratorio.Size = new Size(149, 244);
            lstAlumnosInscriptosLaboratorio.TabIndex = 5;
            // 
            // lstAlumnosInscriptosProgramacion
            // 
            lstAlumnosInscriptosProgramacion.FormattingEnabled = true;
            lstAlumnosInscriptosProgramacion.ItemHeight = 15;
            lstAlumnosInscriptosProgramacion.Location = new Point(558, 271);
            lstAlumnosInscriptosProgramacion.Name = "lstAlumnosInscriptosProgramacion";
            lstAlumnosInscriptosProgramacion.Size = new Size(149, 244);
            lstAlumnosInscriptosProgramacion.TabIndex = 6;
            // 
            // grpAsignaMateria
            // 
            grpAsignaMateria.Controls.Add(lblMateria);
            grpAsignaMateria.Controls.Add(cmbMaterias);
            grpAsignaMateria.Controls.Add(btnAsignar);
            grpAsignaMateria.Location = new Point(194, 302);
            grpAsignaMateria.Name = "grpAsignaMateria";
            grpAsignaMateria.Size = new Size(168, 170);
            grpAsignaMateria.TabIndex = 7;
            grpAsignaMateria.TabStop = false;
            grpAsignaMateria.Text = "Asignar Materia";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(62, 36);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(55, 15);
            lblMateria.TabIndex = 7;
            lblMateria.Text = "MATERIA";
            // 
            // cmbMaterias
            // 
            cmbMaterias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(28, 54);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(118, 23);
            cmbMaterias.TabIndex = 8;
            // 
            // btnAsignar
            // 
            btnAsignar.Location = new Point(28, 126);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(118, 38);
            btnAsignar.TabIndex = 7;
            btnAsignar.Text = "Asignar al alumno seleccionado";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // lblAlumnosCreados
            // 
            lblAlumnosCreados.AutoSize = true;
            lblAlumnosCreados.Location = new Point(26, 253);
            lblAlumnosCreados.Name = "lblAlumnosCreados";
            lblAlumnosCreados.Size = new Size(101, 15);
            lblAlumnosCreados.TabIndex = 9;
            lblAlumnosCreados.Text = "Alumnos Creados";
            // 
            // lblInscriptosProgra
            // 
            lblInscriptosProgra.AutoSize = true;
            lblInscriptosProgra.Location = new Point(407, 253);
            lblInscriptosProgra.Name = "lblInscriptosProgra";
            lblInscriptosProgra.Size = new Size(99, 15);
            lblInscriptosProgra.TabIndex = 10;
            lblInscriptosProgra.Text = "Inscriptos Progra:";
            // 
            // lblInscriptosLabo
            // 
            lblInscriptosLabo.AutoSize = true;
            lblInscriptosLabo.Location = new Point(585, 253);
            lblInscriptosLabo.Name = "lblInscriptosLabo";
            lblInscriptosLabo.Size = new Size(90, 15);
            lblInscriptosLabo.TabIndex = 11;
            lblInscriptosLabo.Text = "Inscriptos Labo:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 527);
            Controls.Add(lblInscriptosLabo);
            Controls.Add(lblInscriptosProgra);
            Controls.Add(lblAlumnosCreados);
            Controls.Add(grpAsignaMateria);
            Controls.Add(lstAlumnosInscriptosProgramacion);
            Controls.Add(lstAlumnosInscriptosLaboratorio);
            Controls.Add(lstAlumnosCreados);
            Controls.Add(grpAltaAlumno);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            grpAltaAlumno.ResumeLayout(false);
            grpAltaAlumno.PerformLayout();
            grpAsignaMateria.ResumeLayout(false);
            grpAsignaMateria.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private GroupBox grpAltaAlumno;
        private Button btnCrearAlumno;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private ListBox lstAlumnosCreados;
        private ListBox lstAlumnosInscriptosLaboratorio;
        private ListBox lstAlumnosInscriptosProgramacion;
        private GroupBox grpAsignaMateria;
        private Label lblMateria;
        private ComboBox cmbMaterias;
        private Button btnAsignar;
        private Label lblAlumnosCreados;
        private Label lblInscriptosProgra;
        private Label lblInscriptosLabo;
    }
}