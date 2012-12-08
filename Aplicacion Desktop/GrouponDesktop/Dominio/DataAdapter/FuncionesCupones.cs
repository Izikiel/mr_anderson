using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace GrouponDesktop.Dominio.DataAdapter
{
    class FuncionesCupones
    {
        public List<Cupon> obtenerCupones(String dni, DateTime fecha)
        {
            List<Cupon> cupones = new List<Cupon>();
            DataAccess.SPManager spManager = new GrouponDesktop.DataAccess.SPManager();
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("dni", Int32.Parse(dni));
            parameters.Add("fecha", fecha);

            using (SqlDataReader reader = spManager.executeSPWithParameters("MR_ANDERSON.sp_ver_cupones_habilitados", parameters))
            {
                while (reader.Read())
                {
                    Cupon cupon = new Cupon();
                    cupon.Codigo = ((String)reader["codigo"]).Trim();
                    cupon.Descripcion = ((String)reader["descripcion"]).Trim();
                    cupones.Add(cupon);
                }
                reader.Close();
            }
            return cupones;
        }

        public string comprarCupones(String dni, String codigo, int cantidad, DateTime fecha)
        {
            DataAccess.SPManager spManager = new GrouponDesktop.DataAccess.SPManager();
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("dni", Int32.Parse(dni));
            parameters.Add("codigo", codigo);
            parameters.Add("cantidad", cantidad);
            parameters.Add("fecha_compra", fecha);
            try
            {
                spManager.executeSPWithParametersWithOutReturn("MR_ANDERSON.sp_comprar_cupon", parameters);
                return "Compra exitosa";
            }
            catch (Exception e)
            {
                return "Error en compra";
            }
        }

        public string devolverCupon(String dni, String codigo, int cantidad, DateTime fecha)
        {
            return "";
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
            catch (Exception e)
            {
                spManager.Close();
                return "Ocurrio un error cuando se quizo crear el cupon";
            }
            spManager.Close();
            return "Se creó correctamente el cupón";
        }

    }

}
