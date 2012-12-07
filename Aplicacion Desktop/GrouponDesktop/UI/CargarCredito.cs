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
        bool isAdmin = false;
        bool isPayPalActive = false;
        bool isCreditCardActive = false;

        public CargarCredito(LoginWindow loginWindow)
        {
            this.loginWindow = loginWindow;
            InitializeComponent();
            initializeWindow();
        }

        private void initializeWindow()
        {
            if (loginWindow.UsuarioActivo.Rol.Nombre == "Administrador")
            {
                Panel_nombreUsuario.Visible = true;
                isAdmin = true;
            }
            Panel_PayPal.Visible = false;
            Panel_PagoTarjeta.Visible = false;
        }
        private void habilitarTarjetaCredito()
        {
            Panel_PayPal.Visible = false;
            Panel_PagoTarjeta.Visible = true;
            isCreditCardActive = true;
            isPayPalActive = false;
        }
        private void habilitarPayPal()
        {
            Panel_PayPal.Visible = true;
            Panel_PagoTarjeta.Visible = false;
            isCreditCardActive = false;
            isPayPalActive = true;
        }

        private void RB_tarjetaCredito_CheckedChanged(object sender, EventArgs e)
        {
            habilitarTarjetaCredito();
        }

        private void RB_payPal_CheckedChanged(object sender, EventArgs e)
        {
            habilitarPayPal();
        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            String userName = "";
            String resultado = "";
            String dni = "";
            User.HomeUsuarios homeUsuario = new User.HomeUsuarios();

            if (isAdmin)
            {
                //Tengo que obtener el DNI del usuario al que le quiere cargar credito el Administrador
                userName = TxtBox_Username.Text;
                dni = homeUsuario.getDatosCliente(userName).Dni;
            }
            else
            {
                dni = loginWindow.UsuarioActivo.DatosCliente.Dni;
            }

            if (isCreditCardActive)
            {
                String tipoTarjeta = "";
                String[] fecha = TxtBox_FechaVencimiento.Text.Split('/');
                int mes = Int32.Parse(fecha[0]);
                int anio = Int32.Parse(fecha[1]) + 2000;
                if (RB_TipoTarjetaCredito.Checked == true)
                    tipoTarjeta = "Credito";
                else
                    tipoTarjeta = "Debito";
                resultado = Dominio.DataAdapter.CargaCredito.agregarCreditoTarjeta(userName, dni, AdministradorConfiguracion.obtenerFecha(),
                    Int32.Parse(TxtBox_MontoCargar.Text), TxtBox_NroTarjeta.Text, tipoTarjeta, "Tarjeta", new DateTime(anio, mes, 1));
            }
            else
            {
                resultado =Dominio.DataAdapter.CargaCredito.agregarCreditoPayPal(userName, dni, AdministradorConfiguracion.obtenerFecha(),
                Int32.Parse(TxtBox_MontoPagarPayPal.Text));
            }
            if (resultado != null)
            {
                //Actualizo la información del usuario activo.
                homeUsuario.setInformacionAlUsuario(this.loginWindow.UsuarioActivo);
            }
            else
            {
                MessageBox.Show("No se pudo realizar la carga.");
            }

        }

    }
}
