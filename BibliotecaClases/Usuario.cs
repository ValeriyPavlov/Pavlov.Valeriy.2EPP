using System;

namespace BibliotecaClases
{
    public abstract class Usuario
    {
        protected string nombreUsuario;
        protected string contraseñaUsuario;

        protected Usuario(string nombreUsuario, string contraseñaUsuario)
        {
            this.nombreUsuario = nombreUsuario;
            this.contraseñaUsuario = contraseñaUsuario;
        }

        public string NombreUsuario { get { return nombreUsuario; } }
        public virtual string Nombre { get { return ""; } }
        public virtual string Apellido { get { return ""; } }
        public virtual string Tipo { get { return ""; } }

        public abstract bool ValidarContraseña(string contraseña);
        public new abstract string GetType();
    }
}
