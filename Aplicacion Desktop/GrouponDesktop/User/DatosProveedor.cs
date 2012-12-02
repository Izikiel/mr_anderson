using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.User
{
   public class DatosProveedor
    {
        private String nombreContacto;
        public String NombreContacto
        {
            get { return nombreContacto; }
            set { nombreContacto = value; }
        }

        private String razonSocial;
        public String RazonSocial
        {
            get { return razonSocial; }
            set { razonSocial = value; }
        }

        private String cuit;
        public String Cuit
        {
            get { return cuit; }
            set { cuit = value; }
        }

        private String mail;
        public String Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        private String telefono;
        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        private String rubro;
        public String Rubro
        {
            get { return rubro; }
            set { rubro = value; }
        }

        
    }
}
