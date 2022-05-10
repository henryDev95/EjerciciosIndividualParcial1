using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppTallas
{
    class clsTallas

    {
        private double tallas;
        
        public clsTallas(double talla)
        {
            this.tallas = talla;
        }
       

        public double Talla2()
        {
            return  tallas * 2.45;
        }

    }
}
