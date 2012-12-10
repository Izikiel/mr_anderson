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
            DataAccess.SPManager spManager;
            try
            {
                spManager = new DataAccess.SPManager();
            }
            catch
            {
                return "Problema Conexion DB";
            }
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
            result = (string)command.Parameters["@result"].Value;
            //spManager.executeSPWithParametersWithOutReturn("MR_ANDERSON.", param);
            spManager.Close();
            return result;
        }
        public static string agregarCreditoPayPal(String userName, String dni, DateTime fechaActual, int montoACargar)
        {
            const String tipoPago = "Efectivo";
            return agregarCreditoTarjeta(userName, dni, fechaActual, montoACargar, "", tipoPago, "", new DateTime(2100, 1, 1));
        }
    }
    public class RegistrarConsumo
    {
        public static void Registrar(String codigo, String dni, String cuit)
        {
            DataAccess.SPManager spManager = new GrouponDesktop.DataAccess.SPManager();

            Dictionary<String, Object> param = new Dictionary<string, object>();

            param.Add("fecha_actual", AdministradorConfiguracion.obtenerFecha());
            param.Add("cod_cupon", codigo);
            param.Add("dni_cliente", dni);
            param.Add("provee_cuit", cuit);

            spManager.executeSPWithParametersWithOutReturn("MR_ANDERSON.sp_registra_consumo_cupon", param);

            spManager.Close();
            return;

        }
    }

    public class GiftCard
    {
        public static string comprarGiftCard(String dniOrigen, String dniDestino, int monto, DateTime fecha)
        {
            String result = "";
            DataAccess.SPManager spManager;
            try
            {
                spManager = new DataAccess.SPManager();
            }
            catch
            {
                return "Problema Conexion DB";
            }
            Dictionary<String, Object> param = new Dictionary<String, Object>();
            param.Add("cliente_origen", Int32.Parse(dniOrigen));
            param.Add("cliente_destino", Int32.Parse(dniDestino));
            param.Add("monto", monto);
            param.Add("fecha", fecha);
            param.Add("result output", result);

            SqlCommand command;
            SqlDataReader reader = spManager.executeSPWithParameters("MR_ANDERSON.sp_compra_giftcard", param, out command);
            result = (string)command.Parameters["@result"].Value;
            if (result == "OK")
                result = "Se realizó correctamente la operación";
            else if (result == "CLIENTE_INHABILITADO")
                result = "El Cliente se encuentra inhabilitado";
            else if (result == "origen=destino")
                result = "El usuario de origen y destino es el mismo.";

            //spManager.executeSPWithParametersWithOutReturn("MR_ANDERSON.", param);
            spManager.Close();
            return result;
        }
    }

    public class AdministradorAdapter
    {
        public static int existeUsuario(String cuit)
        {
            DataAccess.SPManager spManager = new GrouponDesktop.DataAccess.SPManager();

            Dictionary<String, Object> param = new Dictionary<string, object>();

            bool salida = false;
            param.Add("provee_cuit", cuit);
            param.Add("existe output", salida);
            SqlCommand command;

            try
            {
                SqlDataReader reader = spManager.executeSPWithParameters("MR_ANDERSON.sp_existe_cuit", param, out command);
                return (int)Int32.Parse(command.Parameters["@existe"].Value.ToString());
            }
            catch (Exception e)
            {
                spManager.Close();
                return 0;
            }

            spManager.Close();
            return 1;

        }

        public static List<Cupon> getCuponesAPublicar(String cuit, DateTime fecha)
        {
            List<Cupon> cupones = new List<Cupon>();
            DataAccess.SPManager spManager = new GrouponDesktop.DataAccess.SPManager();
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("provee_cuit", cuit);
            parameters.Add("fecha", fecha);

            using (SqlDataReader reader = spManager.executeSPWithParameters("MR_ANDERSON.sp_cupones_a_publicar", parameters))
            {
                while (reader.Read())
                {
                    Cupon cupon = new Cupon();
                    cupon.CuponCodigo = ((String)reader["codigo"]).Trim();
                    cupon.Descripcion = ((String)reader["descripcion"]).Trim();
                    cupones.Add(cupon);
                }
                reader.Close();
            }
            return cupones;
        }
    }

    public class Facturacion
    {
        public Facturacion()
        {
        }
        /*
         * 
ALTER procedure [MR_ANDERSON].[sp_facturar_proveedor] (@fecha_actual DATETIME, @fecha_inicio DATETIME, @ DATETIME, @provee_cuit nvarchar(20), 
            @nro_factura numeric(18,0) output, @importe_factura numeric(18,0) output)
         */
        /// <summary>
        /// Devuelve un Diccionario donde este es key:NumeroFactura Value:Importe
        /// </summary>
        /// <param name="proveedor"></param>
        /// <param name="inicio"></param>
        /// <param name="fin"></param>
        /// <returns>Dictionary<NroFactura, ImporteFactura></returns>
        public static Dictionary<String, String> facturar(String proveedor, DateTime fechaInicio, DateTime fechaFin, out String importeFactura, out String numeroFactura)
        {
            Dictionary<String, String> cantidadElementosPorCodigo = new Dictionary<string, string>();

            DataAccess.SPManager spManager = new GrouponDesktop.DataAccess.SPManager();
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("provee_cuit", proveedor);
            parameters.Add("fecha_inicio", fechaInicio);
            parameters.Add("fecha_final", fechaFin);
            parameters.Add("fecha_actual", AdministradorConfiguracion.obtenerFecha());
            parameters.Add("nro_factura output", "");
            parameters.Add("importe_factura output", "");
            SqlCommand command;
            using (SqlDataReader reader = spManager.executeSPWithParameters("MR_ANDERSON.sp_facturar_proveedor_nfactura", parameters, out command))
            {

                numeroFactura = command.Parameters["@nro_factura"].Value.ToString();
                reader.Close();
            }
            using (SqlDataReader reader = spManager.executeSPWithParameters("MR_ANDERSON.sp_factura_proveedor_importe", parameters, out command))
            {
                importeFactura = command.Parameters["@importe_factura"].Value.ToString();
                reader.Close();
            } 
            using (SqlDataReader reader = spManager.executeSPWithParameters("MR_ANDERSON.sp_facturar_proveedor", parameters, out command))
            {
                while (reader.Read())
                {
                    cantidadElementosPorCodigo.Add((reader["codigo"]).ToString(), (reader["Cantidad"]).ToString());
                }
                reader.Close();
            }
            return cantidadElementosPorCodigo;// cupones;
        }
    }
}
