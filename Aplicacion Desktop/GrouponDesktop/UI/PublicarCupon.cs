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
    public partial class PublicarCupon : Form
    {
        public PublicarCupon()
        {
            InitializeComponent();
            InitializeCuponDataGrid();
        }

        List<Dominio.Cupon> cuponesList;


        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            int a = 0 ;
            if (String.IsNullOrEmpty(textBox1.Text)== false && 
                a==Dominio.DataAdapter.AdministradorAdapter.existeUsuario(textBox1.Text))
            {
                MessageBox.Show("No existe el Cuit");
                return;
            }
            //ALTER procedure [MR_ANDERSON].[sp_cupones_a_publicar] (@fecha DATETIME, @provee_cuit NVARCHAR(20))
            cuponesList = Dominio.DataAdapter.AdministradorAdapter.getCuponesAPublicar(textBox1.Text, AdministradorConfiguracion.obtenerFecha());
            

            foreach (Dominio.Cupon cupon in cuponesList)
            {
                bindingSource1.Add(cupon);
            }
        }

        private BindingSource bindingSource1 = new BindingSource();

        private Dominio.Cupones cupones;

        private void InitializeCuponDataGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSize = true;
            dataGridView1.DataSource = bindingSource1;
            GenerarColumnaDeCupones();
            cupones = new Dominio.Cupones();
        }

        public void GenerarColumnaDeCupones()
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "CuponCodigo";
            column.Name = "Codigo del Cupon";
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Descripcion";
            column.Name = "Descripcion";
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView1.Columns.Add(column);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String codigoCupon = (String)dataGridView1["Codigo del Cupon", rowSelectedIndex].Value;
            String result = cupones.publicar(codigoCupon);
            MessageBox.Show(result);

        }
        int rowSelectedIndex = 0;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelectedIndex = e.RowIndex;
        }


    }
}
