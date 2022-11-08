﻿namespace AutomotrizFront.Presentacion
{
    partial class FrmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.TxtStockMin = new System.Windows.Forms.TextBox();
            this.CboMarca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.Cmncodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnStockMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.RbtAuto = new System.Windows.Forms.RadioButton();
            this.RbtRepuesto = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(165, 107);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(159, 27);
            this.TxtCodigo.TabIndex = 0;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(165, 180);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(159, 27);
            this.TxtDescripcion.TabIndex = 2;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(771, 107);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(125, 27);
            this.TxtPrecio.TabIndex = 3;
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(465, 107);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(159, 27);
            this.TxtStock.TabIndex = 4;
            // 
            // TxtStockMin
            // 
            this.TxtStockMin.Location = new System.Drawing.Point(465, 180);
            this.TxtStockMin.Name = "TxtStockMin";
            this.TxtStockMin.Size = new System.Drawing.Size(159, 27);
            this.TxtStockMin.TabIndex = 5;
            // 
            // CboMarca
            // 
            this.CboMarca.FormattingEnabled = true;
            this.CboMarca.Location = new System.Drawing.Point(771, 180);
            this.CboMarca.Name = "CboMarca";
            this.CboMarca.Size = new System.Drawing.Size(159, 28);
            this.CboMarca.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(673, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Stock Minimo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(665, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Marca";
            // 
            // DgvProductos
            // 
            this.DgvProductos.BackgroundColor = System.Drawing.Color.SlateGray;
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cmncodigo,
            this.CmnDescripcion,
            this.CmnPrecio,
            this.CmnStock,
            this.CmnStockMin});
            this.DgvProductos.Location = new System.Drawing.Point(21, 243);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.RowHeadersWidth = 51;
            this.DgvProductos.RowTemplate.Height = 29;
            this.DgvProductos.Size = new System.Drawing.Size(1202, 488);
            this.DgvProductos.TabIndex = 16;
            this.DgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductos_CellContentClick);
            // 
            // Cmncodigo
            // 
            this.Cmncodigo.HeaderText = "Codigo";
            this.Cmncodigo.MinimumWidth = 6;
            this.Cmncodigo.Name = "Cmncodigo";
            this.Cmncodigo.Width = 125;
            // 
            // CmnDescripcion
            // 
            this.CmnDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CmnDescripcion.HeaderText = "Descripcion";
            this.CmnDescripcion.MinimumWidth = 6;
            this.CmnDescripcion.Name = "CmnDescripcion";
            this.CmnDescripcion.ReadOnly = true;
            // 
            // CmnPrecio
            // 
            this.CmnPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CmnPrecio.HeaderText = "Precio";
            this.CmnPrecio.MinimumWidth = 6;
            this.CmnPrecio.Name = "CmnPrecio";
            this.CmnPrecio.ReadOnly = true;
            // 
            // CmnStock
            // 
            this.CmnStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CmnStock.HeaderText = "Stock";
            this.CmnStock.MinimumWidth = 6;
            this.CmnStock.Name = "CmnStock";
            this.CmnStock.ReadOnly = true;
            // 
            // CmnStockMin
            // 
            this.CmnStockMin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CmnStockMin.HeaderText = "Stock Minimo";
            this.CmnStockMin.MinimumWidth = 6;
            this.CmnStockMin.Name = "CmnStockMin";
            this.CmnStockMin.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutomotrizFront.Properties.Resources.Logo_Corporativo_Estudio_Elegante_Profesional_Blanco_Negro_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(1006, -38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCargar
            // 
            this.BtnCargar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCargar.Location = new System.Drawing.Point(530, 743);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(194, 61);
            this.BtnCargar.TabIndex = 18;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCancelar.Location = new System.Drawing.Point(21, 775);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(94, 29);
            this.BtnCancelar.TabIndex = 19;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // RbtAuto
            // 
            this.RbtAuto.AutoSize = true;
            this.RbtAuto.Location = new System.Drawing.Point(465, 27);
            this.RbtAuto.Name = "RbtAuto";
            this.RbtAuto.Size = new System.Drawing.Size(99, 24);
            this.RbtAuto.TabIndex = 20;
            this.RbtAuto.TabStop = true;
            this.RbtAuto.Text = "Automovil";
            this.RbtAuto.UseVisualStyleBackColor = true;
            // 
            // RbtRepuesto
            // 
            this.RbtRepuesto.AutoSize = true;
            this.RbtRepuesto.Location = new System.Drawing.Point(602, 28);
            this.RbtRepuesto.Name = "RbtRepuesto";
            this.RbtRepuesto.Size = new System.Drawing.Size(92, 24);
            this.RbtRepuesto.TabIndex = 21;
            this.RbtRepuesto.TabStop = true;
            this.RbtRepuesto.Text = "Repuesto";
            this.RbtRepuesto.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tipo De Producto:";
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1235, 816);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RbtRepuesto);
            this.Controls.Add(this.RbtAuto);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.DgvProductos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboMarca);
            this.Controls.Add(this.TxtStockMin);
            this.Controls.Add(this.TxtStock);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProductos";
            this.Text = "FrmProductos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtCodigo;
        private TextBox TxtDescripcion;
        private TextBox TxtPrecio;
        private TextBox TxtStock;
        private TextBox TxtStockMin;
        private ComboBox CboMarca;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private DataGridView DgvProductos;
        private PictureBox pictureBox1;
        private Button BtnCargar;
        private Button BtnCancelar;
        private RadioButton RbtAuto;
        private RadioButton RbtRepuesto;
        private Label label6;
        private DataGridViewTextBoxColumn Cmncodigo;
        private DataGridViewTextBoxColumn CmnDescripcion;
        private DataGridViewTextBoxColumn CmnPrecio;
        private DataGridViewTextBoxColumn CmnStock;
        private DataGridViewTextBoxColumn CmnStockMin;
    }
}