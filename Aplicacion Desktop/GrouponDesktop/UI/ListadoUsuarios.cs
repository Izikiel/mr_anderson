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

namespace GrouponDesktop.UI
{
    public partial class ListadoUsuarios : Form
    {
        String tipo;
        String f;
        String SelectedUsrname;

        public ListadoUsuarios(String t,String f)
        {
            InitializeComponent();
            this.tipo = t;
            this.f = f;
            this.fillGrid();
        }

        private void fillGrid()
        {
            HomeUsuarios home_usuarios = new HomeUsuarios();
            List<Login> listaUsuarios = home_usuarios.getUsuarios(this.tipo);
            dataGridView1.DataSource = listaUsuarios;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex !=
            dataGridView1.Columns["Seleccionar"].Index) return;

            this.SelectedUsrname = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            
            
            switch (f)
            {
                case "Baja":
                    ConfirmarEliminarUsuarioDialog dBaja = new ConfirmarEliminarUsuarioDialog(this.SelectedUsrname);
                    dBaja.ShowDialog();
                    this.fillGrid();
                    break;
                case "Modificacion":
                    if(tipo.Equals("Cliente")){
                    ModificacionCliente dModif = new ModificacionCliente(this.SelectedUsrname);  
                    dModif.ShowDialog();
                    this.fillGrid();
                    }
                    break;

        }


    }
}
}
