using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.Rol
{
    class Rol
    {
        String nombreRol;
        String tipoUsuario;
        List<FuncRol> funcionalidades;

        public Rol(){
            this.funcionalidades = new List<FuncRol>();
        }

        public void setNombreRol(String unNombre){
            nombreRol = unNombre;
        }

        public String getNombreRol(){
            return this.nombreRol;
        }

        public void setTipoUsuario(String unTipoUsuario)
        {
            this.tipoUsuario = unTipoUsuario;
        }

        public String getTipoUsuario()
        {
            return this.tipoUsuario;
        }

        public void addFunc(FuncRol unaF){
            this.funcionalidades.Add(unaF);       
        }
        

    }
}
