using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop
{
    public partial class CargarCredito : Form
    {
        LoginWindow loginWindow;
        public CargarCredito(LoginWindow loginWindow)
        {
            this.loginWindow = loginWindow;
            InitializeComponent();
            initializeWindow();
        }

        private void initializeWindow()
        {
            if (loginWindow.UsuarioActivo.Rol.Nombre == "Administrador")
                Panel_nombreUsuario.Visible = true;
            Panel_PayPal.Visible = false;
            Panel_PagoTarjeta.Visible = false;
        }
        private void habilitarTarjetaCredito()
        {
            Panel_PayPal.Visible = false;
            Panel_PagoTarjeta.Visible = true;
        }
        private void habilitarPayPal()
        {
            Panel_PayPal.Visible = true;
            Panel_PagoTarjeta.Visible = false;
        }

        private void RB_tarjetaCredito_CheckedChanged(object sender, EventArgs e)
        {
            habilitarTarjetaCredito();
        }

        private void RB_payPal_CheckedChanged(object sender, EventArgs e)
        {
            habilitarPayPal();
        }

    }
}
