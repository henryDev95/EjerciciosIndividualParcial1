using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEjercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBoxA.Text);
                int b = int.Parse(textBoxB.Text);
                int c = int.Parse(textBoxC.Text);

                double Dis = Math.Pow(b, 2) - 4 * a * c;

                label6.Text = Dis.ToString();
            }
            catch
            {
                MessageBox.Show("!Solo permite numeros!");
                textBoxA.Clear();
                textBoxB.Clear();
                textBoxC.Clear();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxC.Clear();
            label6.Text = "";
        }
    }
}
