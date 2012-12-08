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
            return agregarCreditoTarjeta(userName, dni, fechaActual, montoACargar, "", tipoPago, "", new DateTime(2100, 1,1)); 
        }
    }
    public class RegistrarConsumo
    {
        public static void Registrar(String codigo, String dni, String cuit)
        {
            DataAccess.SPManager spManager = new GrouponDesktop.DataAccess.SPManager();

            Dictionary<String,Object> param = new Dictionary<string,object>();

            param.Add("fecha_actual", AdministradorConfiguracion.obtenerFecha());
            param.Add("cod_cupon", codigo);
            param.Add("dni_cliente",dni);
            param.Add("provee_cuit",cuit);

            SqlCommand command;

            SqlDataReader reader = spManager.executeSPWithParameters("MR_ANDERSON.sp_registra_consumo_cupon",param, out command);

            spManager.Close();
            return;

        }
    }

    public class CuponArmado
    {
        public Cupon cupon;

        public CuponArmado()
        {
            cupon = new Cupon();
        }
        public CuponArmado(Cupon cupon)
        {
            this.cupon = cupon;
            cupon.Codigo = generarCodigoCupon();
        }


        private String generarCodigoCupon()
        {
            String strToEncrypt = cupon.Descripcion.ToString() + cupon.FechaVencimiento.ToString()
                 + AdministradorConfiguracion.obtenerFecha().ToShortDateString() + new Random(DateTime.Now.Second);
            strToEncrypt = Utilidades.SHA256Encrypt(strToEncrypt);
            strToEncrypt = strToEncrypt.Substring(0, 12);
            return strToEncrypt.ToUpper();

        }
        public String guardar()
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
            param.Add("codigo", cupon.Codigo);
            param.Add("precio_real", cupon.PrecioReal);
            param.Add("precio_fict", cupon.PrecioFicticio);
            param.Add("cantidad_x_usuario", cupon.CantidadMaximaPorUsuario);
            param.Add("descripcion", cupon.Descripcion);
            param.Add("stock_disponible", cupon.Stock);
            param.Add("provee_cuit", cupon.CuitProveedor);
            param.Add("vencimiento_oferta", cupon.FechaFinalizacionOferta);
            param.Add("vencimiento_canje", cupon.FechaVencimiento);
            param.Add("fecha_publicacion", cupon.FechaPublicacion);
            try
            {
                spManager.executeSPWithParametersWithOutReturn("MR_ANDERSON.sp_agregar_cupon", param);
            }
            catch(Exception e)
            {
                spManager.Close();
                return "Ocurrio un error cuando se quizo crear el cupon";
            }
            spManager.Close();
            return "Se creó correctamente el cupón";
        }

    }
}
