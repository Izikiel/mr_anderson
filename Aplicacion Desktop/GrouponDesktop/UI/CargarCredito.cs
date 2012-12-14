using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Dominio;

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
            if(checkearDatos()==false)
            {
                MessageBox.Show("Error En Datos Ingresados");
                return;
            }
            String userName = "";
            String resultado = "";
            String dni = "";
            User.HomeUsuarios homeUsuario = new User.HomeUsuarios();
            
            dni = loginWindow.UsuarioActivo.DatosCliente.Dni;

            if (isCreditCardActive)
            {
                String tipoTarjeta = "";
                String[] fecha = TxtBox_FechaVencimiento.Text.Split('/');
                int mes = Int32.Parse(fecha[0]);
                int anio = Int32.Parse(fecha[1]) + 2000;
                if(mes<0 || mes>12 || anio > 2050 || AdministradorConfiguracion.obtenerFecha().Year>anio)
                {
                    MessageBox.Show("Error En Fecha");
                    return;
                }

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
                return;
            }
            MessageBox.Show(resultado);
            this.Close();
        }

        private bool checkearDatos()
        {
            int value = 0 ;
            
            if (RB_payPal.Checked)
            {
                if(String.IsNullOrEmpty(TxtBox_CodigoPagoPayPal.Text.Trim()) ||
                    String.IsNullOrEmpty(TxtBox_UsuarioPayPal.Text.Trim()))
                {
                    return false;
                }
                if (Int32.TryParse(TxtBox_MontoPagarPayPal.Text, out value) == false)
                {
                    return false;
                }
            }
            else if (RB_tarjetaCredito.Checked)
            {
                if(Utilidades.isNullOrEmpty(TxtBox_NroTarjeta.Text) || Utilidades.isNullOrEmpty(TxtBox_NombreTitular.Text) ||
                    Utilidades.isNullOrEmpty(TxtBox_MontoCargar.Text) || Utilidades.isNullOrEmpty(TxtBox_FechaVencimiento.Text) ||
                    Utilidades.isNullOrEmpty(TxtBox_CodSeguridad.Text))
                {
                    return false;
                }
                if (Int32.TryParse(TxtBox_MontoCargar.Text, out value) == false)
                {
                    return false;
                }
                if (Int32.TryParse(TxtBox_CodSeguridad.Text, out value) == false)
                {
                    return false;
                }

            }
            return true;
        }


        

    }
}
