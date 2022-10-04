using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Profesor : Usuario
    {
        private string _nombre;
        private string _apellido;

        public Profesor(string nombreUsuario, string contraseñaUsuario, string nombre, string apellido) : base(nombreUsuario, contraseñaUsuario)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }

        public override string Tipo { get { return "Profesor"; } }
        public override string Nombre { get => _nombre; }
        public override string Apellido { get => _apellido; }
        public string NombreCompleto
        {
            get => this.ObtenerDatosProfesor();
        }

        /// <summary>
        /// Metodo GetType sobreescrito, retorna un string del tipo.
        /// </summary>
        /// <returns></returns>
        public override string GetType()
        {
            return "Profesor";
        }

        /// <summary>
        /// Obtiene el nombre completo del profesor.
        /// </summary>
        /// <returns></returns> string del nombre completo.
        public string ObtenerDatosProfesor()
        { 
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Nombre);
            sb.Append(' ');
            sb.Append(this.Apellido);

            return sb.ToString();
        }

        /// <summary>
        /// Valida contraseña del profesor.
        /// </summary>
        /// <param name="contraseña"></param>
        /// <returns></returns> false si fallo || true si pudo validar.
        public override bool ValidarContraseña(string contraseña)
        {
            bool retorno = false;
            if (this.contraseñaUsuario == contraseña)
            {
                retorno = true;
            }
            return retorno;
        }


    }
}
