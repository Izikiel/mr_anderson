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
    public partial class LoginWindow : Form
    {
        String nombre;
        String pass;

        public LoginWindow()
        {
            InitializeComponent();
        }

       
        

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.UserName = textBox2.Text;
            login.Password = textBox1.Text;
            login.validateUser();
        }

        
    }
}
