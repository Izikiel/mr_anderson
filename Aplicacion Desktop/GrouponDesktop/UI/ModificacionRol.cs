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
    public partial class ModificacionRol : Form
    {
        string selectedRolName;
        List<String> funcionalidadesRol;
        HomeRoles home;
        Rol.Rol selectedRol;

        public ModificacionRol(String nombre)
        {
            InitializeComponent();
            this.selectedRolName = nombre;
            this.home = new HomeRoles();
            this.selectedRol = home.getRol(this.selectedRolName);
            
            
            this.fill();
            
        }

        public void fill()
        {
            this.selectedRol = home.getRol(this.selectedRolName);
            this.funcionalidadesRol = this.selectedRol.getFuncionalidades();

            this.textBox1.Text = this.selectedRolName;
            this.listBox1.DataSource = funcionalidadesRol;
            if (this.selectedRol.TipoUsuario.Contains("Administrador"))
                this.listBox2.Items.Add("Simular Usuario");
            this.checkBox1.Checked = this.selectedRol.estaHabilitado();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (String f in funcionalidadesRol)
            {
                if (f.Equals(this.listBox2.Text)) return;
            }
            this.home.addFuncionalidad(this.selectedRolName,this.listBox2.Text);
            
            this.fill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (funcionalidadesRol.Count() == 1) return;
            if(this.listBox1.SelectedValue.Equals("Cambiar Password")) return;
            if (this.listBox1.SelectedValue.Equals("Darse de baja")) return;
            
            this.home.deleteFuncionalidad(this.selectedRolName, this.listBox1.SelectedValue.ToString());
            this.fill();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.home.modificarNombre(selectedRolName, this.textBox1.Text);
            selectedRolName = this.textBox1.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.home.modificarStatus(this.selectedRolName,this.checkBox1.Checked);
        }
    }
}
