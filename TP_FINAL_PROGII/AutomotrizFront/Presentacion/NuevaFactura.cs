using AutomotrizFront.Servicios;
using DataAPIAutomo.Dominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizFront.Presentacion
{
    public partial class NuevaFactura : Form
    {
        private Factura nueva;
        public NuevaFactura()
        {
            InitializeComponent();
        }

        private void NuevaFactura_Load(object sender, EventArgs e)
        {
            CargarAutosAsync();
            CargarClientesAsync();
            CargarVendedoresAsync();
            CargarFormasPago();
            ProxFact();
            nueva = new Factura();
            DgvDetalles.ForeColor = Color.Black;
    
        }

        private async void ProxFact()
        {
            string url = "http://localhost:5239/nrofact";
            var result = await ClientSingleton.Getinstance().GetAsync(url);
            var nro = result.ToString();
            LblNroFact.Text = "N° Factura: " + nro;
            
        }

        private async void CargarAutosAsync()
        {
            string url = "http://localhost:5239/autos";
            var result = await ClientSingleton.Getinstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Producto>>(result);
            CboProductos.DataSource = lst;
            CboProductos.DisplayMember = "Descripcion";
            CboProductos.ValueMember = "Codigo";

        }
        private async void CargarFormasPago()
        {
            string url = "http://localhost:5239/formas_pago";
            var result = await ClientSingleton.Getinstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<FormaPago>>(result);
            CboFormaPago.DataSource = lst;
            CboFormaPago.DisplayMember = "Descripcion";
            CboFormaPago.ValueMember = "Id";
        }


        private async void CargarClientesAsync()
        {
            string url = "http://localhost:5239/clientes";
            var result = await ClientSingleton.Getinstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Cliente>>(result);
            CboClientes.DataSource = lst;
            CboClientes.DisplayMember = "Nombre";
            CboClientes.ValueMember = "Id";
        }

        private async void CargarVendedoresAsync()
        {
            string url = "http://localhost:5239/vendedores";
            var result = await ClientSingleton.Getinstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Vendedor>>(result);
            CboVendedores.DataSource = lst;
            CboVendedores.DisplayMember = "Nombre";
            CboVendedores.ValueMember = "Id";
        }

        private async Task GuardarPresupuestoAsync()
        {
            //datos del presupuesto:
            nueva.Cliente = (Cliente)CboClientes.SelectedItem;
            nueva.Vendedor = (Vendedor)CboVendedores.SelectedItem;
            nueva.Forma_Pago = (FormaPago)CboFormaPago.SelectedItem;

            string bodyContent = JsonConvert.SerializeObject(nueva);

            string url = "http://localhost:5239/factura";
            var result = await ClientSingleton.Getinstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))
            {
                MessageBox.Show("Factura Registrada", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar la Factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvDetalles.CurrentCell.ColumnIndex == 5)
            {
                nueva.QuitarDetalle(DgvDetalles.CurrentRow.Index);
               
                DgvDetalles.Rows.Remove(DgvDetalles.CurrentRow);
                
                CalcularTotal();

            }
        }

        private void CboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            if(CboProductos.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe seleccionar un producto", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (TxtCantidad.Text == "" || !int.TryParse(TxtCantidad.Text, out _))
            {
                MessageBox.Show("Debe ingresar una cantidad válida!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
          

            foreach (DataGridViewRow row in DgvDetalles.Rows)
            {
                if (row.Cells["CmnProducto"].Value.ToString().Equals(CboProductos.Text))
                {
                    MessageBox.Show("El producto: " + CboProductos.Text + " Ya se encuentra cargado", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            Producto p = (Producto)CboProductos.SelectedItem;
            int cantidad = Convert.ToInt32(TxtCantidad.Text);
            Detalle det = new Detalle(p, cantidad, p.Precio);
            nueva.AddDetalle(det);
            DgvDetalles.Rows.Add(new object[] {p.Codigo, p.Descripcion,p.Precio, TxtCantidad.Text, p.Precio * cantidad});
            
            CalcularTotal();
        }


        private void CalcularTotal()
        {
            double Total = nueva.CalcularTotal();
            Lbltotal.Text = "Total: " +  Total.ToString();   
        }

        private void CboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (CboClientes.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe seleccionar un Cliente", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (CboVendedores.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe seleccionar un Vendedor", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (CboFormaPago.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe seleccionar una forma de pago", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            await GuardarPresupuestoAsync();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        //    Producto p = (Producto)cboProductos.SelectedItem;
        //    int cantidad = Convert.ToInt32(txtCantidad.Text);

        //    DetallePresupuesto detalle = new DetallePresupuesto(p, cantidad);
        //    nuevo.AgregarDetalle(detalle);
        //    dgvDetalles.Rows.Add(new object[] { p.ProductoNro, p.Nombre, p.Precio, txtCantidad.Text });

        //    CalcularTotal();
    }
}
