using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GrouponDesktop.DataAccess;
using System.Data.SqlClient;

namespace GrouponDesktop.Cupones
{
    class HomeCiudades
    {
        public List<String> getCiudades()
        {
            List<String> ciudades = new List<String>();

            DataAccess.SPManager spManager = new DataAccess.SPManager();

            using (SqlDataReader reader = spManager.executeSPWithOutParameters("MR_ANDERSON.sp_get_ciudades"))
            {
                while (reader.Read())
                {
                    String unaCiudad = ((String)reader["ciudad"]);
                    ciudades.Add(unaCiudad);
                }
                reader.Close();
            }
            spManager.Close();
            return ciudades;
        }
    }
}
