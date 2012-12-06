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
    public partial class DevolverCupon : Form
    {
        LoginWindow login;
        bool isAdmin = false;
        public DevolverCupon(LoginWindow login)
        {
            InitializeComponent();
            this.login = login;
            if (this.login.UsuarioActivo.Rol.Nombre == "Administrador")
            {
                groupBox_OnlyAdmin.Visible = Enabled;
                isAdmin = true;
            }
            txtBox_Fecha.Text = AdministradorConfiguracion.obtenerFecha().ToShortDateString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!camposCompletos())
                MessageBox.Show("Falta completar datos");
            //else: 
        
        }

        private bool camposCompletos()
        {
            foreach (Control ctrl in this.Controls)
            {
                if(String.IsNullOrEmpty(ctrl.Text))
                    return false;
            }
            return true;

        }

    }
}
