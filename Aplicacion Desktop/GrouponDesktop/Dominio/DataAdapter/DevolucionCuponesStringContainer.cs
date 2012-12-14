using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.Dominio.DataAdapter
{
    class DevolucionCuponesStringContainer
    {
        private String nombreProveedor;
        public String NombreProveedor
        {
            get { return nombreProveedor; }
            set { nombreProveedor = value; }
        }

        private String cuponesVendidos;
        public String CuponesVendidos
        {
            get { return cuponesVendidos; }
            set { cuponesVendidos = value; }
        }

        private String cuponesDevueltos;
        public String CuponesDevueltos
        {
            get { return cuponesDevueltos; }
            set { cuponesDevueltos = value; }
        }

        private String porcentajeDevolucion;
        public String PorcentajeDevolucion
        {
            get { return porcentajeDevolucion; }
            set { porcentajeDevolucion = value; }
        }
        private String descripcion;
        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private String codigo;
        public String Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
    }
}
