using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GrouponDesktop.User;

namespace GrouponDesktop.Rol
{
    class FuncRol
    {
        private String usuarioValido;


        public FuncRol(String unUsuarioValido)
        {
            this.usuarioValido = unUsuarioValido;
        }

        public Boolean esUsuarioValido(User.User unUsuario)
        {
            return unUsuario.getTipoUsuario() == this.usuarioValido;
        }
    }
}
