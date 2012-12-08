using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace GrouponDesktop.Dominio.DataAdapter
{
    class FuncionesCupones
    {
        public List<Cupon> obtenerCupones(String dni, DateTime fecha)
        {
            List<Cupon> cupones = new List<Cupon>();
            DataAccess.SPManager spManager = new GrouponDesktop.DataAccess.SPManager();
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("dni", Int32.Parse(dni));
            parameters.Add("fecha", fecha);

            using (SqlDataReader reader = spManager.executeSPWithParameters("MR_ANDERSON.sp_ver_cupones_habilitados", parameters))
            {
                while (reader.Read())
                {
                    Cupon cupon = new Cupon();
                    cupon.Codigo = ((String)reader["codigo"]).Trim();
                    cupon.Descripcion = ((String)reader["descripcion"]).Trim();
                    cupones.Add(cupon);
                }
                reader.Close();
            }
            return cupones;
        }

        public string comprarCupones(String dni, String codigo, int cantidad, DateTime fecha)
        {
            DataAccess.SPManager spManager = new GrouponDesktop.DataAccess.SPManager();
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("dni", Int32.Parse(dni));
            parameters.Add("codigo", codigo);
            parameters.Add("cantidad", cantidad);
            parameters.Add("fecha_compra", fecha);
            try
            {
                spManager.executeSPWithParametersWithOutReturn("MR_ANDERSON.sp_comprar_cupon", parameters);
                return "Compra exitosa";
            }
            catch (Exception e)
            {
                return "Error en compra";
            }
        }

        public string devolverCupon(String dni, String codigo, int cantidad, DateTime fecha)
        {
            return "";
        }


    }
}
