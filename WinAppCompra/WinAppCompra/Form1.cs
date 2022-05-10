using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppCompra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int filas = dataGridView1.Rows.Count - 1;
            dataGridView1[0, filas].Value = txtNombre.Text;
            dataGridView1[1, filas].Value = txtCedula.Text;
            dataGridView1[2, filas].Value = dtFecha.Text;
            dataGridView1[3, filas].Value = cbImp.Text;
            dataGridView1[4, filas].Value = cbLap.Text;
            dataGridView1[5, filas].Value = cbMon.Text;
            dataGridView1[6, filas].Value = cbPar.Text;
            lblRespuesta.Text = calcular().ToString();
            double IVA = calcular() * 0.12;
            lblIVA.Text = IVA.ToString();
            double total = calcular() + IVA;
            lblTotal.Text = total.ToString();
            
        }

        private void checkImp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkImp.Checked)
                cbImp.Enabled = true;
            else
                cbImp.Enabled = false;
        }

        private void checkLap_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLap.Checked)
                cbLap.Enabled = true;
            else
                cbLap.Enabled = false;
        }

        private void checkMon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMon.Checked)
                cbMon.Enabled = true;
            else
                cbMon.Enabled = false;
        }

        private void checkPar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPar.Checked)
                cbPar.Enabled = true;
            else
                cbPar.Enabled = false;
        }

        public double calcular()
        {
            double total = 0;
            if(checkImp.Checked)
                total += (300 * double.Parse(cbImp.Text));
            if (checkLap.Checked)
                total += (800 * double.Parse(cbLap.Text));
            if (checkMon.Checked)
                total += (150 * double.Parse(cbMon.Text));
            else
                total += (100 * double.Parse(cbPar.Text));

            return total;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if(txtNombre.Text == "")
                    txtNombre.Focus();
                else
                    txtCedula.Focus();
            }
        }

        private void cbLap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("En este campo, se coloca la cédula");
                e.Handled = true;
            }
            if (txtCedula.Text == "")
                txtCedula.Focus();
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtNombre.Focus();
            txtCedula.Clear();
            checkImp.Checked = false;
            checkLap.Checked = false;
            checkMon.Checked = false;
            checkPar.Checked = false;
            cbImp.Text = 0.ToString();
            cbLap.Text = 0.ToString();
            cbPar.Text = 0.ToString();
            cbMon.Text = 0.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cancelar?", "Mensaje", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                txtNombre.Clear();
                txtNombre.Focus();
                txtCedula.Clear();
                checkImp.Checked = false;
                checkLap.Checked = false;
                checkMon.Checked = false;
                checkPar.Checked = false;
                cbImp.Text = 0.ToString();
                cbLap.Text = 0.ToString();
                cbPar.Text = 0.ToString();
                cbMon.Text = 0.ToString();
            }
        }

        private void pbLaptop_Click(object sender, EventArgs e)
        {

        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }
    }
}
