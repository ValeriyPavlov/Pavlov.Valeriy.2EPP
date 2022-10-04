using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaClases;

namespace Vista
{
    public partial class FrmMenuAdmin : Form
    {
        FrmAltaUsuarios formAltaUsuarios;
        FrmAltaMaterias formAltaMaterias;

        public FrmMenuAdmin()
        {
            InitializeComponent();
        }

        public FrmAltaUsuarios FormAltaUsuarios { get => formAltaUsuarios; set => formAltaUsuarios = value; }

        private void btn_alta_usuarios_Click(object sender, EventArgs e)
        {
            formAltaUsuarios = new FrmAltaUsuarios();

            if (formAltaUsuarios.ShowDialog() == DialogResult.OK)
            {
                dgv_admin_usuarios.DataSource = null;
                dgv_admin_usuarios.DataSource = BaseDatos.Usuarios;
            }
        }

        private void btn_menuAdmin_salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FrmMenuAdmin_Load(object sender, EventArgs e)
        {
            dgv_admin_usuarios.DataSource = BaseDatos.Usuarios;
            dgv_admin_materias.DataSource = BaseDatos.Materias;
            dgv_admin_materias.Columns["Profesor"].Visible = false;
            cb_menuAdmin_seleccionAlumno.DataSource = null;
            cb_menuAdmin_materias.DataSource = BaseDatos.Materias;
            cb_menuAdmin_materias.DisplayMember = "Nombre";
            dgv_estadoMateriasAlumno.DataSource = null;
            dgv_estadoMateriasAlumno.DataSource = ((Materia)cb_menuAdmin_materias.SelectedItem).AlumnosLista;
            dgv_estadoMateriasAlumno.Columns["NombreCompleto"].Visible = false;
        }

        private void btn_crear_materias_Click(object sender, EventArgs e)
        {
            formAltaMaterias = new FrmAltaMaterias();
            if (formAltaMaterias.ShowDialog() == DialogResult.OK)
            {
                dgv_admin_materias.DataSource = null;
                dgv_admin_materias.DataSource = BaseDatos.Materias;
            }
        }

        private void btn_menuAdmin_estadoAlumno_Click(object sender, EventArgs e)
        {
            if (cb_menuAdmin_seleccionAlumno.SelectedIndex == -1 || cb_menuAdmin_materias.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un estado!");
            }
            else
            {
                ((Materia)cb_menuAdmin_materias.SelectedItem).CambiarEstadoAlumno(((Alumno)cb_menuAdmin_seleccionAlumno.SelectedItem));
                dgv_estadoMateriasAlumno.DataSource = null;
                dgv_estadoMateriasAlumno.DataSource = ((Materia)cb_menuAdmin_materias.SelectedItem).AlumnosLista;
                dgv_estadoMateriasAlumno.Columns["NombreCompleto"].Visible = false;
                lbl_estadoAlumno.Text = ((Materia)cb_menuAdmin_materias.SelectedItem).RecibirEstadoDeAlumno(((Alumno)cb_menuAdmin_seleccionAlumno.SelectedItem));
            }
        }

        private void cb_menuAdmin_seleccionAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_estadoMateriasAlumno.DataSource = null;
            dgv_estadoMateriasAlumno.DataSource = ((Materia)cb_menuAdmin_materias.SelectedItem).AlumnosLista;
            dgv_estadoMateriasAlumno.Columns["NombreCompleto"].Visible = false;
            lbl_estadoAlumno.Text = ((Materia)cb_menuAdmin_materias.SelectedItem).RecibirEstadoDeAlumno(((Alumno)cb_menuAdmin_seleccionAlumno.SelectedItem));
        }

        private void cb_menuAdmin_materias_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_estadoMateriasAlumno.DataSource = ((Materia)cb_menuAdmin_materias.SelectedItem).AlumnosLista;
            dgv_estadoMateriasAlumno.Columns["NombreCompleto"].Visible = false;
            cb_menuAdmin_materias.DisplayMember = "Nombre";
            cb_menuAdmin_seleccionAlumno.DataSource = ((Materia)cb_menuAdmin_materias.SelectedItem).AlumnosLista;
            cb_menuAdmin_seleccionAlumno.DisplayMember = "NombreCompleto";
        }
    }
}
