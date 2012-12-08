using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using GrouponDesktop.DataAdapter;
using GrouponDesktop.Rol;
using GrouponDesktop.Dominio.DataAdapter;

namespace GrouponDesktop.User
{
    class HomeUsuarios
    {
        //////BUSQUEDAS /////

        /// <summary>
        /// Devuelve el Usuario inicializado, sin datos. Solo 
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public User getUsuario(Login login)
        {
            User usuario = new User();
            usuario.DatosLogin = login;

            DataAccess.SPManager spManagerLogin = new DataAccess.SPManager();
            Dictionary<String, Object> param_login = new Dictionary<String, Object>();

            param_login.Add("nombre_usuario", login.UserName);

            SqlDataReader reader_login = spManagerLogin.executeSPWithParameters("MR_ANDERSON.sp_usuario_habilitado", param_login);
            reader_login.Read();

            if (Convert.ToInt16(reader_login["Habilitado"]).Equals(1)) usuario.DatosLogin.Habilitado = true;
            else usuario.DatosLogin.Habilitado = false;
            spManagerLogin.Close();

                
            return usuario;
        }
        /// <summary>
        /// A este método le pasaremos un usuario, y se encargará de agregarle la información o en su debido caso, actualizarla.
        /// Se puede usar después de Cargar crédito, o hacer alguna modificación en la Configuración del usuario.
        /// </summary>
        /// <param name="usuario"></param>
        public void setInformacionAlUsuario(User usuario)
        {
            setUsuarioRol(usuario);
            setUsuarioDirecciones(usuario);
            setDatosUsuarioAlUsuario(usuario);

        }

        private static void setUsuarioRol(User usuario)
        {
            DataAccess.SPManager spManager = new DataAccess.SPManager();
            Dictionary<String, Object> param = new Dictionary<String, Object>();
            param.Add("nombre_usuario", usuario.DatosLogin.UserName);
            using (SqlDataReader reader = spManager.executeSPWithParameters("MR_ANDERSON.get_nombre_rol_de_usuario", param))
            {
                reader.Read();
                HomeRoles home = new HomeRoles();
                usuario.Rol = home.getRol((String)reader["rol"]);
            }

            spManager.Close();
        }

        /// <summary>
        /// Este método se encargara de setear las direcciones en el Usuario que se le pasa
        /// </summary>
        /// <param name="usuario"></param>
        public void setUsuarioDirecciones(User usuario)
        {
            DataAccess.SPManager spManager2 = new DataAccess.SPManager();

            Dictionary<String, Object> param_direccion = new Dictionary<string, object>();
            param_direccion.Add("username", usuario.DatosLogin.UserName);
            using (SqlDataReader reader2 = spManager2.executeSPWithParameters("MR_ANDERSON.sp_get_direccion", param_direccion))
            {
                if (!reader2.HasRows)
                {
                    return;
                }
                reader2.Read();
                usuario.Direccion = new Direccion();
                usuario.Direccion.Calle = (string)reader2["calle"];
                if (!Convert.IsDBNull(reader2["depto"])) usuario.Direccion.Depto = (string)reader2["depto"];
                if (!Convert.IsDBNull(reader2["codigo_postal"])) usuario.Direccion.CodigoPostal = Convert.ToInt32(reader2["codigo_postal"]);
                if (!Convert.IsDBNull(reader2["nro_piso"])) usuario.Direccion.Piso = Convert.ToInt32(reader2["nro_piso"]);
                usuario.Direccion.Localidad = (string)reader2["localidad"];

            }
            spManager2.Close();
        }

        public void setDatosUsuarioAlUsuario(User usuario)

        {
            if (usuario.Rol.TipoUsuario == "Cliente")
            {
                usuario.DatosCliente = getDatosCliente(usuario.DatosLogin.UserName);
            }
            if (usuario.Rol.TipoUsuario == "Proveedor")
            {
                usuario.DatosProveedor = getDatosProveedor(usuario.DatosLogin.UserName);
            }
        }

        /// <summary>
        /// Solo para Clientes
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        /// 

