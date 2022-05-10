using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppCandidatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            string Pre1 = textBox1.Text;
            string Pre2 = textBox2.Text;
            string Pre3 = textBox3.Text;
            int cantidVotos = int.Parse(textBox4.Text);
            int cantidadPres1 = 0;
            int cantidadPres2 = 0;
            int cantidadPres3 = 0;

            var random = new Random();

            for (int i = 1;  i <= cantidVotos; i++)
            {
                 if (random.Next(1,3)== 1)
                {
                    cantidadPres1 = cantidadPres1 + 1;
                }
                else
                {

                    if (random.Next(1,3) == 2)
                    {
                        cantidadPres2 = cantidadPres2 + 1;
                    }
                    else
                    {
                        cantidadPres3++;
                    }
              

                }
            }


            label12.Text = cantidadPres1.ToString();

            label13.Text = cantidadPres2.ToString();

            label14.Text = cantidadPres3.ToString();

            if (PredidenteGanador(cantidadPres1, cantidadPres2, cantidadPres3)== 1)
            {
                label9.Text = Pre1;
                label11.Text = cantidadPres1.ToString();

            }
            else
            {
                if (PredidenteGanador(cantidadPres1, cantidadPres2, cantidadPres3) == 2)
                {
                    label9.Text = Pre2;
                    label11.Text = cantidadPres2.ToString();

                }
                else
                {
                    label9.Text = Pre3;
                    label11.Text = cantidadPres3.ToString();
                }
            }

        }


        public int PredidenteGanador(int x, int y, int z)
        {
            int ganador = x;

            if (y > ganador)
            {
                ganador = y;

                if (z > ganador)
                {
                    ganador = z;
                }
            }
            else
            {
                if (z > ganador) {
                    ganador = z;
                }
            }


            if (ganador == x)
            {
                return 1;
            }else{
                if (ganador == y)
                {
                    return 2;
                }
                else{
                    return 3;
                }
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
