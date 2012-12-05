using System;
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
        

        public AltaRol()
        {
            InitializeComponent();
            funcionalidades = new List<String>();
           
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
            
        }

        private void clearAll()
        {
            foreach (Object ctrl in this.Controls) 
                if (ctrl is CheckBox)
                {
                    CheckBox chk = (CheckBox)ctrl;
                    chk.Enabled = true;
                    chk.Checked = false;
                }

            funcionalidades.Clear();
            
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

            
            Rol.Rol unRol = new Rol.Rol();
            try
            {

                unRol.crear(textBox1.Text, cboBoxTipoUsr.SelectedItem.ToString(), funcionalidades);
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.ToString());
                return;
            }
            MessageBox.Show("Se dio de alta al rol correctamente. Nombre de rol: "+ unRol.getNombreRol());
            
            this.Close();
            
        }

        private void cancelar_Click(Object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearAll();
            textBox1.Clear();
            cboBoxTipoUsr.ResetText();
        }

        

    }
}
