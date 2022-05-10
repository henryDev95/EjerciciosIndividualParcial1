using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppCadena
{
    public partial class Form1 : Form
    {

      
        public Form1()
        {
            InitializeComponent();
        }

        private void buttCalcular_Click(object sender, EventArgs e)
        {

            string cadena = textCadena.Text+$"a";
            CalcularC calcular = new CalcularC(cadena);
            string nuevo = calcular.eliminarEspacio();
            labResultado.Text = calcular.SumaNumero(nuevo).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textCadena.Clear();
            labResultado.Text = "";
        }
    }
}
