using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Materia
    {
        private int _id;
        private EMateria _nombre;
        private int _cuatrimestre;
        private Profesor _profesor;
        private Dictionary<Alumno, EstadoAlumno> alumnado;
        private EMateria _correlativa;
        private string _fechaExamen;


        public Materia(EMateria nombre, int cuatrimestre, Profesor profesor, EMateria correlativa)
        {
            _id = Generador_Ids();
            _nombre = nombre;
            _cuatrimestre = cuatrimestre;
            _profesor = profesor;
            _correlativa = correlativa;
            alumnado = new Dictionary<Alumno, EstadoAlumno>();
            _fechaExamen = "  ";
        }

        public int Id { get => _id;}
        public EMateria Nombre { get => _nombre; set => _nombre = value; }
        public Profesor Profesor { get => _profesor; set => _profesor = value; }
        public string ProfesorDatos { get => _profesor.ObtenerDatosProfesor(); }
        public int Cuatrimestre { get => _cuatrimestre; set => _cuatrimestre = value; }
        public List<Alumno> AlumnosLista { get => alumnado.Keys.ToList(); }
        public EMateria Correlativa { get => _correlativa; set => _correlativa = value; }
        public string FechaExamen { get => _fechaExamen; set => _fechaExamen = value; }

        /// <summary>
        /// Generador de IDs autoincremental.
        /// </summary>
        static int idAux = 0;
        private static int Generador_Ids()
        {
            idAux = idAux + 1;
            return idAux;
        }

        /// <summary>
        /// Agrega a un alumno al alumnado de la materia.
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns></returns> false = fallo | true = exito.
        public bool AgregarAlumno(Alumno alumno)
        {
            bool retorno = false;
            if (!(alumnado.ContainsKey(alumno)))
            {
                alumnado.Add(alumno, new EstadoAlumno());
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Asigna nota al alumno.
        /// </summary>
        /// <param name="alumno"></param>
        /// <param name="nota"></param>
        public void EvaluarAlumnos(Alumno alumno, int nota)
        {
            foreach (KeyValuePair<Alumno, EstadoAlumno> itemAlumno in alumnado)
            {
                if (alumno == itemAlumno.Key)
                {
                    if (itemAlumno.Value.NotaExamen == 0)
                    {
                        itemAlumno.Value.NotaExamen = nota;
                        if (nota > 6 && itemAlumno.Value.EstadoCursada == EstadoCursada.Regular)
                        {
                            alumno.AgregarMateriaAprobada(this);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Metodo que modifica el presente del alumno dentro de esta materia.
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns></returns> false = fallo | true = exito.
        public bool PonerPresenteAlumno(Alumno alumno)
        {
            bool retorno = false;
            if (this.AlumnosLista.Contains(alumno))
            {
                alumnado.TryGetValue(alumno, out EstadoAlumno estadoAlumno);
                if (estadoAlumno.Presente == false)
                {
                    estadoAlumno.Presente = true;
                    retorno = true;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Modifica la regularidad del Alumno.
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns></returns> false = fallo | true = exito.
        public bool CambiarEstadoAlumno(Alumno alumno)
        {
            bool retorno = false;
            if (this.AlumnosLista.Contains(alumno))
            {
                alumnado.TryGetValue(alumno, out EstadoAlumno estadoAlumno);
                if (estadoAlumno.EstadoCursada == EstadoCursada.Regular)
                {
                    estadoAlumno.EstadoCursada = EstadoCursada.Libre;
                }
                else
                {
                    estadoAlumno.EstadoCursada = EstadoCursada.Regular;
                }
            }
            return retorno;
        }
        
        /// <summary>
        /// Recibe el estado de regularidad del Alumno.
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns></returns>
        public string RecibirEstadoDeAlumno(Alumno alumno)
        {
            if (this.AlumnosLista.Contains(alumno))
            {
                alumnado.TryGetValue(alumno, out EstadoAlumno estadoAlumno);
                return (estadoAlumno.EstadoCursada).ToString();
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// Asigna la fecha de examen al atributo fechaExamen.
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns></returns> false = fallo | true = exito.
        public bool AsignarFechaExamen(string fecha)
        {
            bool retorno = false;
            if (fecha != "  ")
            {
                if (_fechaExamen == "  ")
                {
                    _fechaExamen = fecha;
                    retorno = true;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Busca la nota del alumno.
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns></returns> Retorna nota | 0 si fallo.
        public int MostrarNotaAlumno(Alumno alumno)
        {
            int retorno = 0;
            if (this.AlumnosLista.Contains(alumno))
            {
                alumnado.TryGetValue(alumno, out EstadoAlumno estadoAlumno);
                retorno = estadoAlumno.NotaExamen;
            }
            return retorno;
        }
        
    }
}
