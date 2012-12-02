using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.User
{
    public class Direccion
    {
        private String calle;
        public String Calle
        {
            get { return calle; }
            set { calle = value; }
        }

        private int numero;
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private int piso;
        public int Piso
        {
            get { return piso; }
            set { piso = value; }
        }

        private String depto;
        public String Depto
        {
            get { return depto; }
            set { depto = value; }
        }

        private String localidad;
        public String Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }

        private int codigoPostal;
        public int CodigoPostal
        {
            get { return codigoPostal; }
            set {codigoPostal = value; }
        }
    }
}
