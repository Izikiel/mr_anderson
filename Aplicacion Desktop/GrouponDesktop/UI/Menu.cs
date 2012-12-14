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
            //Timer_RefreshMenu.
            mostrarSaldoSiEsCliente();
        }

        private void mostrarSaldoSiEsCliente()
        {
            if (loginWindow.UsuarioActivo.Rol.TipoUsuario == "Cliente")
            {
                label1.Visible = true;
                Lbl_Saldo.Visible = true;
                Lbl_Saldo.Text = loginWindow.UsuarioActivo.DatosCliente.Saldo.ToString();
            }
            else
            {
                label1.Visible = false;
                Lbl_Saldo.Visible = false;
            }
        }

        public void do_f(string f)
        {
            switch (f)
            {
                case "ABM Rol":
                    if (this.loginWindow.UsuarioActivo.Rol.TipoUsuario != "Administrador")
                    {
                        MessageBox.Show("Ingrese como administrador");
                        return;
                    }
                    ABMRol w = new ABMRol(loginWindow);
                    w.ShowDialog();
                    break;
                case "Cargar Credito":
                    if (this.loginWindow.UsuarioActivo.Rol.TipoUsuario != "Cliente")
                    {
                        MessageBox.Show("Ingrese como un cliente");
                        return;
                    }
                    CargarCredito creditoWindow = new CargarCredito(loginWindow);
                    creditoWindow.ShowDialog();
                    break;
                case "ABM Usuario":
                    if (this.loginWindow.UsuarioActivo.Rol.TipoUsuario != "Administrador")
                    {
                        MessageBox.Show("Ingrese como administrador");
                        return;
                    }
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
                    wABM.ShowDialog();
                    break;
                   
                case "Comprar Giftcard":
                    if (this.loginWindow.UsuarioActivo.Rol.TipoUsuario != "Cliente")
                    {
                        MessageBox.Show("Ingrese como un cliente");
                        return;
                    }
                    ComprarGiftCard comprarGiftCard = new ComprarGiftCard(loginWindow);
                    comprarGiftCard.ShowDialog();
                    break;
                case "Comprar Cupon":
                    if (this.loginWindow.UsuarioActivo.Rol.TipoUsuario != "Cliente")
                    {
                        MessageBox.Show("Ingrese como un cliente");
                        return;
                    }
                    ComprarCupon comprarCupon = new ComprarCupon(loginWindow);
                    comprarCupon.ShowDialog();
                    break;
                case "Pedir Devolucion":
                    if (this.loginWindow.UsuarioActivo.Rol.TipoUsuario != "Cliente")
                    {
                        MessageBox.Show("Ingrese como un cliente");
                        return;
                    }
                    DevolverCupon devolverCupon = new DevolverCupon(loginWindow);
                    devolverCupon.ShowDialog();
                    break;
                case "Simular Usuario":
                    new SimularOtroUsuario(loginWindow).Show();
                    break;
                case "Armar Cupon":
                    if (this.loginWindow.UsuarioActivo.Rol.TipoUsuario != "Proveedor")
                    {
                        MessageBox.Show("Ingrese como un proveedor");
                        return;
                    }
                    new ArmarCupon(loginWindow).ShowDialog();
                    break;
                case "Registro Consumo":
                    if (this.loginWindow.UsuarioActivo.Rol.TipoUsuario != "Proveedor")
                    {
                        MessageBox.Show("Ingrese como un proveedor");
                        return;
                    }
                    new RegistroConsumo(loginWindow).ShowDialog();
                    break;
                case "Publicar Cupones":
                    if (this.loginWindow.UsuarioActivo.Rol.TipoUsuario != "Administrador")
                    {
                        MessageBox.Show("Ingrese como administrador");
                        return;
                    }
                    new PublicarCupon().ShowDialog();
                    break;
                case "Listado Estadistico":
                    if (this.loginWindow.UsuarioActivo.Rol.TipoUsuario != "Administrador")
                    {
                        MessageBox.Show("Ingrese como administrador");
                        return;
                    }
                    new ListadoEstadistico().Show();
                    break;
                case "Facturar Proveedor": 
                    if (this.loginWindow.UsuarioActivo.Rol.TipoUsuario != "Administrador")
                    {
                        MessageBox.Show("Ingrese como administrador");
                        return;
                    }
                    new FacturarProveedor().ShowDialog();
                    break;
                case "Ver Historial":
                    if (this.loginWindow.UsuarioActivo.Rol.TipoUsuario != "Cliente")
                    {
                        MessageBox.Show("Ingrese como un cliente");
                        return;
                    }
                    new ListadoHistorialCupones(loginWindow).Show();
                    break;
                case "Cambiar Password":
                    new CambiarPassword(loginWindow).ShowDialog();
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

        private void Timer_RefreshMenu_Tick(object sender, EventArgs e)
        {
            mostrarSaldoSiEsCliente();
        }
    }
}
