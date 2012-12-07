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
        public static string agregarCreditoTarjeta(String userName, String dni, DateTime fechaActual, int montoACargar, String numeroTarjeta,
                    String tipoPago, String tipoTarjeta, DateTime fechaVencimiento)
        {
            String result = "";
            DataAccess.SPManager spManager = new DataAccess.SPManager();

            Dictionary<String, Object> param = new Dictionary<String, Object>();
            param.Add("monto", montoACargar);
            param.Add("dni", Int32.Parse(dni));
            param.Add("fecha", fechaActual);
            param.Add("tipo_pago", tipoPago);
            param.Add("nro_tarjeta", numeroTarjeta);
            param.Add("fecha_emision", new DateTime(2000, 5, 5));
            param.Add("fecha_vencimiento", fechaVencimiento);
            param.Add("tipo_tarjeta", tipoTarjeta);
            param.Add("result output", result);
            SqlCommand command;
            SqlDataReader reader = spManager.executeSPWithParameters("MR_ANDERSON.sp_cargar_credito", param, out command);
            string resultado = (string)command.Parameters["@result"].Value;

            //spManager.executeSPWithParametersWithOutReturn("MR_ANDERSON.", param);

            spManager.Close();
            return resultado;
        }
        public static string agregarCreditoPayPal(String userName, String dni, DateTime fechaActual, int montoACargar)
        {
            const String tipoPago = "Efectivo";
            return agregarCreditoTarjeta(userName, dni, fechaActual, montoACargar, "", tipoPago, "", new DateTime(2100, 1,1)); 
        }
    }
}
