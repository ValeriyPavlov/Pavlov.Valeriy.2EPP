namespace Vista
{
    partial class FrmMenuAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuAlumno));
            this.btn_menuAlumno_salir = new System.Windows.Forms.Button();
            this.dgv_menuAlumno_materias_disponibles = new System.Windows.Forms.DataGridView();
            this.lbl_materiasDisponibles = new System.Windows.Forms.Label();
            this.lbl_materiasInscriptas = new System.Windows.Forms.Label();
            this.btn_menuAlumno_inscribirse = new System.Windows.Forms.Button();
            this.txb_menuAlumno_Inscripcion = new System.Windows.Forms.TextBox();
            this.lbl_menuAlumno_idMateria = new System.Windows.Forms.Label();
            this.dgv_menuAlumno_inscripcion = new System.Windows.Forms.DataGridView();
            this.btn_menuAlumno_asistencia = new System.Windows.Forms.Button();
            this.cb_menuAlumno_asistencia = new System.Windows.Forms.ComboBox();
            this.dgv_materiasAprobadas = new System.Windows.Forms.DataGridView();
            this.lbl_materiasAprobadas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menuAlumno_materias_disponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menuAlumno_inscripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materiasAprobadas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_menuAlumno_salir
            // 
            this.btn_menuAlumno_salir.Location = new System.Drawing.Point(12, 753);
            this.btn_menuAlumno_salir.Name = "btn_menuAlumno_salir";
            this.btn_menuAlumno_salir.Size = new System.Drawing.Size(75, 71);
            this.btn_menuAlumno_salir.TabIndex = 0;
            this.btn_menuAlumno_salir.Text = "Volver al Login";
            this.btn_menuAlumno_salir.UseVisualStyleBackColor = true;
            this.btn_menuAlumno_salir.Click += new System.EventHandler(this.btn_menuAlumno_salir_Click);
            // 
            // dgv_menuAlumno_materias_disponibles
            // 
            this.dgv_menuAlumno_materias_disponibles.AllowUserToAddRows = false;
            this.dgv_menuAlumno_materias_disponibles.AllowUserToDeleteRows = false;
            this.dgv_menuAlumno_materias_disponibles.AllowUserToOrderColumns = true;
            this.dgv_menuAlumno_materias_disponibles.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_menuAlumno_materias_disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_menuAlumno_materias_disponibles.Location = new System.Drawing.Point(51, 50);
            this.dgv_menuAlumno_materias_disponibles.Name = "dgv_menuAlumno_materias_disponibles";
            this.dgv_menuAlumno_materias_disponibles.ReadOnly = true;
            this.dgv_menuAlumno_materias_disponibles.RowTemplate.Height = 25;
            this.dgv_menuAlumno_materias_disponibles.Size = new System.Drawing.Size(631, 196);
            this.dgv_menuAlumno_materias_disponibles.TabIndex = 1;
            // 
            // lbl_materiasDisponibles
            // 
            this.lbl_materiasDisponibles.AutoSize = true;
            this.lbl_materiasDisponibles.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_materiasDisponibles.Location = new System.Drawing.Point(51, 19);
            this.lbl_materiasDisponibles.Name = "lbl_materiasDisponibles";
            this.lbl_materiasDisponibles.Size = new System.Drawing.Size(198, 28);
            this.lbl_materiasDisponibles.TabIndex = 3;
            this.lbl_materiasDisponibles.Text = "Materias Disponibles:";
            // 
            // lbl_materiasInscriptas
            // 
            this.lbl_materiasInscriptas.AutoSize = true;
            this.lbl_materiasInscriptas.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_materiasInscriptas.Location = new System.Drawing.Point(51, 249);
            this.lbl_materiasInscriptas.Name = "lbl_materiasInscriptas";
            this.lbl_materiasInscriptas.Size = new System.Drawing.Size(172, 28);
            this.lbl_materiasInscriptas.TabIndex = 4;
            this.lbl_materiasInscriptas.Text = "Materias Inscripto:";
            // 
            // btn_menuAlumno_inscribirse
            // 
            this.btn_menuAlumno_inscribirse.Location = new System.Drawing.Point(318, 439);
            this.btn_menuAlumno_inscribirse.Name = "btn_menuAlumno_inscribirse";
            this.btn_menuAlumno_inscribirse.Size = new System.Drawing.Size(89, 72);
            this.btn_menuAlumno_inscribirse.TabIndex = 5;
            this.btn_menuAlumno_inscribirse.Text = "Inscribirse";
            this.btn_menuAlumno_inscribirse.UseVisualStyleBackColor = true;
            this.btn_menuAlumno_inscribirse.Click += new System.EventHandler(this.btn_menuAlumno_inscribirse_Click);
            // 
            // txb_menuAlumno_Inscripcion
            // 
            this.txb_menuAlumno_Inscripcion.Location = new System.Drawing.Point(318, 398);
            this.txb_menuAlumno_Inscripcion.Name = "txb_menuAlumno_Inscripcion";
            this.txb_menuAlumno_Inscripcion.Size = new System.Drawing.Size(100, 23);
            this.txb_menuAlumno_Inscripcion.TabIndex = 6;
            // 
            // lbl_menuAlumno_idMateria
            // 
            this.lbl_menuAlumno_idMateria.AutoSize = true;
            this.lbl_menuAlumno_idMateria.Location = new System.Drawing.Point(102, 406);
            this.lbl_menuAlumno_idMateria.Name = "lbl_menuAlumno_idMateria";
            this.lbl_menuAlumno_idMateria.Size = new System.Drawing.Size(210, 15);
            this.lbl_menuAlumno_idMateria.TabIndex = 7;
            this.lbl_menuAlumno_idMateria.Text = "Ingrese el ID de la materia a inscribirse:";
            // 
            // dgv_menuAlumno_inscripcion
            // 
            this.dgv_menuAlumno_inscripcion.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_menuAlumno_inscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_menuAlumno_inscripcion.Location = new System.Drawing.Point(51, 280);
            this.dgv_menuAlumno_inscripcion.Name = "dgv_menuAlumno_inscripcion";
            this.dgv_menuAlumno_inscripcion.RowTemplate.Height = 25;
            this.dgv_menuAlumno_inscripcion.Size = new System.Drawing.Size(631, 107);
            this.dgv_menuAlumno_inscripcion.TabIndex = 8;
            // 
            // btn_menuAlumno_asistencia
            // 
            this.btn_menuAlumno_asistencia.Location = new System.Drawing.Point(552, 439);
            this.btn_menuAlumno_asistencia.Name = "btn_menuAlumno_asistencia";
            this.btn_menuAlumno_asistencia.Size = new System.Drawing.Size(95, 72);
            this.btn_menuAlumno_asistencia.TabIndex = 9;
            this.btn_menuAlumno_asistencia.Text = "Dar Asistencia";
            this.btn_menuAlumno_asistencia.UseVisualStyleBackColor = true;
            this.btn_menuAlumno_asistencia.Click += new System.EventHandler(this.btn_menuAlumno_asistencia_Click);
            // 
            // cb_menuAlumno_asistencia
            // 
            this.cb_menuAlumno_asistencia.FormattingEnabled = true;
            this.cb_menuAlumno_asistencia.Location = new System.Drawing.Point(538, 398);
            this.cb_menuAlumno_asistencia.Name = "cb_menuAlumno_asistencia";
            this.cb_menuAlumno_asistencia.Size = new System.Drawing.Size(121, 23);
            this.cb_menuAlumno_asistencia.TabIndex = 10;
            // 
            // dgv_materiasAprobadas
            // 
            this.dgv_materiasAprobadas.AllowUserToAddRows = false;
            this.dgv_materiasAprobadas.AllowUserToDeleteRows = false;
            this.dgv_materiasAprobadas.AllowUserToOrderColumns = true;
            this.dgv_materiasAprobadas.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_materiasAprobadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_materiasAprobadas.Location = new System.Drawing.Point(51, 597);
            this.dgv_materiasAprobadas.Name = "dgv_materiasAprobadas";
            this.dgv_materiasAprobadas.ReadOnly = true;
            this.dgv_materiasAprobadas.RowTemplate.Height = 25;
            this.dgv_materiasAprobadas.Size = new System.Drawing.Size(631, 150);
            this.dgv_materiasAprobadas.TabIndex = 11;
            // 
            // lbl_materiasAprobadas
            // 
            this.lbl_materiasAprobadas.AutoSize = true;
            this.lbl_materiasAprobadas.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_materiasAprobadas.Location = new System.Drawing.Point(51, 566);
            this.lbl_materiasAprobadas.Name = "lbl_materiasAprobadas";
            this.lbl_materiasAprobadas.Size = new System.Drawing.Size(192, 28);
            this.lbl_materiasAprobadas.TabIndex = 12;
            this.lbl_materiasAprobadas.Text = "Materias Aprobadas:";
            // 
            // FrmMenuAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(737, 836);
            this.Controls.Add(this.lbl_materiasAprobadas);
            this.Controls.Add(this.dgv_materiasAprobadas);
            this.Controls.Add(this.cb_menuAlumno_asistencia);
            this.Controls.Add(this.btn_menuAlumno_asistencia);
            this.Controls.Add(this.dgv_menuAlumno_inscripcion);
            this.Controls.Add(this.lbl_menuAlumno_idMateria);
            this.Controls.Add(this.txb_menuAlumno_Inscripcion);
            this.Controls.Add(this.btn_menuAlumno_inscribirse);
            this.Controls.Add(this.lbl_materiasInscriptas);
            this.Controls.Add(this.lbl_materiasDisponibles);
            this.Controls.Add(this.dgv_menuAlumno_materias_disponibles);
            this.Controls.Add(this.btn_menuAlumno_salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuAlumno";
            this.Text = "Menu Alumno";
            this.Load += new System.EventHandler(this.FrmMenuAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menuAlumno_materias_disponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menuAlumno_inscripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materiasAprobadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_menuAlumno_salir;
        private System.Windows.Forms.DataGridView dgv_menuAlumno_materias_disponibles;
        private System.Windows.Forms.Label lbl_materiasDisponibles;
        private System.Windows.Forms.Label lbl_materiasInscriptas;
        private System.Windows.Forms.Button btn_menuAlumno_inscribirse;
        private System.Windows.Forms.TextBox txb_menuAlumno_Inscripcion;
        private System.Windows.Forms.Label lbl_menuAlumno_idMateria;
        private System.Windows.Forms.DataGridView dgv_menuAlumno_inscripcion;
        private System.Windows.Forms.Button btn_menuAlumno_asistencia;
        private System.Windows.Forms.ComboBox cb_menuAlumno_asistencia;
        private System.Windows.Forms.DataGridView dgv_materiasAprobadas;
        private System.Windows.Forms.Label lbl_materiasAprobadas;
    }
}