using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.Dominio
{
    class Utilidades
    {
        public static bool camposCompletos(System.Windows.Forms.Control.ControlCollection controls)
        {
            foreach (System.Windows.Forms.Control ctrl in controls)
            {
                try
                {
                    if (String.IsNullOrEmpty(ctrl.Text.Trim()))
                        return false;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            return true;

        }

        public static bool isNullOrEmpty(String str)
        {
            return String.IsNullOrEmpty(str.Trim());
        }
    }
}
