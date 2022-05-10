using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinappMatriz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random objRnd = new Random();
        int po, ne, sum, sumpar;
        private void TxtColumnas_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Nombre(e);
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                try
                {

                
                if (int.Parse(TxtColumnas.Text) >= 1 && int.Parse(TxtColumnas.Text) <= 5)
                {
                    txtFilas.Focus();
                }
                else
                {
                    MessageBox.Show("Debe ingresar valores de 1-5", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                }
                catch
                {
                    MessageBox.Show("No puede dejar este campo vacio", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtFilas_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Nombre(e);
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                try
                {


                    if (int.Parse(TxtColumnas.Text) >= 1 && int.Parse(TxtColumnas.Text) <= 5)
                    {
                       

                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar valores de 1-5", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("No puede dejar este campo vacio", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int colum = int.Parse(TxtColumnas.Text);
            int filas = int.Parse(txtFilas.Text);
            
            int[,] vec = new int[10, 10];

            for (int k = 0; k < filas; k++)
            {
                for (int i = 0; i < colum; i++)
                {
                    vec[k, i] = objRnd.Next(-6, 6);
                    if (vec[k, i] >= 1)
                    {
                        po++;
                    }
                    else if(vec[k,i]<0)
                    {
                        ne++;
                    }
                    sum += vec[k, i];
                    if (i % 2 != 0)
                    {
                        sumpar += vec[k, i];
                    }
                }

               

            }
            dataGridView1.RowCount = filas;
            dataGridView1.ColumnCount = colum;
            for (int x = 0; x < filas; x++)
            {
                for (int j = 0; j < colum; j++)
                {
                    dataGridView1.Rows[x].Cells[j].Value = vec[x, j];
                }
            }

            lblPositivo.Text = po.ToString();
            lblNegativos.Text = ne.ToString();
            lblSumElemen.Text = sum.ToString();
            lblPar.Text = sumpar.ToString();

        }
    }
}

