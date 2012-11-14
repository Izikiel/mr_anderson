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
    public partial class Listado : Form
    {
        String f;
        BindingList<StringValue> componentes;

        public Listado()
        {
            InitializeComponent();
            componentes = new BindingList<StringValue>();
          
            this.dataGridView1.DataSource = componentes;
            this.fillGrid();
        }

        public void setF(String f)
        {
            this.f = f;
        }

        private void fillGrid() {
            if(true){
                HomeRoles home_roles = new HomeRoles();
                List<Rol.Rol> listaRoles = home_roles.getRoles();
                foreach (Rol.Rol unRol in listaRoles)
                {
                    this.componentes.Add(new StringValue(unRol.getNombreRol()));
                }
            }
            dataGridView1.DataSource = this.componentes;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex !=
            dataGridView1.Columns["Seleccionar"].Index) return;

            switch (f)
            {
                case "Baja Rol":
                    ConfirmarEliminarRolDialog w = new ConfirmarEliminarRolDialog();
                    //w.setNombreRol
                    w.ShowDialog();
                    break;
                case "Alta Rol":
                    ModificarRol wModif = new ModificarRol();
                    //wModif.setNombreRol
                    wModif.ShowDialog();
                    break;

            }
        }
    }
}
