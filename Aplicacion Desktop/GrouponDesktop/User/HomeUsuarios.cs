using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using GrouponDesktop.DataAdapter;
using GrouponDesktop.Rol;

namespace GrouponDesktop.User
{
    class HomeUsuarios
    {
        //////BUSQUEDAS /////

        public User getUsuario(Login login)
        {
            User usuario = new User();
            usuario.DatosLogin = login;
            DataAccess.SPManager spManager = new DataAccess.SPManager();

            Dictionary<String, Object> param = new Dictionary<String, Object>();
            param.Add("nombre_usuario", login.UserName);
            using (SqlDataReader reader = spManager.executeSPWithParameters("MR_ANDERSON.get_nombre_rol_de_usuario", param))
            {
                reader.Read();
                HomeRoles home = new HomeRoles();
                usuario.Rol = home.getRol((String)reader["rol"]);
            }

            spManager.Close();
            return usuario;
        }
      

        ////PERSISTENCIA////
        public void persistir(User usuario)
        {
            List<String> funcs = new List<String>();

            DataAccess.SPManager spManager = new DataAccess.SPManager();

            if(usuario.DatosCliente != null){
                Dictionary<String, Object> param_user = new Dictionary<String, Object>();
                
                param_user.Add("dni_sended", usuario.DatosCliente.Dni);
                param_user.Add("apellido_sended",usuario.DatosCliente.Apellido);
                param_user.Add("telefono_sended", usuario.DatosCliente.Telefono);
                param_user.Add("mail_sended", usuario.DatosCliente.Mail);
                param_user.Add("fecha_nac_sended", usuario.DatosCliente.FechaNac);
                param_user.Add("username_sended", usuario.DatosLogin.UserName);
                param_user.Add("nombre_sended", usuario.DatosCliente.Nombre);
                param_user.Add("result output", "");
                SqlCommand command;
                spManager.executeSPWithParameters("MR_ANDERSON.sp_insert_cliente", param_user, out command);
                string resultado = (string)command.Parameters["@result"].Value;
                if (!resultado.Equals("CLIENT_REG_OK"))
                {
                    throw new Exception(resultado);
                }

            }else{
                Dictionary<String, Object> param_prov = new Dictionary<String, Object>();
                param_prov.Add("provee_cuit_sended", usuario.DatosProveedor.Cuit);
                param_prov.Add("provee_rs_sended", usuario.DatosProveedor.RazonSocial);
                param_prov.Add("provee_telefono_sended", usuario.DatosProveedor.Telefono);
                param_prov.Add("provee_rubro_sended", usuario.DatosProveedor.Rubro);
                param_prov.Add("username_sended", usuario.DatosLogin.UserName);
                param_prov.Add("nombre_contacto_sended", usuario.DatosProveedor.NombreContacto);
                param_prov.Add("provee_email_sended", usuario.DatosProveedor.Mail);
                param_prov.Add("result output", "");
                SqlCommand command;
                spManager.executeSPWithParameters("MR_ANDERSON.sp_insert_proveedor", param_prov,out command);
                string resultado = (string)command.Parameters["@result"].Value;
                if (!resultado.Equals("PROV_REG_OK"))
                {
                    throw new Exception(resultado); 
                }

            }
            spManager.Close();
            
            DataAccess.SPManager spManager2 = new DataAccess.SPManager();

            Dictionary<String, Object> param_login = new Dictionary<String, Object>();
            param_login.Add("username_sended", usuario.DatosLogin.UserName);
            param_login.Add("user_password_sended", usuario.DatosLogin.Password);
            param_login.Add("rol_sended", usuario.Rol.getNombreRol());
            param_login.Add("tipo", usuario.TipoUsuario);
            param_login.Add("result output", "");

            spManager2.executeSPWithParameters("MR_ANDERSON.sp_insert_login", param_login);
            spManager2.Close();
        }

        ////VALIDACIONES////
        public Boolean usuarioNoExistente(String nombre)
        {
            DataAccess.SPManager spManager = new DataAccess.SPManager();

            Dictionary<String, Object> param = new Dictionary<string, object>();
            param.Add("nombre_usuario", nombre);
            param.Add("result output", "");
            SqlCommand command;

            SqlDataReader reader = spManager.executeSPWithParameters("MR_ANDERSON.sp_nombre_usuario_no_existente", param,out command);
            if (command.Parameters["@result"].Value.ToString().Equals("0"))
            {
                reader.Close();
                spManager.Close();
                return false;
            }
            reader.Close();
            spManager.Close();
            return true;
            
            
        }
    }
}
