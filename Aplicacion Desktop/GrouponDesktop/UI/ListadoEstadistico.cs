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
    public partial class ListadoEstadistico : Form
    {
        public ListadoEstadistico()
        {
            InitializeComponent();
        }

        private Boolean checkearDatosValidos()
        {

            int value;
            if (Int32.TryParse(this.textBox1.Text, out value) == false)
            {
                MessageBox.Show("El formato del año ingresado es incorrecto");
                return false;
            }
            
            
            if (this.radioButton1.Checked == false & this.radioButton2.Checked == false)
            {
                MessageBox.Show("Elija un semestre");
                return false;
            }

            if (this.comboBox1.Text.Equals("")) return false;

            return true;
                    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!this.checkearDatosValidos()) return;



        }

        private void radioButton1_Clicked(object sender, EventArgs e)
        {
            this.radioButton2.Checked = false;
        }

        private void radioButton2_Clicked(object sender, EventArgs e)
        {
            this.radioButton1.Checked = false;
        }
    }
}
