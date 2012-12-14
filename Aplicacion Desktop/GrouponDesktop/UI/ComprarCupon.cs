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
        Dominio.Cupones cupones;

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
            GenerarColumnaDeCupones();
            cupones = new Dominio.Cupones();

            List<Dominio.Cupon> cuponesList = cupones.obtenerCuponesEnFecha(login.UsuarioActivo.DatosCliente.Dni, AdministradorConfiguracion.obtenerFecha());

            foreach (Dominio.Cupon cupon in cuponesList)
            {
                bindingSource1.Add(cupon);
            }
        }

        public void GenerarColumnaDeCupones()
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "CuponCodigo";
            column.Name = "Codigo del Cupon";
            DataGrid_Cupones.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Descripcion";
            column.Name = "Descripcion";
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGrid_Cupones.Columns.Add(column);
            
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "PrecioReal";
            column.Name = "Precio";
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGrid_Cupones.Columns.Add(column);

        }

        private void Btn_Comprar_Click(object sender, EventArgs e)
        {
            String codigoCupon = (String) DataGrid_Cupones["Codigo del Cupon",rowSelectedIndex].Value;
            String msg = cupones.comprarCupones(login.UsuarioActivo.DatosCliente.Dni, codigoCupon);
            MessageBox.Show(msg);
            
            User.HomeUsuarios usuarios = new GrouponDesktop.User.HomeUsuarios();
            usuarios.setInformacionAlUsuario(login.UsuarioActivo);

        }

        int rowSelectedIndex = 0;

        private void DataGrid_Cupones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelectedIndex = e.RowIndex;
        }
    }
}
