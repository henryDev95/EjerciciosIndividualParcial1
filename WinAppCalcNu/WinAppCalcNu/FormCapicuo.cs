using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppCalcNu
{
    public partial class FormCapicuo : Form
    {
        public FormCapicuo()
        {
            InitializeComponent();
        }

        private void buttCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(texValor.Text);
                string cadena = "";
             
                string x = Convert.ToString(n);
                do
                {
                    int r = n % 10;
                    cadena = string.Concat(cadena, r);
                    n = n / 10;

                } while (n != 0);

                if (cadena == x)
                {
                    labResul.Text = "El número es capicúa";
                }
                else
                {
                    labResul.Text = "El número no es capicúa";
                }


            }
            catch
            {
                MessageBox.Show("Solo permite numeros enteros");
                texValor.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            texValor.Clear();
            labResul.Text = "";
        }
    }
}
