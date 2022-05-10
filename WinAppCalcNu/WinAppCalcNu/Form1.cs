using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppCalcNu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormFactorion factorial = new FormFactorion();
            factorial.Show();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            
           // panelContenido.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormPrimo primo = new FormPrimo();
            primo.Show();
        }


       

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormPerfecto perfecto = new FormPerfecto();
            perfecto.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormCapicuo capicua = new FormCapicuo();
            capicua.Show();
        }
    }
}
