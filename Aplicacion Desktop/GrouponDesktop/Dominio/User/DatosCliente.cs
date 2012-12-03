using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.User
{
    public class DatosCliente
    {
        private String nombre;
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private String dni;
        public String Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        private String apellido;
        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
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

        private String fechaNac;
        public String FechaNac
        {
            get { return fechaNac; }
            set { fechaNac = value; }
        }

        private int saldo;
        public int Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

    }
}
