namespace Vista
{
    partial class FrmAltaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaUsuarios));
            this.btn_altaUsuarios_aceptar = new System.Windows.Forms.Button();
            this.btn_altaUsuarios_cancelar = new System.Windows.Forms.Button();
            this.txb_altaUsuarios_usuario = new System.Windows.Forms.TextBox();
            this.txb_altaUsuarios_contraseña = new System.Windows.Forms.TextBox();
            this.cb_altaUsuarios_tipoUsuario = new System.Windows.Forms.ComboBox();
            this.txb_altaUsuarios_apellido = new System.Windows.Forms.TextBox();
            this.txb_altaUsuarios_nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_altaUsuarios_aceptar
            // 
            this.btn_altaUsuarios_aceptar.Location = new System.Drawing.Point(333, 361);
            this.btn_altaUsuarios_aceptar.Name = "btn_altaUsuarios_aceptar";
            this.btn_altaUsuarios_aceptar.Size = new System.Drawing.Size(94, 63);
            this.btn_altaUsuarios_aceptar.TabIndex = 0;
            this.btn_altaUsuarios_aceptar.Text = "Aceptar";
            this.btn_altaUsuarios_aceptar.UseVisualStyleBackColor = true;
            this.btn_altaUsuarios_aceptar.Click += new System.EventHandler(this.btn_altaUsuarios_aceptar_Click);
            // 
            // btn_altaUsuarios_cancelar
            // 
            this.btn_altaUsuarios_cancelar.Location = new System.Drawing.Point(34, 361);
            this.btn_altaUsuarios_cancelar.Name = "btn_altaUsuarios_cancelar";
            this.btn_altaUsuarios_cancelar.Size = new System.Drawing.Size(94, 63);
            this.btn_altaUsuarios_cancelar.TabIndex = 1;
            this.btn_altaUsuarios_cancelar.Text = "Cancelar";
            this.btn_altaUsuarios_cancelar.UseVisualStyleBackColor = true;
            this.btn_altaUsuarios_cancelar.Click += new System.EventHandler(this.btn_altaUsuarios_cancelar_Click);
            // 
            // txb_altaUsuarios_usuario
            // 
            this.txb_altaUsuarios_usuario.Location = new System.Drawing.Point(90, 98);
            this.txb_altaUsuarios_usuario.MaxLength = 20;
            this.txb_altaUsuarios_usuario.Name = "txb_altaUsuarios_usuario";
            this.txb_altaUsuarios_usuario.PlaceholderText = "Usuario";
            this.txb_altaUsuarios_usuario.Size = new System.Drawing.Size(280, 23);
            this.txb_altaUsuarios_usuario.TabIndex = 2;
            // 
            // txb_altaUsuarios_contraseña
            // 
            this.txb_altaUsuarios_contraseña.Location = new System.Drawing.Point(90, 156);
            this.txb_altaUsuarios_contraseña.MaxLength = 20;
            this.txb_altaUsuarios_contraseña.Name = "txb_altaUsuarios_contraseña";
            this.txb_altaUsuarios_contraseña.PlaceholderText = "Contraseña";
            this.txb_altaUsuarios_contraseña.Size = new System.Drawing.Size(280, 23);
            this.txb_altaUsuarios_contraseña.TabIndex = 3;
            // 
            // cb_altaUsuarios_tipoUsuario
            // 
            this.cb_altaUsuarios_tipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_altaUsuarios_tipoUsuario.FormattingEnabled = true;
            this.cb_altaUsuarios_tipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Profesor",
            "Alumno"});
            this.cb_altaUsuarios_tipoUsuario.Location = new System.Drawing.Point(90, 34);
            this.cb_altaUsuarios_tipoUsuario.Name = "cb_altaUsuarios_tipoUsuario";
            this.cb_altaUsuarios_tipoUsuario.Size = new System.Drawing.Size(280, 23);
            this.cb_altaUsuarios_tipoUsuario.TabIndex = 1;
            this.cb_altaUsuarios_tipoUsuario.SelectedIndexChanged += new System.EventHandler(this.cb_altaUsuarios_tipoUsuario_SelectedIndexChanged);
            // 
            // txb_altaUsuarios_apellido
            // 
            this.txb_altaUsuarios_apellido.Location = new System.Drawing.Point(90, 213);
            this.txb_altaUsuarios_apellido.MaxLength = 20;
            this.txb_altaUsuarios_apellido.Name = "txb_altaUsuarios_apellido";
            this.txb_altaUsuarios_apellido.PlaceholderText = "Apellido";
            this.txb_altaUsuarios_apellido.Size = new System.Drawing.Size(280, 23);
            this.txb_altaUsuarios_apellido.TabIndex = 4;
            this.txb_altaUsuarios_apellido.Visible = false;
            // 
            // txb_altaUsuarios_nombre
            // 
            this.txb_altaUsuarios_nombre.Location = new System.Drawing.Point(90, 272);
            this.txb_altaUsuarios_nombre.MaxLength = 20;
            this.txb_altaUsuarios_nombre.Name = "txb_altaUsuarios_nombre";
            this.txb_altaUsuarios_nombre.PlaceholderText = "Nombre";
            this.txb_altaUsuarios_nombre.Size = new System.Drawing.Size(280, 23);
            this.txb_altaUsuarios_nombre.TabIndex = 5;
            this.txb_altaUsuarios_nombre.Visible = false;
            // 
            // FrmAltaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(457, 444);
            this.Controls.Add(this.txb_altaUsuarios_nombre);
            this.Controls.Add(this.txb_altaUsuarios_apellido);
            this.Controls.Add(this.cb_altaUsuarios_tipoUsuario);
            this.Controls.Add(this.txb_altaUsuarios_contraseña);
            this.Controls.Add(this.txb_altaUsuarios_usuario);
            this.Controls.Add(this.btn_altaUsuarios_cancelar);
            this.Controls.Add(this.btn_altaUsuarios_aceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAltaUsuarios";
            this.Text = "Alta Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_altaUsuarios_aceptar;
        private System.Windows.Forms.Button btn_altaUsuarios_cancelar;
        private System.Windows.Forms.TextBox txb_altaUsuarios_usuario;
        private System.Windows.Forms.TextBox txb_altaUsuarios_contraseña;
        private System.Windows.Forms.ComboBox cb_altaUsuarios_tipoUsuario;
        private System.Windows.Forms.TextBox txb_altaUsuarios_apellido;
        private System.Windows.Forms.TextBox txb_altaUsuarios_nombre;
    }
}