using BibliotecaClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Frm_Login : Form
    {

        FrmMenuAdmin menuPrincipalAdmin = new FrmMenuAdmin();
        FrmMenuAlumno menuPrincipalAlumno = new FrmMenuAlumno();
        FrmMenuProfesor menuPrincipalProfesor = new FrmMenuProfesor();

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_login_aceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario = BaseDatos.ValidarLogin(this.txb_usuario.Text, this.txb_contraseña.Text);
            if (usuario != null)
            {
                if (usuario.GetType() == "Admin")
                {
                    menuPrincipalAdmin.ShowDialog();
                }
                else if (usuario.GetType() == "Alumno")
                {
                    menuPrincipalAlumno.UsuarioAlumno = usuario;
                    menuPrincipalAlumno.ShowDialog();
                }
                else if (usuario.GetType() == "Profesor")
                {
                    menuPrincipalProfesor.UsuarioProfesor = usuario;
                    menuPrincipalProfesor.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Usuario/Contraseña Incorrecta");
            }
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_admin_Click(object sender, EventArgs e)
        {
            txb_usuario.Text = "admin";
            txb_contraseña.Text = "admin";
        }

        private void btn_login_alumno_Click(object sender, EventArgs e)
        {
            txb_usuario.Text = "alumno";
            txb_contraseña.Text = "alumno";
        }

        private void btn_login_profesor_Click(object sender, EventArgs e)
        {
            txb_usuario.Text = "profesor";
            txb_contraseña.Text = "profesor";
        }
    }
}
