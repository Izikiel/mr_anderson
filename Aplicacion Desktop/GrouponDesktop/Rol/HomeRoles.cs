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
                    Rol unRol =   this.cargar((String)reader["rol"]);
                    roles.Add(unRol);
                }
                reader.Close();
            }
            spManager.Close();
            return roles;
        }

        ////// PERSISTENCIA /////////
        public void persistir(Rol unRol)
        {
            DataAccess.SPManager spManager = new DataAccess.SPManager();

            Dictionary<String, Object> param = new Dictionary<string, object>();
            param.Add("nombre_rol", unRol.getNombreRol());
            try
            {

                spManager.executeSPWithParametersWithOutReturn("MR_ANDERSON.sp_new_rol", param);
            }
            catch (Exception e)
            {
                spManager.Close();
                throw new Exception("No se pudo dar de alta al rol. Motivo: " + e.ToString());
                //ver : no me tira error si quiero crear un rol q ya existe (con el mismo nombre)
            }
            spManager.Close();

            foreach (String func in unRol.getFuncionalidades())
            {

                spManager = new DataAccess.SPManager();

                param.Add("funcionalidad", func);

                spManager.executeSPWithParameters("MR_ANDERSON.sp_add_func_rol", param);

                spManager.Close();

                param.Remove("funcionalidad");
            }
        }

        public Rol cargar(String nombre_rol)
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

        public void modificar(String nombreRol)
        {

            //comunicarse con la base y modificar 
            //modificacion de nombre, de status (habilitado o no) y de funcionalidades (agregar, eliminar)
        }

        public void eliminar(String nombreRol)
        {

            //eliminar de la base
        }

    }
}
