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
    public partial class ListadoEstadistico : Form
    {
        String semestre;

        public ListadoEstadistico()
        {
            InitializeComponent();
            this.label_descripcion.Text = "";
        }

        private void top5Changed(object sender, EventArgs e)
        {
            this.label_descripcion.Text = "";

            switch (this.comboBox1.Text)
            {
                case "Devolucion Cupones":
                    this.label_descripcion.Text = "Muestra los primeros cinco\nprovedores con mayor\nporcentaje de cupones devueltos.";
                    break;
                case "Acreditacion GiftCards":
                    this.label_descripcion.Text = "Muestra los primeros cinco\nclientes con mayor cantidad\nde Giftcards acreditadas.";
                    break;
            } 
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
            
            
            GrouponDesktop.Dominio.DataAdapter.ListadoEstadistico listado = new GrouponDesktop.Dominio.DataAdapter.ListadoEstadistico();
            
            switch (this.comboBox1.Text)
            {
                case "Devolucion Cupones":
                    List<DevolucionCuponesStringContainer> resultado = listado.top5DevolucionCupones(Convert.ToInt32(this.textBox1.Text), Convert.ToInt32(semestre));
                    this.dataGridView1.DataSource = resultado;
                    break;
                case "Acreditacion GiftCards":
                    List<UsuariosGiftCardsStringContainer> resultado2 = listado.top5UsuariosGiftCardsAcreditadas(Convert.ToInt32(this.textBox1.Text), Convert.ToInt32(semestre));
                    this.dataGridView1.DataSource = resultado2;
                    break;
            } 
            
            
        }

        private void radioButton1_Clicked(object sender, EventArgs e)
        {
            this.radioButton2.Checked = false;
            semestre = this.radioButton1.Text;
        }

        private void radioButton2_Clicked(object sender, EventArgs e)
        {
            this.radioButton1.Checked = false;
            semestre = this.radioButton2.Text;
        }
    }
}
