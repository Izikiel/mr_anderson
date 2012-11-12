using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.User;
using GrouponDesktop.DataAdapter;

namespace GrouponDesktop
{
    public partial class LoginWindow : Form
    {
        String nombre;
        String pass;
        User.User usuarioActivo;
        DataAccess.SPManager spManager = new GrouponDesktop.DataAccess.SPManager();

        public LoginWindow()
        {
            InitializeComponent();
           
        }

       
        

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.UserName = textBox2.Text;
            login.Password = textBox1.Text;
            try
            {
                login.validateUser();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.ToString());
            }
            //this.usuarioActivo = login.getUser();
            /*Rol.Rol unRol = new Rol.Rol();
            unRol.setEstadoValido(true);
            unRol.setNombreRol("elrol");

            unRol.addFunc("Hola");
            unRol.addFunc("Soy un boton");
            unRol.addFunc("lalala");
            
            User.User usuarioActivo = new User.User();
            usuarioActivo.setTipoUsuario("Admin");
            usuarioActivo.setRol(unRol);*/

            //Form menu = this.crearMenuWindow(usuarioActivo.getRol());
            //menu.Show();
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           // RegistroUsuario registroWindow = new RegistroUsuario();
           // registroWindow.Show();
        }

        private Form crearMenuWindow(Rol.Rol unRol)
        {
            Form menu = new Form();
            int i = 0;
            int j = 0;
            foreach(String func in unRol.getFuncionalidades()){
                Button boton = new Button();
                boton.Text = func;
                boton.AutoSize = true;
                boton.Location = new System.Drawing.Point(20+j,20+i);
                boton.Click += new EventHandler(this.buttonClicked);
                menu.Controls.Add(boton);
                i = i + 25;
                if (i > 25 * 7)
                {
                    i = 0;
                    j = j + 90;
                }
                
            }
            return menu;
        }

        private void buttonClicked(Object sender, EventArgs e)
        {   
            Button boton = (Button)sender;
            this.usuarioActivo.getRol().do_f(boton.Text);
        }
    }
}
