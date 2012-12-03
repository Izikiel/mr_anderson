using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Rol;

namespace GrouponDesktop
{
    public partial class ListadoRoles : Form
    {
        String f;
        String selectedRolName;

        public ListadoRoles()
        {
            InitializeComponent();
            this.fillGrid();
        }

        public void setF(String f)
        {
            this.f = f;
        }

        private void fillGrid() {
                HomeRoles home_roles = new HomeRoles();
                List<Rol.Rol> listaRoles = home_roles.getRoles();
                dataGridView1.DataSource = listaRoles;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex !=
            dataGridView1.Columns["Seleccionar"].Index) return;

            this.selectedRolName = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value as string;
            
            switch (f)
            {
                case "Baja Rol":
                    ConfirmarEliminarRolDialog w = new ConfirmarEliminarRolDialog(this.selectedRolName);
                    w.ShowDialog();
                    this.fillGrid();
                    break;
                case "Modificacion Rol":
                    ModificacionRol wModif = new ModificacionRol(this.selectedRolName);  
                    wModif.ShowDialog();
                    this.fillGrid();
                    break;

            }
        }
    }
}
