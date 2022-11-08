namespace AutomotrizFront.Presentacion
{
    partial class frmClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.DgvCliente = new System.Windows.Forms.DataGridView();
            this.CmnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnPromedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnPrimera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(107, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el cliente: :";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(351, 44);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(259, 27);
            this.TxtNombre.TabIndex = 1;
            this.TxtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DgvCliente
            // 
            this.DgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CmnCodigo,
            this.CmnCliente,
            this.CmnTotal,
            this.CmnPromedio,
            this.CmnPrimera});
            this.DgvCliente.Location = new System.Drawing.Point(12, 114);
            this.DgvCliente.Name = "DgvCliente";
            this.DgvCliente.RowHeadersWidth = 51;
            this.DgvCliente.RowTemplate.Height = 29;
            this.DgvCliente.Size = new System.Drawing.Size(1211, 690);
            this.DgvCliente.TabIndex = 2;
            // 
            // CmnCodigo
            // 
            this.CmnCodigo.HeaderText = "Codigo";
            this.CmnCodigo.MinimumWidth = 6;
            this.CmnCodigo.Name = "CmnCodigo";
            this.CmnCodigo.Width = 80;
            // 
            // CmnCliente
            // 
            this.CmnCliente.HeaderText = "Cliente";
            this.CmnCliente.MinimumWidth = 6;
            this.CmnCliente.Name = "CmnCliente";
            this.CmnCliente.ReadOnly = true;
            this.CmnCliente.Width = 220;
            // 
            // CmnTotal
            // 
            this.CmnTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CmnTotal.HeaderText = "Total";
            this.CmnTotal.MinimumWidth = 6;
            this.CmnTotal.Name = "CmnTotal";
            this.CmnTotal.ReadOnly = true;
            // 
            // CmnPromedio
            // 
            this.CmnPromedio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CmnPromedio.HeaderText = "Promedio";
            this.CmnPromedio.MinimumWidth = 6;
            this.CmnPromedio.Name = "CmnPromedio";
            this.CmnPromedio.ReadOnly = true;
            // 
            // CmnPrimera
            // 
            this.CmnPrimera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CmnPrimera.HeaderText = "Primera Venta";
            this.CmnPrimera.MinimumWidth = 6;
            this.CmnPrimera.Name = "CmnPrimera";
            this.CmnPrimera.ReadOnly = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(675, 42);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(94, 29);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1235, 816);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.DgvCliente);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmClientes";
            this.Text = "frmVendedores";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TxtNombre;
        private DataGridView DgvCliente;
        private DataGridViewTextBoxColumn CmnCodigo;
        private DataGridViewTextBoxColumn CmnCliente;
        private DataGridViewTextBoxColumn CmnTotal;
        private DataGridViewTextBoxColumn CmnPromedio;
        private DataGridViewTextBoxColumn CmnPrimera;
        private Button BtnBuscar;
    }
}