        public DatosCliente getDatosCliente(String username)
        {
            DatosCliente datosCliente = new DatosCliente();
            DataAccess.SPManager spManager = new DataAccess.SPManager();

            Dictionary<String, Object> param = new Dictionary<String, Object>();
            param.Add("username", username);


            using (SqlDataReader reader = spManager.executeSPWithParameters("MR_ANDERSON.sp_get_datos_cliente", param))
            {
                reader.Read();
                datosCliente.Apellido = (string)reader["apellido"];
                datosCliente.Nombre = (string)reader["nombre"];
                datosCliente.Saldo = Convert.ToInt32(reader["saldo"]);
                datosCliente.Telefono = Convert.ToString(reader["telefono"]);
                datosCliente.Mail = (string)reader["mail"];
                datosCliente.FechaNac = Convert.ToString(reader["fecha_nac"]);
                datosCliente.Dni = Convert.ToString(reader["dni"]);
            }
            spManager.Close();
            return datosCliente;
        }

        public DatosProveedor getDatosProveedor(String username)
        {
            DatosProveedor datosProveedor = new DatosProveedor();
            DataAccess.SPManager spManager = new DataAccess.SPManager();

            Dictionary<String, Object> param = new Dictionary<String, Object>();
            param.Add("username", username);


            using (SqlDataReader reader = spManager.executeSPWithParameters("MR_ANDERSON.sp_get_datos_proveedor", param))
            {
                reader.Read();
                datosProveedor.Cuit = (string)reader["provee_cuit"];
                datosProveedor.RazonSocial = (string)reader["provee_rs"];
                //datosCliente.Saldo = Convert.ToInt32(reader["provee_cuit"]);
                datosProveedor.Telefono = Convert.ToString(reader["provee_telefono"]);
                datosProveedor.Rubro = (string)reader["provee_rubro"];
                try
                {
                    datosProveedor.NombreContacto = (string)reader["nombre_contacto"];
                    datosProveedor.Mail = (string)reader["provee_email"];
                }
                catch
                {
                }
            }
            spManager.Close();
            return datosProveedor;
        }



        public User getProveedor(Login login)
        {
            User usuario = this.getUsuario(login);
            this.setInformacionAlUsuario(usuario);
            DataAccess.SPManager spManager = new DataAccess.SPManager();

            Dictionary<String, Object> param = new Dictionary<String, Object>();
            param.Add("username", login.UserName);
            using (SqlDataReader reader = spManager.executeSPWithParameters("MR_ANDERSON.sp_get_datos_proveedor", param))
            {
                reader.Read();
                usuario.DatosProveedor = new DatosProveedor();
                usuario.DatosProveedor.Cuit = (string)reader["provee_cuit"];
                usuario.DatosProveedor.RazonSocial = (string)reader["provee_rs"];
                usuario.DatosProveedor.Telefono = Convert.ToString(reader["provee_telefono"]);
                usuario.DatosProveedor.Rubro = (string)reader["provee_rubro"];
                if(!Convert.IsDBNull(reader["nombre_contacto"]))
                    usuario.DatosProveedor.NombreContacto = (string)reader["nombre_contacto"];
                if (!Convert.IsDBNull(reader["provee_email"]))
                usuario.DatosProveedor.Mail = (string)reader["provee_email"];

            }
            spManager.Close();

            return usuario;
        }


        private void setSaldoAlUsuario(User usuario)
        {
            usuario.DatosCliente = new DatosCliente();
            usuario.DatosCliente.Saldo = 100;
        }

     

        public List<UserStringContainer> getNombreUsuarios(String tipo)
        {//retorna los usuarios de un tipo
            List<UserStringContainer> usuarios = new List<UserStringContainer>();

            DataAccess.SPManager spManager = new DataAccess.SPManager();

            Dictionary<String, Object> param = new Dictionary<String, Object>();
            param.Add("tipo", tipo);
            using (SqlDataReader reader = spManager.executeSPWithParameters("MR_ANDERSON.sp_get_all_usrs", param))
            {
                while (reader.Read())
                {
                    UserStringContainer user = new UserStringContainer();
                    user.Nombre = (String)reader["username"];
                    usuarios.Add(user);
                }
                reader.Close();
            }
            spManager.Close();
            return usuarios;

        }

