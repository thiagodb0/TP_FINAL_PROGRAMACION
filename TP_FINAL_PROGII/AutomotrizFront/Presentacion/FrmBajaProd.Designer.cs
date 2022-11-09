namespace AutomotrizFront.Presentacion
{
    partial class FrmBajaProd
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
            this.BtnBaja = new System.Windows.Forms.Button();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.Cmncodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnStockMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBaja
            // 
            this.BtnBaja.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBaja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnBaja.Location = new System.Drawing.Point(518, 712);
            this.BtnBaja.Name = "BtnBaja";
            this.BtnBaja.Size = new System.Drawing.Size(194, 61);
            this.BtnBaja.TabIndex = 39;
            this.BtnBaja.Text = "Aceptar";
            this.BtnBaja.UseVisualStyleBackColor = true;
            this.BtnBaja.Click += new System.EventHandler(this.BtnBaja_Click);
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
            this.DgvProductos.Location = new System.Drawing.Point(8, 212);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.RowHeadersWidth = 51;
            this.DgvProductos.RowTemplate.Height = 29;
            this.DgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProductos.Size = new System.Drawing.Size(1202, 488);
            this.DgvProductos.TabIndex = 38;
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
            this.pictureBox1.Location = new System.Drawing.Point(982, -23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(17, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Codigo";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtCodigo.Location = new System.Drawing.Point(87, 163);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(159, 27);
            this.TxtCodigo.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(19, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 34);
            this.label2.TabIndex = 43;
            this.label2.Text = "DAR DE BAJA";
            // 
            // FrmBajaProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1235, 788);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnBaja);
            this.Controls.Add(this.DgvProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBajaProd";
            this.Text = "Baja Productos";
            this.Load += new System.EventHandler(this.FrmBajaProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnBaja;
        private DataGridView DgvProductos;
        private DataGridViewTextBoxColumn Cmncodigo;
        private DataGridViewTextBoxColumn CmnDescripcion;
        private DataGridViewTextBoxColumn CmnPrecio;
        private DataGridViewTextBoxColumn CmnStock;
        private DataGridViewTextBoxColumn CmnStockMin;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox TxtCodigo;
        private Label label2;
    }
}