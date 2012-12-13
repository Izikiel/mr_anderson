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
    public partial class ComprarGiftCard : Form
    {
        LoginWindow login;
        String saldo;
        public ComprarGiftCard(LoginWindow login)
        {
            InitializeComponent();

            this.login = login;
            saldo = login.UsuarioActivo.DatosCliente.Saldo.ToString();
            if (String.IsNullOrEmpty(saldo))
                LblSaldo.Text = "0";
            else
                LblSaldo.Text = saldo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User.HomeUsuarios usuarios = new GrouponDesktop.User.HomeUsuarios();
            int montoGiftCard = 0;
            if (Int32.TryParse(TxtBoxMontoGift.Text, out montoGiftCard) == false)
            {
                MessageBox.Show("Monto no valido");
                return;
            }
            Boolean usuarioNoExistente;
            usuarioNoExistente = usuarios.usuarioNoExistente(TxtBoxUsuarioDestino.Text);
            if (usuarioNoExistente || montoGiftCard > Int32.Parse(saldo))
            {
                if(usuarioNoExistente) MessageBox.Show("El usuario no existe");
                else MessageBox.Show("Su saldo no es suficiente");
                return;
            }
            User.DatosCliente clienteDestino = usuarios.getDatosCliente(TxtBoxUsuarioDestino.Text);

            String result = Dominio.DataAdapter.GiftCard.comprarGiftCard(login.UsuarioActivo.DatosCliente.Dni,
                clienteDestino.Dni, Int32.Parse(TxtBoxMontoGift.Text), AdministradorConfiguracion.obtenerFecha());
            usuarios.setInformacionAlUsuario(login.UsuarioActivo);
            MessageBox.Show(result);
            this.Close();
            /*
create procedure MR_ANDERSON.sp_compra_giftcard (@cliente_origen NUMERIC(18), @cliente_destino NUMERIC(18),  
                                @monto int, @fecha DATETIME, @result NVARCHAR(20))*/
            //Do SP
        }


    }
}
