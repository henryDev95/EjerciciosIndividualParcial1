using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEJercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttContar_Click(object sender, EventArgs e)
        {
            try
            {
                ulong numero = Convert.ToUInt64(textBoxNumero.Text);
                int cc = (int)(Math.Log(numero) / Math.Log(10)) + 1;
                labelResultado.Text = cc.ToString();
            }
            catch
            {
                MessageBox.Show("Solo permite valores numericos");
            }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxNumero.Clear();
            labelResultado.Text = "";
        }
    }
}
