using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GrouponDesktop.Rol;

namespace GrouponDesktop
{
    class RolAdapter
    {
        public List<FuncRol> getFuncRol(List<String> listaFString)
        {
            List<FuncRol> listaFunc = new List<FuncRol>();
            foreach (String unString in listaFString)
            {
                switch (unString)
                {
                    case "comprarGiftCard" :
                        listaFunc.Add(new FuncRol("cliente"));
                        break;

                }
            }
            return listaFunc;
        }
    }
}
