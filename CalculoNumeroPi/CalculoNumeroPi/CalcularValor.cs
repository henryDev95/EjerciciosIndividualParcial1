using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoNumeroPi
{
    class CalcularValor
    {
        public CalcularValor() { }


        public double valorPi()
        {
            double resultado = 0.0f;

            double i = 1, n = 1 , l= 1;

            while ( i < 100)
            {
                if (i == 1)
                {
                    resultado = resultado + l;
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        resultado = resultado -(l/(i+n));
                    }
                    else
                    {
                        resultado = resultado + (l/(i+n));
                    }

                    n++;
                }
                i++; 
            }
                return (4 * resultado);
        }
    }
}
