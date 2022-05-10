using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppCircunferencia
{
    public partial class Form1 : Form
    {
        double radio, lon, area;
        public Form1()
        {
            InitializeComponent();
            txtlongitud.Enabled = false;
            txtarea.Enabled = false;

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            radio = double.Parse(txtradio.Text);

            lon = 2 *System.Math.PI *radio;
            area = System.Math.PI * Math.Pow(radio,2);
            
            int x = (int) lon;
            
            int y = (int) area;
            
            txtlongitud.Text = x.ToString();
            txtarea.Text = y.ToString();

            


        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtradio.Clear();
            txtlongitud.Clear();
            txtarea.Clear();
        }

        private void txtradio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                radio = double.Parse(txtradio.Text);
                try
                {
                    if(radio>0)
                    {
                        btncalcular.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese valores mayores que cero");
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Ingrese Valores Numericos");
                    txtradio.Clear();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtradio.Clear();
            txtlongitud.Clear();
            txtarea.Clear();
        }
    }
}
