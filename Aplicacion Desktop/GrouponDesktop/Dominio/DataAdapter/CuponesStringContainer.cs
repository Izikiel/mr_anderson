using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.Dominio.DataAdapter
{
    class CuponesStringContainer
    {
        private String codigo;
        public String Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private String estado;
        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
