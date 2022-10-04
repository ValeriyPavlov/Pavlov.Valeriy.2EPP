namespace Vista
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.btn_login_aceptar = new System.Windows.Forms.Button();
            this.txb_usuario = new System.Windows.Forms.TextBox();
            this.txb_contraseña = new System.Windows.Forms.TextBox();
            this.btn_login_salir = new System.Windows.Forms.Button();
            this.btn_login_admin = new System.Windows.Forms.Button();
            this.btn_login_alumno = new System.Windows.Forms.Button();
            this.btn_login_profesor = new System.Windows.Forms.Button();
            this.lbl_autocompletado = new System.Windows.Forms.Label();
            this.lbl_sistema_admin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_login_aceptar
            // 
            this.btn_login_aceptar.Location = new System.Drawing.Point(117, 171);
            this.btn_login_aceptar.Name = "btn_login_aceptar";
            this.btn_login_aceptar.Size = new System.Drawing.Size(150, 71);
            this.btn_login_aceptar.TabIndex = 0;
            this.btn_login_aceptar.Text = "Aceptar";
            this.btn_login_aceptar.UseVisualStyleBackColor = true;
            this.btn_login_aceptar.Click += new System.EventHandler(this.btn_login_aceptar_Click);
            // 
            // txb_usuario
            // 
            this.txb_usuario.Location = new System.Drawing.Point(76, 57);
            this.txb_usuario.Name = "txb_usuario";
            this.txb_usuario.PlaceholderText = "Usuario";
            this.txb_usuario.Size = new System.Drawing.Size(241, 23);
            this.txb_usuario.TabIndex = 1;
            // 
            // txb_contraseña
            // 
            this.txb_contraseña.Location = new System.Drawing.Point(76, 111);
            this.txb_contraseña.MaxLength = 20;
            this.txb_contraseña.Name = "txb_contraseña";
            this.txb_contraseña.PasswordChar = '*';
            this.txb_contraseña.PlaceholderText = "Contraseña";
            this.txb_contraseña.Size = new System.Drawing.Size(241, 23);
            this.txb_contraseña.TabIndex = 2;
            // 
            // btn_login_salir
            // 
            this.btn_login_salir.Location = new System.Drawing.Point(12, 301);
            this.btn_login_salir.Name = "btn_login_salir";
            this.btn_login_salir.Size = new System.Drawing.Size(75, 62);
            this.btn_login_salir.TabIndex = 3;
            this.btn_login_salir.Text = "Salir";
            this.btn_login_salir.UseVisualStyleBackColor = true;
            this.btn_login_salir.Click += new System.EventHandler(this.btn_login_salir_Click);
            // 
            // btn_login_admin
            // 
            this.btn_login_admin.Location = new System.Drawing.Point(318, 271);
            this.btn_login_admin.Name = "btn_login_admin";
            this.btn_login_admin.Size = new System.Drawing.Size(75, 23);
            this.btn_login_admin.TabIndex = 4;
            this.btn_login_admin.Text = "Admin";
            this.btn_login_admin.UseVisualStyleBackColor = true;
            this.btn_login_admin.Click += new System.EventHandler(this.btn_login_admin_Click);
            // 
            // btn_login_alumno
            // 
            this.btn_login_alumno.Location = new System.Drawing.Point(318, 351);
            this.btn_login_alumno.Name = "btn_login_alumno";
            this.btn_login_alumno.Size = new System.Drawing.Size(75, 23);
            this.btn_login_alumno.TabIndex = 5;
            this.btn_login_alumno.Text = "Alumno";
            this.btn_login_alumno.UseVisualStyleBackColor = true;
            this.btn_login_alumno.Click += new System.EventHandler(this.btn_login_alumno_Click);
            // 
            // btn_login_profesor
            // 
            this.btn_login_profesor.Location = new System.Drawing.Point(318, 312);
            this.btn_login_profesor.Name = "btn_login_profesor";
            this.btn_login_profesor.Size = new System.Drawing.Size(75, 23);
            this.btn_login_profesor.TabIndex = 6;
            this.btn_login_profesor.Text = "Profesor";
            this.btn_login_profesor.UseVisualStyleBackColor = true;
            this.btn_login_profesor.Click += new System.EventHandler(this.btn_login_profesor_Click);
            // 
            // lbl_autocompletado
            // 
            this.lbl_autocompletado.AutoSize = true;
            this.lbl_autocompletado.Location = new System.Drawing.Point(318, 241);
            this.lbl_autocompletado.Name = "lbl_autocompletado";
            this.lbl_autocompletado.Size = new System.Drawing.Size(63, 15);
            this.lbl_autocompletado.TabIndex = 7;
            this.lbl_autocompletado.Text = "AutoLogin";
            // 
            // lbl_sistema_admin
            // 
            this.lbl_sistema_admin.AutoSize = true;
            this.lbl_sistema_admin.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_sistema_admin.Location = new System.Drawing.Point(12, 9);
            this.lbl_sistema_admin.Name = "lbl_sistema_admin";
            this.lbl_sistema_admin.Size = new System.Drawing.Size(382, 37);
            this.lbl_sistema_admin.TabIndex = 8;
            this.lbl_sistema_admin.Text = "Sistema Administrativo UTN";
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(405, 382);
            this.Controls.Add(this.lbl_sistema_admin);
            this.Controls.Add(this.lbl_autocompletado);
            this.Controls.Add(this.btn_login_profesor);
            this.Controls.Add(this.btn_login_alumno);
            this.Controls.Add(this.btn_login_admin);
            this.Controls.Add(this.btn_login_salir);
            this.Controls.Add(this.txb_contraseña);
            this.Controls.Add(this.txb_usuario);
            this.Controls.Add(this.btn_login_aceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login_aceptar;
        private System.Windows.Forms.TextBox txb_usuario;
        private System.Windows.Forms.TextBox txb_contraseña;
        private System.Windows.Forms.Button btn_login_salir;
        private System.Windows.Forms.Button btn_login_admin;
        private System.Windows.Forms.Button btn_login_alumno;
        private System.Windows.Forms.Button btn_login_profesor;
        private System.Windows.Forms.Label lbl_autocompletado;
        private System.Windows.Forms.Label lbl_sistema_admin;
    }
}
