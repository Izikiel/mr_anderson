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
        List<FuncRol> funcionalidades;
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
        
    }
}
