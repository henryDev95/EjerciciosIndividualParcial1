using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PantallaPrincipal
{
    public partial class FormRepeticion : Form
    {
        public FormRepeticion()
        {
            InitializeComponent();
            panelRepeti.Visible = true;
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        public void OcultarContenido()
        {
            panelRepeti.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            label2.Visible = false;
        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelRepeti.Controls.Count > 0)
                this.panelRepeti.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelRepeti.Controls.Add(fh);
            this.panelRepeti.Tag = fh;
            fh.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OcultarContenido();
            AbrirFormEnPanel(new CalculoNumeroPi.Form1());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OcultarContenido();
            AbrirFormEnPanel(new WinAppSerieFibonacci.Form1());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OcultarContenido();
            AbrirFormEnPanel(new WinAppSerie.Form1());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OcultarContenido();
            AbrirFormEnPanel(new WinAppTallas.Form1());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OcultarContenido();
            AbrirFormEnPanel(new WinAppCalcNu.Form1());
        }
    }
}
