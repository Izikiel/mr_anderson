using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.UI;

namespace GrouponDesktop
{
    public partial class Menu : Form
    {
        LoginWindow loginWindow;
        public Menu(LoginWindow loginWindow)
        {
            this.loginWindow = loginWindow;
            InitializeComponent();
        }

        public void do_f(string f)
        {
            switch (f)
            {
                case "ABM Rol":
                    ABMRol w = new ABMRol(loginWindow);
                    w.Show();
                    break;
                case "Cargar Credito":
                    CargarCredito creditoWindow = new CargarCredito(loginWindow);
                    creditoWindow.Show();
                    break;
                case "ABM Usuario":
                    Button BAbmClientes = new Button();
                    Button BAbmProveedores = new Button();
                    BAbmClientes.Text = "Abm Clientes";
                    BAbmClientes.AutoSize = true;
                    BAbmClientes.Location = new System.Drawing.Point(50, 30);
                    BAbmClientes.Click += new EventHandler(this.abmClientes);
                    BAbmProveedores.Text = "Abm Proveedores";
                    BAbmProveedores.AutoSize = true;
                    BAbmProveedores.Location = new System.Drawing.Point(40, 85);
                    BAbmProveedores.Click += new EventHandler(this.abmProv);
                    Form wABM = new Form();
                    wABM.Controls.Add(BAbmProveedores);
                    wABM.Controls.Add(BAbmClientes);
                    wABM.Size = new System.Drawing.Size(200,200);
                    wABM.Show();
                    break;
                   
                case "Comprar Giftcard":
                    ComprarGiftCard comprarGiftCard = new ComprarGiftCard(loginWindow);
                    comprarGiftCard.Show();
                    break;
                case "Comprar Cupon":
                    ComprarCupon comprarCupon = new ComprarCupon(loginWindow);
                    comprarCupon.Show();
                    break;
                case "Pedir Devolucion":
                    DevolverCupon devolverCupon = new DevolverCupon(loginWindow);
                    devolverCupon.Show();
                    break;

            }
        }

        private void menu_closed(object sender, EventArgs e)
        {   //TODO: hacer q la ventana de login se oculte y despues volver a mostrarla
            //Parent.Show();
            this.Close();
        }

        private void abmProv(object sender, EventArgs e)
        {
            ABMUsr w = new ABMUsr("Proveedor");
            w.Show();
        }

        private void abmClientes(object sender, EventArgs e)
        {
            ABMUsr w = new ABMUsr("Cliente");
            w.Show();
        }
    }
}
