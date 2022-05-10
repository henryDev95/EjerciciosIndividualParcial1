using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppSerie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(textBox1.Text);

                Serie serie = new Serie(numero);

                label4.Text = serie.serie().ToString();

                textBox1.Clear();
            }
            catch
            {
                MessageBox.Show("Solo permite valores numéricos");
                textBox1.Clear();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label4.Text = "";
        }
    }
}
