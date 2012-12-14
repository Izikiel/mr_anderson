using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Cupones;
using GrouponDesktop.User;
using GrouponDesktop.DataAdapter;
using GrouponDesktop.Rol;

namespace GrouponDesktop.UI
{
    public partial class ModificacionProveedor : Form
    {
        HomeCiudades homeCiudades = new HomeCiudades();
        HomeUsuarios homeUsr = new HomeUsuarios();
        HomeRoles homeRol = new HomeRoles();
        User.User proveedorSeleccionado = new User.User();

        public ModificacionProveedor(String username)
        {
            InitializeComponent();
            Login login = new Login();
            login.UserName = username;
            this.proveedorSeleccionado = homeUsr.getProveedor(login);
            this.comboBox1.DataSource = this.homeRol.getRolesParaTipo(this.proveedorSeleccionado.Rol.TipoUsuario);
            this.fill();
        }

        private void fill()
        {
            this.comboBox1.Text = this.proveedorSeleccionado.Rol.Nombre;

            this.checkBox1.Checked = this.proveedorSeleccionado.DatosLogin.Habilitado;

            this.textBox4.Text = this.proveedorSeleccionado.DatosProveedor.Cuit;
            this.textBox2.Text = this.proveedorSeleccionado.DatosProveedor.Mail;
            this.textBox12.Text = this.proveedorSeleccionado.DatosProveedor.NombreContacto;
            this.textBox1.Text = this.proveedorSeleccionado.DatosProveedor.RazonSocial;
            this.textBox13.Text = this.proveedorSeleccionado.DatosProveedor.Rubro;
            this.textBox3.Text = this.proveedorSeleccionado.DatosProveedor.Telefono;

            this.textBox6.Text = this.proveedorSeleccionado.Direccion.Calle; 
            this.textBox11.Text = Convert.ToString(this.proveedorSeleccionado.Direccion.CodigoPostal);
            this.textBox8.Text = Convert.ToString(this.proveedorSeleccionado.Direccion.Piso);
            this.textBox9.Text = this.proveedorSeleccionado.Direccion.Depto;
            this.textBox10.Text = this.proveedorSeleccionado.Direccion.Localidad;
        }

        private User.User nuevoProveedor()
        {
            User.User prov = new User.User();
            prov.DatosLogin = new Login();
            prov.DatosProveedor = new DatosProveedor();
            prov.Direccion = new Direccion();
            prov.DatosLogin.Habilitado = this.checkBox1.Checked;
            prov.DatosLogin.UserName = this.proveedorSeleccionado.DatosLogin.UserName;

            prov.DatosProveedor.Cuit = this.textBox4.Text;
            prov.DatosProveedor.Mail = this.textBox2.Text;
            prov.DatosProveedor.NombreContacto = this.textBox12.Text;
            prov.DatosProveedor.RazonSocial = this.textBox1.Text;
            prov.DatosProveedor.Rubro = this.textBox13.Text;
            prov.DatosProveedor.Telefono = this.textBox3.Text;

            prov.Direccion.Calle = this.textBox6.Text;
            prov.Direccion.Depto = this.textBox9.Text;
            prov.Direccion.Localidad = this.textBox10.Text;

            String campo = "";
            try
            {
                campo = "piso";
                if (!this.textBox8.Text.Equals("")) prov.Direccion.Piso = Convert.ToInt32(this.textBox8.Text);
                campo = "codigo postal";
                prov.Direccion.CodigoPostal = Convert.ToInt32(this.textBox11.Text);

            }
            catch (Exception)
            {
                String error = "El campo " + campo + " tiene un formato incorrecto.";
                throw new Exception(error);
            }

            return prov;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if ((c.Text.Equals("")))
                { MessageBox.Show("Tiene que completar todos los campos\nEl campo piso y depto no son obligatorios."); return; }

            }

            foreach (Control c in this.groupBox1.Controls)
            {
                if ((c.Text.Equals("")) & (!c.Name.Equals(textBox8.Name)) & (!c.Name.Equals(textBox9.Name)))
                { MessageBox.Show("Tiene que completar todos los campos\nEl campo piso y depto no son obligatorios."); return; }
            }
            try
            {
                User.User nuevoProv = this.nuevoProveedor();
                homeUsr.modificarProveedor(this.proveedorSeleccionado, nuevoProv,
                     nuevoProv.DatosLogin.Habilitado,this.comboBox1.Text);
            }
            catch (Exception except)
            {
                MessageBox.Show("No se ha podido modificar al proveedor"+ except.ToString());
                return;
            }

            MessageBox.Show("Se ha modificado correctamente");
            this.Close();

        }
    }
}
