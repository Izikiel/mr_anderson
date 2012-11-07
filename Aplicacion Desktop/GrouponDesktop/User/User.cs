using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GrouponDesktop.Rol;

namespace GrouponDesktop.User
{
    class User
    {
        String tipoUsuario;
        Rol.Rol unRol;
        public User()
        {

        }
        public void setTipoUsuario(String unTipo)
        {
            this.tipoUsuario = unTipo;
        }
        public String getTipoUsuario()
        {
            return this.tipoUsuario;
        }

        public void setRol(Rol.Rol rol)
        {
            this.unRol = rol;
        }

        public Rol.Rol getRol()
        {
            return this.unRol;
        }
    }
}
