using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.User;
using GrouponDesktop.DataAdapter;
using GrouponDesktop.Cupones;

namespace GrouponDesktop
{
    public partial class RegistroCliente : Form
    {
        RegistroWindow padre;
        HomeUsuarios homeUsr;
        List<String> ciudadesSeleccionadas = new List<string>();

        public RegistroCliente(RegistroWindow padre)
        {
            InitializeComponent();
            this.padre = padre;
            this.homeUsr = new HomeUsuarios();
            HomeCiudades homeCiudades = new HomeCiudades();
            this.listBox1.DataSource = ciudadesSeleccionadas;
            this.listBox2.DataSource = homeCiudades.getCiudades();
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
                if (c.Text.Equals("") &&
                    (c.Name != "piso_box" || c.Name != "depto_box" || c.Name != "postal_box"))
                {

                    MessageBox.Show("Tiene que completar todos los campos\nEl campo piso y depto no son obligatorios.");
                    return;
                }
            }
            try
            {
                this.padre.Usuario.DatosCliente.Nombre = this.textBox1.Text;
                this.padre.Usuario.DatosCliente.Apellido = this.textBox2.Text;
                this.padre.Usuario.DatosCliente.Dni = this.textBox3.Text;
                this.padre.Usuario.DatosCliente.Mail = this.textBox4.Text;
                this.padre.Usuario.DatosCliente.Telefono = this.textBox5.Text;
                this.padre.Usuario.CuidadesPreferencia = this.ciudadesSeleccionadas;
                this.padre.Usuario.DatosCliente.FechaNac = this.getFechaToAAAAMMDD();

                this.padre.Usuario.Direccion.Calle = this.textBox6.Text+" "+this.textBox7.Text;
                this.padre.Usuario.Direccion.Depto = this.depto_box.Text;
                this.padre.Usuario.Direccion.Localidad = this.textBox10.Text;

                
                String campo = "";
                try
                {
                    campo = "piso";
                    if(this.piso_box.Text.Equals(""))
                        this.padre.Usuario.Direccion.Piso = 0;
                    else
                        this.padre.Usuario.Direccion.Piso = Convert.ToInt32(this.piso_box.Text);

                    campo = "codigo postal";
                    this.padre.Usuario.Direccion.CodigoPostal = Convert.ToInt32(this.postal_box.Text);

                }
                catch (Exception)
                {
                    String error = "El campo " + campo + " tiene un formato incorrecto.";
                    MessageBox.Show(error);
                    return;
                }
                homeUsr.persistir(this.padre.Usuario);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                return;
            }

            MessageBox.Show("El usuario se ha generado correctamente");

        }


        private String getFechaToAAAAMMDD()
        {
            int fechaInt = this.dateTimePicker1.Value.Year * 10000;
            fechaInt = fechaInt + this.dateTimePicker1.Value.Month*100;
            fechaInt = fechaInt + this.dateTimePicker1.Value.Day;
            String fechaString = fechaInt.ToString();
            return fechaString;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            padre.Close();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(ciudadesSeleccionadas.Contains(this.listBox2.SelectedValue.ToString())) return;
            ciudadesSeleccionadas.Add(this.listBox2.SelectedValue.ToString());
            List<String> ciudadesSeleccionadas2 = new List<string>();
            ciudadesSeleccionadas2.AddRange(ciudadesSeleccionadas);
            this.listBox1.DataSource = ciudadesSeleccionadas2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ciudadesSeleccionadas.Remove(this.listBox1.SelectedValue.ToString());
            List<String> ciudadesSeleccionadas2 = new List<string>();
            ciudadesSeleccionadas2.AddRange(ciudadesSeleccionadas);
            this.listBox1.DataSource = ciudadesSeleccionadas2;
        }


    }
}
