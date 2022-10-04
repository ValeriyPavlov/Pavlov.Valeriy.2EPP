using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Alumno : Usuario
    {
        private string _nombre;
        private string _apellido;
        private List<int> _materias;
        private List<EstadoAlumno> _materiasCursada;
        private List<Materia> _materiasAprobadas;

        public Alumno(string nombreUsuario, string contraseñaUsuario, string nombre, string apellido) : base(nombreUsuario, contraseñaUsuario)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._materias = new List<int>();
            this._materiasCursada = new List<EstadoAlumno>();
            this._materiasAprobadas = new List<Materia>();
        }

        public string NombreCompleto { get {return (_nombre + ' ' + _apellido); } }
        public override string Tipo { get { return "Alumno"; } }
        public override string Nombre { get => _nombre;}
        public override string Apellido { get => _apellido;}
        public List<int> Materias { get => _materias;}
        public List<EstadoAlumno> MateriasCursada { get => _materiasCursada; set => _materiasCursada = value; }
        public List<Materia> MateriasAprobadas { get => _materiasAprobadas;}

        /// <summary>
        /// Agrega la materia a una lista interna del alumno.
        /// </summary>
        /// <param name="idMateria"></param> ID de la materia a agregar.
        private void AgregarMateriaAlAlumno(int idMateria)
        {
             EstadoAlumno materiaAux = new EstadoAlumno();
            _materiasCursada.Add(materiaAux);
        }

        /// <summary>
        /// Metodo GetType sobreescrito que retorna un string del tipo de usuario.
        /// </summary>
        /// <returns></returns> Returno el tipo.
        public override string GetType()
        {
            return "Alumno";
        }

        /// <summary>
        /// Valida contraseña del usuario.
        /// </summary>
        /// <param name="contraseña"></param> String a ser validado.
        /// <returns></returns> false = fallo | true = exito.
        public override bool ValidarContraseña(string contraseña)
        {
            bool retorno = false;
            if (this.contraseñaUsuario == contraseña)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Inscribe al alumno a una materia.
        /// </summary>
        /// <param name="idMateria"></param> ID de la materia a inscribirse.
        /// <returns></returns> false = fallo | true = exito.
        public bool InscribirseMateria(int idMateria)
        {
            bool retorno = true;
            if (_materias.Count < 2)
            {
                foreach (var id in _materias)
                {

                    if (idMateria == id)
                    {
                        retorno = false;
                        break;
                    }
                }
                if (retorno == true)
                {
                    _materias.Add(idMateria);
                    AgregarMateriaAlAlumno(idMateria);
                }
            }
            return retorno;
        }

        /// <summary>
        /// Agrega a una lista, las materias que aprobo el alumno.
        /// </summary>
        /// <param name="materia"></param> Materia a ser agregada.
        public void AgregarMateriaAprobada(Materia materia)
        {
            this._materiasAprobadas.Add(materia);
        }
    }
}
