namespace Vista
{
    partial class FrmMenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuAdmin));
            this.btn_alta_usuarios = new System.Windows.Forms.Button();
            this.btn_menuAdmin_salir = new System.Windows.Forms.Button();
            this.dgv_admin_usuarios = new System.Windows.Forms.DataGridView();
            this.btn_crear_materias = new System.Windows.Forms.Button();
            this.dgv_admin_materias = new System.Windows.Forms.DataGridView();
            this.cb_menuAdmin_seleccionAlumno = new System.Windows.Forms.ComboBox();
            this.lbl_menuAdmin_seleccionAlumno = new System.Windows.Forms.Label();
            this.btn_menuAdmin_estadoAlumno = new System.Windows.Forms.Button();
            this.lbl_menuAdmin_materia = new System.Windows.Forms.Label();
            this.cb_menuAdmin_materias = new System.Windows.Forms.ComboBox();
            this.dgv_estadoMateriasAlumno = new System.Windows.Forms.DataGridView();
            this.lbl_estadoAlumno = new System.Windows.Forms.Label();
            this.lbl_estadoActualA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin_usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin_materias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estadoMateriasAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_alta_usuarios
            // 
            this.btn_alta_usuarios.Location = new System.Drawing.Point(26, 23);
            this.btn_alta_usuarios.Name = "btn_alta_usuarios";
            this.btn_alta_usuarios.Size = new System.Drawing.Size(110, 52);
            this.btn_alta_usuarios.TabIndex = 1;
            this.btn_alta_usuarios.Text = "Alta Usuarios";
            this.btn_alta_usuarios.UseVisualStyleBackColor = true;
            this.btn_alta_usuarios.Click += new System.EventHandler(this.btn_alta_usuarios_Click);
            // 
            // btn_menuAdmin_salir
            // 
            this.btn_menuAdmin_salir.Location = new System.Drawing.Point(12, 598);
            this.btn_menuAdmin_salir.Name = "btn_menuAdmin_salir";
            this.btn_menuAdmin_salir.Size = new System.Drawing.Size(75, 63);
            this.btn_menuAdmin_salir.TabIndex = 2;
            this.btn_menuAdmin_salir.Text = "Volver al Login";
            this.btn_menuAdmin_salir.UseVisualStyleBackColor = true;
            this.btn_menuAdmin_salir.Click += new System.EventHandler(this.btn_menuAdmin_salir_Click);
            // 
            // dgv_admin_usuarios
            // 
            this.dgv_admin_usuarios.AllowUserToDeleteRows = false;
            this.dgv_admin_usuarios.AllowUserToOrderColumns = true;
            this.dgv_admin_usuarios.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_admin_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admin_usuarios.Location = new System.Drawing.Point(142, 23);
            this.dgv_admin_usuarios.Name = "dgv_admin_usuarios";
            this.dgv_admin_usuarios.ReadOnly = true;
            this.dgv_admin_usuarios.RowTemplate.Height = 25;
            this.dgv_admin_usuarios.Size = new System.Drawing.Size(627, 201);
            this.dgv_admin_usuarios.TabIndex = 3;
            // 
            // btn_crear_materias
            // 
            this.btn_crear_materias.Location = new System.Drawing.Point(26, 236);
            this.btn_crear_materias.Name = "btn_crear_materias";
            this.btn_crear_materias.Size = new System.Drawing.Size(110, 52);
            this.btn_crear_materias.TabIndex = 4;
            this.btn_crear_materias.Text = "Crear Materias";
            this.btn_crear_materias.UseVisualStyleBackColor = true;
            this.btn_crear_materias.Click += new System.EventHandler(this.btn_crear_materias_Click);
            // 
            // dgv_admin_materias
            // 
            this.dgv_admin_materias.AllowUserToDeleteRows = false;
            this.dgv_admin_materias.AllowUserToOrderColumns = true;
            this.dgv_admin_materias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_admin_materias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_admin_materias.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_admin_materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admin_materias.Location = new System.Drawing.Point(142, 236);
            this.dgv_admin_materias.Name = "dgv_admin_materias";
            this.dgv_admin_materias.ReadOnly = true;
            this.dgv_admin_materias.RowTemplate.Height = 25;
            this.dgv_admin_materias.Size = new System.Drawing.Size(627, 200);
            this.dgv_admin_materias.TabIndex = 5;
            // 
            // cb_menuAdmin_seleccionAlumno
            // 
            this.cb_menuAdmin_seleccionAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_menuAdmin_seleccionAlumno.FormattingEnabled = true;
            this.cb_menuAdmin_seleccionAlumno.Location = new System.Drawing.Point(29, 531);
            this.cb_menuAdmin_seleccionAlumno.Name = "cb_menuAdmin_seleccionAlumno";
            this.cb_menuAdmin_seleccionAlumno.Size = new System.Drawing.Size(121, 23);
            this.cb_menuAdmin_seleccionAlumno.TabIndex = 6;
            this.cb_menuAdmin_seleccionAlumno.SelectedIndexChanged += new System.EventHandler(this.cb_menuAdmin_seleccionAlumno_SelectedIndexChanged);
            // 
            // lbl_menuAdmin_seleccionAlumno
            // 
            this.lbl_menuAdmin_seleccionAlumno.AutoSize = true;
            this.lbl_menuAdmin_seleccionAlumno.Location = new System.Drawing.Point(29, 513);
            this.lbl_menuAdmin_seleccionAlumno.Name = "lbl_menuAdmin_seleccionAlumno";
            this.lbl_menuAdmin_seleccionAlumno.Size = new System.Drawing.Size(112, 15);
            this.lbl_menuAdmin_seleccionAlumno.TabIndex = 8;
            this.lbl_menuAdmin_seleccionAlumno.Text = "Seleccione Alumno:";
            // 
            // btn_menuAdmin_estadoAlumno
            // 
            this.btn_menuAdmin_estadoAlumno.Location = new System.Drawing.Point(168, 461);
            this.btn_menuAdmin_estadoAlumno.Name = "btn_menuAdmin_estadoAlumno";
            this.btn_menuAdmin_estadoAlumno.Size = new System.Drawing.Size(75, 75);
            this.btn_menuAdmin_estadoAlumno.TabIndex = 10;
            this.btn_menuAdmin_estadoAlumno.Text = "Cambiar Estado";
            this.btn_menuAdmin_estadoAlumno.UseVisualStyleBackColor = true;
            this.btn_menuAdmin_estadoAlumno.Click += new System.EventHandler(this.btn_menuAdmin_estadoAlumno_Click);
            // 
            // lbl_menuAdmin_materia
            // 
            this.lbl_menuAdmin_materia.AutoSize = true;
            this.lbl_menuAdmin_materia.Location = new System.Drawing.Point(29, 461);
            this.lbl_menuAdmin_materia.Name = "lbl_menuAdmin_materia";
            this.lbl_menuAdmin_materia.Size = new System.Drawing.Size(109, 15);
            this.lbl_menuAdmin_materia.TabIndex = 13;
            this.lbl_menuAdmin_materia.Text = "Seleccione Materia:";
            // 
            // cb_menuAdmin_materias
            // 
            this.cb_menuAdmin_materias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_menuAdmin_materias.FormattingEnabled = true;
            this.cb_menuAdmin_materias.Location = new System.Drawing.Point(31, 479);
            this.cb_menuAdmin_materias.Name = "cb_menuAdmin_materias";
            this.cb_menuAdmin_materias.Size = new System.Drawing.Size(121, 23);
            this.cb_menuAdmin_materias.TabIndex = 14;
            this.cb_menuAdmin_materias.SelectedIndexChanged += new System.EventHandler(this.cb_menuAdmin_materias_SelectedIndexChanged);
            // 
            // dgv_estadoMateriasAlumno
            // 
            this.dgv_estadoMateriasAlumno.AllowUserToAddRows = false;
            this.dgv_estadoMateriasAlumno.AllowUserToDeleteRows = false;
            this.dgv_estadoMateriasAlumno.AllowUserToOrderColumns = true;
            this.dgv_estadoMateriasAlumno.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_estadoMateriasAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_estadoMateriasAlumno.Location = new System.Drawing.Point(266, 453);
            this.dgv_estadoMateriasAlumno.Name = "dgv_estadoMateriasAlumno";
            this.dgv_estadoMateriasAlumno.ReadOnly = true;
            this.dgv_estadoMateriasAlumno.RowTemplate.Height = 25;
            this.dgv_estadoMateriasAlumno.Size = new System.Drawing.Size(503, 165);
            this.dgv_estadoMateriasAlumno.TabIndex = 15;
            // 
            // lbl_estadoAlumno
            // 
            this.lbl_estadoAlumno.AutoSize = true;
            this.lbl_estadoAlumno.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_estadoAlumno.Location = new System.Drawing.Point(174, 551);
            this.lbl_estadoAlumno.Name = "lbl_estadoAlumno";
            this.lbl_estadoAlumno.Size = new System.Drawing.Size(0, 25);
            this.lbl_estadoAlumno.TabIndex = 16;
            // 
            // lbl_estadoActualA
            // 
            this.lbl_estadoActualA.AutoSize = true;
            this.lbl_estadoActualA.Location = new System.Drawing.Point(25, 559);
            this.lbl_estadoActualA.Name = "lbl_estadoActualA";
            this.lbl_estadoActualA.Size = new System.Drawing.Size(143, 15);
            this.lbl_estadoActualA.TabIndex = 17;
            this.lbl_estadoActualA.Text = "Estado actual del alumno:";
            // 
            // FrmMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(787, 675);
            this.Controls.Add(this.lbl_estadoActualA);
            this.Controls.Add(this.lbl_estadoAlumno);
            this.Controls.Add(this.dgv_estadoMateriasAlumno);
            this.Controls.Add(this.cb_menuAdmin_materias);
            this.Controls.Add(this.lbl_menuAdmin_materia);
            this.Controls.Add(this.btn_menuAdmin_estadoAlumno);
            this.Controls.Add(this.lbl_menuAdmin_seleccionAlumno);
            this.Controls.Add(this.cb_menuAdmin_seleccionAlumno);
            this.Controls.Add(this.dgv_admin_materias);
            this.Controls.Add(this.btn_crear_materias);
            this.Controls.Add(this.dgv_admin_usuarios);
            this.Controls.Add(this.btn_menuAdmin_salir);
            this.Controls.Add(this.btn_alta_usuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuAdmin";
            this.Text = "Menu Principal Administrador";
            this.Load += new System.EventHandler(this.FrmMenuAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin_usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin_materias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estadoMateriasAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_alta_usuarios;
        private System.Windows.Forms.Button btn_menuAdmin_salir;
        private System.Windows.Forms.DataGridView dgv_admin_usuarios;
        private System.Windows.Forms.Button btn_crear_materias;
        private System.Windows.Forms.DataGridView dgv_admin_materias;
        private System.Windows.Forms.ComboBox cb_menuAdmin_seleccionAlumno;
        private System.Windows.Forms.Label lbl_menuAdmin_seleccionAlumno;
        private System.Windows.Forms.Button btn_menuAdmin_estadoAlumno;
        private System.Windows.Forms.Label lbl_menuAdmin_materia;
        private System.Windows.Forms.ComboBox cb_menuAdmin_materias;
        private System.Windows.Forms.DataGridView dgv_estadoMateriasAlumno;
        private System.Windows.Forms.Label lbl_estadoAlumno;
        private System.Windows.Forms.Label lbl_estadoActualA;
    }
}