using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace GrouponDesktop
{
    class DataManager
    {
        private static DataManager instance = null;

        static public DataManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataManager();
                return instance;
            }
        }
        private SqlConnection connection;
        public SqlConnection Connection
        {
            get { return connection; }
        }
        private DataManager()
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

        

        String connectionString = "Server=Rodri-PC\\SQLSERVER2008;Database=GD2C2012;User Id=gd;Password=gd2012;";
    }

    /// <summary>
    /// Estros métodos van a ser llamados por métodos especializados por cada tipo de SP. 
    /// Cuando se retorne un SqlDataReader se debe recordar de cerrar el data reader.
    /// </summary>
    public class StoredProcedureHelper
    {
        public SqlDataReader executeSPWithOutParameters(String spName)
        {
            SqlConnection conn = DataManager.Instance.Connection;
            SqlDataReader rdr = null;
            try
            {

                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                rdr = cmd.ExecuteReader();
                return rdr;
            }
            catch
            {
                throw new Exception("no se pudo ejecutar el StoredProcedure");
            }
        }
        public void executeSPWithParametersWithOutReturn(String spName, Dictionary<String, Object> parameters)
        {
            SqlConnection conn = DataManager.Instance.Connection;
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
            }
            catch(Exception e)
            {
                throw new Exception("no se pudo ejecutar el StoredProcedure por: " + e);
            }
        }
    }


}
