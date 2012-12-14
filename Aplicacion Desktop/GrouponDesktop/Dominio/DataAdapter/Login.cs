using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace GrouponDesktop.DataAdapter
{
   public class Login
    {
       public void validateUser()
       {
           DataAccess.SPManager spManager = new GrouponDesktop.DataAccess.SPManager();
           Dictionary<String, Object> parameters = new Dictionary<string, object>();
           parameters.Add("username_sended", userName);
           parameters.Add("user_password_sended", password);
           parameters.Add("result output", "");
           SqlCommand command;
           string resultado = "";
           try
           {
               SqlDataReader reader = spManager.executeSPWithParameters("MR_ANDERSON.sp_login", parameters, out command);
               resultado = (string)command.Parameters["@result"].Value;
               reader.Close();
           }
           catch
           {
               
           }
           spManager.Close();


           if (!resultado.Equals("LOGIN_OK"))
           {
               throw new Exception(resultado);
           }

       }

       public void setPasswordOldUser()
       {
           DataAccess.SPManager spManager = new GrouponDesktop.DataAccess.SPManager();
           Dictionary<String, Object> parameters = new Dictionary<string, object>();
           parameters.Add("username", this.userName);
           parameters.Add("password", this.password);
           spManager.executeSPWithParametersWithOutReturn("MR_ANDERSON.sp_cambiar_password", parameters);
           spManager.Close();


       }

        private String userName;
        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private String password;
        public String Password
        {
            get { return password; }
            set { password = Dominio.Utilidades.SHA256Encrypt(value); }
        }

        private Boolean habilitado;
        public Boolean Habilitado
        {
            get { return habilitado; }
            set { habilitado = value; }
        }

    }
}
