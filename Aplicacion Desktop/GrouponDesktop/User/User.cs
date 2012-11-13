using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GrouponDesktop.Rol;
using GrouponDesktop.DataAdapter;
using System.Data.SqlClient;

namespace GrouponDesktop.User
{
    class User
    {

        private Login datosLogin;
        public Login DatosLogin
        {
            get{return datosLogin;}
            set{datosLogin = value;}
        }

        private Rol.Rol rol;
        public Rol.Rol Rol
        {
            get{return rol;}
            set{rol = value;}
        }

        public User()
        {

        }
        
        public void cargar()
        {
            DataAccess.SPManager spManager = new DataAccess.SPManager();

            Dictionary<String, Object> param = new Dictionary<String, Object>();
            param.Add("nombre_usuario", this.datosLogin.UserName);
            using (SqlDataReader reader = spManager.executeSPWithParameters("MR_ANDERSON.get_nombre_rol_de_usuario", param))
            {
                reader.Read();
                this.Rol = new Rol.Rol();
                this.rol.cargar((String) reader["rol"]);
            }

            spManager.Close();
        }
    }
}
