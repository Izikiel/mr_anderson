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
    public partial class ConfirmarEliminarUsuarioDialog : Form
    {
        String username;
        LoginWindow loginW;

        public ConfirmarEliminarUsuarioDialog(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        public ConfirmarEliminarUsuarioDialog(String username, LoginWindow loginW)
        {
            InitializeComponent();
            this.username = username;
            this.loginW = loginW;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            HomeUsuarios home = new HomeUsuarios();
            home.changeStatus(this.username, false);
            if(this.loginW != null) this.loginW.UsuarioActivo.DatosLogin.Habilitado = false;
            MessageBox.Show("Se ha inhabilitado correctamente");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
