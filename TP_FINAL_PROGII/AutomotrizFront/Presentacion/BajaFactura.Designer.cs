﻿namespace AutomotrizFront.Presentacion
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CmnNroFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnDarBaja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CmnNroFact,
            this.CmnFecha,
            this.CmnCliente,
            this.CmnVendedor,
            this.CmnEstado});
            this.dataGridView1.Location = new System.Drawing.Point(12, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1193, 506);
            this.dataGridView1.TabIndex = 0;
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
            // CmnEstado
            // 
            this.CmnEstado.HeaderText = "Estado";
            this.CmnEstado.MinimumWidth = 6;
            this.CmnEstado.Name = "CmnEstado";
            this.CmnEstado.ReadOnly = true;
            this.CmnEstado.Width = 125;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(470, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccione la factura que desea dar de baja";
            // 
            // BajaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1217, 769);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDarBaja);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BajaFactura";
            this.Text = "BajaFactura";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CmnNroFact;
        private DataGridViewTextBoxColumn CmnFecha;
        private DataGridViewTextBoxColumn CmnCliente;
        private DataGridViewTextBoxColumn CmnVendedor;
        private DataGridViewTextBoxColumn CmnEstado;
        private Button BtnCancelar;
        private Button BtnDarBaja;
        private Label label1;
        private Label label2;
    }
}