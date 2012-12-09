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
            parameters.Add("anio", anio);
            parameters.Add("semestre", semestre);
            parameters.Add("result output", "");
            SqlCommand command;
            SqlDataReader reader = spManager.executeSPWithParameters("poner el nombre del sp", parameters, out command);
            string resultado = (string)command.Parameters["@result"].Value;
            while (reader.Read())
            {
                DevolucionCuponesStringContainer objResultado = new DevolucionCuponesStringContainer();
                if (!Convert.IsDBNull(reader["cantidad_vendidos"])) objResultado.CuponesVendidos = Convert.ToString(reader["cantidad_vendidos"]);
                if(!Convert.IsDBNull(reader["cantidad_devueltos"])) objResultado.CuponesDevueltos = Convert.ToString(reader["cantidad_devueltos"]);
                if(!Convert.IsDBNull(reader["porcentaje_devueltos"])) objResultado.PorcentajeDevolucion = Convert.ToString(reader["porcentaje_devueltos"]);
                if (!Convert.IsDBNull(reader["nombre_usuario"])) objResultado.NombreProveedor = Convert.ToString(reader["nombre_usuario"]);

                listResultado.Add(objResultado);
            }

            reader.Close();
            spManager.Close();
            return listResultado;
        }

        public List<UsuariosGiftCardsStringContainer> top5UsuariosGiftCardsAcreditadas(int anio, int semestre)
        {
            List<UsuariosGiftCardsStringContainer> listResultado = new List<UsuariosGiftCardsStringContainer>();

            DataAccess.SPManager spManager = new GrouponDesktop.DataAccess.SPManager();
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("anio", anio);
            parameters.Add("semestre", semestre);
            parameters.Add("result output", "");
            SqlCommand command;
            SqlDataReader reader = spManager.executeSPWithParameters("poner el nombre del sp", parameters, out command);
            string resultado = (string)command.Parameters["@result"].Value;
            while (reader.Read())
            {
                UsuariosGiftCardsStringContainer objResultado = new UsuariosGiftCardsStringContainer();
                if (!Convert.IsDBNull(reader["nombre_usuario"])) objResultado.NombreUsuario = Convert.ToString(reader["cantidad_vendidos"]);
                if (!Convert.IsDBNull(reader["cantidad"])) objResultado.CantidadDeGiftCardsAcreditadas = Convert.ToString(reader["cantidad_devueltos"]);

                listResultado.Add(objResultado);
            }

            reader.Close();
            spManager.Close();
            return listResultado;
        }
    }
}
