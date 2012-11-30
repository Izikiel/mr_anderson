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


        ////PERSISTENCIA////
        //MR_ANDERSON.sp_insert_cliente (@nombre_sended NVARCHAR(255), @dni_sended NUMERIC(18), @apellido_sended NVARCHAR(255),
          //          @telefono_sended NUMERIC(18) , @mail_sended NVARCHAR(255), @fecha_nac_sended DATETIME,
            //        @username_sended NVARCHAR(100), @result NVARCHAR(19) output)
        //public void agregar(String nombre, int dni, String apellido, int telefono, String mail, String fecha_nac, 

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
