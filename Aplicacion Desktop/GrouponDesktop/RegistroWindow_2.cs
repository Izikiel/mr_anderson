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
    public partial class RegistroWindow_2 : Form
    {
        String nombreUsr;
        String pass;
        String tipo;
        Form WParent;

        public RegistroWindow_2(Form parent)
        {
            InitializeComponent();
            this.WParent = parent;
        }


    }
}
