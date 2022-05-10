using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinAppCadena
{
    class CalcularC
    {
        private char[] numero = {'0','1','2','3','4','5','6','7','8','9'};

        string cadena = "";
        public CalcularC(string cadena) {
            this.cadena = cadena;
        }


        public string eliminarEspacio()
        {
            return Regex.Replace(cadena, @"\s", "");
        }


        public int SumaNumero(string cadenaNueva)
        {
            string valor ="";
            int suma=0;
            int[] vect = new int[200];
            int p = 0;
            int valorTotal = 0;
        

            for (int i = 0; i < cadenaNueva.Length; i++)
            {
                bool encontrado = false;
                
                for (int j = 0; j < numero.Length; j++)
                {
                    if (cadenaNueva[i] == numero[j])
                    {
                        encontrado = true;

                      //  Console.WriteLine(cadenaNueva[i].ToString());

                    }
                }

                if (encontrado == true)
                {
                    valor = valor + $"{cadenaNueva[i]}";
                    suma = 0;
                }
                else
                {
                    if (valor != "")
                    {                                           
                       suma = int.Parse(valor.ToString());
                       vect[p] = suma;
                       p++;
                      
                      Console.WriteLine(suma);
                    }
                    valor= "";
                   // Console.WriteLine(valor);
                    
                    //contador++;
                }


            }
            
            for (int l=0; l < p; l++)
            {
                valorTotal += vect[l];
            }
          
     
            return valorTotal;
        }
             

    }
}
