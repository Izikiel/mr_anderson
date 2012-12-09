using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Dominio.DataAdapter;

namespace GrouponDesktop.UI
{
    public partial class ListadoHistorialCupones : Form
    {
        LoginWindow loginWindow;

        public ListadoHistorialCupones(LoginWindow loginWindow)
        {
            InitializeComponent();
            this.loginWindow = loginWindow;
            
        }

        public Boolean datosValidos()
        {
            int fecha1 = Convert.ToInt32(this.getFechaToAAAAMMDD(this.dateTimePicker1));
            int fecha2 = Convert.ToInt32(this.getFechaToAAAAMMDD(this.dateTimePicker2));
            if (fecha2 <= fecha1)
            {
                MessageBox.Show("Ingrese un intervalo valido");
                return false;
            }

            return true;
        }

        private String getFechaToAAAAMMDD(DateTimePicker dateTimePicker)
        {
            int fechaInt = dateTimePicker.Value.Year * 10000;
            fechaInt = fechaInt + dateTimePicker.Value.Month * 100;
            fechaInt = fechaInt + dateTimePicker.Value.Day;
            String fechaString = fechaInt.ToString();
            return fechaString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!this.datosValidos()) return;

            GrouponDesktop.Dominio.DataAdapter.ListadoHistorialCupones listado = new GrouponDesktop.Dominio.DataAdapter.ListadoHistorialCupones();

            List<CuponesStringContainer> resultado = listado.historialCuponesPara(Convert.ToInt32(loginWindow.UsuarioActivo.DatosCliente.Dni), this.getFechaToAAAAMMDD(dateTimePicker1), this.getFechaToAAAAMMDD(dateTimePicker2));
            this.dataGridView1.DataSource = resultado;

        }
    }
}
