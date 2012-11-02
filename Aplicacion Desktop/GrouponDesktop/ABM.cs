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
    public partial class ABM : Form
    {
        public ABM()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            Tabs.TabPages[0].Name = "Alta";
            Tabs.TabPages[1].Name = "Modificación";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ClienteRB_CheckedChanged(object sender, EventArgs e)
        {
            mostrarClienteAbm();
        }

        private void ProverdorRB_CheckedChanged(object sender, EventArgs e)
        {
            mostrarProviderAbm();
        }

        private void mostrarClienteAbm()
        {
            ClientPanel.Visible = true;
            ProveedorPanel.Visible = false;
        }
        private void mostrarProviderAbm()
        {
            ProveedorPanel.Visible = true;
            ClientPanel.Visible = false;
        }
        
    }
}
