namespace Registrate
{
    partial class FormRegistro
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
            grpIngreso = new GroupBox();
            numericUpDownEdad = new NumericUpDown();
            txbDireccion = new TextBox();
            txbNombre = new TextBox();
            lbEdad = new Label();
            lbDireccion = new Label();
            label1 = new Label();
            grpGenero = new GroupBox();
            rdbNoBinario = new RadioButton();
            rdbFemenino = new RadioButton();
            rdbMasculino = new RadioButton();
            grpCursos = new GroupBox();
            chkbJavaScript = new CheckBox();
            chkbCplus = new CheckBox();
            chkbCsharp = new CheckBox();
            listBoxPaises = new ListBox();
            lbPais = new Label();
            btnIngresar = new Button();
            grpIngreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdad).BeginInit();
            grpGenero.SuspendLayout();
            grpCursos.SuspendLayout();
            SuspendLayout();
            // 
            // grpIngreso
            // 
            grpIngreso.Controls.Add(numericUpDownEdad);
            grpIngreso.Controls.Add(txbDireccion);
            grpIngreso.Controls.Add(txbNombre);
            grpIngreso.Controls.Add(lbEdad);
            grpIngreso.Controls.Add(lbDireccion);
            grpIngreso.Controls.Add(label1);
            grpIngreso.Location = new Point(35, 30);
            grpIngreso.Name = "grpIngreso";
            grpIngreso.Size = new Size(213, 180);
            grpIngreso.TabIndex = 0;
            grpIngreso.TabStop = false;
            grpIngreso.Text = "Detalles del usuario";
            // 
            // numericUpDownEdad
            // 
            numericUpDownEdad.Location = new Point(107, 134);
            numericUpDownEdad.Name = "numericUpDownEdad";
            numericUpDownEdad.Size = new Size(100, 23);
            numericUpDownEdad.TabIndex = 10;
            numericUpDownEdad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txbDireccion
            // 
            txbDireccion.Location = new Point(107, 83);
            txbDireccion.Name = "txbDireccion";
            txbDireccion.Size = new Size(100, 23);
            txbDireccion.TabIndex = 9;
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(107, 36);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(100, 23);
            txbNombre.TabIndex = 8;
            // 
            // lbEdad
            // 
            lbEdad.AutoSize = true;
            lbEdad.Location = new Point(6, 136);
            lbEdad.Name = "lbEdad";
            lbEdad.Size = new Size(36, 15);
            lbEdad.TabIndex = 7;
            lbEdad.Text = "Edad:";
            // 
            // lbDireccion
            // 
            lbDireccion.AutoSize = true;
            lbDireccion.Location = new Point(6, 86);
            lbDireccion.Name = "lbDireccion";
            lbDireccion.Size = new Size(60, 15);
            lbDireccion.TabIndex = 6;
            lbDireccion.Text = "Direccion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 39);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre:";
            // 
            // grpGenero
            // 
            grpGenero.Controls.Add(rdbNoBinario);
            grpGenero.Controls.Add(rdbFemenino);
            grpGenero.Controls.Add(rdbMasculino);
            grpGenero.Location = new Point(370, 54);
            grpGenero.Name = "grpGenero";
            grpGenero.Size = new Size(155, 141);
            grpGenero.TabIndex = 1;
            grpGenero.TabStop = false;
            grpGenero.Text = "Genero";
            // 
            // rdbNoBinario
            // 
            rdbNoBinario.AutoSize = true;
            rdbNoBinario.Location = new Point(30, 108);
            rdbNoBinario.Name = "rdbNoBinario";
            rdbNoBinario.Size = new Size(81, 19);
            rdbNoBinario.TabIndex = 2;
            rdbNoBinario.TabStop = true;
            rdbNoBinario.Text = "No Binario";
            rdbNoBinario.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            rdbFemenino.AutoSize = true;
            rdbFemenino.Location = new Point(30, 63);
            rdbFemenino.Name = "rdbFemenino";
            rdbFemenino.Size = new Size(78, 19);
            rdbFemenino.TabIndex = 1;
            rdbFemenino.TabStop = true;
            rdbFemenino.Text = "Femenino";
            rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.Location = new Point(30, 22);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(80, 19);
            rdbMasculino.TabIndex = 0;
            rdbMasculino.TabStop = true;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // grpCursos
            // 
            grpCursos.Controls.Add(chkbJavaScript);
            grpCursos.Controls.Add(chkbCplus);
            grpCursos.Controls.Add(chkbCsharp);
            grpCursos.Location = new Point(370, 215);
            grpCursos.Name = "grpCursos";
            grpCursos.Size = new Size(155, 136);
            grpCursos.TabIndex = 2;
            grpCursos.TabStop = false;
            grpCursos.Text = "Cursos";
            // 
            // chkbJavaScript
            // 
            chkbJavaScript.AutoSize = true;
            chkbJavaScript.Location = new Point(30, 107);
            chkbJavaScript.Name = "chkbJavaScript";
            chkbJavaScript.Size = new Size(78, 19);
            chkbJavaScript.TabIndex = 2;
            chkbJavaScript.Text = "JavaScript";
            chkbJavaScript.UseVisualStyleBackColor = true;
            // 
            // chkbCplus
            // 
            chkbCplus.AutoSize = true;
            chkbCplus.Location = new Point(30, 64);
            chkbCplus.Name = "chkbCplus";
            chkbCplus.Size = new Size(50, 19);
            chkbCplus.TabIndex = 1;
            chkbCplus.Text = "C++";
            chkbCplus.UseVisualStyleBackColor = true;
            // 
            // chkbCsharp
            // 
            chkbCsharp.AutoSize = true;
            chkbCsharp.Location = new Point(30, 22);
            chkbCsharp.Name = "chkbCsharp";
            chkbCsharp.Size = new Size(41, 19);
            chkbCsharp.TabIndex = 0;
            chkbCsharp.Text = "C#";
            chkbCsharp.UseVisualStyleBackColor = true;
            // 
            // listBoxPaises
            // 
            listBoxPaises.FormattingEnabled = true;
            listBoxPaises.ItemHeight = 15;
            listBoxPaises.Location = new Point(25, 248);
            listBoxPaises.Name = "listBoxPaises";
            listBoxPaises.Size = new Size(233, 139);
            listBoxPaises.TabIndex = 3;
            // 
            // lbPais
            // 
            lbPais.AutoSize = true;
            lbPais.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbPais.Location = new Point(25, 226);
            lbPais.Name = "lbPais";
            lbPais.Size = new Size(34, 19);
            lbPais.TabIndex = 4;
            lbPais.Text = "Pais";
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.Location = new Point(400, 371);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(97, 32);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 415);
            Controls.Add(btnIngresar);
            Controls.Add(lbPais);
            Controls.Add(listBoxPaises);
            Controls.Add(grpCursos);
            Controls.Add(grpGenero);
            Controls.Add(grpIngreso);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormRegistro";
            Text = "Registro";
            Load += FormRegistro_Load;
            grpIngreso.ResumeLayout(false);
            grpIngreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdad).EndInit();
            grpGenero.ResumeLayout(false);
            grpGenero.PerformLayout();
            grpCursos.ResumeLayout(false);
            grpCursos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpIngreso;
        private GroupBox grpGenero;
        private GroupBox grpCursos;
        private ListBox listBoxPaises;
        private Label label1;
        private Label lbPais;
        private NumericUpDown numericUpDownEdad;
        private TextBox txbDireccion;
        private TextBox txbNombre;
        private Label lbEdad;
        private Label lbDireccion;
        private RadioButton rdbNoBinario;
        private RadioButton rdbFemenino;
        private RadioButton rdbMasculino;
        private CheckBox chkbJavaScript;
        private CheckBox chkbCplus;
        private CheckBox chkbCsharp;
        private Button btnIngresar;
    }
}