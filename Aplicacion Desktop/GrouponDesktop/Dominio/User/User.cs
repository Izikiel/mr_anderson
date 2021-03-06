﻿using System;
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
        public User()
        {
        }
        public User(bool inicializar)
        {
            direccion = new Direccion();
            datosCliente = new DatosCliente();
            datosLogin = new Login();
            rol = new GrouponDesktop.Rol.Rol();
            datosProveedor = new DatosProveedor();
            ciudadesPreferencia = new List<string>();
        }
        private Direccion direccion;
        public Direccion Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        
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

        private List<String> ciudadesPreferencia;
        public List<String> CuidadesPreferencia
        {
            get { return ciudadesPreferencia; }
            set { ciudadesPreferencia = value; }
        }
        public User clonarUsuario()
        {
            return (User) MemberwiseClone();
        }
        


    }
}
