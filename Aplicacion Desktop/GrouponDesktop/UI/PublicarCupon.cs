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
    public partial class PublicarCupon : Form
    {
        public PublicarCupon()
        {
            InitializeComponent();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            int a = Dominio.DataAdapter.AdministradorAdapter.existeUsuario(textBox1.Text);
            if (a==0)
            {
                MessageBox.Show("No existe el Cuit");
                return;
            }
            //ALTER procedure [MR_ANDERSON].[sp_cupones_a_publicar] (@fecha DATETIME, @provee_cuit NVARCHAR(20))

        }
    }
}
