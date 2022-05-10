using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppSerieFibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonResultado_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(textBoxNumero.Text);
                int i = 0;

                while (i <= numero)
                {
                    listBoxSerie.Items.Add(fibonacci(i));
                    i++;
                }
            }
            catch
            {
                MessageBox.Show("Solo permite valores numéricos");
                textBoxNumero.Clear();
            }

        }

        public int fibonacci(int num)
        {
            if (num < 2)
            {
                return num;
            }
            else
            {
                return fibonacci(num - 1) + fibonacci(num - 2);
            }
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            textBoxNumero.Clear();
            listBoxSerie.Items.Clear();
        }
    }
}
