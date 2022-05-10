namespace WinAppTraCelsius
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labResultado = new System.Windows.Forms.Label();
            this.butCalcular = new System.Windows.Forms.Button();
            this.butBorrar = new System.Windows.Forms.Button();
            this.textValor = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRANSFORMAR DE GRADOS FAHRENHEIT A CELSIUS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gº FAHRENHEIT :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gº CELSIUS : ";
            // 
            // labResultado
            // 
            this.labResultado.AutoSize = true;
            this.labResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labResultado.Location = new System.Drawing.Point(222, 145);
            this.labResultado.Name = "labResultado";
            this.labResultado.Size = new System.Drawing.Size(95, 16);
            this.labResultado.TabIndex = 3;
            this.labResultado.Text = ".............................";
            // 
            // butCalcular
            // 
            this.butCalcular.BackColor = System.Drawing.SystemColors.HotTrack;
            this.butCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCalcular.Location = new System.Drawing.Point(84, 224);
            this.butCalcular.Name = "butCalcular";
            this.butCalcular.Size = new System.Drawing.Size(105, 37);
            this.butCalcular.TabIndex = 4;
            this.butCalcular.Text = "Calcular";
            this.butCalcular.UseVisualStyleBackColor = false;
            this.butCalcular.Click += new System.EventHandler(this.butCalcular_Click);
            // 
            // butBorrar
            // 
            this.butBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.butBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBorrar.Location = new System.Drawing.Point(235, 224);
            this.butBorrar.Name = "butBorrar";
            this.butBorrar.Size = new System.Drawing.Size(106, 37);
            this.butBorrar.TabIndex = 5;
            this.butBorrar.Text = "Borrar";
            this.butBorrar.UseVisualStyleBackColor = false;
            this.butBorrar.Click += new System.EventHandler(this.butBorrar_Click);
            // 
            // textValor
            // 
            this.textValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValor.Location = new System.Drawing.Point(216, 91);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(125, 22);
            this.textValor.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinAppTraCelsius.Properties.Resources.tabla_Celsius_Fahrenheit;
            this.pictureBox1.Location = new System.Drawing.Point(356, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 311);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(663, 395);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textValor);
            this.Controls.Add(this.butBorrar);
            this.Controls.Add(this.butCalcular);
            this.Controls.Add(this.labResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Celsius";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labResultado;
        private System.Windows.Forms.Button butCalcular;
        private System.Windows.Forms.Button butBorrar;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

