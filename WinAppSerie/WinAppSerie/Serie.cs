using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppSerie
{
    class Serie
    {

        private int numero;

        public Serie(int numero)
        {
            this.numero = numero;
        }


        public double serie()
        {
            double serie = 0;
            int num = 2;
            for(int i=1; i <= numero; i++)
            {
                if(i % 2 == 0)
                {
                    serie = serie - (factorial(num) / Math.Pow(num-1, i));
              
                }
                else
                {
                    serie = serie + (Math.Pow(num-1, i)/ factorial(num));
                    
                }

                num = num + 2;

            }

            return serie;
        }

        public int factorial(int n)
        {
            int factorial = 1;

            for(int i=1;i <= n; i++)
            {

                factorial = factorial * i;
            }

            return factorial;
        }

    }
}
