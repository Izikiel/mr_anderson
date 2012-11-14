using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop
{
    class StringValue
    {
        private String s_value;
        public String S_value
        {
            get{return s_value;}
            set{s_value = value;}
        }


        public StringValue(String s)
        {
            s_value = s;
        }
    }
}
