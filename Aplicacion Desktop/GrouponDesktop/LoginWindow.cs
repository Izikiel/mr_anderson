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
        DataAccess.SPManager spManager = new GrouponDesktop.DataAccess.SPManager();

        public LoginWindow()
        {
            InitializeComponent();
            DataAdapter.DataTester da = new DataAdapter.DataTester();
            da.getUsers(spManager);
            da.insertUser(spManager);
        }

       
        

        private void button1_Click(object sender, EventArgs e)
        {
            /*Login login = new Login();
            login.UserName = textBox2.Text;
            login.Password = textBox1.Text;
            login.validateUser();*/
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        
    }
}
