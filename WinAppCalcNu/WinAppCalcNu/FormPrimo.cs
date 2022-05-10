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
    public partial class FormPrimo : Form
    {
        public FormPrimo()
        {
            InitializeComponent();
        }

        private void buttCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(texValor.Text);
                int cont = 0;
                for (int i = 1; i<= numero; i++)
                {
                    if(numero % i == 0)
                    {
                        cont++;
                    }
                }

                if (cont ==2)
                {
                    labResul.Text = "El numero es primo";
                }
                else
                {
                    labResul.Text = "El numero no es primo";
                }

            }
            catch
            {
                MessageBox.Show("Solo permite numeros enteros");
                texValor.Clear();
            }
        }

        private void FormPrimo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            texValor.Clear();
            labResul.Text = "";
        
            
        }
    }
}
