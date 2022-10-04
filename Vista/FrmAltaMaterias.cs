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
using BibliotecaClases;

namespace Vista
{
    public partial class FrmAltaMaterias : Form
    {
        Materia? materiaAux;
        public FrmAltaMaterias()
        {
            InitializeComponent();
            cb_altaMateria_profesor.DataSource = BaseDatos.Profesores;
            cb_altaMateria_profesor.DisplayMember = "NombreCompleto";
        }

        private void btn_materias_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_materias_aceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                ConstruirMateria();
                BaseDatos.AgregarMateria = materiaAux;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void ConstruirMateria()
        {
            EMateria eMateria = (EMateria)cb_altaMaterias_materia.SelectedIndex;
            Profesor profeAux = (Profesor)cb_altaMateria_profesor.SelectedItem;
            materiaAux = new Materia(eMateria, BaseDatos.AsignarCuatrimestre(eMateria), profeAux, BaseDatos.AsignarCorrelatividad(eMateria));
        }

        private bool ValidarDatos()
        {
            bool retorno = true;
            if (cb_altaMaterias_materia.SelectedIndex == -1 || cb_altaMateria_profesor.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar todos los campos!");
                retorno = false;
            }
            return retorno;
        }

        private void FrmAltaMaterias_Load(object sender, EventArgs e)
        {
            
        }
    }
}
