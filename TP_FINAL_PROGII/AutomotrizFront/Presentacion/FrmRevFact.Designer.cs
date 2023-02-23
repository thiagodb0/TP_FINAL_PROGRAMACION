namespace AutomotrizFront.Presentacion
{
    partial class FrmRevFact
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
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.DgvDetalles = new System.Windows.Forms.DataGridView();
            this.LblNro = new System.Windows.Forms.Label();
            this.CmnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(317, 404);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(206, 39);
            this.BtnCerrar.TabIndex = 1;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            // 
            // DgvDetalles
            // 
            this.DgvDetalles.AllowUserToAddRows = false;
            this.DgvDetalles.BackgroundColor = System.Drawing.Color.SlateGray;
            this.DgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CmnFactura,
            this.CmnDetalle,
            this.CmnProducto,
            this.CmnPrecio,
            this.CmnCantidad,
            this.CmnSubtotal});
            this.DgvDetalles.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DgvDetalles.Location = new System.Drawing.Point(12, 43);
            this.DgvDetalles.Name = "DgvDetalles";
            this.DgvDetalles.RowHeadersWidth = 51;
            this.DgvDetalles.RowTemplate.Height = 29;
            this.DgvDetalles.Size = new System.Drawing.Size(776, 355);
            this.DgvDetalles.TabIndex = 4;
            // 
            // LblNro
            // 
            this.LblNro.AutoSize = true;
            this.LblNro.Location = new System.Drawing.Point(189, 16);
            this.LblNro.Name = "LblNro";
            this.LblNro.Size = new System.Drawing.Size(41, 20);
            this.LblNro.TabIndex = 5;
            this.LblNro.Text = "Nro: ";
            // 
            // CmnCodigo
            // 
            this.CmnCodigo.HeaderText = "Codigo";
            this.CmnCodigo.MinimumWidth = 6;
            this.CmnCodigo.Name = "CmnCodigo";
            this.CmnCodigo.Visible = false;
            this.CmnCodigo.Width = 125;
            // 
            // CmnFactura
            // 
            this.CmnFactura.HeaderText = "N° Factura";
            this.CmnFactura.MinimumWidth = 6;
            this.CmnFactura.Name = "CmnFactura";
            this.CmnFactura.ReadOnly = true;
            this.CmnFactura.Visible = false;
            this.CmnFactura.Width = 125;
            // 
            // CmnDetalle
            // 
            this.CmnDetalle.HeaderText = "N° Detalle";
            this.CmnDetalle.MinimumWidth = 6;
            this.CmnDetalle.Name = "CmnDetalle";
            this.CmnDetalle.ReadOnly = true;
            this.CmnDetalle.Width = 110;
            // 
            // CmnProducto
            // 
            this.CmnProducto.HeaderText = "Producto";
            this.CmnProducto.MinimumWidth = 6;
            this.CmnProducto.Name = "CmnProducto";
            this.CmnProducto.ReadOnly = true;
            this.CmnProducto.Width = 200;
            // 
            // CmnPrecio
            // 
            this.CmnPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CmnPrecio.HeaderText = "Precio";
            this.CmnPrecio.MinimumWidth = 6;
            this.CmnPrecio.Name = "CmnPrecio";
            this.CmnPrecio.ReadOnly = true;
            // 
            // CmnCantidad
            // 
            this.CmnCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CmnCantidad.HeaderText = "Cantidad";
            this.CmnCantidad.MinimumWidth = 6;
            this.CmnCantidad.Name = "CmnCantidad";
            this.CmnCantidad.ReadOnly = true;
            // 
            // CmnSubtotal
            // 
            this.CmnSubtotal.HeaderText = "Subtotal";
            this.CmnSubtotal.MinimumWidth = 6;
            this.CmnSubtotal.Name = "CmnSubtotal";
            this.CmnSubtotal.ReadOnly = true;
            this.CmnSubtotal.Width = 125;
            // 
            // FrmRevFact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblNro);
            this.Controls.Add(this.DgvDetalles);
            this.Controls.Add(this.BtnCerrar);
            this.Name = "FrmRevFact";
            this.Text = "FrmRevFact";
            this.Load += new System.EventHandler(this.FrmRevFact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button BtnCerrar;
        private DataGridView DgvDetalles;
        private Label LblNro;
        private DataGridViewTextBoxColumn CmnCodigo;
        private DataGridViewTextBoxColumn CmnFactura;
        private DataGridViewTextBoxColumn CmnDetalle;
        private DataGridViewTextBoxColumn CmnProducto;
        private DataGridViewTextBoxColumn CmnPrecio;
        private DataGridViewTextBoxColumn CmnCantidad;
        private DataGridViewTextBoxColumn CmnSubtotal;
    }
}