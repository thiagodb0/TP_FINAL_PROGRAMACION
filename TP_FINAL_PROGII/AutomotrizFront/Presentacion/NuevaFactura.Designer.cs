namespace AutomotrizFront.Presentacion
{
    partial class NuevaFactura
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
            this.LblNroFact = new System.Windows.Forms.Label();
            this.CboClientes = new System.Windows.Forms.ComboBox();
            this.CboProductos = new System.Windows.Forms.ComboBox();
            this.DgvDetalles = new System.Windows.Forms.DataGridView();
            this.CmnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cmnacciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CboFormaPago = new System.Windows.Forms.ComboBox();
            this.CboVendedores = new System.Windows.Forms.ComboBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.Lbltotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNroFact
            // 
            this.LblNroFact.AutoSize = true;
            this.LblNroFact.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblNroFact.Location = new System.Drawing.Point(6, 11);
            this.LblNroFact.Name = "LblNroFact";
            this.LblNroFact.Size = new System.Drawing.Size(234, 28);
            this.LblNroFact.TabIndex = 0;
            this.LblNroFact.Text = "Nro de Factura: 1";
            this.LblNroFact.Click += new System.EventHandler(this.label1_Click);
            // 
            // CboClientes
            // 
            this.CboClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboClientes.ForeColor = System.Drawing.SystemColors.MenuText;
            this.CboClientes.FormattingEnabled = true;
            this.CboClientes.Location = new System.Drawing.Point(101, 146);
            this.CboClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CboClientes.Name = "CboClientes";
            this.CboClientes.Size = new System.Drawing.Size(250, 28);
            this.CboClientes.TabIndex = 1;
            this.CboClientes.SelectedIndexChanged += new System.EventHandler(this.CboClientes_SelectedIndexChanged);
            // 
            // CboProductos
            // 
            this.CboProductos.FormattingEnabled = true;
            this.CboProductos.Location = new System.Drawing.Point(12, 230);
            this.CboProductos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CboProductos.Name = "CboProductos";
            this.CboProductos.Size = new System.Drawing.Size(380, 28);
            this.CboProductos.TabIndex = 2;
            this.CboProductos.SelectedIndexChanged += new System.EventHandler(this.CboProductos_SelectedIndexChanged);
            // 
            // DgvDetalles
            // 
            this.DgvDetalles.AllowUserToAddRows = false;
            this.DgvDetalles.BackgroundColor = System.Drawing.Color.SlateGray;
            this.DgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CmnCodigo,
            this.CmnProducto,
            this.CmnPrecio,
            this.CmnCantidad,
            this.CmnSubtotal,
            this.Cmnacciones});
            this.DgvDetalles.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DgvDetalles.Location = new System.Drawing.Point(12, 273);
            this.DgvDetalles.Name = "DgvDetalles";
            this.DgvDetalles.RowHeadersWidth = 51;
            this.DgvDetalles.RowTemplate.Height = 29;
            this.DgvDetalles.Size = new System.Drawing.Size(1211, 420);
            this.DgvDetalles.TabIndex = 3;
            this.DgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CmnCodigo
            // 
            this.CmnCodigo.HeaderText = "Codigo";
            this.CmnCodigo.MinimumWidth = 6;
            this.CmnCodigo.Name = "CmnCodigo";
            this.CmnCodigo.Visible = false;
            this.CmnCodigo.Width = 125;
            // 
            // CmnProducto
            // 
            this.CmnProducto.HeaderText = "Producto";
            this.CmnProducto.MinimumWidth = 6;
            this.CmnProducto.Name = "CmnProducto";
            this.CmnProducto.ReadOnly = true;
            this.CmnProducto.Width = 250;
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
            this.CmnSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CmnSubtotal.HeaderText = "Subtotal";
            this.CmnSubtotal.MinimumWidth = 6;
            this.CmnSubtotal.Name = "CmnSubtotal";
            this.CmnSubtotal.ReadOnly = true;
            // 
            // Cmnacciones
            // 
            this.Cmnacciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cmnacciones.HeaderText = "Acciones";
            this.Cmnacciones.MinimumWidth = 6;
            this.Cmnacciones.Name = "Cmnacciones";
            this.Cmnacciones.ReadOnly = true;
            this.Cmnacciones.Text = "Quitar";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 83);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 27);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // CboFormaPago
            // 
            this.CboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboFormaPago.FormattingEnabled = true;
            this.CboFormaPago.Location = new System.Drawing.Point(614, 152);
            this.CboFormaPago.Name = "CboFormaPago";
            this.CboFormaPago.Size = new System.Drawing.Size(185, 28);
            this.CboFormaPago.TabIndex = 5;
            // 
            // CboVendedores
            // 
            this.CboVendedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboVendedores.FormattingEnabled = true;
            this.CboVendedores.Location = new System.Drawing.Point(614, 86);
            this.CboVendedores.Name = "CboVendedores";
            this.CboVendedores.Size = new System.Drawing.Size(310, 28);
            this.CboVendedores.TabIndex = 6;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(422, 230);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(136, 27);
            this.TxtCantidad.TabIndex = 7;
            // 
            // BtnCargar
            // 
            this.BtnCargar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCargar.Location = new System.Drawing.Point(595, 228);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(129, 29);
            this.BtnCargar.TabIndex = 8;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAceptar.Location = new System.Drawing.Point(1061, 740);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(142, 64);
            this.BtnAceptar.TabIndex = 9;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCancelar.Location = new System.Drawing.Point(12, 739);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(142, 64);
            this.BtnCancelar.TabIndex = 10;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // Lbltotal
            // 
            this.Lbltotal.AutoSize = true;
            this.Lbltotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbltotal.Location = new System.Drawing.Point(1061, 696);
            this.Lbltotal.Name = "Lbltotal";
            this.Lbltotal.Size = new System.Drawing.Size(58, 28);
            this.Lbltotal.TabIndex = 11;
            this.Lbltotal.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Forma de pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Vendedor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutomotrizFront.Properties.Resources.Logo_Corporativo_Estudio_Elegante_Profesional_Blanco_Negro_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(860, -139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // NuevaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1235, 816);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbltotal);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.CboVendedores);
            this.Controls.Add(this.CboFormaPago);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DgvDetalles);
            this.Controls.Add(this.CboProductos);
            this.Controls.Add(this.CboClientes);
            this.Controls.Add(this.LblNroFact);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NuevaFactura";
            this.Text = "NuevaFactura";
            this.Load += new System.EventHandler(this.NuevaFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblNroFact;
        private ComboBox CboClientes;
        private ComboBox CboProductos;
        private DataGridView DgvDetalles;
        private DateTimePicker dateTimePicker1;
        private ComboBox CboFormaPago;
        private ComboBox CboVendedores;
        private TextBox TxtCantidad;
        private Button BtnCargar;
        private Button BtnAceptar;
        private Button BtnCancelar;
        private Label Lbltotal;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn CmnCodigo;
        private DataGridViewTextBoxColumn CmnProducto;
        private DataGridViewTextBoxColumn CmnPrecio;
        private DataGridViewTextBoxColumn CmnCantidad;
        private DataGridViewTextBoxColumn CmnSubtotal;
        private DataGridViewButtonColumn Cmnacciones;
    }
}