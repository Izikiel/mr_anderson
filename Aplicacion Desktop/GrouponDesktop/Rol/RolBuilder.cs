using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.Rol
{
    class RolBuilder
    {
        public Rol buildRol(String nombreRol, User.User unUsuario, List<FuncRol> funcionalidades)
        {
            Rol unRol = new Rol();
            foreach (FuncRol unaFuncionalidad in funcionalidades)
            {
                if (!unaFuncionalidad.esUsuarioValido(unUsuario))
                {
                    throw new Exception();
                }
                else unRol.addFunc(unaFuncionalidad);

            }
            unRol.setNombreRol(nombreRol);
            unRol.setTipoUsuario(unUsuario.getTipoUsuario());
            return unRol;
        }
    }
}
