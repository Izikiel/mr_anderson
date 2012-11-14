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
    public partial class ABMRol : Form
    {
        public ABMRol()
        {
            InitializeComponent();
        }

        private void ABMRol_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaRol w = new AltaRol();
            w.Show();
        }

        private void buttonBajaModifCliecked(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            Listado w = new Listado();
            w.setF(boton.Text + " Rol");
            w.ShowDialog();
            
        }

    }
}
