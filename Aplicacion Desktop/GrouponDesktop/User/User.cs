using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.User
{
    class User
    {
        String tipoUsuario;

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
