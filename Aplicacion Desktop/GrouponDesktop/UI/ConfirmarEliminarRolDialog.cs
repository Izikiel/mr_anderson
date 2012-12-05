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
    public partial class ConfirmarEliminarRolDialog : Form
    {
        String nombre_rol;

        public ConfirmarEliminarRolDialog(String nombre)
        {
            InitializeComponent();
            this.nombre_rol = nombre;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeRoles home = new HomeRoles();
            home.modificarStatus(this.nombre_rol, false);
            MessageBox.Show("Se inhabilito el rol correctamente");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
    }
}
