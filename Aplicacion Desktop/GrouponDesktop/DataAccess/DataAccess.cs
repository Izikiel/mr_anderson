using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace GrouponDesktop
{
    class DBManager
    {
        private SqlConnection connection;
        public SqlConnection Connection
        {
            get { return connection; }
        }

        public DBManager()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch
            {
                throw new Exception("Error al querer abrir la DB");
            }
        }
        public void closeConnection()
        {
            connection.Close();
        }
        

        String connectionString = "Server=Rodri-PC\\SQLSERVER2008;Database=GD2C2012;User Id=gd;Password=gd2012;";
    }

    /// <summary>
    /// Estros métodos van a ser llamados por métodos especializados por cada tipo de SP. 
    /// Cuando se retorne un SqlDataReader se debe recordar de cerrar el data reader.
    /// </summary>
    public class SPManager
    {
        DBManager dbManager; 
        public SPManager()
        {
            dbManager = new DBManager();
        }

        public SqlDataReader executeSPWithOutParameters(String spName)
        {
            try
            {
                return executeSPWithParameters(spName, new Dictionary<string, object>(0));
            }
            catch
            {
                throw new Exception("no se pudo ejecutar el StoredProcedure");
            }
        }
        public SqlDataReader executeSPWithParameters(String spName, Dictionary<String, Object> parameters)
        {
            SqlConnection conn = dbManager.Connection;
            SqlDataReader rdr = null;
            try
            {

                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (String paramKey in parameters.Keys)
                {
                    cmd.Parameters.Add(new SqlParameter("@"+paramKey, parameters[paramKey]));
                }
                rdr = cmd.ExecuteReader();
                return rdr;
            }
            catch(Exception e)
            {
                throw new Exception("no se pudo ejecutar el StoredProcedure por: " + e);
            }
        }
    }


}
