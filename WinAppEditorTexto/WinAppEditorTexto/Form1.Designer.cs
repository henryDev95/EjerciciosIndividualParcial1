
namespace WinAppEditorTexto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Negrita = new System.Windows.Forms.ToolStripButton();
            this.tsCursiva = new System.Windows.Forms.ToolStripButton();
            this.tsSubrayado = new System.Windows.Forms.ToolStripButton();
            this.tsIzquierda = new System.Windows.Forms.ToolStripButton();
            this.tsCentrar = new System.Windows.Forms.ToolStripButton();
            this.tsDerecha = new System.Windows.Forms.ToolStripButton();
            this.tsTamFuente = new System.Windows.Forms.ToolStripButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.cbFuente = new System.Windows.Forms.ComboBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 112);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(550, 276);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Negrita,
            this.tsCursiva,
            this.tsSubrayado,
            this.tsIzquierda,
            this.tsCentrar,
            this.tsDerecha,
            this.tsTamFuente});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(550, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Negrita
            // 
            this.Negrita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Negrita.Image = global::WinAppEditorTexto.Properties.Resources.n;
            this.Negrita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Negrita.Name = "Negrita";
            this.Negrita.Size = new System.Drawing.Size(24, 24);
            this.Negrita.Text = "Negrita";
            this.Negrita.Click += new System.EventHandler(this.Negrita_Click);
            // 
            // tsCursiva
            // 
            this.tsCursiva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsCursiva.Image = global::WinAppEditorTexto.Properties.Resources.italic_text;
            this.tsCursiva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCursiva.Name = "tsCursiva";
            this.tsCursiva.Size = new System.Drawing.Size(24, 24);
            this.tsCursiva.Text = "Cursiva";
            this.tsCursiva.Click += new System.EventHandler(this.tsCursiva_Click);
            // 
            // tsSubrayado
            // 
            this.tsSubrayado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSubrayado.Image = global::WinAppEditorTexto.Properties.Resources.underline;
            this.tsSubrayado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSubrayado.Name = "tsSubrayado";
            this.tsSubrayado.Size = new System.Drawing.Size(24, 24);
            this.tsSubrayado.Text = "Subrayado";
            this.tsSubrayado.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsIzquierda
            // 
            this.tsIzquierda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsIzquierda.Image = global::WinAppEditorTexto.Properties.Resources.alinear_a_la_izquierda;
            this.tsIzquierda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsIzquierda.Name = "tsIzquierda";
            this.tsIzquierda.Size = new System.Drawing.Size(24, 24);
            this.tsIzquierda.Text = "Alinear a la izquierda";
            this.tsIzquierda.Click += new System.EventHandler(this.tsIzquierda_Click);
            // 
            // tsCentrar
            // 
            this.tsCentrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsCentrar.Image = global::WinAppEditorTexto.Properties.Resources.alinear_al_centro;
            this.tsCentrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCentrar.Name = "tsCentrar";
            this.tsCentrar.Size = new System.Drawing.Size(24, 24);
            this.tsCentrar.Text = "Centrar";
            this.tsCentrar.Click += new System.EventHandler(this.tsCentrar_Click);
            // 
            // tsDerecha
            // 
            this.tsDerecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDerecha.Image = global::WinAppEditorTexto.Properties.Resources.alinear_a_la_derecha;
            this.tsDerecha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDerecha.Name = "tsDerecha";
            this.tsDerecha.Size = new System.Drawing.Size(24, 24);
            this.tsDerecha.Text = "Alinear a la derecha";
            this.tsDerecha.Click += new System.EventHandler(this.tsDerecha_Click);
            // 
            // tsTamFuente
            // 
            this.tsTamFuente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsTamFuente.Image = global::WinAppEditorTexto.Properties.Resources.una;
            this.tsTamFuente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTamFuente.Name = "tsTamFuente";
            this.tsTamFuente.Size = new System.Drawing.Size(24, 24);
            this.tsTamFuente.Text = "Fuente";
            this.tsTamFuente.Click += new System.EventHandler(this.tsTamFuente_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(550, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.abrirToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.guardarToolStripMenuItem.Text = "Guardar (Ctrl+G)";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // cbFuente
            // 
            this.cbFuente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbFuente.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFuente.FormattingEnabled = true;
            this.cbFuente.Location = new System.Drawing.Point(172, 29);
            this.cbFuente.Name = "cbFuente";
            this.cbFuente.Size = new System.Drawing.Size(122, 24);
            this.cbFuente.TabIndex = 4;
            this.cbFuente.Text = "Century Gothic";
            this.cbFuente.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbFuente_DrawItem);
            this.cbFuente.SelectedIndexChanged += new System.EventHandler(this.cbFuente_SelectedIndexChanged);
            // 
            // cbColor
            // 
            this.cbColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbColor.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(300, 29);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(59, 24);
            this.cbColor.TabIndex = 5;
            this.cbColor.Text = "Color";
            this.cbColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbColor_DrawItem);
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.cbColor_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 388);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.cbFuente);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor_texto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Negrita;
        private System.Windows.Forms.ToolStripButton tsCursiva;
        private System.Windows.Forms.ToolStripButton tsSubrayado;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsIzquierda;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripButton tsCentrar;
        private System.Windows.Forms.ToolStripButton tsDerecha;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ComboBox cbFuente;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.ToolStripButton tsTamFuente;
    }
}

