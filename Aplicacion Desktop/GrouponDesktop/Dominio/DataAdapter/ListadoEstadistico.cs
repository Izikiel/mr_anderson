using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GrouponDesktop.DataAdapter;
using GrouponDesktop.DataAccess;
using System.Data.SqlClient;

namespace GrouponDesktop.Dominio.DataAdapter
{
    class ListadoEstadistico
    {
        public List<DevolucionCuponesStringContainer> top5DevolucionCupones(int anio, int semestre)
        {
            List<DevolucionCuponesStringContainer> listResultado = new List<DevolucionCuponesStringContainer>();

            DataAccess.SPManager spManager = new GrouponDesktop.DataAccess.SPManager();
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("year", anio);
            parameters.Add("semestre", semestre);
            SqlDataReader reader = spManager.executeSPWithParameters("MR_ANDERSON.sp_estadistico_devoluciones", parameters);
            if (reader.HasRows == false) return listResultado;
            while (reader.Read())
            {
                DevolucionCuponesStringContainer objResultado = new DevolucionCuponesStringContainer();
                if (!Convert.IsDBNull(reader["vendidos"])) objResultado.CuponesVendidos = Convert.ToString(reader["vendidos"]);
                if(!Convert.IsDBNull(reader["devueltos"])) objResultado.CuponesDevueltos = Convert.ToString(reader["devueltos"]);
                if(!Convert.IsDBNull(reader["porcentaje_devueltos"])) objResultado.PorcentajeDevolucion = Convert.ToString(reader["porcentaje_devueltos"]);
                if (!Convert.IsDBNull(reader["username"])) objResultado.NombreProveedor = Convert.ToString(reader["username"]);
                if (!Convert.IsDBNull(reader["descripcion"])) objResultado.NombreProveedor = Convert.ToString(reader["descripcion"]);
                if (!Convert.IsDBNull(reader["codigo"])) objResultado.NombreProveedor = Convert.ToString(reader["codigo"]);

                listResultado.Add(objResultado);
            }

            reader.Close();
            spManager.Close();
            return listResultado;
        }

        public List<UsuariosGiftCardsStringContainer> top5UsuariosGiftCardsAcreditadas(int year, int semestre)
        {
            List<UsuariosGiftCardsStringContainer> listResultado = new List<UsuariosGiftCardsStringContainer>();

            DataAccess.SPManager spManager = new GrouponDesktop.DataAccess.SPManager();
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("year", year);
            parameters.Add("semestre", semestre);
            SqlDataReader reader = spManager.executeSPWithParameters("MR_ANDERSON.sp_estadistico_usuarios", parameters);
            while (reader.Read())
            {
                UsuariosGiftCardsStringContainer objResultado = new UsuariosGiftCardsStringContainer();
                if (!Convert.IsDBNull(reader["nombre_usuario"])) objResultado.NombreUsuario = Convert.ToString(reader["nombre_usuario"]);
                if (!Convert.IsDBNull(reader["cantidad"])) objResultado.CantidadDeGiftCardsAcreditadas = Convert.ToString(reader["cantidad"]);

                listResultado.Add(objResultado);
            }

            reader.Close();
            spManager.Close();
            return listResultado;
        }
    }
}
