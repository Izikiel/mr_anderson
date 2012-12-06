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
            if(Int32.TryParse(TxtBoxMontoGift.Text, out montoGiftCard) == false)
                return;
            if (usuarios.usuarioNoExistente(TxtBoxUsuarioDestino.Text) || montoGiftCard > Int32.Parse(saldo))
            {
                return;
            }
            //Do SP
        }


    }
}
