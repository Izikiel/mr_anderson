using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.User;

namespace GrouponDesktop.UI
{
    public partial class CambiarPassword : Form
    {
        LoginWindow loginWindow;
        HomeUsuarios homeUsr = new HomeUsuarios();

        public CambiarPassword(LoginWindow w)
        {
            InitializeComponent();
            this.loginWindow = w;
            this.label2.Text = loginWindow.UsuarioActivo.DatosLogin.UserName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Equals(""))
            {
                MessageBox.Show("Ingrese una nueva contraseña");
                return;
            }

            try
            {
                this.loginWindow.UsuarioActivo.DatosLogin.Password = this.textBox1.Text;
                this.loginWindow.UsuarioActivo.DatosLogin.setPasswordOldUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cambiar la contraseña "+ ex.ToString());
            }

            MessageBox.Show("Se ha cambiado la contraseña del usuario: " + this.loginWindow.UsuarioActivo.DatosLogin.UserName);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
