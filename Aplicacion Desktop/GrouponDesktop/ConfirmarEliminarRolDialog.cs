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
    public partial class ConfirmarEliminarRolDialog : Form
    {
        public ConfirmarEliminarRolDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //llamar a home que elimine el rol
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