        public List<UserStringContainer> getNombreUsuarios(String tipo, String filtro1, String filtro2, String filtro3, String filtro4)
        {

            List<UserStringContainer> usuarios = new List<UserStringContainer>();

            DataAccess.SPManager spManager = new DataAccess.SPManager();

            Dictionary<String, Object> param = new Dictionary<String, Object>();
            param.Add("tipo", tipo);
            if(filtro1 != null) param.Add("filtro1", "%" + filtro1 + "%");
            if(filtro2 != null) param.Add("filtro2", "%" + filtro2 + "%");
            if(filtro3 != null) param.Add("filtro3", "%" + filtro3 + "%");
            if(filtro4 != null) param.Add("filtro4", "%" + filtro4 + "%");

            using (SqlDataReader reader = spManager.executeSPWithParameters("MR_ANDERSON.sp_get_usrs_filtrados", param))
            {
                while (reader.Read())
                {
                    UserStringContainer user = new UserStringContainer();
                    user.Nombre = (String)reader["username"];
                    usuarios.Add(user);
                }
                reader.Close();
            }
            spManager.Close();
            return usuarios;

            
        }

        ////PERSISTENCIA////

        public void persistir(User usuario)
        {
            List<String> funcs = new List<String>();

            DataAccess.SPManager spManager2 = new DataAccess.SPManager();

            Dictionary<String, Object> param_login = new Dictionary<String, Object>();
            param_login.Add("username_sended", usuario.DatosLogin.UserName);
            param_login.Add("user_password_sended", usuario.DatosLogin.Password);
            param_login.Add("rol_sended", usuario.Rol.getNombreRol());
            param_login.Add("tipo", usuario.TipoUsuario);
            param_login.Add("result output", "");

            spManager2.executeSPWithParameters("MR_ANDERSON.sp_insert_login", param_login);
            spManager2.Close();

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
                

                DataAccess.SPManager spManager3 = new DataAccess.SPManager();


                foreach (String c in usuario.CuidadesPreferencia)
                {
                    Dictionary<String, Object> param_ciudades = new Dictionary<string, object>();
                    param_ciudades.Add("ciudad", c);
                    param_ciudades.Add("dni", usuario.DatosCliente.Dni);
                    spManager3.executeSPWithParametersWithOutReturn("MR_ANDERSON.sp_add_ciudad_user",param_ciudades);
                }

                spManager3.Close();
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
                SqlCommand command_prov;
                spManager.executeSPWithParameters("MR_ANDERSON.sp_insert_proveedor", param_prov,out command_prov);
                String resultado_prov = command_prov.Parameters["@result"].Value.ToString();
                if (!resultado_prov.Equals("PROV_REG_OK"))
                {
                    throw new Exception(resultado_prov); 
                }

            }
            spManager.Close();
            
            

            DataAccess.SPManager spManager4 = new DataAccess.SPManager();

            Dictionary<String, Object> param_direccion = new Dictionary<string, object>();
            param_direccion.Add("calle", usuario.Direccion.Calle);

            param_direccion.Add("localidad", usuario.Direccion.Localidad);
            param_direccion.Add("username", usuario.DatosLogin.UserName);
            param_direccion.Add("nro_piso", usuario.Direccion.Piso);
            param_direccion.Add("depto", usuario.Direccion.Depto);
            param_direccion.Add("codigo_postal", usuario.Direccion.CodigoPostal);
            param_direccion.Add("result output", "");

            SqlCommand command2;
            spManager4.executeSPWithParameters("MR_ANDERSON.sp_insert_direccion",param_direccion, out command2);

            String resultado2 = command2.Parameters["@result"].Value.ToString();
            if (!resultado2.Equals("OK"))
            {
                throw new Exception(resultado2);
            }

            spManager4.Close();

         
        }

        public void modificarRol(String nombreViejo, String nombreNuevo)
        {
            DataAccess.SPManager spManager = new DataAccess.SPManager();
            Dictionary<String, Object> param = new Dictionary<string, object>();
            param.Add("nombre_rol", nombreViejo);
            param.Add("nuevo_nombre_rol", nombreNuevo);
            spManager.executeSPWithParametersWithOutReturn("MR_ANDERSON.sp_change_rol_name_a_usuarios", param);
            spManager.Close();
        }

