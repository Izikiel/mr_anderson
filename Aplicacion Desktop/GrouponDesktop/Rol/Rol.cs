using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using GrouponDesktop.DataAdapter;
using GrouponDesktop.DataAccess;

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
           

            DataAccess.SPManager spManager = new DataAccess.SPManager();

            Dictionary<String, Object> param = new Dictionary<string, object>();
            param.Add("nombre_rol", this.nombre);
            try
            {

                spManager.executeSPWithParameters("MR_ANDERSON.sp_new_rol", param);
            }
            catch (Exception e)
            {   
                spManager.Close();
                throw new Exception("No se pudo dar de alta al rol. Motivo: " + e.ToString()); 
                //ver : no me tira error si quiero crear un rol q ya existe (con el mismo nombre)
            }
            spManager.Close();
            
            foreach(String func in this.funcionalidades){

                spManager = new DataAccess.SPManager();

                param.Add("funcionalidad", func);

                   spManager.executeSPWithParameters("MR_ANDERSON.sp_add_func_rol", param);

                spManager.Close();

                param.Remove("funcionalidad");
            }
            

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

        public List<String> getFuncionalidades()
        {
            return funcionalidades;
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
