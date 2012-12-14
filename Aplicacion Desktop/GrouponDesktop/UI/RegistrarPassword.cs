using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.DataAdapter;

namespace GrouponDesktop.UI
{
    public partial class RegistrarPassword : Form
    {
        String username;
        public RegistrarPassword(Login log)
        {
            username = log.UserName;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                Login login = new Login();
                login.UserName = this.username;
                login.Password = this.text_pass.Text;
                login.setPasswordOldUser();
                this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
