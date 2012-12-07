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
        public DevolverCupon(LoginWindow login)
        {
            InitializeComponent();
            this.login = login;
            txtBox_Fecha.Text = AdministradorConfiguracion.obtenerFecha().ToShortDateString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Dominio.Utilidades.camposCompletos(this.Controls))
                MessageBox.Show("Falta completar datos");

            //else: 
        
        }



    }
}
