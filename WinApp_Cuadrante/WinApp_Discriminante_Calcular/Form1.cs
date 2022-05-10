using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_Cuadrante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string datoa = textA.Text;
            string datob = textB.Text;

            try
            {
                double _datoa = double.Parse(datoa);
                double _datob = double.Parse(datob);


                CL_Cuadrante objDiscrimiante = new CL_Cuadrante(_datoa, _datob);
                txtrespuesta.Text = objDiscrimiante.Calc_Cuadrante().ToString();


                int N1, N2;
                N1 = int.Parse(textA.Text);// esto permitirar que lea los valores q ingresamos
                N2 = int.Parse(textB.Text);

                if (N1 > 0 && N2 > 0)
                {
                    primer.Visible = true;
                }
                if (N1 < 0 && N2 > 0)
                {
                    segundo.Visible = true;
                }
                if (N1 < 0 && N2 < 0)
                {
                    tercer.Visible = true;
                }
                if (N1 > 0 && N2 < 0)
                {
                    cuarto.Visible = true;
                }

            }
            catch
            {
                MessageBox.Show("Solo permite valores numéricos");
                textA.Clear();
                textB.Clear();

            }
            


        }

         

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            textA.Text = "";
            textB.Text = "";
            txtrespuesta.Text = "";
            

            primer.Visible = false;
            segundo.Visible = false;
            tercer.Visible = false;
            cuarto.Visible = false;



        }
    }
}
