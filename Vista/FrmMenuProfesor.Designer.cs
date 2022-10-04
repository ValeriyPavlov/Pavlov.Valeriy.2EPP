namespace Vista
{
    partial class FrmMenuProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuProfesor));
            this.btn_menuProf_salir = new System.Windows.Forms.Button();
            this.cb_menuProfe_materia = new System.Windows.Forms.ComboBox();
            this.lbl_menuProfe_seleccionMateria = new System.Windows.Forms.Label();
            this.txb_dia_examen = new System.Windows.Forms.TextBox();
            this.txb_mes_examen = new System.Windows.Forms.TextBox();
            this.lbl_fecha_examen = new System.Windows.Forms.Label();
            this.btn_crear_examen = new System.Windows.Forms.Button();
            this.cb_seleccionar_alumno = new System.Windows.Forms.ComboBox();
            this.cb_seleccionar_nota = new System.Windows.Forms.ComboBox();
            this.btn_evaluarAlumno = new System.Windows.Forms.Button();
            this.lbl_notaActual = new System.Windows.Forms.Label();
            this.lbl_notaDelAlumno = new System.Windows.Forms.Label();
            this.lbl_fechaExamen = new System.Windows.Forms.Label();
            this.lbl_fechaActual_examen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_menuProf_salir
            // 
            this.btn_menuProf_salir.Location = new System.Drawing.Point(12, 448);
            this.btn_menuProf_salir.Name = "btn_menuProf_salir";
            this.btn_menuProf_salir.Size = new System.Drawing.Size(114, 57);
            this.btn_menuProf_salir.TabIndex = 0;
            this.btn_menuProf_salir.Text = "Volver al Login";
            this.btn_menuProf_salir.UseVisualStyleBackColor = true;
            this.btn_menuProf_salir.Click += new System.EventHandler(this.btn_menuProf_salir_Click);
            // 
            // cb_menuProfe_materia
            // 
            this.cb_menuProfe_materia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_menuProfe_materia.FormattingEnabled = true;
            this.cb_menuProfe_materia.Location = new System.Drawing.Point(27, 35);
            this.cb_menuProfe_materia.Name = "cb_menuProfe_materia";
            this.cb_menuProfe_materia.Size = new System.Drawing.Size(121, 23);
            this.cb_menuProfe_materia.TabIndex = 2;
            this.cb_menuProfe_materia.SelectedIndexChanged += new System.EventHandler(this.cb_menuProfe_materia_SelectedIndexChanged);
            // 
            // lbl_menuProfe_seleccionMateria
            // 
            this.lbl_menuProfe_seleccionMateria.AutoSize = true;
            this.lbl_menuProfe_seleccionMateria.Location = new System.Drawing.Point(27, 17);
            this.lbl_menuProfe_seleccionMateria.Name = "lbl_menuProfe_seleccionMateria";
            this.lbl_menuProfe_seleccionMateria.Size = new System.Drawing.Size(109, 15);
            this.lbl_menuProfe_seleccionMateria.TabIndex = 3;
            this.lbl_menuProfe_seleccionMateria.Text = "Seleccione Materia:";
            // 
            // txb_dia_examen
            // 
            this.txb_dia_examen.Location = new System.Drawing.Point(27, 97);
            this.txb_dia_examen.Name = "txb_dia_examen";
            this.txb_dia_examen.Size = new System.Drawing.Size(52, 23);
            this.txb_dia_examen.TabIndex = 4;
            // 
            // txb_mes_examen
            // 
            this.txb_mes_examen.Location = new System.Drawing.Point(85, 97);
            this.txb_mes_examen.Name = "txb_mes_examen";
            this.txb_mes_examen.Size = new System.Drawing.Size(52, 23);
            this.txb_mes_examen.TabIndex = 5;
            // 
            // lbl_fecha_examen
            // 
            this.lbl_fecha_examen.AutoSize = true;
            this.lbl_fecha_examen.Location = new System.Drawing.Point(27, 70);
            this.lbl_fecha_examen.Name = "lbl_fecha_examen";
            this.lbl_fecha_examen.Size = new System.Drawing.Size(166, 15);
            this.lbl_fecha_examen.TabIndex = 6;
            this.lbl_fecha_examen.Text = "Ingrese Dia y Mes del Examen:";
            // 
            // btn_crear_examen
            // 
            this.btn_crear_examen.Location = new System.Drawing.Point(212, 37);
            this.btn_crear_examen.Name = "btn_crear_examen";
            this.btn_crear_examen.Size = new System.Drawing.Size(91, 80);
            this.btn_crear_examen.TabIndex = 7;
            this.btn_crear_examen.Text = "Crear Examen";
            this.btn_crear_examen.UseVisualStyleBackColor = true;
            this.btn_crear_examen.Click += new System.EventHandler(this.btn_crear_examen_Click);
            // 
            // cb_seleccionar_alumno
            // 
            this.cb_seleccionar_alumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_seleccionar_alumno.FormattingEnabled = true;
            this.cb_seleccionar_alumno.Location = new System.Drawing.Point(34, 260);
            this.cb_seleccionar_alumno.Name = "cb_seleccionar_alumno";
            this.cb_seleccionar_alumno.Size = new System.Drawing.Size(121, 23);
            this.cb_seleccionar_alumno.TabIndex = 8;
            this.cb_seleccionar_alumno.SelectedIndexChanged += new System.EventHandler(this.cb_seleccionar_alumno_SelectedIndexChanged);
            // 
            // cb_seleccionar_nota
            // 
            this.cb_seleccionar_nota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_seleccionar_nota.FormattingEnabled = true;
            this.cb_seleccionar_nota.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cb_seleccionar_nota.Location = new System.Drawing.Point(34, 311);
            this.cb_seleccionar_nota.Name = "cb_seleccionar_nota";
            this.cb_seleccionar_nota.Size = new System.Drawing.Size(121, 23);
            this.cb_seleccionar_nota.TabIndex = 9;
            // 
            // btn_evaluarAlumno
            // 
            this.btn_evaluarAlumno.Location = new System.Drawing.Point(212, 260);
            this.btn_evaluarAlumno.Name = "btn_evaluarAlumno";
            this.btn_evaluarAlumno.Size = new System.Drawing.Size(110, 79);
            this.btn_evaluarAlumno.TabIndex = 10;
            this.btn_evaluarAlumno.Text = "Evaluar Alumno";
            this.btn_evaluarAlumno.UseVisualStyleBackColor = true;
            this.btn_evaluarAlumno.Click += new System.EventHandler(this.btn_evaluarAlumno_Click);
            // 
            // lbl_notaActual
            // 
            this.lbl_notaActual.AutoSize = true;
            this.lbl_notaActual.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_notaActual.Location = new System.Drawing.Point(331, 356);
            this.lbl_notaActual.Name = "lbl_notaActual";
            this.lbl_notaActual.Size = new System.Drawing.Size(0, 30);
            this.lbl_notaActual.TabIndex = 11;
            // 
            // lbl_notaDelAlumno
            // 
            this.lbl_notaDelAlumno.AutoSize = true;
            this.lbl_notaDelAlumno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_notaDelAlumno.Location = new System.Drawing.Point(27, 365);
            this.lbl_notaDelAlumno.Name = "lbl_notaDelAlumno";
            this.lbl_notaDelAlumno.Size = new System.Drawing.Size(298, 21);
            this.lbl_notaDelAlumno.TabIndex = 12;
            this.lbl_notaDelAlumno.Text = "Nota actual del alumno seleccionado:";
            // 
            // lbl_fechaExamen
            // 
            this.lbl_fechaExamen.AutoSize = true;
            this.lbl_fechaExamen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_fechaExamen.Location = new System.Drawing.Point(27, 150);
            this.lbl_fechaExamen.Name = "lbl_fechaExamen";
            this.lbl_fechaExamen.Size = new System.Drawing.Size(155, 21);
            this.lbl_fechaExamen.TabIndex = 13;
            this.lbl_fechaExamen.Text = "Fecha del examen: ";
            // 
            // lbl_fechaActual_examen
            // 
            this.lbl_fechaActual_examen.AutoSize = true;
            this.lbl_fechaActual_examen.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_fechaActual_examen.Location = new System.Drawing.Point(188, 143);
            this.lbl_fechaActual_examen.Name = "lbl_fechaActual_examen";
            this.lbl_fechaActual_examen.Size = new System.Drawing.Size(0, 30);
            this.lbl_fechaActual_examen.TabIndex = 14;
            // 
            // FrmMenuProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 516);
            this.Controls.Add(this.lbl_fechaActual_examen);
            this.Controls.Add(this.lbl_fechaExamen);
            this.Controls.Add(this.lbl_notaDelAlumno);
            this.Controls.Add(this.lbl_notaActual);
            this.Controls.Add(this.btn_evaluarAlumno);
            this.Controls.Add(this.cb_seleccionar_nota);
            this.Controls.Add(this.cb_seleccionar_alumno);
            this.Controls.Add(this.btn_crear_examen);
            this.Controls.Add(this.lbl_fecha_examen);
            this.Controls.Add(this.txb_mes_examen);
            this.Controls.Add(this.txb_dia_examen);
            this.Controls.Add(this.lbl_menuProfe_seleccionMateria);
            this.Controls.Add(this.cb_menuProfe_materia);
            this.Controls.Add(this.btn_menuProf_salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuProfesor";
            this.Text = "Menu Profesor";
            this.Load += new System.EventHandler(this.FrmMenuProfesor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_menuProf_salir;
        private System.Windows.Forms.ComboBox cb_menuProfe_materia;
        private System.Windows.Forms.Label lbl_menuProfe_seleccionMateria;
        private System.Windows.Forms.TextBox txb_dia_examen;
        private System.Windows.Forms.TextBox txb_mes_examen;
        private System.Windows.Forms.Label lbl_fecha_examen;
        private System.Windows.Forms.Button btn_crear_examen;
        private System.Windows.Forms.ComboBox cb_seleccionar_alumno;
        private System.Windows.Forms.ComboBox cb_seleccionar_nota;
        private System.Windows.Forms.Button btn_evaluarAlumno;
        private System.Windows.Forms.Label lbl_notaActual;
        private System.Windows.Forms.Label lbl_notaDelAlumno;
        private System.Windows.Forms.Label lbl_fechaExamen;
        private System.Windows.Forms.Label lbl_fechaActual_examen;
    }
}