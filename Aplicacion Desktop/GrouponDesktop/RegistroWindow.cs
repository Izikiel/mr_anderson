using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GrouponDesktop.User;
using GrouponDesktop.Rol;

namespace GrouponDesktop
{
    public partial class RegistroWindow : Form
    {
        HomeUsuarios homeUsr;

        public RegistroWindow()
        {
            InitializeComponent();
            HomeRoles homeRol = new HomeRoles();
            List<Rol.Rol> roles =  homeRol.getRoles();
            foreach (Rol.Rol rol in roles)
            {
                if (rol.getNombreRol().Contains("Admin")) continue;
                this.comboBox1.Items.Add(rol.getNombreRol());
            }
            this.homeUsr = new HomeUsuarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (homeUsr.usuarioNoExistente(this.textBox1.Text).Equals("true"))
            {
                if (this.textBox2.Text.Equals("")) { MessageBox.Show("Ingrese una contraseña."); return; }
                if (this.comboBox1.SelectedItem.ToString().Equals("")) { MessageBox.Show("Elija un tipo de usuario"); return; }

                RegistroWindow_2 w = new RegistroWindow_2(this);
                w.Show();
                this.Hide();
            }
            else MessageBox.Show("Nombre de usuario no disponible.\n Ingrese otro.");
        }
    }
}
