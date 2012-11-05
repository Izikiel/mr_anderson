﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Rol;

namespace GrouponDesktop
{
    public partial class AltaRol : Form
    {
        private List<String> funcionalidades;
        RolBuilder rolBuilder;

        public AltaRol()
        {
            InitializeComponent();
            funcionalidades = new List<String>();
            rolBuilder = new RolBuilder();
        }

        private void allCheckBoxes_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            if (chk.Checked == true)this.funcionalidades.Add(chk.Text);
            if(chk.Checked == false) this.funcionalidades.Remove(chk.Text);
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearAll();
            String selectedItem = cboBoxTipoUsr.SelectedItem.ToString();
            if (selectedItem == "Cliente") enableCliCheckBoxes();
            if (selectedItem == "Proveedor") enableProvCheckBoxes();
            if (selectedItem == "Admin") enableAdminCheckBoxes();
            
        }

        private void clearAll()
        {
            foreach (Object ctrl in this.Controls) 
                if (ctrl is CheckBox)
                {
                    CheckBox chk = (CheckBox)ctrl;
                    chk.Enabled = false;
                    chk.Checked = false;
                }

            funcionalidades.Clear();
            
        }

        private void enableCliCheckBoxes()
        {
            checkBoxComprarGC.Enabled = true;
            checkBoxCargarCredito.Enabled = true;
            checkBoxHistorial.Enabled = true;
            checkBoxListadoEstadistico.Enabled = true;
            checkBoxPedirDevolucion.Enabled = true;
            checkBoxVerCupones.Enabled = true;
        }

        private void enableProvCheckBoxes()
        {
            checkBoxArmarCupon.Enabled = true;
            
        }

        private void enableAdminCheckBoxes()
        {
            checkBoxABMUsr.Enabled = true;
            checkBoxPublicarCupones.Enabled = true;
            checkBoxFacturarProv.Enabled = true;
            checkBoxABMRol.Enabled = true;
        }

        private void aceptar_Click(Object sender, EventArgs e)
        {
                   
            if (textBox1.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre de rol");
                return;
            }
            
            
            if (!funcionalidades.Any())
            {
                MessageBox.Show("Debe elegir al menos una funcionalidad");
                return;
            }

            Rol.Rol unRol = rolBuilder.buildRol(textBox1.Text, cboBoxTipoUsr.SelectedItem.ToString(), funcionalidades);
            MessageBox.Show("Se dio de alta al rol correctamente. Nombre de rol: "+ unRol.getNombreRol());
            //TODO: llamar a un objeto que persista al rol en la base
            
            this.Close();
            
        }

        private void cancelar_Click(Object sender, EventArgs e)
        {
            this.Close();
        }

        

    }
}
