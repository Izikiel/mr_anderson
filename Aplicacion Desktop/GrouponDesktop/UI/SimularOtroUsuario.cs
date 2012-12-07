using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop.UI
{
    public partial class SimularOtroUsuario : Form
    {
        LoginWindow login;
        public SimularOtroUsuario(LoginWindow login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String userName = TxtBox_Username.Text;
            DataAdapter.Login log = new GrouponDesktop.DataAdapter.Login();
            
            if(log.existeUsuario(userName)==false)
            {
                MessageBox.Show("No existe el usuario");
                return;
            }
            User.HomeUsuarios homeUsuario = new GrouponDesktop.User.HomeUsuarios();
            
            User.User user = new GrouponDesktop.User.User(true);
            user.DatosLogin.UserName = userName;
            homeUsuario.setInformacionAlUsuario(user);

            login.UsuarioActivo = user;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            login.volverAdminAModoInicial();
        }
    }
}
