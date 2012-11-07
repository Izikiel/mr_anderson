using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.Rol
{
    class Rol
    {
        String nombre;
        String tipoUsuario;
        List<String> funcionalidades;
        Boolean estadoValido;

        public Rol(){
            this.funcionalidades = new List<String>();
        }

        public Rol cargar()
        {
            cargarDatosRol();
            cargarFuncionalidades();

            return this;
        }

        public void cargarDatosRol()
        {
            //llamar a sp q cargue los datos
        }

        public void cargarFuncionalidades()
        {
            //llamar a sp q cargue las func
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


            this.persistir();
        }

        public void persistir()
        {
            //llamar a sp q persista en bd
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


        public String getTipoUsuario()
        {
            return this.tipoUsuario;
        }

        public void addFunc(String unaF){
            this.funcionalidades.Add(unaF);       
        }
        
        public void delFunc(String unaF){
            this.funcionalidades.Remove(unaF);
        }

        public void do_f(String unaF)
        {
            switch (unaF)
            {
                //case "ALTA_ROL" :

                //  break;


            }
        }

    }
}
