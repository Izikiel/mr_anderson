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
    public partial class FacturarProveedor : Form
    {
        Dictionary<String, String> dataMap = new Dictionary<string, string>();
        public FacturarProveedor()
        {
            InitializeComponent();
            InitializeDates();
            GenerarColumnas();
        }

        private void InitializeDates()
        {
            TimePicker_Desde.Value = AdministradorConfiguracion.obtenerFecha();
            TimePicker_Hasta.Value = AdministradorConfiguracion.obtenerFecha();
        }

        private void Btn_Facturar_Click(object sender, EventArgs e)
        {
            borrarDataGrid();
            String importeFact = "";
            String numeroFact = "";

            dataMap = Dominio.DataAdapter.Facturacion.facturar(TxtBox_Proveedor.Text,
                TimePicker_Desde.Value, TimePicker_Hasta.Value, out importeFact, out numeroFact);

            TxtBox_NumeroFactura.Text = numeroFact;
            TxtBox_Total.Text = importeFact;
            agregarDataAlDataGrid();
            if (!String.IsNullOrEmpty(importeFact))
                MessageBox.Show("La Factura se realizó correctamente");
            else
                MessageBox.Show("No se encontraron datos del Proveedor en el periodo de tiempo");
            
        }

        public void borrarDataGrid()
        {
            DataGrid_Clientes.Rows.Clear();
            TxtBox_NumeroFactura.Text = "";
            TxtBox_Total.Text = "";
        }

        public void GenerarColumnas()
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.Name = "Codigo del Cupon";
            DataGrid_Clientes.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Name = "Cantidad";
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGrid_Clientes.Columns.Add(column);

        }

        public void agregarDataAlDataGrid()
        {
            foreach(String str in dataMap.Keys)
            {
                String [] array = new string[2];
                array[0]=str;
                array[1]=dataMap[str];
                DataGrid_Clientes.Rows.Add(array);
            }
        }

    }
}
