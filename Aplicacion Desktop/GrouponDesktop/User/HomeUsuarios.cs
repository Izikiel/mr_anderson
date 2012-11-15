using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace GrouponDesktop.User
{
    class HomeUsuarios
    {
        //////BUSQUEDAS /////


        ////VALIDACIONES////
        public String usuarioNoExistente(String nombre)
        {
            DataAccess.SPManager spManager = new DataAccess.SPManager();

            Dictionary<String, Object> param = new Dictionary<string, object>();
            param.Add("nombre_usuario", nombre);
            param.Add("result output", "");
            SqlCommand command;

            SqlDataReader reader = spManager.executeSPWithParameters("MR_ANDERSON.sp_nombre_usuario_no_existente", param,out command);
            string resultado = (string)command.Parameters["@result"].Value;
            return resultado;
            reader.Close();
            spManager.Close();
        }
    }
}
