using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public static class BaseDatos
    {
        static List<Usuario> usuarios;
        static List<Profesor> profesores;
        static List<Materia> materias;
        static List<Alumno> alumnos;
        static Materia progra1;
        static Materia labo1;
        static Dictionary<EMateria, EMateria> correlatividades;
        static Dictionary<EMateria, int> cuatrimestres;

        static BaseDatos()
        {
            usuarios = new List<Usuario>();
            materias = new List<Materia>();
            alumnos = new List<Alumno>();
            profesores = new List<Profesor>();
            correlatividades = new Dictionary<EMateria, EMateria>();
            cuatrimestres = new Dictionary<EMateria, int>();
            HardCodearValoresIniciales();
        }

        private static void HardCodearValoresIniciales()
        {
            Admin administrador = new Admin("admin", "admin");

            Profesor profesor = new Profesor("profesor", "profesor", "German", "Scarafilo");
            Profesor profesor2 = new Profesor("mrampi", "mrampi", "Mario", "Rampi");
            profesores.Add(profesor);
            profesores.Add(profesor2);

            Alumno alumno = new Alumno("alumno", "alumno", "Juan", "Perez");
            Alumno alumno2 = new Alumno("pavlov44", "pavlov44", "Valeriy", "Pavlov");
            Alumno alumno3 = new Alumno("pazos33", "pazos33", "Nahuel", "Pazos");
            alumnos.Add(alumno);
            alumnos.Add(alumno2);
            alumnos.Add(alumno3);

            progra1 = new Materia(EMateria.Programacion_I, 1, profesor, EMateria.Sin_Correlatividad);
            labo1 = new Materia(EMateria.Laboratorio_I, 1, profesor2, EMateria.Sin_Correlatividad);
            materias.Add(labo1);
            materias.Add(progra1);

            alumno.InscribirseMateria(1);
            alumno.InscribirseMateria(2);
            progra1.AgregarAlumno(alumno);
            labo1.AgregarAlumno(alumno);

            usuarios.Add(administrador);
            usuarios.Add(profesor);
            usuarios.Add(profesor2);
            usuarios.Add(alumno);
            usuarios.Add(alumno2);
            usuarios.Add(alumno3);

            EstablecerCuatrimestres();
            EstablecerCorrelatividades();
        }

        public static List<Usuario> Usuarios
        {
            get => usuarios;
        }

        public static Usuario AgregarUsuarios
        {
            set => usuarios.Add((Usuario)value);
        }

        public static List<Materia> Materias
        {
            get => materias;
        }
        public static Materia AgregarMateria
        {
            set => materias.Add((Materia)value);
        }

        public static List<Profesor> Profesores
        {
            get => profesores;
        }

        public static Profesor AgregarProfesores
        {
            set => profesores.Add((Profesor)value);
        }

        public static List<Alumno> Alumnos
        {
            get => alumnos;
        }

        public static Alumno AgregarAlumnos
        {
            set => alumnos.Add((Alumno)value);
        }

        /// <summary>
        /// Establece los cuatrimestres para las Materias.
        /// </summary>
        private static void EstablecerCuatrimestres()
        {
            cuatrimestres.Add(EMateria.Programacion_I, 1);
            cuatrimestres.Add(EMateria.Laboratorio_I, 1);
            cuatrimestres.Add(EMateria.Ingles_I, 1);
            cuatrimestres.Add(EMateria.Sis_Proc_Datos, 1);
            cuatrimestres.Add(EMateria.Matematica, 1);
            cuatrimestres.Add(EMateria.Programacion_II, 2);
            cuatrimestres.Add(EMateria.Laboratorio_II, 2);
            cuatrimestres.Add(EMateria.Ingles_II, 2);
            cuatrimestres.Add(EMateria.Metodologia, 2);
            cuatrimestres.Add(EMateria.Estadistica, 2);
            cuatrimestres.Add(EMateria.Arq_Sist_Operat, 2);
            cuatrimestres.Add(EMateria.Programacion_III, 3);
            cuatrimestres.Add(EMateria.Laboratorio_III, 3);
            cuatrimestres.Add(EMateria.Ingles_III, 3);
        }

        /// <summary>
        /// Establece las correlatividades para las Materias.
        /// </summary>
        private static void EstablecerCorrelatividades()
        {
            correlatividades.Add(EMateria.Programacion_I, EMateria.Sin_Correlatividad);
            correlatividades.Add(EMateria.Laboratorio_I, EMateria.Sin_Correlatividad);
            correlatividades.Add(EMateria.Matematica, EMateria.Sin_Correlatividad);
            correlatividades.Add(EMateria.Ingles_I, EMateria.Sin_Correlatividad);
            correlatividades.Add(EMateria.Sis_Proc_Datos, EMateria.Sin_Correlatividad);
            correlatividades.Add(EMateria.Programacion_II, EMateria.Programacion_I);
            correlatividades.Add(EMateria.Laboratorio_II, EMateria.Laboratorio_I);
            correlatividades.Add(EMateria.Estadistica, EMateria.Matematica);
            correlatividades.Add(EMateria.Ingles_II, EMateria.Ingles_I);
            correlatividades.Add(EMateria.Metodologia, EMateria.Sin_Correlatividad);
            correlatividades.Add(EMateria.Arq_Sist_Operat, EMateria.Sis_Proc_Datos);
            correlatividades.Add(EMateria.Programacion_III, EMateria.Programacion_II);
            correlatividades.Add(EMateria.Laboratorio_III, EMateria.Laboratorio_II);
            correlatividades.Add(EMateria.Ingles_III, EMateria.Ingles_II);
        }

        /// <summary>
        /// Validacion de Login.
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="contraseña"></param>
        /// <returns></returns> retorna el usuario logeado o null si fallo.
        public static Usuario ValidarLogin(string nombreUsuario, string contraseña)
        {
            Usuario user = null;
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.NombreUsuario == nombreUsuario)
                {
                    if (ValidarContraseña(usuario, contraseña))
                    {
                        user = usuario;
                    }
                }
            }
            return user;
        }

        /// <summary>
        /// Validacion de la contraseña.
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contraseña"></param>
        /// <returns></returns> false = fallo | true = exito.
        private static bool ValidarContraseña(Usuario usuario, string contraseña)
        {
            bool retorno = false;
            if (usuario.ValidarContraseña(contraseña))
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Asigna el cuatrimestre a la materia.
        /// </summary>
        /// <param name="materia"></param>
        /// <returns></returns> Retorna -1 si fallo u otro valor si fue exitoso
        public static int AsignarCuatrimestre(EMateria materia)
        {
            int retorno = -1;
            foreach (var item in cuatrimestres)
            {
                if (materia == item.Key)
                {
                    retorno = item.Value;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Asignacion de correlatividades.
        /// </summary>
        /// <param name="materia"></param> Materia de la cual se pretende conseguir la correlatividad.
        /// <returns></returns> Retorna la correlatividad si existe.
        public static EMateria AsignarCorrelatividad(EMateria materia)
        {
            EMateria retorno = EMateria.Sin_Correlatividad;
            foreach (var item in correlatividades)
            {
                if (materia == item.Key)
                {
                    retorno = item.Value;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Retorna una Lista de Materias que contengan al alumno.
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns></returns> Lista de Materias
        public static List<Materia> MateriasDelAlumno(Alumno alumno)
        {
            List<Materia> retorno = new List<Materia>();
            foreach (Materia materia in materias)
            {
                if (materia.AlumnosLista.Contains(alumno))
                { 
                    retorno.Add(materia);
                }
            }
            return retorno;
        }

        /// <summary>
        /// Registra la asistencia para el alumno.
        /// </summary>
        /// <param name="alumno"></param>
        /// <param name="materia"></param>
        /// <returns></returns> false = fallo | true = exito.
        public static bool RegistrarPresenteAlumno(Alumno alumno, Materia materia)
        { 
            return materia.PonerPresenteAlumno(alumno);
        }
    }
}
