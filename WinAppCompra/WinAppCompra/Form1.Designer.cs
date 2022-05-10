
namespace WinAppCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbProductos = new System.Windows.Forms.GroupBox();
            this.cbPar = new System.Windows.Forms.ComboBox();
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.cbLap = new System.Windows.Forms.ComboBox();
            this.cbImp = new System.Windows.Forms.ComboBox();
            this.checkPar = new System.Windows.Forms.CheckBox();
            this.checkMon = new System.Windows.Forms.CheckBox();
            this.checkLap = new System.Windows.Forms.CheckBox();
            this.pbMonitor = new System.Windows.Forms.PictureBox();
            this.pbParlante = new System.Windows.Forms.PictureBox();
            this.pbLaptop = new System.Windows.Forms.PictureBox();
            this.pbImpresora = new System.Windows.Forms.PictureBox();
            this.checkImp = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impresora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Laptop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parlante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnNueva = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbDatos.SuspendLayout();
            this.gbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbParlante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLaptop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImpresora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(339, 510);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(114, 42);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lblFecha);
            this.gbDatos.Controls.Add(this.dtFecha);
            this.gbDatos.Controls.Add(this.txtCedula);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.lblCedula);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.Location = new System.Drawing.Point(25, 26);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(730, 85);
            this.gbDatos.TabIndex = 1;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(460, 39);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 16);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
            // 
            // dtFecha
            // 
            this.dtFecha.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Location = new System.Drawing.Point(520, 36);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 26);
            this.dtFecha.TabIndex = 2;
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(332, 36);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 26);
            this.txtCedula.TabIndex = 3;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(90, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(157, 26);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(267, 39);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(53, 16);
            this.lblCedula.TabIndex = 1;
            this.lblCedula.Text = "Cédula";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(10, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombres";
            // 
            // gbProductos
            // 
            this.gbProductos.Controls.Add(this.cbPar);
            this.gbProductos.Controls.Add(this.cbMon);
            this.gbProductos.Controls.Add(this.cbLap);
            this.gbProductos.Controls.Add(this.cbImp);
            this.gbProductos.Controls.Add(this.checkPar);
            this.gbProductos.Controls.Add(this.checkMon);
            this.gbProductos.Controls.Add(this.checkLap);
            this.gbProductos.Controls.Add(this.pbMonitor);
            this.gbProductos.Controls.Add(this.pbParlante);
            this.gbProductos.Controls.Add(this.pbLaptop);
            this.gbProductos.Controls.Add(this.pbImpresora);
            this.gbProductos.Controls.Add(this.checkImp);
            this.gbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProductos.Location = new System.Drawing.Point(25, 135);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Size = new System.Drawing.Size(730, 194);
            this.gbProductos.TabIndex = 2;
            this.gbProductos.TabStop = false;
            this.gbProductos.Text = "Productos";
            // 
            // cbPar
            // 
            this.cbPar.Enabled = false;
            this.cbPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPar.FormattingEnabled = true;
            this.cbPar.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbPar.Location = new System.Drawing.Point(595, 153);
            this.cbPar.Name = "cbPar";
            this.cbPar.Size = new System.Drawing.Size(46, 28);
            this.cbPar.TabIndex = 11;
            this.cbPar.Text = "0";
            // 
            // cbMon
            // 
            this.cbMon.Enabled = false;
            this.cbMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbMon.Location = new System.Drawing.Point(419, 153);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(48, 28);
            this.cbMon.TabIndex = 10;
            this.cbMon.Text = "0";
            // 
            // cbLap
            // 
            this.cbLap.Enabled = false;
            this.cbLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLap.FormattingEnabled = true;
            this.cbLap.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbLap.Location = new System.Drawing.Point(246, 153);
            this.cbLap.Name = "cbLap";
            this.cbLap.Size = new System.Drawing.Size(49, 28);
            this.cbLap.TabIndex = 9;
            this.cbLap.Text = "0";
            this.cbLap.SelectedIndexChanged += new System.EventHandler(this.cbLap_SelectedIndexChanged);
            // 
            // cbImp
            // 
            this.cbImp.Enabled = false;
            this.cbImp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbImp.FormattingEnabled = true;
            this.cbImp.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbImp.Location = new System.Drawing.Point(61, 153);
            this.cbImp.Name = "cbImp";
            this.cbImp.Size = new System.Drawing.Size(48, 28);
            this.cbImp.TabIndex = 8;
            this.cbImp.Text = "0";
            // 
            // checkPar
            // 
            this.checkPar.AutoSize = true;
            this.checkPar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkPar.BackgroundImage")));
            this.checkPar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPar.Location = new System.Drawing.Point(553, 121);
            this.checkPar.Name = "checkPar";
            this.checkPar.Size = new System.Drawing.Size(124, 20);
            this.checkPar.TabIndex = 7;
            this.checkPar.Text = "Parlante ($100)";
            this.checkPar.UseVisualStyleBackColor = true;
            this.checkPar.CheckedChanged += new System.EventHandler(this.checkPar_CheckedChanged);
            // 
            // checkMon
            // 
            this.checkMon.AutoSize = true;
            this.checkMon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkMon.BackgroundImage")));
            this.checkMon.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMon.Location = new System.Drawing.Point(380, 121);
            this.checkMon.Name = "checkMon";
            this.checkMon.Size = new System.Drawing.Size(124, 20);
            this.checkMon.TabIndex = 6;
            this.checkMon.Text = "Monitor ($150)";
            this.checkMon.UseVisualStyleBackColor = true;
            this.checkMon.CheckedChanged += new System.EventHandler(this.checkMon_CheckedChanged);
            // 
            // checkLap
            // 
            this.checkLap.AutoSize = true;
            this.checkLap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkLap.BackgroundImage")));
            this.checkLap.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLap.Location = new System.Drawing.Point(212, 121);
            this.checkLap.Name = "checkLap";
            this.checkLap.Size = new System.Drawing.Size(118, 20);
            this.checkLap.TabIndex = 5;
            this.checkLap.Text = "Laptop ($800)";
            this.checkLap.UseVisualStyleBackColor = true;
            this.checkLap.CheckedChanged += new System.EventHandler(this.checkLap_CheckedChanged);
            // 
            // pbMonitor
            // 
            this.pbMonitor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMonitor.BackgroundImage")));
            this.pbMonitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMonitor.Location = new System.Drawing.Point(380, 38);
            this.pbMonitor.Name = "pbMonitor";
            this.pbMonitor.Size = new System.Drawing.Size(114, 77);
            this.pbMonitor.TabIndex = 4;
            this.pbMonitor.TabStop = false;
            // 
            // pbParlante
            // 
            this.pbParlante.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbParlante.BackgroundImage")));
            this.pbParlante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbParlante.Location = new System.Drawing.Point(559, 38);
            this.pbParlante.Name = "pbParlante";
            this.pbParlante.Size = new System.Drawing.Size(114, 77);
            this.pbParlante.TabIndex = 3;
            this.pbParlante.TabStop = false;
            // 
            // pbLaptop
            // 
            this.pbLaptop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLaptop.BackgroundImage")));
            this.pbLaptop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLaptop.Location = new System.Drawing.Point(212, 38);
            this.pbLaptop.Name = "pbLaptop";
            this.pbLaptop.Size = new System.Drawing.Size(114, 77);
            this.pbLaptop.TabIndex = 2;
            this.pbLaptop.TabStop = false;
            this.pbLaptop.Click += new System.EventHandler(this.pbLaptop_Click);
            // 
            // pbImpresora
            // 
            this.pbImpresora.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbImpresora.BackgroundImage")));
            this.pbImpresora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImpresora.Location = new System.Drawing.Point(30, 38);
            this.pbImpresora.Name = "pbImpresora";
            this.pbImpresora.Size = new System.Drawing.Size(114, 77);
            this.pbImpresora.TabIndex = 1;
            this.pbImpresora.TabStop = false;
            // 
            // checkImp
            // 
            this.checkImp.AutoSize = true;
            this.checkImp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkImp.BackgroundImage")));
            this.checkImp.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkImp.Location = new System.Drawing.Point(13, 121);
            this.checkImp.Name = "checkImp";
            this.checkImp.Size = new System.Drawing.Size(136, 20);
            this.checkImp.TabIndex = 0;
            this.checkImp.Text = "Impresora ($300)";
            this.checkImp.UseVisualStyleBackColor = true;
            this.checkImp.CheckedChanged += new System.EventHandler(this.checkImp_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
            this.Cedula,
            this.Fecha,
            this.Impresora,
            this.Laptop,
            this.Monitor,
            this.Parlante});
            this.dataGridView1.Location = new System.Drawing.Point(25, 350);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(735, 135);
            this.dataGridView1.TabIndex = 3;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cédula";
            this.Cedula.Name = "Cedula";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Impresora
            // 
            this.Impresora.HeaderText = "Impresora";
            this.Impresora.Name = "Impresora";
            // 
            // Laptop
            // 
            this.Laptop.HeaderText = "Laptop";
            this.Laptop.Name = "Laptop";
            // 
            // Monitor
            // 
            this.Monitor.HeaderText = "Monitor";
            this.Monitor.Name = "Monitor";
            // 
            // Parlante
            // 
            this.Parlante.HeaderText = "Parlante";
            this.Parlante.Name = "Parlante";
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.Location = new System.Drawing.Point(435, 562);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(16, 16);
            this.lblRespuesta.TabIndex = 5;
            this.lblRespuesta.Text = "0";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(308, 562);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(41, 16);
            this.lblMensaje.TabIndex = 6;
            this.lblMensaje.Text = "Total";
            this.lblMensaje.Click += new System.EventHandler(this.lblMensaje_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 588);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "IVA (12%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 613);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total a pagar";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.Location = new System.Drawing.Point(435, 588);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(16, 16);
            this.lblIVA.TabIndex = 9;
            this.lblIVA.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(435, 613);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(16, 16);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "0";
            // 
            // btnNueva
            // 
            this.btnNueva.FlatAppearance.BorderSize = 0;
            this.btnNueva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNueva.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueva.Location = new System.Drawing.Point(629, 591);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(140, 42);
            this.btnNueva.TabIndex = 11;
            this.btnNueva.Text = "Nueva compra";
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(629, 543);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 42);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(855, 659);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbProductos);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.btnCalcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbProductos.ResumeLayout(false);
            this.gbProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbParlante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLaptop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImpresora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox gbProductos;
        private System.Windows.Forms.PictureBox pbImpresora;
        private System.Windows.Forms.CheckBox checkImp;
        private System.Windows.Forms.PictureBox pbMonitor;
        private System.Windows.Forms.PictureBox pbParlante;
        private System.Windows.Forms.PictureBox pbLaptop;
        private System.Windows.Forms.CheckBox checkPar;
        private System.Windows.Forms.CheckBox checkMon;
        private System.Windows.Forms.CheckBox checkLap;
        private System.Windows.Forms.ComboBox cbPar;
        private System.Windows.Forms.ComboBox cbMon;
        private System.Windows.Forms.ComboBox cbLap;
        private System.Windows.Forms.ComboBox cbImp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impresora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Laptop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parlante;
        private System.Windows.Forms.Button btnCancelar;
    }
}

