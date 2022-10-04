namespace Vista
{
    partial class FrmAltaMaterias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaMaterias));
            this.btn_materias_aceptar = new System.Windows.Forms.Button();
            this.btn_materias_cancelar = new System.Windows.Forms.Button();
            this.cb_altaMaterias_materia = new System.Windows.Forms.ComboBox();
            this.cb_altaMateria_profesor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_materias_aceptar
            // 
            this.btn_materias_aceptar.Location = new System.Drawing.Point(329, 237);
            this.btn_materias_aceptar.Name = "btn_materias_aceptar";
            this.btn_materias_aceptar.Size = new System.Drawing.Size(141, 78);
            this.btn_materias_aceptar.TabIndex = 0;
            this.btn_materias_aceptar.Text = "Aceptar";
            this.btn_materias_aceptar.UseVisualStyleBackColor = true;
            this.btn_materias_aceptar.Click += new System.EventHandler(this.btn_materias_aceptar_Click);
            // 
            // btn_materias_cancelar
            // 
            this.btn_materias_cancelar.Location = new System.Drawing.Point(12, 237);
            this.btn_materias_cancelar.Name = "btn_materias_cancelar";
            this.btn_materias_cancelar.Size = new System.Drawing.Size(141, 78);
            this.btn_materias_cancelar.TabIndex = 1;
            this.btn_materias_cancelar.Text = "Cancelar";
            this.btn_materias_cancelar.UseVisualStyleBackColor = true;
            this.btn_materias_cancelar.Click += new System.EventHandler(this.btn_materias_cancelar_Click);
            // 
            // cb_altaMaterias_materia
            // 
            this.cb_altaMaterias_materia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_altaMaterias_materia.FormattingEnabled = true;
            this.cb_altaMaterias_materia.Items.AddRange(new object[] {
            "Programacion_I",
            "Laboratorio_I",
            "Matematica",
            "Ingles_I",
            "Sis_Proc_Datos",
            "Programacion_II",
            "Laboratorio_II",
            "Estadistica",
            "Ingles_II",
            "Arq_Sist_Operat",
            "Metodologia",
            "Programacion_III",
            "Laboratorio_III",
            "Ingles_III"});
            this.cb_altaMaterias_materia.Location = new System.Drawing.Point(137, 43);
            this.cb_altaMaterias_materia.Name = "cb_altaMaterias_materia";
            this.cb_altaMaterias_materia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_altaMaterias_materia.Size = new System.Drawing.Size(170, 23);
            this.cb_altaMaterias_materia.TabIndex = 2;
            // 
            // cb_altaMateria_profesor
            // 
            this.cb_altaMateria_profesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_altaMateria_profesor.FormattingEnabled = true;
            this.cb_altaMateria_profesor.Location = new System.Drawing.Point(137, 117);
            this.cb_altaMateria_profesor.Name = "cb_altaMateria_profesor";
            this.cb_altaMateria_profesor.Size = new System.Drawing.Size(170, 23);
            this.cb_altaMateria_profesor.TabIndex = 3;
            this.cb_altaMateria_profesor.Tag = "";
            // 
            // FrmAltaMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 324);
            this.Controls.Add(this.cb_altaMateria_profesor);
            this.Controls.Add(this.cb_altaMaterias_materia);
            this.Controls.Add(this.btn_materias_cancelar);
            this.Controls.Add(this.btn_materias_aceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAltaMaterias";
            this.Text = "Alta Materias";
            this.Load += new System.EventHandler(this.FrmAltaMaterias_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_materias_aceptar;
        private System.Windows.Forms.Button btn_materias_cancelar;
        private System.Windows.Forms.ComboBox cb_altaMaterias_materia;
        private System.Windows.Forms.ComboBox cb_altaMateria_profesor;
    }
}