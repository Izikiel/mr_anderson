using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.Dominio.DataAdapter
{
    class UsuariosGiftCardsStringContainer
    {
        private String nombreUsuario;
        public String NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        private String cantidadDeGiftCardsAcreditadas;
        public String CantidadDeGiftCardsAcreditadas
        {
            get { return cantidadDeGiftCardsAcreditadas; }
            set { cantidadDeGiftCardsAcreditadas = value; }
        }

        private String dni;
        public String Dni
        {
            get { return dni; }
            set { dni = value; }
        }
    }
}
