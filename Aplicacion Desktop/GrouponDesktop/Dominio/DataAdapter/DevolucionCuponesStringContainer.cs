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
    }
}
