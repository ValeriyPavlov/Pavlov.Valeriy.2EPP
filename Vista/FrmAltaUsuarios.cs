using BibliotecaClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmAltaUsuarios : Form
    {
        Admin auxAdmin;
        Profesor auxProfesor;
        Alumno auxAlumno;

        public FrmAltaUsuarios()
        {
            InitializeComponent();
        }

        private void btn_altaUsuarios_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_altaUsuarios_aceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (RegistrarUsuario())
                {
                    switch (cb_altaUsuarios_tipoUsuario.SelectedIndex)
                    {
                        case 0:
                            BaseDatos.AgregarUsuarios = auxAdmin;
                            break;
                        case 1:
                            BaseDatos.AgregarUsuarios = auxProfesor;
                            BaseDatos.AgregarProfesores = auxProfesor;
                            break;
                        case 2:
                            BaseDatos.AgregarUsuarios = auxAlumno;
                            BaseDatos.AgregarAlumnos = auxAlumno;
                            break;
                    }
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void cb_altaUsuarios_tipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cb_altaUsuarios_tipoUsuario.SelectedIndex)
            {
                case 0:
                    txb_altaUsuarios_nombre.Visible = false;
                    txb_altaUsuarios_apellido.Visible = false;
                    break;
                case 1:
                    txb_altaUsuarios_nombre.Visible = true;
                    txb_altaUsuarios_apellido.Visible = true;
                    break;
                case 2:
                    txb_altaUsuarios_nombre.Visible = true;
                    txb_altaUsuarios_apellido.Visible = true;
                    break;
            }
        }

        /// <summary>
        /// Validacion de datos de los campos del formulario.
        /// </summary>
        /// <returns></returns> false si estan incompletos | true si estan completos.
        private bool ValidarDatos()
        {
            bool retorno = false;
            if (txb_altaUsuarios_usuario.Text.Length > 2 && txb_altaUsuarios_contraseña.Text.Length > 2 && (cb_altaUsuarios_tipoUsuario.SelectedIndex == 1 || cb_altaUsuarios_tipoUsuario.SelectedIndex == 2) && txb_altaUsuarios_apellido.Text.Length > 2 && txb_altaUsuarios_nombre.Text.Length > 2)
            {
                retorno = true;
            }
            else if (cb_altaUsuarios_tipoUsuario.SelectedIndex == 0 && txb_altaUsuarios_usuario.Text.Length > 2 && txb_altaUsuarios_contraseña.Text.Length > 2)
            {
                retorno = true;
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos!");
            }
            return retorno;
        }

        /// <summary>
        /// Registracion del usuario.
        /// </summary>
        /// <returns></returns>
        private bool RegistrarUsuario()
        {
            bool retorno = true;
            foreach (Usuario user in BaseDatos.Usuarios)
            {
                if (this.txb_altaUsuarios_usuario.Text == user.NombreUsuario)
                {
                    retorno = false; 
                }
            }
            if (retorno == true)
            {
                switch (cb_altaUsuarios_tipoUsuario.SelectedIndex)
                {
                    case 0:
                        auxAdmin = new Admin(txb_altaUsuarios_usuario.Text, txb_altaUsuarios_contraseña.Text);
                        break;
                    case 1:
                        auxProfesor = new Profesor(txb_altaUsuarios_usuario.Text, txb_altaUsuarios_contraseña.Text, txb_altaUsuarios_nombre.Text, txb_altaUsuarios_apellido.Text);
                        break;
                    case 2:
                        auxAlumno = new Alumno(txb_altaUsuarios_usuario.Text, txb_altaUsuarios_contraseña.Text, txb_altaUsuarios_nombre.Text, txb_altaUsuarios_apellido.Text);
                        break;
                }
            }
            else
            {
                MessageBox.Show("El nombre del usuario ya se encuentra registrado.");
            }
            return retorno;
        }

    }
}
