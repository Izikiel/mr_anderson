﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop.UI
{
    public partial class RegistroConsumo : Form
    {
        String cuit;

        public RegistroConsumo(LoginWindow login)
        {
            InitializeComponent();
            this.cuit = login.UsuarioActivo.DatosProveedor.Cuit;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Dominio.Utilidades.isNumeric(this.codigo_cupon.Text))
            {
                MessageBox.Show("El Codigo del cupon es solo numerico. ");
            }
            String msg = Dominio.DataAdapter.RegistrarConsumo.Registrar(this.codigo_cupon.Text, this.dni_cliente.Text,
                                                            this.cuit);
            MessageBox.Show(msg);
            this.Close();
        }

    }
}
