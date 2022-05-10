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
    public partial class FormFactorion : Form
    {
        public FormFactorion()
        {
            InitializeComponent();
        }

        private void buttCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(texValor.Text);
                int factorial = 1;
                for (int i = 1; i <= n; i++)
                {
                    factorial = factorial * i;
                }

                labResul.Text = factorial.ToString();

               

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
