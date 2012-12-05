using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using GrouponDesktop.Rol;
using GrouponDesktop.DataAdapter;
using GrouponDesktop.DataAccess;

namespace GrouponDesktop.Rol
{
    class HomeRoles
    {
        //////////BUSQUEDAS/////////////

        public List<Rol> getRoles()
        {
            List<Rol> roles = new List<Rol>();

            DataAccess.SPManager spManager = new DataAccess.SPManager();
            
            using (SqlDataReader reader = spManager.executeSPWithOutParameters("MR_ANDERSON.get_all_roles"))
            {
                while (reader.Read())
                {
                    Rol unRol =   this.getRol((String)reader["rol"]);
                    roles.Add(unRol);
                }
                reader.Close();
            }
            spManager.Close();
            return roles;
        }

        public Rol getRol(String nombre_rol)
        {
            Boolean estado;
            List<String> funcs = new List<String>();

            DataAccess.SPManager spManager = new DataAccess.SPManager();

            Dictionary<String, Object> param = new Dictionary<String, Object>();
            param.Add("nombre_rol", nombre_rol);
            using (SqlDataReader reader = spManager.executeSPWithParameters("MR_ANDERSON.get_datos_rol", param))
            {
                reader.Read();
                if ((Boolean)reader["Habilitado"] == true)
                {
                    estado = true;
                }
                else estado = false;

                funcs.Add((String)reader["Funcionalidad"]);

                while (reader.Read())
                {
                    funcs.Add((String)reader["Funcionalidad"]);
                }
                reader.Close();
            }

            Rol rol = new Rol();
            return rol.cargar(estado, funcs, nombre_rol);
        }

        public List<String> getRolesParaTipo(String tipo)
        {
            DataAccess.SPManager spManager = new DataAccess.SPManager();

            Dictionary<String, Object> param = new Dictionary<string, object>();
            param.Add("tipo", tipo);
            List<String> listaRoles = new List<string>();

            SqlDataReader reader = spManager.executeSPWithParameters("MR_ANDERSON.sp_get_roles_para_tipo", param);
            using (reader)
            {

                while (reader.Read())
                {
                    listaRoles.Add((string)reader["Rol"]);
                }
            }

            spManager.Close();
            return listaRoles;
        }

        ////// PERSISTENCIA /////////
        public void persistir(Rol unRol)
        {
            DataAccess.SPManager spManager = new DataAccess.SPManager();

            Dictionary<String, Object> param = new Dictionary<string, object>();
            param.Add("nombre_rol", unRol.getNombreRol());
            param.Add("tipo", unRol.TipoUsuario);

            try
            {

                spManager.executeSPWithParametersWithOutReturn("MR_ANDERSON.sp_new_rol", param);
            }
            catch (Exception e)
            {
                spManager.Close();
                throw new Exception("No se pudo dar de alta al rol. Motivo: " + e.ToString());
            }

            spManager.Close();

            Dictionary<String, Object> param_funcs = new Dictionary<string, object>();

            foreach (String func in unRol.getFuncionalidades())
            {

                /*spManager = new DataAccess.SPManager();

                param_funcs.Add("funcionalidad", func);

                spManager.executeSPWithParameters("MR_ANDERSON.sp_add_func_rol", param_funcs);

                spManager.Close();

                param_funcs.Remove("funcionalidad");*/
                this.addFuncionalidad(unRol.getNombreRol(), func);
            }
        }

        public void addFuncionalidad(String nombreRol, String f) 
        {
            DataAccess.SPManager spManager = new DataAccess.SPManager();

            Dictionary<String, Object> param = new Dictionary<string, object>();
            param.Add("nombre_rol", nombreRol);
            param.Add("Funcionalidad", f);

            spManager.executeSPWithParametersWithOutReturn("MR_ANDERSON.sp_add_func_rol", param);
            spManager.Close();
                    
        }

        public void deleteFuncionalidad(String nombreRol, String f)
        {
            DataAccess.SPManager spManager = new DataAccess.SPManager();

            Dictionary<String, Object> param = new Dictionary<string, object>();
            param.Add("nombre_rol", nombreRol);
            param.Add("Funcionalidad", f);

            spManager.executeSPWithParametersWithOutReturn("MR_ANDERSON.sp_del_func_rol", param);
            spManager.Close();

        }

        public void modificarNombre(String nombreViejo,String nombreNuevo)
        {
            DataAccess.SPManager spManager = new DataAccess.SPManager();

            Dictionary<String, Object> param = new Dictionary<string, object>();
            param.Add("nombre_rol", nombreViejo);
            param.Add("nuevo_nombre_rol", nombreNuevo);

            spManager.executeSPWithParametersWithOutReturn("MR_ANDERSON.sp_change_rol_name", param);
            spManager.Close();
         
        }

        public void modificarStatus(String nombreRol, Boolean status)
        {

            DataAccess.SPManager spManager = new DataAccess.SPManager();

            Dictionary<String, Object> param = new Dictionary<string, object>();
            param.Add("nombre_rol", nombreRol);
            if (status) param.Add("status", 1);
            else param.Add("status", 0);

            spManager.executeSPWithParametersWithOutReturn("MR_ANDERSON.sp_change_status_rol", param);
            spManager.Close();

        }

        public void eliminar(String nombreRol)
        {

            DataAccess.SPManager spManager = new DataAccess.SPManager();

            Dictionary<String, Object> param = new Dictionary<string, object>();
            param.Add("nombre_rol", nombreRol);

            spManager.executeSPWithParametersWithOutReturn("MR_ANDERSON.sp_eliminar_rol", param);
            spManager.Close();
        }

    }
}
