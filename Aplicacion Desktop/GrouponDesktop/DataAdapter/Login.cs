using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

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
            SqlDataReader reader = spManager.executeSPWithParameters("MR_ANDERSON.sp_login", parameters, out command);
            string resultado = (string)command.Parameters["@result"].Value;

            reader.Close();
            spManager.Close();

            if (!resultado.Equals("LOGIN_OK"))
            {
                throw new Exception(resultado);
            }
            
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
            set { password = value; }
        }
    }
}
