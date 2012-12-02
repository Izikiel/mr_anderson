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

namespace GrouponDesktop
{
    public partial class RegistroCliente : Form
    {
        RegistroWindow padre;
        HomeUsuarios homeUsr;

        public RegistroCliente(RegistroWindow padre)
        {
            InitializeComponent();
            this.padre = padre;
            this.homeUsr = new HomeUsuarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.Text.Equals("")) { MessageBox.Show("Tiene que completar todos los campos"); return; }

            }
            try
            {
                this.padre.Usuario.DatosCliente.Nombre = this.textBox1.Text;
                this.padre.Usuario.DatosCliente.Apellido = this.textBox2.Text;
                this.padre.Usuario.DatosCliente.Dni = this.textBox3.Text;
                this.padre.Usuario.DatosCliente.Mail = this.textBox4.Text;
                this.padre.Usuario.DatosCliente.Telefono = this.textBox5.Text;
                this.padre.Usuario.DatosCliente.FechaNac = this.getFechaToAAAAMMDD();
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
    }
}
