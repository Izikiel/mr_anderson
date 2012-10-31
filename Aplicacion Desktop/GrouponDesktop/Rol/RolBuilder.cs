using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.Rol
{
    class RolBuilder
    {
        //hacer el chequeo de q las funcionalidades sean validas desde la ui

        public FuncRol getFuncRol(String nombreFunc)
        {
            switch (nombreFunc)
            {
                case "comprarGiftCard":
                    return new FuncRol("cliente");
                    

            }

            return null;
        }

        public Rol buildRol(String nombreRol, String tipoUsuario, List<String> funcionalidades)
        {
            Rol unRol = new Rol();
            foreach (String unaFuncionalidad in funcionalidades)
            {
                unRol.addFunc(this.getFuncRol(unaFuncionalidad));
            }
            unRol.setNombreRol(nombreRol);
            unRol.addTipoUsuario(tipoUsuario);
            unRol.setEstadoValido(true);
            return unRol;
        }
    }
}