        private void setCiudadesAlUsuario(User usuario)
        {
            DataAccess.SPManager spManager = new DataAccess.SPManager();

            Dictionary<String, Object> param = new Dictionary<String, Object>();
            param.Add("nombre_usuario", usuario.DatosLogin.UserName);
            using (SqlDataReader reader = spManager.executeSPWithParameters("MR_ANDERSON.sp_get_ciudades", param))
            {
                reader.Read();
                HomeRoles home = new HomeRoles();
                usuario.Rol = home.getRol((String)reader["rol"]);
            }

            spManager.Close();
        }

        public void changeStatus(String nombreUsuario, Boolean habilitado)
        {
            int status = 0;
            if (habilitado) status = 1;
            DataAccess.SPManager spManager = new DataAccess.SPManager();

            Dictionary<String, Object> param = new Dictionary<string, object>();
            param.Add("username", nombreUsuario);
            param.Add("habilitado", status);
            spManager.executeSPWithParametersWithOutReturn("MR_ANDERSON.sp_change_status_user", param);

            spManager.Close();
        }


        public void setRolesAlUsuario(User usuario)
        {
            DataAccess.SPManager spManager = new DataAccess.SPManager();

            Dictionary<String, Object> param = new Dictionary<String, Object>();
            param.Add("nombre_usuario", usuario.DatosLogin.UserName);
            using (SqlDataReader reader = spManager.executeSPWithParameters("MR_ANDERSON.get_nombre_rol_de_usuario", param))
            {
                reader.Read();
                HomeRoles home = new HomeRoles();
                usuario.Rol = home.getRol((String)reader["rol"]);
            }

            spManager.Close();
        }

        public void modificarDatosCliente(User clienteViejo, User clienteNuevo)
        {
            DataAccess.SPManager spManager = new DataAccess.SPManager();
            

            Dictionary<String, Object> param = new Dictionary<String, Object>();
            param.Add("nombre_sended",clienteNuevo.DatosCliente.Nombre);
            param.Add("dni_sended", clienteNuevo.DatosCliente.Dni);
            param.Add("apellido_sended", clienteNuevo.DatosCliente.Apellido);
            param.Add("telefono_sended", clienteNuevo.DatosCliente.Telefono);
            param.Add("mail_sended", clienteNuevo.DatosCliente.Mail);
            param.Add("fecha_nac_sended", clienteNuevo.DatosCliente.FechaNac);
            param.Add("username_sended", clienteViejo.DatosLogin.UserName);
            param.Add("result output", "");
            SqlCommand cmd = new SqlCommand();
            spManager.executeSPWithParameters("MR_ANDERSON.sp_modify_client", param,out cmd);
            string resultado = (string)cmd.Parameters["@result"].Value;
            spManager.Close();

            if (!resultado.Equals("OK"))
            {
                throw new Exception(resultado);
            }
            
            
        }

        public void modificarDireccion(String username, Direccion dir)
        {
            DataAccess.SPManager spManager = new DataAccess.SPManager();


            Dictionary<String, Object> param = new Dictionary<String, Object>();
            param.Add("username", username);
            param.Add("calle", dir.Calle);
            param.Add("nro_piso", dir.Piso);
            param.Add("depto", dir.Depto);
            param.Add("localidad", dir.Localidad);
            param.Add("codigo_postal", dir.CodigoPostal);
            SqlCommand cmd = new SqlCommand();
            try{
                spManager.executeSPWithParameters("MR_ANDERSON.sp_modify_direccion", param);
            
            spManager.Close();

        }
            catch(Exception e){
                spManager.Close();
                throw new Exception(e.ToString());
            }
            

        }

        public void eliminarCiudadesDeCliente(String dni, List<String> ciudades)
        {
            Boolean ok = true;
            Dictionary<String, Object> param = new Dictionary<String, Object>();
            param.Add("dni", Convert.ToInt32(dni));
            SqlCommand cmd = new SqlCommand();
            
            
            foreach(String c in ciudades){

                try
                {
                    DataAccess.SPManager spManager = new DataAccess.SPManager();
                    param.Add("ciudad_a_borrar", c);
                    spManager.executeSPWithParameters("MR_ANDERSON.sp_delete_ciudad", param);
                    param.Remove("ciudad_a_borrar");
                    spManager.Close();
                }
                catch (Exception )
                {
                    ok = false;
                    
                }
                
            }

            if (!ok) {
                throw new Exception("Fallo al eliminar ciudades");
            }
            
        }

