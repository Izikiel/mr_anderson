using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GrouponDesktop.DataAdapter
{
    class DataTester
    {

        public void getUsers(DataAccess.SPManager spManager)
        {
            List<String> nombres = new List<string>();
            List<String> direcciones = new List<string>();
            using (SqlDataReader reader = spManager.executeSPWithOutParameters("GetAllUsers"))
            {
                while (reader.Read())
                {
                    String nombre = (String)reader["name"];
                    String direccion = (String)reader["address"];
                    nombres.Add(nombre);
                    direcciones.Add(direccion);
                }
                reader.Close();
            }
        }

        public void insertUser(DataAccess.SPManager spManager)
        {
            Dictionary<String, Object> param = new Dictionary<string,object>();
            param.Add("name", "Carlos");
            param.Add("address", "Medrano 2012");
            param.Add("telephone", "4555-5555");
            param.Add("isActive", true);

            spManager.executeSPWithParameters("InsertUser", param);

        }

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
