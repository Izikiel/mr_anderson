using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GrouponDesktop.DataAccess
{
    /// <summary>
    /// Estros métodos van a ser llamados por métodos especializados por cada tipo de SP. 
    /// Cuando se retorne un SqlDataReader se debe recordar de cerrar el data reader.
    /// </summary>
    public class SPManager
    {
        private DBManager dbManager;
        public DBManager DbManager
        {
            get { return dbManager; }
        }
        public SPManager()
        {
            dbManager = new DBManager();
        }
        public void Close()
        {
            dbManager.closeConnection();
        }

        public void executeSPWithOutParametersWithOutReturn(String spName)
        {
            try
            {
                SqlDataReader rdr = executeSPWithParameters(spName, new Dictionary<string, object>(0));
                rdr.Close();
            }
            catch
            {
                throw new Exception("no se pudo ejecutar el StoredProcedure");
            }
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
            SqlCommand command;
            return executeSPWithParameters(spName, parameters, out command);
        }

        public SqlDataReader executeSPWithParameters(String spName, Dictionary<String, Object> parameters, out SqlCommand cmd)
        {
            SqlConnection conn = dbManager.Connection;
            SqlDataReader rdr = null;
            try
            {
                cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (String paramKey in parameters.Keys)
                {
                    SqlParameter param = new SqlParameter("@" + paramKey, parameters[paramKey]);
                    if (paramKey.Contains(" output"))
                    {
                        param.SqlDbType = SqlDbType.NVarChar;
                        param.Size = 20;
                        param.ParameterName = "@" + paramKey.Replace(" output", "");
                        param.Direction = ParameterDirection.Output;
                    }
                    cmd.Parameters.Add(param);
                }
                rdr = cmd.ExecuteReader();
                return rdr;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void executeSPWithParametersWithOutReturn(String spName, Dictionary<String, Object> parameters)
        {
            SqlConnection conn = dbManager.Connection;
            SqlDataReader rdr = null;
            try
            {
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (String paramKey in parameters.Keys)
                {
                    cmd.Parameters.Add(new SqlParameter("@" + paramKey, parameters[paramKey]));
                }
                rdr = cmd.ExecuteReader();
                rdr.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void executeSPWithParametersWithOutReturn(String spName, Dictionary<String, Object> parameters,
                                                         SqlTransaction tran )
        {
            SqlConnection conn = dbManager.Connection;
            SqlDataReader rdr = null;
            try
            {
                SqlCommand cmd = new SqlCommand(spName, conn,tran);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (String paramKey in parameters.Keys)
                {
                    cmd.Parameters.Add(new SqlParameter("@" + paramKey, parameters[paramKey]));
                }
                rdr = cmd.ExecuteReader();
                rdr.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
