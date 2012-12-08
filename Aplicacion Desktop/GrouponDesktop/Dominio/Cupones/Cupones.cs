using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.Dominio
{
    public class Cupones
    {
        Dominio.DataAdapter.FuncionesCupones funcionesCupones = null;
        List<Cupon> cuponesList;
        public List<Cupon> CuponesList
        {
            get {return cuponesList; }
            set { cuponesList = value; }
        }
        public Cupones()
        {
            funcionesCupones = new GrouponDesktop.Dominio.DataAdapter.FuncionesCupones(); ;
        }

        public List<Cupon> obtenerCuponesEnFecha(String dni, DateTime fecha)
        {
            return funcionesCupones.obtenerCupones(dni, fecha);
            
        }

        public String comprarCupones(String dni, String codigo, int cantidad)
        {
            return funcionesCupones.comprarCupones(dni, codigo, cantidad, AdministradorConfiguracion.obtenerFecha());
        }

    }

    public class Cupon
    {
        String cuponCodigo;
        public String Codigo
        {
            get { return cuponCodigo; }
            set { cuponCodigo = value; }
        }
        DateTime fechaVencimiento;
        public DateTime FechaVencimiento
        {
            get { return fechaVencimiento; }
            set { fechaVencimiento = value; }
        }
        DateTime fechaFinalizacionOferta;
        public DateTime FechaFinalizacionOferta
        {
            get { return fechaFinalizacionOferta; }
            set { fechaFinalizacionOferta = value; }
        }
        DateTime fechaPublicacion;
        public DateTime FechaPublicacion
        {
            get { return fechaPublicacion; }
            set { fechaPublicacion = value; }
        }
        String descripcion;
        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        double precioFicticio;
        public double PrecioFicticio
        {
            get { return precioFicticio; }
            set { precioFicticio = value; }
        }

        double precioReal;
        public double PrecioReal
        {
            get { return precioReal; }
            set { precioReal = value; }
        }

        int cantidadDisponible;
        public int CantidadDisponible
        {
            get { return cantidadDisponible; }
            set { cantidadDisponible = value; }
        }

        int cantidadMaximaPorUsuario;
        public int CantidadMaximaPorUsuario
        {
            get { return cantidadMaximaPorUsuario; }
            set { cantidadMaximaPorUsuario = value; }
        }
        int stock;
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        String cuitProveedor = "";
        public String CuitProveedor
        {
            get { return cuitProveedor; }
            set { cuitProveedor = value; }
        }

        





    }
}
