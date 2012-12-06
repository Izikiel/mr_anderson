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
        Boolean modificarCiudades = false;
        

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
            if (!(Convert.IsDBNull(this.clienteSeleccionado.Direccion.Piso))) this.textBox8.Text = Convert.ToString(this.clienteSeleccionado.Direccion.Piso);
            else this.textBox8.Text = null;
            if (!(Convert.IsDBNull(this.clienteSeleccionado.Direccion.CodigoPostal))) this.textBox11.Text = Convert.ToString(this.clienteSeleccionado.Direccion.CodigoPostal);
            else this.textBox11.Text = null;
           
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.modificarCiudades = true;
            if (ciudadesSeleccionadas.Contains(this.listBox2.SelectedValue.ToString())) return;
            ciudadesSeleccionadas.Add(this.listBox2.SelectedValue.ToString());
            List<String> ciudadesSeleccionadas2 = new List<string>();
            ciudadesSeleccionadas2.AddRange(ciudadesSeleccionadas);
            this.listBox1.DataSource = ciudadesSeleccionadas2;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.modificarCiudades = true;
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
            nuevoCliente.DatosCliente.FechaNac = this.getFechaToAAAAMMDD();
            nuevoCliente.Direccion = new Direccion();
            nuevoCliente.Direccion.Calle = this.textBox6.Text;
            nuevoCliente.Direccion.Depto = this.textBox9.Text;
            nuevoCliente.Direccion.Localidad = this.textBox10.Text;
            if(!this.textBox8.Text.Equals(""))nuevoCliente.Direccion.Piso = Convert.ToInt32(this.textBox8.Text);
            if (!this.textBox11.Text.Equals("")) nuevoCliente.Direccion.CodigoPostal = Convert.ToInt32(this.textBox11.Text);
            //agregar habilitado o no 
            return nuevoCliente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (this.modificarCiudades)
            {
                try
                {
                    this.homeUsr.eliminarCiudadesDeCliente(this.clienteSeleccionado.DatosCliente.Dni, this.ciudadesOriginales);
                    this.homeUsr.agregarCiudadesACliente(this.clienteSeleccionado.DatosCliente.Dni, this.ciudadesSeleccionadas);

                }
                catch (Exception falloCiudades)
                {
                    //ver como hacer para que se vuelva a modificar con los datos originales en caso de q ya se hubiese eliminado
                    MessageBox.Show("No se pudo modificar por: " + falloCiudades.ToString());
                    return;
                }
            }
            try
            {  
                User.User nuevoCliente = this.nuevoCliente();
                //ver como hacer para que no queden los datos inconsistentes
                this.homeUsr.modificarDireccion(this.clienteSeleccionado.DatosLogin.UserName, nuevoCliente.Direccion);
                //CAMBIAR ESTO this.homeUsr.changeStatus(this.clienteSeleccionado.DatosLogin.UserName, true);
                this.homeUsr.modificarCliente(this.clienteSeleccionado, nuevoCliente);
            }
            catch (Exception excep)
            {
                MessageBox.Show("No se pudo modificar por: " + excep.ToString());
                return;
            }
            MessageBox.Show("Se ha modificado correctamente");
            this.Close();

        }

        private String getFechaToAAAAMMDD()
        {
            int fechaInt = this.dateTimePicker1.Value.Year * 10000;
            fechaInt = fechaInt + this.dateTimePicker1.Value.Month * 100;
            fechaInt = fechaInt + this.dateTimePicker1.Value.Day;
            String fechaString = fechaInt.ToString();
            return fechaString;
        }

    }
}
