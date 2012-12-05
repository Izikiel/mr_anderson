using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


using GrouponDesktop.DataAdapter;
using GrouponDesktop.DataAccess;

namespace GrouponDesktop.Rol
{
    public class Rol
    {
        private String tipoUsuario;
        public String TipoUsuario
        {
            get { return tipoUsuario; }
            set { tipoUsuario = value; }
        }
        List<String> funcionalidades;
        Boolean estadoValido;

        public Rol(){
            this.funcionalidades = new List<String>();
        }

        private String nombre;
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public Rol cargar(Boolean habilitado, List<String> funcs, String nombre_rol,String tipo)
        {
            this.setEstadoValido(habilitado);
            this.addAllFuncs(funcs);
            this.setNombreRol(nombre_rol);
            this.TipoUsuario = tipo;
            return this;
        }

        public void addAllFuncs(List<String> funcs)
        {   
            foreach (String f in funcs)
            {
                this.addFunc(f);
            }
        }

        
        public void crear(String nombreRol, String tipoUsr, List<String> funcs)
        {
            foreach (String unaFuncionalidad in funcs)
            {
                this.addFunc(unaFuncionalidad);
            }

            this.nombre = nombreRol;
            this.tipoUsuario = tipoUsr;
            this.setEstadoValido(true);

            HomeRoles home= new HomeRoles();
            home.persistir(this);
        }

        public Boolean estaHabilitado() {
            return this.estadoValido;
        }

       
        public void setEstadoValido(Boolean bol)
        {
            this.estadoValido = bol;
        }
        public void setNombreRol(String unNombre){
            nombre = unNombre;
        }

        public String getNombreRol(){
            return this.nombre;
        }

        public void addFunc(String unaF){
            this.funcionalidades.Add(unaF);       
        }
        
        public void delFunc(String unaF){
            this.funcionalidades.Remove(unaF);
        }

        public List<String> getFuncionalidades()
        {
            return funcionalidades;
        }

    }
}
