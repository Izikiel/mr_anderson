using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GrouponDesktop
{
    class Login
    {
        public void validateUser()
        {
            DataAccess.SPManager spManager = new GrouponDesktop.DataAccess.SPManager();
            Dictionary<String, Object> parameters = new Dictionary<string,object>();
            parameters.Add("UserName", userName);
            parameters.Add("Password", password);

            //SqlDataReader dataReader = spManager.executeSPWithParameters("Log In", parameters);
            //dataReader.GetString(0);

//            dataReader.Close();
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
            set { password = value; }
        }
    }
}
