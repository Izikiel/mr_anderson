using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GrouponDesktop.Dominio.DataAdapter
{
    public class CargaCredito
    {
        public static void agregarCredito(String userName, String dni, DateTime fechaActual, int montoACargar, String numeroTarjeta, 
                    String tipoPago, DateTime fechaVencimiento)
        {
            String result="";
            DataAccess.SPManager spManager = new DataAccess.SPManager();

            Dictionary<String, Object> param = new Dictionary<String, Object>();
            param.Add("monto", montoACargar);
            param.Add("dni", Int32.Parse(dni));
            param.Add("fecha", fechaActual);
            param.Add("tipo_pago", tipoPago);
            param.Add("nro_tarjeta", numeroTarjeta);
            param.Add("fecha_emision", new DateTime(2000,5,5));
            param.Add("fecha_vencimiento", fechaVencimiento);
            param.Add("tipo_tarjeta", "");
            param.Add("result", result);

            spManager.executeSPWithParametersWithOutReturn("MR_ANDERSON.sp_cargar_credito", param);
           
            spManager.Close();
        }
    }
}
