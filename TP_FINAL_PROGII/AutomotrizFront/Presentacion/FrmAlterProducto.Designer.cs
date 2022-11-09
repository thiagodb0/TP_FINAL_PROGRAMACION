namespace AutomotrizFront.Presentacion
{
    partial class FrmAlterProducto
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
            this.label6 = new System.Windows.Forms.Label();
            this.RbtRepuesto = new System.Windows.Forms.RadioButton();
            this.RbtAuto = new System.Windows.Forms.RadioButton();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.Cmncodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnStockMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CboMarca = new System.Windows.Forms.ComboBox();
            this.TxtStockMin = new System.Windows.Forms.TextBox();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Tipo De Producto:";
            // 
            // RbtRepuesto
            // 
            this.RbtRepuesto.AutoSize = true;
            this.RbtRepuesto.Location = new System.Drawing.Point(592, 39);
            this.RbtRepuesto.Name = "RbtRepuesto";
            this.RbtRepuesto.Size = new System.Drawing.Size(92, 24);
            this.RbtRepuesto.TabIndex = 39;
            this.RbtRepuesto.TabStop = true;
            this.RbtRepuesto.Text = "Repuesto";
            this.RbtRepuesto.UseVisualStyleBackColor = true;
            // 
            // RbtAuto
            // 
            this.RbtAuto.AutoSize = true;
            this.RbtAuto.Location = new System.Drawing.Point(455, 37);
            this.RbtAuto.Name = "RbtAuto";
            this.RbtAuto.Size = new System.Drawing.Size(99, 24);
            this.RbtAuto.TabIndex = 38;
            this.RbtAuto.TabStop = true;
            this.RbtAuto.Text = "Automovil";
            this.RbtAuto.UseVisualStyleBackColor = true;
            // 
            // BtnCargar
            // 
            this.BtnCargar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCargar.Location = new System.Drawing.Point(520, 753);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(194, 61);
            this.BtnCargar.TabIndex = 37;
            this.BtnCargar.Text = "Modificar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
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
            this.DgvProductos.Location = new System.Drawing.Point(10, 253);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.RowHeadersWidth = 51;
            this.DgvProductos.RowTemplate.Height = 29;
            this.DgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProductos.Size = new System.Drawing.Size(1202, 488);
            this.DgvProductos.TabIndex = 35;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(655, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Stock Minimo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(663, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Codigo";
            // 
            // CboMarca
            // 
            this.CboMarca.FormattingEnabled = true;
            this.CboMarca.Location = new System.Drawing.Point(761, 191);
            this.CboMarca.Name = "CboMarca";
            this.CboMarca.Size = new System.Drawing.Size(159, 28);
            this.CboMarca.TabIndex = 28;
            // 
            // TxtStockMin
            // 
            this.TxtStockMin.Location = new System.Drawing.Point(455, 191);
            this.TxtStockMin.Name = "TxtStockMin";
            this.TxtStockMin.Size = new System.Drawing.Size(159, 27);
            this.TxtStockMin.TabIndex = 27;
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(455, 117);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(159, 27);
            this.TxtStock.TabIndex = 26;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(761, 117);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(125, 27);
            this.TxtPrecio.TabIndex = 25;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(154, 191);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(159, 27);
            this.TxtDescripcion.TabIndex = 24;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(154, 117);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(159, 27);
            this.TxtCodigo.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutomotrizFront.Properties.Resources.Logo_Corporativo_Estudio_Elegante_Profesional_Blanco_Negro_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(995, -27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAlterProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1235, 820);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RbtRepuesto);
            this.Controls.Add(this.RbtAuto);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAlterProducto";
            this.Text = "FrmAlterProducto";
            this.Load += new System.EventHandler(this.FrmAlterProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label6;
        private RadioButton RbtRepuesto;
        private RadioButton RbtAuto;
        private Button BtnCargar;
        private DataGridView DgvProductos;
        private DataGridViewTextBoxColumn Cmncodigo;
        private DataGridViewTextBoxColumn CmnDescripcion;
        private DataGridViewTextBoxColumn CmnPrecio;
        private DataGridViewTextBoxColumn CmnStock;
        private DataGridViewTextBoxColumn CmnStockMin;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox CboMarca;
        private TextBox TxtStockMin;
        private TextBox TxtStock;
        private TextBox TxtPrecio;
        private TextBox TxtDescripcion;
        private TextBox TxtCodigo;
        private PictureBox pictureBox1;
    }
}