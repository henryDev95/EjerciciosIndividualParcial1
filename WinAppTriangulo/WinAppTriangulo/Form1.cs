using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttoCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int lado1 = int.Parse(textBoLado1.Text);
                int lado2 = int.Parse(textBoLado2.Text);
                int lado3 = int.Parse(textBoLado3.Text);

                if (lado3 <= lado1 + lado2)
                {
                    if (lado3 == lado1 + lado2)
                    {
                        labResultado.Text = "Rectángulo";

                    }
                    else
                    {
                        if (lado1 == lado2 && lado1 == lado3 && lado2 == lado3)
                        {
                            labResultado.Text = "Equilátero";

                        }
                        else
                        {
                            if (lado1 == lado2 && lado1 != lado3)
                            {
                                labResultado.Text = "Isósceles";
                            }
                            else
                            {
                                labResultado.Text = "escaleno";
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("NO se puede formar un triangulo");
                    textBoLado1.Clear();
                    textBoLado2.Clear();
                    textBoLado3.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Solo permite valores numéricos");
                textBoLado1.Clear();
                textBoLado2.Clear();
                textBoLado3.Clear();
                labResultado.Text = "";
            }

           
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            textBoLado1.Clear();
            textBoLado2.Clear();
            textBoLado3.Clear();
            labResultado.Text = "";
        }
    }
}
