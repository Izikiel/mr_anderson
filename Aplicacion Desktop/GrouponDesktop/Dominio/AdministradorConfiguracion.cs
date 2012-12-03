using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace GrouponDesktop
{
    class AdministradorConfiguracion
    {
        public static string obtenerValorApp(string key)
        {
            try
            {
                return ConfigurationManager.AppSettings[key];
            }
            catch
            {
                return null;
            }
        }
        public static string obtenerValorDB(string key)
        {
            try
            {
                return ConfigurationManager.ConnectionStrings[key].ConnectionString;
            }
            catch
            {
                return null;
            }
        }
    }
}
