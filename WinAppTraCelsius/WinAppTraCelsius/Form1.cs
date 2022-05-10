using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppTraCelsius
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double FAHRENHEIT = double.Parse(textValor.Text);
                double celsius = ((FAHRENHEIT - 32) * 5) / (9);
                labResultado.Text = celsius.ToString();

            }
            catch
            {
                MessageBox.Show("Solo permite valores numericos");
                textValor.Clear();
            }
        }

        private void butBorrar_Click(object sender, EventArgs e)
        {
            textValor.Clear();
            labResultado.Text = "";
        }
    }
}
