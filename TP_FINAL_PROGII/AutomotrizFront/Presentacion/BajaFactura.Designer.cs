namespace AutomotrizFront.Presentacion
{
    partial class BajaFactura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dgfacturas = new System.Windows.Forms.DataGridView();
            this.CmnNroFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnFormaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnDarBaja = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblNro = new System.Windows.Forms.Label();
            this.BtnRevisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgfacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgfacturas
            // 
            this.Dgfacturas.BackgroundColor = System.Drawing.Color.SlateGray;
            this.Dgfacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgfacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CmnNroFact,
            this.CmnFecha,
            this.CmnCliente,
            this.CmnVendedor,
            this.CmnFormaPago});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgfacturas.DefaultCellStyle = dataGridViewCellStyle1;
            this.Dgfacturas.Location = new System.Drawing.Point(12, 78);
            this.Dgfacturas.Name = "Dgfacturas";
            this.Dgfacturas.RowHeadersWidth = 51;
            this.Dgfacturas.RowTemplate.Height = 29;
            this.Dgfacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgfacturas.Size = new System.Drawing.Size(1193, 600);
            this.Dgfacturas.TabIndex = 0;
            this.Dgfacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgfacturas_CellContentClick);
            // 
            // CmnNroFact
            // 
            this.CmnNroFact.HeaderText = "N° Factura";
            this.CmnNroFact.MinimumWidth = 6;
            this.CmnNroFact.Name = "CmnNroFact";
            this.CmnNroFact.ReadOnly = true;
            this.CmnNroFact.Width = 150;
            // 
            // CmnFecha
            // 
            this.CmnFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CmnFecha.HeaderText = "Fecha";
            this.CmnFecha.MinimumWidth = 6;
            this.CmnFecha.Name = "CmnFecha";
            this.CmnFecha.ReadOnly = true;
            // 
            // CmnCliente
            // 
            this.CmnCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CmnCliente.HeaderText = "Cliente";
            this.CmnCliente.MinimumWidth = 6;
            this.CmnCliente.Name = "CmnCliente";
            this.CmnCliente.ReadOnly = true;
            // 
            // CmnVendedor
            // 
            this.CmnVendedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CmnVendedor.HeaderText = "Vendedor";
            this.CmnVendedor.MinimumWidth = 6;
            this.CmnVendedor.Name = "CmnVendedor";
            this.CmnVendedor.ReadOnly = true;
            // 
            // CmnFormaPago
            // 
            this.CmnFormaPago.HeaderText = "Forma Pago";
            this.CmnFormaPago.MinimumWidth = 6;
            this.CmnFormaPago.Name = "CmnFormaPago";
            this.CmnFormaPago.ReadOnly = true;
            this.CmnFormaPago.Width = 125;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(12, 722);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(92, 35);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnDarBaja
            // 
            this.BtnDarBaja.Location = new System.Drawing.Point(517, 702);
            this.BtnDarBaja.Name = "BtnDarBaja";
            this.BtnDarBaja.Size = new System.Drawing.Size(209, 55);
            this.BtnDarBaja.TabIndex = 2;
            this.BtnDarBaja.Text = "Dar Baja";
            this.BtnDarBaja.UseVisualStyleBackColor = true;
            this.BtnDarBaja.Click += new System.EventHandler(this.BtnDarBaja_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(470, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccione la factura que desea dar de baja";
            // 
            // LblNro
            // 
            this.LblNro.Location = new System.Drawing.Point(0, 0);
            this.LblNro.Name = "LblNro";
            this.LblNro.Size = new System.Drawing.Size(100, 23);
            this.LblNro.TabIndex = 0;
            // 
            // BtnRevisar
            // 
            this.BtnRevisar.Location = new System.Drawing.Point(932, 715);
            this.BtnRevisar.Name = "BtnRevisar";
            this.BtnRevisar.Size = new System.Drawing.Size(94, 29);
            this.BtnRevisar.TabIndex = 46;
            this.BtnRevisar.Text = "Revisar";
            this.BtnRevisar.UseVisualStyleBackColor = true;
            this.BtnRevisar.Click += new System.EventHandler(this.BtnRevisar_Click);
            // 
            // BajaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1217, 769);
            this.Controls.Add(this.LblNro);
            this.Controls.Add(this.BtnRevisar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnDarBaja);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.Dgfacturas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BajaFactura";
            this.Text = "BajaFactura";
            this.Load += new System.EventHandler(this.BajaFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgfacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView Dgfacturas;
        private Button BtnCancelar;
        private Button BtnDarBaja;
        private Label label2;
        private DataGridViewTextBoxColumn CmnNroFact;
        private DataGridViewTextBoxColumn CmnFecha;
        private DataGridViewTextBoxColumn CmnCliente;
        private DataGridViewTextBoxColumn CmnVendedor;
        private DataGridViewTextBoxColumn CmnFormaPago;
        private Label LblNro;
        private Button BtnRevisar;
    }
}