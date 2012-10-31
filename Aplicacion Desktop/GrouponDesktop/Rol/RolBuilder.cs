using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.Rol
{
    class RolBuilder
    {
        public Rol buildRol(String nombreRol, String tipoUsuario, List<FuncRol> funcionalidades)
        {
            Rol unRol = new Rol();
            foreach (FuncRol unaFuncionalidad in funcionalidades)
            {
                if (!unaFuncionalidad.esUsuarioValido(tipoUsuario))
                {
                    throw new Exception();
                }
                else unRol.addFunc(unaFuncionalidad);

            }
            unRol.setNombreRol(nombreRol);
            unRol.addTipoUsuario(tipoUsuario);
            return unRol;
        }
    }
}
