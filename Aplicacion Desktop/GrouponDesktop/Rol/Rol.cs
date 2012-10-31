using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.Rol
{
    class Rol
    {
        String nombreRol;
        List<String> tiposUsuarios;
        List<FuncRol> funcionalidades;

        public Rol(){
            this.funcionalidades = new List<FuncRol>();
            this.tiposUsuarios = new List<String>();
        }

        public void setNombreRol(String unNombre){
            nombreRol = unNombre;
        }

        public String getNombreRol(){
            return this.nombreRol;
        }

        public void addTipoUsuario(String unTipoUsuario)
        {
            this.tiposUsuarios.Add(unTipoUsuario);
        }

        public List<String> getTiposUsuarios()
        {
            return this.tiposUsuarios;
        }

        public void addFunc(FuncRol unaF){
            this.funcionalidades.Add(unaF);       
        }
        

    }
}