        public void agregarCiudadesACliente(String dni, List<String> ciudades)
        {
            Boolean ok = true;
            

            Dictionary<String, Object> param = new Dictionary<String, Object>();
            param.Add("dni", Convert.ToInt32(dni));
            param.Add("result output", "");
            SqlCommand cmd = new SqlCommand();

            foreach (String c in ciudades)
            {
                DataAccess.SPManager spManager = new DataAccess.SPManager();
                    param.Add("ciudad", c);
                    spManager.executeSPWithParameters("MR_ANDERSON.sp_agregar_ciudad", param, out cmd);
                    string resultado = (string)cmd.Parameters["@result"].Value;
                    param.Remove("ciudad");
                    if (!resultado.Equals("OK")) ok = false;
                    spManager.Close();
                
            }

            if (!ok)
            {
                throw new Exception("Fallo al agregar ciudades");
            }

        }

        public void modificarCliente(User clienteViejo, User clienteNuevo,
            List<String> ciudadesOriginales, List<String> ciudadesSeleccionadas, Boolean modificarCiudades,Boolean habilitado)
        {
            DataAccess.SPManager spManager = new DataAccess.SPManager();
            SqlTransaction tran = spManager.DbManager.Connection.BeginTransaction();
            try
            {
                if (modificarCiudades)
                {
                    this.eliminarCiudadesDeCliente(clienteViejo.DatosCliente.Dni, ciudadesOriginales);
                    this.agregarCiudadesACliente(clienteViejo.DatosCliente.Dni, ciudadesSeleccionadas);
                }

                this.modificarDireccion(clienteViejo.DatosLogin.UserName, clienteNuevo.Direccion);
                this.changeStatus(clienteViejo.DatosLogin.UserName, habilitado);
                this.modificarDatosCliente(clienteViejo, clienteNuevo);
            }
            catch (Exception e)
            {
                tran.Rollback();
                spManager.Close();
                throw new Exception("No se pudo modificar al cliente por : " + e.ToString());

            }
            tran.Commit();
            spManager.Close();
        }

        public void modificarDatosProveedor(User provViejo, User provNuevo)
        {

            DataAccess.SPManager spManager = new DataAccess.SPManager();

            Dictionary<String, Object> param = new Dictionary<String, Object>();
            param.Add("cuit_sended", provNuevo.DatosProveedor.Cuit);
            param.Add("rs_sended", provNuevo.DatosProveedor.RazonSocial);
            param.Add("rubro_sended", provNuevo.DatosProveedor.Rubro);
            param.Add("telefono_sended", provNuevo.DatosProveedor.Telefono);
            param.Add("provee_email_sended", provNuevo.DatosProveedor.Mail);
            param.Add("nombre_contacto_sended", provNuevo.DatosProveedor.NombreContacto);
            param.Add("username_sended", provViejo.DatosLogin.UserName);
            param.Add("result output", "");
            SqlCommand cmd = new SqlCommand();
            spManager.executeSPWithParameters("MR_ANDERSON.sp_modify_proveedor", param, out cmd);
            string resultado = (string)cmd.Parameters["@result"].Value;
            spManager.Close();

            if (!resultado.Equals("OK"))
            {
                throw new Exception(resultado);
            }
        }

        public void modificarProveedor(User provViejo , User provNuevo,Boolean habilitado)
        {
            DataAccess.SPManager spManager = new DataAccess.SPManager();
            SqlTransaction tran = spManager.DbManager.Connection.BeginTransaction();
            try
            {
                this.modificarDireccion(provViejo.DatosLogin.UserName, provNuevo.Direccion);
                this.changeStatus(provViejo.DatosLogin.UserName, habilitado);
                this.modificarDatosProveedor(provViejo, provNuevo);
            }
            catch (Exception e)
            {
                tran.Rollback();
                spManager.Close();
                throw new Exception("No se pudo modificar el proveedor por : " + e.ToString());

            }
            tran.Commit();
            spManager.Close();
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
