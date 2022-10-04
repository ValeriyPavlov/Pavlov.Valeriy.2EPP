using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Admin : Usuario
    {
        public Admin(string nombreUsuario, string contraseñaUsuario) : base(nombreUsuario, contraseñaUsuario)
        {

        }

        public override string Tipo { get { return "Administrador"; } }

        /// <summary>
        /// Metodo sobreescrito de GetType, retorna el tipo del usuario.
        /// </summary>
        /// <returns></returns> Retorna string del tipo de usuario.
        public override string GetType()
        {
            return "Admin";
        }

        /// <summary>
        /// Metodo Validador de contraseña.
        /// </summary>
        /// <param name="contraseña"></param>
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
    }
}
