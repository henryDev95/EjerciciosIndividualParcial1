using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinAppEditorTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Negrita_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                FontStyle negrita = new FontStyle();
                if (richTextBox1.SelectionFont.Bold)
                {
                    negrita = FontStyle.Regular;
                }
                else
                {
                    negrita = FontStyle.Bold;
                }
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, negrita);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Documento de texto|*.txt";
            guardar.Title = "Guardar";
            guardar.FileName = "Sin título 1";
            var result = guardar.ShowDialog();
            if(result == DialogResult.OK)
            {
                StreamWriter escribir = new StreamWriter(guardar.FileName);
                foreach(object linea in richTextBox1.Lines)
                {
                    escribir.WriteLine(linea);
                }
                escribir.Close();
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Documento de texto|*.txt";
            abrir.Title = "Abrir";
            abrir.FileName = "Sin título 1";
            var result = abrir.ShowDialog();
            if (result == DialogResult.OK)
            {
                StreamReader leer = new StreamReader(abrir.FileName);
                richTextBox1.Text = leer.ReadToEnd();
                leer.Close();
            }
        }

        private void tsFuente_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void tsIzquierda_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void tsCentrar_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void tsDerecha_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void tsColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void tsCursiva_Click(object sender, EventArgs e)
        {
            FontStyle cursiva = new FontStyle();
            if (richTextBox1.SelectionFont.Italic)
            {
                cursiva = FontStyle.Regular;
            }
            else
            {
                cursiva = FontStyle.Italic;
            }
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, cursiva);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FontStyle subrayado = new FontStyle();

            if (richTextBox1.SelectionFont.Underline)
            {
                subrayado = FontStyle.Regular;
            }
            else
            {
                subrayado = FontStyle.Underline;
            }
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, subrayado);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbFuente.Items.Clear();
            foreach (FontFamily fuente in FontFamily.Families)
            {
                string nombre = fuente.Name;
                cbFuente.Items.Add(nombre);
            }

            cbColor.Items.Clear();
            string[] colores = Enum.GetNames(typeof(System.Drawing.KnownColor));
            cbColor.Items.AddRange(colores);
        }

        private void cbFuente_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            string texto = cbFuente.Items[e.Index].ToString();
            Font fuente = new Font(texto, e.Font.Size);
            e.Graphics.DrawString(texto, fuente, new SolidBrush(e.ForeColor), e.Bounds.Left + 2, e.Bounds.Top + 2);
            e.DrawFocusRectangle();
        }

        private void cbFuente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbFuente.Font = new Font(cbFuente.Text, cbFuente.Font.Size);
            richTextBox1.SelectionFont = cbFuente.Font;
        }

        private void cbColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                string texto = cbColor.Items[e.Index].ToString();
                Brush col = new SolidBrush(e.ForeColor);
                Color color = Color.FromName(texto);
                Brush lapiz = new SolidBrush(color);
                Pen esf = new Pen(e.ForeColor);
                e.Graphics.DrawRectangle(esf, new Rectangle(e.Bounds.Left + 2, e.Bounds.Top + 2, 30, e.Bounds.Height - 4));
                e.Graphics.FillRectangle(lapiz, new Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 3, 28, e.Bounds.Height - 6));
                e.Graphics.DrawString(texto, e.Font, col, e.Bounds.Left + 65, e.Bounds.Top + 2);
                e.DrawFocusRectangle();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbColor.ForeColor = Color.FromName(cbColor.Text);
            richTextBox1.SelectionColor = cbColor.ForeColor;
        }

        private void tsTamFuente_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.G)
                guardarToolStripMenuItem_Click(sender, e);
        }
    }
}
