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
            set { password = SHA256Encrypt(value); }
        }

        public string SHA256Encrypt(string input)
        {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = provider.ComputeHash(inputBytes);

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < hashedBytes.Length; i++)
                output.Append(hashedBytes[i].ToString("x2").ToLower());

            return output.ToString();
        }  
    }
}
