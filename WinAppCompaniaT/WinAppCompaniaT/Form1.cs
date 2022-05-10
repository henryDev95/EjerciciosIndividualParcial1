using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppCompaniaT
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
                float peso = float.Parse(textBox1.Text);
                if (comboBox1.SelectedItem != null)
                {
                    string zona = comboBox1.SelectedItem.ToString();
                    float valor = valorZona(zona);
                    if (peso > 5)
                    {
                        labResultado.Text = valor.ToString()+ " " +"euros";
                    }
                    else
                    {
                        MessageBox.Show("!El peso del paquete no es permitido!");
                        textBox1.Clear();
                        comboBox1.Text = "";
                    }

                }
            }
            catch
            {
                MessageBox.Show("!Solo permite numeros!");
                textBox1.Clear();
                comboBox1.Text = "";
            }
        }

        public float valorZona(string zona)
        {
            float valor = 0.0F;
            switch (zona) {
                case "América del Norte":
                    valor = 24;
                    break;
                case "América del Sur":
                    valor = 21;
                    break;
                case "América Central":
                    valor = 20;
                    break;
                case "Europa":
                    valor = 10;
                    break;
                case "Asia":
                    valor = 18;
                    break;
            }

            return valor;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
