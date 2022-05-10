using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppCalculadoraMath
{
    public partial class Form1 : Form
    {
        string operador;
        double n1, n2, respuesta;
        bool bandBtn = true, bandN = true, bandOper = true;
        public Form1()
        {
            InitializeComponent();
            txtRespuesta.Clear();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (bandN)
            {
                txtRespuesta.Clear();
                txtRespuesta.Text = "0";
                bandN = false;
            }
            else
            {
                txtRespuesta.Text = txtRespuesta.Text + "0";
            }
            bandBtn = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (bandN)
            {
                txtRespuesta.Clear();
                txtRespuesta.Text = "1";
                bandN = false;
            }
            else
            {
                txtRespuesta.Text = txtRespuesta.Text + "1";
            }
            bandBtn = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (bandN)
            {
                txtRespuesta.Clear();
                txtRespuesta.Text = "2";
                bandN = false;
            }
            else
            {
                txtRespuesta.Text = txtRespuesta.Text + "2";
            }
            bandBtn = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (bandN)
            {
                txtRespuesta.Clear();
                txtRespuesta.Text = "3";
                bandN = false;
            }
            else
            {
                txtRespuesta.Text = txtRespuesta.Text + "3";
            }
            bandBtn = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (bandN)
            {
                txtRespuesta.Clear();
                txtRespuesta.Text = "4";
                bandN = false;
            }
            else
            {
                txtRespuesta.Text = txtRespuesta.Text + "4";
            }
            bandBtn = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (bandN)
            {
                txtRespuesta.Clear();
                txtRespuesta.Text = "5";
                bandN = false;
            }
            else
            {
                txtRespuesta.Text = txtRespuesta.Text + "5";
            }
            bandBtn = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (bandN)
            {
                txtRespuesta.Clear();
                txtRespuesta.Text = "6";
                bandN = false;
            }
            else
            {
                txtRespuesta.Text = txtRespuesta.Text + "6";
            }
            bandBtn = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (bandN)
            {
                txtRespuesta.Clear();
                txtRespuesta.Text = "7";
                bandN = false;
            }
            else
            {
                txtRespuesta.Text = txtRespuesta.Text + "7";
            }
            bandBtn = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (bandN)
            {
                txtRespuesta.Clear();
                txtRespuesta.Text = "8";
                bandN = false;
            }
            else
            {
                txtRespuesta.Text = txtRespuesta.Text + "8";
            }
            bandBtn = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (bandN)
            {
                txtRespuesta.Clear();
                txtRespuesta.Text = "9";
                bandN = false;
            }
            else
            {
                txtRespuesta.Text = txtRespuesta.Text + "9";
            }
            bandBtn = false;
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            txtRespuesta.Text = txtRespuesta.Text + ",";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtRespuesta.Clear();
            bandBtn = true;
            bandN = true;
            bandOper = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtRespuesta.TextLength > 1)
            {
                txtRespuesta.Text = txtRespuesta.Text.Remove(txtRespuesta.Text.Length - 1, 1);
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            calcular();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            operador = "*";
            calcular();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            calcular();
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            respuesta = Math.Round(Math.Pow(double.Parse(txtRespuesta.Text), 2));
            txtRespuesta.Text = respuesta.ToString();
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            operador = "^";
            calcular();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            respuesta = Math.Round(Math.Sqrt(double.Parse(txtRespuesta.Text)), 2);
            txtRespuesta.Text = respuesta.ToString();
        }

        private void btnAbsoluto_Click(object sender, EventArgs e)
        {
            respuesta = Math.Truncate(double.Parse(txtRespuesta.Text));
            txtRespuesta.Text = respuesta.ToString();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            respuesta = Math.Log10(double.Parse(txtRespuesta.Text));
            txtRespuesta.Text = respuesta.ToString();
        }

        private void btnFraccion_Click(object sender, EventArgs e)
        {
            respuesta = 1 / (double.Parse(txtRespuesta.Text));
            txtRespuesta.Text = respuesta.ToString();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            respuesta = Math.Sin(double.Parse(txtRespuesta.Text));
            txtRespuesta.Text = respuesta.ToString();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            respuesta = Math.Cos(double.Parse(txtRespuesta.Text));
            txtRespuesta.Text = respuesta.ToString();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            respuesta = Math.Tan(double.Parse(txtRespuesta.Text));
            txtRespuesta.Text = respuesta.ToString();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            operador = "max";
            calcular();
        }

        private void btnCsc_Click(object sender, EventArgs e)
        {
            operador = "min";
            calcular();
        }

        private void btnCot_Click(object sender, EventArgs e)
        {
            respuesta = Math.Round(double.Parse(txtRespuesta.Text), 2);
            txtRespuesta.Text = respuesta.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txtRespuesta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 46 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            calcular();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if(bandBtn == false)
            {
                if(bandOper == false)
                {
                    n2 = Double.Parse(txtRespuesta.Text);
                    operaciones(operador);
                    bandBtn = true;
                    bandN = true;
                    bandOper = true;
                }
            }
        }

        private void operaciones(string operacion)
        {
            switch (operador)
            {
                case "+":
                    respuesta = n1 + n2;
                    break;
                case "-":
                    respuesta = n1 - n2;
                    break;
                case "*":
                    respuesta = n1 * n2;
                    break;
                case "/":
                    respuesta = n1 / n2;
                    break;
                case "^":
                    respuesta = Math.Round(Math.Pow(n1, n2));
                    break;
                case "²":
                    respuesta = Math.Round(Math.Pow(n1, 2));
                    break;
                case "max":
                    respuesta = Math.Max(n1, n2);
                    break;
                case "min":
                    respuesta = Math.Min(n1, n2);
                    break;
            }
            txtRespuesta.Text = respuesta.ToString();
        }

        private void calcular()
        {
            bandN = true;
            if (bandOper)
            {
                try
                {
                    n1 = Double.Parse(txtRespuesta.Text);
                }
                catch(FormatException)
                {
                }
                bandOper = false;
            }
            else
            {
                if (!bandBtn)
                {
                    n2 = Double.Parse(txtRespuesta.Text);
                    operaciones(operador);
                    try
                    {
                        n1 = Double.Parse(txtRespuesta.Text);
                    }
                    catch (FormatException)
                    {
                    }
                    bandBtn = true;
                    bandN = true;
                }
            }
        }
    }
}
