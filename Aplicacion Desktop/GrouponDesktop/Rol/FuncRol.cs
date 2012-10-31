using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GrouponDesktop.User;

namespace GrouponDesktop.Rol
{
    class FuncRol
    {
        private List<String> usuariosValidos;


        public FuncRol(String unUsuarioValido)
        {
            this.usuariosValidos = new List<String>();
        }

        public Boolean esUsuarioValido(String tipoUsuario)
        {
            return this.usuariosValidos.Contains(tipoUsuario);
        }
    }
}
