using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        public static bool camposCompletos(List<System.Windows.Forms.Control> controls)
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

        public static bool isNumeric(String str)
        {
            Double num = 0;
            return Double.TryParse(str, out num);
        }

        public static bool areNumericControls(List<System.Windows.Forms.Control> controls)
        {
            foreach (System.Windows.Forms.Control ctrl in controls)
            {
                if (isNumeric(ctrl.Text) == false)
                    return false;
            }
            return true;
        }


        public static string SHA256Encrypt(string input)
        {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = provider.ComputeHash(inputBytes);

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < hashedBytes.Length; i++)
                output.Append(hashedBytes[i].ToString("x2").ToLower());

            return output.ToString();
        }  
    }
}
