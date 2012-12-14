using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GrouponDesktop.Dominio.DataAdapter;
using System.Data.SqlClient;

namespace GrouponDesktop.Dominio.DataAdapter
{
    class ListadoHistorialCupones
    {
        public List<CuponesStringContainer> historialCuponesPara(int dni, String fecha1, String fecha2)
        {
            List<CuponesStringContainer> listResultado = new List<CuponesStringContainer>();

            DataAccess.SPManager spManager = new GrouponDesktop.DataAccess.SPManager();
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("dni", dni);
            parameters.Add("fecha_inicio", fecha1);
            parameters.Add("fecha_final", fecha2);
            SqlDataReader reader = spManager.executeSPWithParameters("MR_ANDERSON.historial_compra", parameters);
            while (reader.Read())
            {
                CuponesStringContainer objResultado = new CuponesStringContainer();
                if (!Convert.IsDBNull(reader["codigo"])) objResultado.Codigo = Convert.ToString(reader["codigo"]);
                if (!Convert.IsDBNull(reader["estado"])) objResultado.Estado = Convert.ToString(reader["estado"]);
                if (!Convert.IsDBNull(reader["id_compra"])) objResultado.IdCompra = Convert.ToString(reader["id_compra"]);

                listResultado.Add(objResultado);
            }

            reader.Close();
            spManager.Close();
            return listResultado;
        }
    }
}
