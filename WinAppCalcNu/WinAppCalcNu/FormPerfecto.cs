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
    public partial class FormPerfecto : Form
    {
        public FormPerfecto()
        {
            InitializeComponent();
        }

        private void buttCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(texValor.Text);

                int suma = 0;

                for (int i = 1; i < numero; i++){

                    if (numero % i == 0)
                    {
                        suma = suma + i;
                    }
                }

                if (suma==numero)
                {
                    labResul.Text = "El número es perfecto";
                }
                else
                {
                    labResul.Text = "El número es perfecto";
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
