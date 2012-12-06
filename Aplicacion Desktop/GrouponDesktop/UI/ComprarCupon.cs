using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop
{
    public partial class ComprarCupon : Form
    {
        LoginWindow login;
        public ComprarCupon(LoginWindow login)
        {
            this.login = login;
            InitializeComponent();
            InitializeCuponDataGrid();

        }
        private BindingSource bindingSource1 = new BindingSource();

        private void InitializeCuponDataGrid()
        {
            DataGrid_Cupones.AutoGenerateColumns = false;
            DataGrid_Cupones.AutoSize = true;
            DataGrid_Cupones.DataSource = bindingSource1;

            Dominio.Cupones cupones = new Dominio.Cupones();
            List<Dominio.Cupon> cuponesList = cupones.obtenerCuponesEnFecha(AdministradorConfiguracion.obtenerFecha(), AdministradorConfiguracion.obtenerFecha());
            
            foreach (Dominio.Cupon cupon in cuponesList)
            {
                bindingSource1.Add(cupon);
            }
            GenerarColumnaDeCupones();
        }

        public void GenerarColumnaDeCupones()
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "TituloCupon";
            column.Name = "Cupon Title";
            DataGrid_Cupones.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "PrecioActual";
            column.Name = "Precio";
            DataGrid_Cupones.Columns.Add(column);
        }

        private void Btn_Comprar_Click(object sender, EventArgs e)
        {
            //Comparo con el saldo disponible (si es necesario y no lo hace la DB)
            //Efectuo compra
        }
    }
}
