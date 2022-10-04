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
    public partial class FrmMenuAlumno : Form
    {
        Usuario usuarioAlumno;
        List<Materia> materiaAux;

        public Usuario UsuarioAlumno { get => usuarioAlumno; set => usuarioAlumno = value; }

        public FrmMenuAlumno()
        {
            InitializeComponent();
        }

        private void btn_menuAlumno_salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FrmMenuAlumno_Load(object sender, EventArgs e)
        {
            materiaAux = new List<Materia>();
            dgv_menuAlumno_materias_disponibles.DataSource = BaseDatos.Materias;
            TraerListaMateriasInscriptas();
            dgv_menuAlumno_inscripcion.DataSource = materiaAux;
            dgv_menuAlumno_inscripcion.Columns["Profesor"].Visible = false;
            dgv_menuAlumno_materias_disponibles.Columns["Profesor"].Visible = false;
            dgv_materiasAprobadas.DataSource = ((Alumno)usuarioAlumno).MateriasAprobadas;

            if (materiaAux.Count > 0)
            {
                btn_menuAlumno_asistencia.Visible = true;
                cb_menuAlumno_asistencia.Visible = true;
                cb_menuAlumno_asistencia.DataSource = materiaAux;
                cb_menuAlumno_asistencia.DisplayMember = "Nombre";
            }
            else
            {
                btn_menuAlumno_asistencia.Visible = false;
                cb_menuAlumno_asistencia.Visible = false;
            }
        }

        private void btn_menuAlumno_inscribirse_Click(object sender, EventArgs e)
        {
            ChequearInscripcion();
            TraerListaMateriasInscriptas();
            dgv_menuAlumno_inscripcion.DataSource = null;
            dgv_menuAlumno_inscripcion.DataSource = materiaAux;
            dgv_menuAlumno_inscripcion.Columns["Profesor"].Visible = false;
            cb_menuAlumno_asistencia.DataSource = null;
            cb_menuAlumno_asistencia.DataSource = materiaAux;
            cb_menuAlumno_asistencia.DisplayMember = "Nombre";
        }

        /// <summary>
        /// Chequea si es posible la inscripcion del alumno y si es asi lo hace.
        /// </summary>
        public void ChequearInscripcion()
        {
            if (int.TryParse(txb_menuAlumno_Inscripcion.Text, out int idAux))
            {
                foreach (var materia in BaseDatos.Materias)
                {
                    if (materia.Id == idAux)
                    {
                        if (materia.AgregarAlumno((Alumno)usuarioAlumno))
                        {
                            MessageBox.Show("Se inscribio con exito!");
                            ((Alumno)usuarioAlumno).InscribirseMateria(idAux);
                            btn_menuAlumno_asistencia.Visible = true;
                            cb_menuAlumno_asistencia.Visible = true;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Solamente caracteres numericos!");
            }
        }

        /// <summary>
        /// Trae la lista de las materias ya inscriptas por el alumno.
        /// </summary>
        private void TraerListaMateriasInscriptas()
        {
            foreach (var id in ((Alumno)usuarioAlumno).Materias)
            {
                foreach (var materia in BaseDatos.Materias)
                {
                    if (id == materia.Id)
                    {
                        if (!(materiaAux.Contains(materia)))
                        {
                            materiaAux.Add(materia);
                        }
                    }
                }
            }
        }

        private void btn_menuAlumno_asistencia_Click(object sender, EventArgs e)
        {

            if (BaseDatos.RegistrarPresenteAlumno(((Alumno)usuarioAlumno), ((Materia)cb_menuAlumno_asistencia.SelectedItem)))
            {
                MessageBox.Show("Presente!");
            }

        }
    }
}
