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
using GrouponDesktop.DataAdapter;

namespace GrouponDesktop
{
    public partial class RegistroWindow : Form
    {
        HomeUsuarios homeUsr;
        HomeRoles homeRol;
        private User.User usuario;
        public User.User Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public RegistroWindow()
        {
            InitializeComponent();
            this.homeRol = new HomeRoles();
            List<Rol.Rol> roles =  homeRol.getRoles();
            this.homeUsr = new HomeUsuarios();
            this.usuario = new User.User();
            this.usuario.DatosLogin = new Login();
            this.usuario.Rol = new Rol.Rol();
            this.usuario.Direccion = new Direccion();
            this.comboBox2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (homeUsr.usuarioNoExistente(this.textBox1.Text))
            {
                if (this.textBox2.Text.Equals("")) { MessageBox.Show("Ingrese una contraseña."); return; }

                if (this.comboBox1.SelectedIndex.Equals(-1)) { MessageBox.Show("Elija un tipo de usuario."); return; }
                if (this.comboBox2.SelectedIndex.Equals(-1)) { MessageBox.Show("Elija un rol."); return; }
                Form w = new Form();
                this.usuario.DatosLogin.UserName = this.textBox1.Text;
                this.usuario.DatosLogin.Password = this.textBox2.Text;
                this.usuario.Rol.setNombreRol(this.comboBox2.SelectedItem.ToString());
                this.usuario.TipoUsuario = this.comboBox1.SelectedItem.ToString();
                if (comboBox2.SelectedItem.ToString().Equals("Cliente"))
                {
                    w = new RegistroCliente(this);
                    this.usuario.DatosProveedor = null;
                    this.usuario.DatosCliente = new DatosCliente();
                }
                else
                {
                    w = new RegistroProveedor(this);
                    this.usuario.DatosCliente = null;
                    this.usuario.DatosProveedor = new DatosProveedor();
                }
                w.Show();
                this.Hide();
            }
            else MessageBox.Show("Nombre de usuario no disponible.\n Ingrese otro.");
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBox2.Items.Clear();
            this.comboBox2.ResetText();
            this.comboBox2.Enabled = true;
            List<String> rolesParaTipo = this.homeRol.getRolesParaTipo(this.comboBox1.SelectedItem.ToString());
            foreach (String rol in rolesParaTipo)
            {
                this.comboBox2.Items.Add(rol);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
