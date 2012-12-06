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

namespace GrouponDesktop.UI
{
    public partial class ModificacionCliente : Form
    {
        List<String> ciudadesSeleccionadas = new List<string>();
        List<String> ciudadesOriginales = new List<string>();
        HomeCiudades homeCiudades = new HomeCiudades();
        HomeUsuarios homeUsr = new HomeUsuarios();
        User.User clienteSeleccionado = new User.User();
        Boolean Habilitado = true;

        public ModificacionCliente(String username)
        {
            InitializeComponent();
            Login login = new Login();
            login.UserName = username;
            this.clienteSeleccionado = homeUsr.getCliente(login);
            this.fill();
        }

        private void fill()
        {
            this.ciudadesSeleccionadas.AddRange(homeCiudades.getCiudadesUsuario(clienteSeleccionado.DatosCliente.Dni));
            this.ciudadesOriginales.AddRange(ciudadesSeleccionadas);
            this.listBox1.DataSource = ciudadesSeleccionadas;
            this.listBox2.DataSource = homeCiudades.getCiudades();

            this.textBox1.Text = this.clienteSeleccionado.DatosCliente.Nombre;
            this.textBox2.Text = this.clienteSeleccionado.DatosCliente.Apellido;
            this.textBox3.Text = this.clienteSeleccionado.DatosCliente.Dni;
            this.textBox4.Text = this.clienteSeleccionado.DatosCliente.Mail;
            this.textBox5.Text = this.clienteSeleccionado.DatosCliente.Telefono;
            int fecha = Convert.ToInt32(this.clienteSeleccionado.DatosCliente.FechaNac);
            int anio = fecha/10000;
            fecha = fecha % 10000;
            int mes = fecha / 100;
            int dia = fecha % 100;
            this.dateTimePicker1.Value = new DateTime(anio,mes,dia);

            this.textBox6.Text = this.clienteSeleccionado.Direccion.Calle;
            this.textBox9.Text = this.clienteSeleccionado.Direccion.Depto;
            this.textBox10.Text = this.clienteSeleccionado.Direccion.Localidad;
            if(!this.clienteSeleccionado.Direccion.Piso.ToString().Equals(""))this.textBox8.Text = Convert.ToString(this.clienteSeleccionado.Direccion.Piso);
            if (!this.clienteSeleccionado.Direccion.CodigoPostal.ToString().Equals("")) this.textBox11.Text = Convert.ToString(this.clienteSeleccionado.Direccion.CodigoPostal);
           
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ciudadesSeleccionadas.Contains(this.listBox2.SelectedValue.ToString())) return;
            ciudadesSeleccionadas.Add(this.listBox2.SelectedValue.ToString());
            List<String> ciudadesSeleccionadas2 = new List<string>();
            ciudadesSeleccionadas2.AddRange(ciudadesSeleccionadas);
            this.listBox1.DataSource = ciudadesSeleccionadas2;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ciudadesSeleccionadas.Count() == 1) return;
            ciudadesSeleccionadas.Remove(this.listBox1.SelectedValue.ToString());
            List<String> ciudadesSeleccionadas2 = new List<string>();
            ciudadesSeleccionadas2.AddRange(ciudadesSeleccionadas);
            this.listBox1.DataSource = ciudadesSeleccionadas2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private User.User nuevoCliente() 
        {
            User.User nuevoCliente = new User.User();
            nuevoCliente.DatosCliente = new DatosCliente();
            nuevoCliente.DatosLogin = new Login();
            nuevoCliente.DatosCliente.Nombre = textBox1.Text;
            nuevoCliente.DatosCliente.Apellido = this.textBox2.Text;
            nuevoCliente.DatosCliente.Dni = textBox3.Text;
            nuevoCliente.DatosCliente.Mail = this.textBox4.Text;
            nuevoCliente.DatosCliente.Telefono = textBox5.Text;
            //agregar los demas campos

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.homeUsr.eliminarCiudadesDeCliente(this.clienteSeleccionado.DatosCliente.Dni,this.ciudadesOriginales);
            this.homeUsr.agregarCiudadesACliente(this.clienteSeleccionado.DatosCliente.Dni, this.ciudadesSeleccionadas);
            //CAMBIAR ESTO this.homeUsr.changeStatus(this.clienteSeleccionado.DatosLogin.UserName, true);
            this.homeUsr.modificarCliente(this.clienteSeleccionado, this.nuevoCliente());

        }
    }
}
