using BibliotecaClases;
using Microsoft.VisualBasic;
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
    public partial class FrmMenuProfesor : Form
    {
        Usuario usuarioProfesor;
        public Usuario UsuarioProfesor { get => usuarioProfesor; set => usuarioProfesor = value; }
        List<Materia> listaMaterias;

        public FrmMenuProfesor()
        {
            InitializeComponent();
        }

        private void btn_menuProf_salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FrmMenuProfesor_Load(object sender, EventArgs e)
        {
            listaMaterias = new List<Materia>();
            TraerListaMateriasInscriptas();
            cb_menuProfe_materia.DataSource = listaMaterias;
            cb_menuProfe_materia.DisplayMember = "Nombre";
            cb_seleccionar_nota.SelectedIndex = 0;
        }

        /// <summary>
        /// Trae la lista de materias inscriptas.
        /// </summary>
        private void TraerListaMateriasInscriptas()
        {
            foreach (var materia in BaseDatos.Materias)
            {
                if (materia.Profesor == (Profesor)usuarioProfesor)
                {
                    listaMaterias.Add(materia);
                }
            }
        }

        private void cb_menuProfe_materia_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_fechaActual_examen.Text = ((Materia)cb_menuProfe_materia.SelectedItem).FechaExamen;
            cb_seleccionar_alumno.DataSource = null;
            cb_seleccionar_alumno.DataSource = ((Materia)cb_menuProfe_materia.SelectedItem).AlumnosLista;
            cb_seleccionar_alumno.DisplayMember = "NombreCompleto";
            MostrarNotaAlumno();
        }

        private void btn_crear_examen_Click(object sender, EventArgs e)
        {
            Materia materiaAux = (Materia)cb_menuProfe_materia.SelectedItem;
            if (materiaAux.AsignarFechaExamen(ConstuirFechaExamen()))
            {
                lbl_fechaActual_examen.Text = ((Materia)cb_menuProfe_materia.SelectedItem).FechaExamen;
            }
        }

        /// <summary>
        /// Construye un string de fecha de examen.
        /// </summary>
        /// <returns></returns> Retorna el string construido.
        public string ConstuirFechaExamen()
        {
            string retorno = "  ";
            if (txb_dia_examen.Text.Length > 0 && txb_mes_examen.Text.Length > 0)
            {
                if (int.TryParse(txb_dia_examen.Text, out int dia) && int.TryParse(txb_mes_examen.Text, out int mes))
                {
                    if (dia > 0 && dia < 31 && mes > 0 && mes < 13)
                    {
                        StringBuilder sb = new();
                        sb.Append(dia);
                        sb.Append('/');
                        sb.Append(mes);
                        retorno = sb.ToString();
                    }
                }
            }
            return retorno;
        }
        string? notaStr;
        private void btn_evaluarAlumno_Click(object sender, EventArgs e)
        {
            if (cb_seleccionar_alumno.SelectedIndex != -1 && cb_seleccionar_nota.SelectedIndex != -1)
            {
                if (cb_seleccionar_nota.SelectedItem is not null)
                {
                    notaStr = (cb_seleccionar_nota.SelectedItem).ToString();
                    if (int.TryParse(notaStr, out int nota))
                    {
                        ((Materia)cb_menuProfe_materia.SelectedItem).EvaluarAlumnos(((Alumno)cb_seleccionar_alumno.SelectedItem), nota);
                        MostrarNotaAlumno();
                    }
                }
            }
        }

        private void cb_seleccionar_alumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarNotaAlumno();
        }

        /// <summary>
        /// Muestra la nota actual del alumno.
        /// </summary>
        private void MostrarNotaAlumno()
        {
            int nota = ((Materia)cb_menuProfe_materia.SelectedItem).MostrarNotaAlumno((Alumno)cb_seleccionar_alumno.SelectedItem);
            lbl_notaActual.Text = nota.ToString();
        }
    }
}
