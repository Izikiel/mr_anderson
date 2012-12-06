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
    public partial class ABMUsr : Form
    {
        String tipo;
        public ABMUsr(String t)
        {
            this.tipo = t;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonModificacionBajaClicked(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            ListadoUsuarios w = new ListadoUsuarios(this.tipo,boton.Text);
            w.ShowDialog();
            
        }



    }
}
