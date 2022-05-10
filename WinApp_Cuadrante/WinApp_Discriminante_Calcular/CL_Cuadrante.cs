using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinApp_Cuadrante
{
    class CL_Cuadrante
    {
        double _valorA, _valorB,sum,sum2,sum3,sum4,sum5,sum6;

        public CL_Cuadrante(double a, double b )
        {
            this._valorA = a;
            this._valorB = b;
         
        }
        public double Calc_Cuadrante()
        {


            sum = (_valorA - 0);
            sum2 = (_valorB - 0);

            sum3 = Math.Pow(sum, 2);

            sum4 = Math.Pow(sum2, 2);


            sum5 = sum3 + sum4;
            sum6 = Math.Sqrt(sum5);
            return sum6;
            
        }
    }
}
