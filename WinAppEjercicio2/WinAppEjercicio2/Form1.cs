using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEjercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Imprimir_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);

            int c_uno = numero / 10;
            int c_dos = c_uno / 10;
            int c_tres = c_dos / 10;
            int c_cuatro = c_tres / 10;
          
            int r_uno = numero % 10;
            int r_dos = c_uno % 10;
            int r_tres = c_dos % 10;
            int r_cuatro = c_tres % 10;

            int invertido = r_uno * 10000 + r_dos * 1000 + r_tres * 100 + r_cuatro *10+ c_cuatro;

            Imprimir.Text = invertido.ToString();
        }
    }
}
