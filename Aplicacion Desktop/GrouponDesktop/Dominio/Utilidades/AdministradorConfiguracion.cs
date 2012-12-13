using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Globalization;

namespace GrouponDesktop
{
    class AdministradorConfiguracion
    {
        public static DateTime obtenerFecha()
        {
            String fecha = obtenerValorApp("fecha");
            if (fecha == null)
                return DateTime.Now;
            return DateTime.Parse(fecha, new CultureInfo("es-AR", false));
        }
        public static string obtenerValorApp(string key)
        {
            try
            {
                return ConfigurationManager.AppSettings.Get(key);
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
