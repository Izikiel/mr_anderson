using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GrouponDesktop.Rol;
using GrouponDesktop.DataAdapter;
using System.Data.SqlClient;

namespace GrouponDesktop.User
{
    public class User
    {
        
        private String tipoUsuario;
        public String TipoUsuario
        {
            get { return tipoUsuario; }
            set { tipoUsuario = value; }
        }
        private Login datosLogin;
        public Login DatosLogin
        {
            get{return datosLogin;}
            set{datosLogin = value;}
        }

        private Rol.Rol rol;
        public Rol.Rol Rol
        {
            get{return rol;}
            set{rol = value;}
        }

        private DatosCliente datosCliente;
        public DatosCliente DatosCliente
        {
            get { return datosCliente; }
            set { datosCliente = value; }
        }

        private DatosProveedor datosProveedor;
        public DatosProveedor DatosProveedor
        {
            get { return datosProveedor; }
            set { datosProveedor = value; }
        }
        
        
    }
}
