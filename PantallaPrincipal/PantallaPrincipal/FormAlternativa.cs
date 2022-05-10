﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PantallaPrincipal
{
    public partial class FormAlternativa : Form
    {
        public FormAlternativa()
        {
            InitializeComponent();
            panelSecuen.Visible = true;
        }

        private void FormSecuencial_Load(object sender, EventArgs e)
        {

        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelSecuen.Controls.Count > 0)
                this.panelSecuen.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelSecuen.Controls.Add(fh);
            this.panelSecuen.Tag = fh;
            fh.Show();

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OcultarContenido();
            AbrirFormEnPanel(new WinAppTriangulo.Form1());
                     
        }

        public void OcultarContenido()
        {
            panelSecuen.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            label1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OcultarContenido();
            AbrirFormEnPanel(new WinAppCompaniaT.Form1());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OcultarContenido();
            AbrirFormEnPanel(new WinAppCandidatos.Form1());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OcultarContenido();
            AbrirFormEnPanel(new WinApp_Cuadrante.Form1());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OcultarContenido();
            AbrirFormEnPanel(new WinAppCompra.Form1());
        }
    }
}
