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
        public String CuponCodigo
        {
            get { return cuponCodigo; }
            set { cuponCodigo = value; }
        }
        String descripcion;
        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        String precioActual;
        public String PrecioActual
        {
            get { return precioActual; }
            set { precioActual = value; }
        }
    }
}
