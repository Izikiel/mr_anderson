using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.User;
using GrouponDesktop.Dominio.DataAdapter;

namespace GrouponDesktop.UI
{
    public partial class ListadoUsuarios : Form
    {
        String tipo; //cliente o proveedor
        String f; //Baja o Modificacion
        String SelectedUsrname;
        List<UserStringContainer> listaUsuarios;
        HomeUsuarios home_usuarios = new HomeUsuarios();

        public ListadoUsuarios(String t,String f)
        {
            InitializeComponent();
            this.tipo = t;
            this.f = f;
            this.initFiltros();
            this.fillGridSinFiltros();
        }

        private void initFiltros()
        {
            if (this.tipo.Equals("Cliente"))
            {//inicializar filtros Cliente
                this.filtro1.Text = "nombre";
                this.filtro2.Text = "apellido";
                this.filtro3.Text = "dni";
                this.filtro4.Text = "mail";
            }
            else
            {//inicializar filtros proveedor
                this.filtro1.Text = "rs";
                this.filtro2.Text = "cuit";
                this.filtro3.Text = "mail";
                this.filtro4.Hide();
                this.textBox4.Hide();
            }
        }

        private void fillGridSinFiltros()
        {
            this.listaUsuarios = new List<UserStringContainer>();
            this.listaUsuarios.AddRange(this.home_usuarios.getNombreUsuarios(this.tipo));
            this.fillGrid();
        }

        private void fillGridConFiltros(object sender, EventArgs e)
        {
            this.listaUsuarios = new List<UserStringContainer>();
            this.listaUsuarios.AddRange(this.home_usuarios.getNombreUsuarios(this.tipo,
            this.textBox1.Text,this.textBox2.Text,this.textBox3.Text,this.textBox4.Text));
            this.fillGrid();
        }

        private void fillGrid()
        {
            dataGridView1.DataSource = this.listaUsuarios;
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
                    if (tipo.Equals("Cliente"))
                    {
                        ModificacionCliente dModif = new ModificacionCliente(this.SelectedUsrname);
                        dModif.ShowDialog();
                        this.fillGrid();
                    }
                    else
                    {
                        /*ModificacionProveedor dModifP = new ModificacionProveedor(this.SelectedUsrname);
                        dModifP.ShowDialog();
                        this.fillGrid();*/
                    }
                    break;

        }


    }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.fillGridSinFiltros();
        }

}
}
