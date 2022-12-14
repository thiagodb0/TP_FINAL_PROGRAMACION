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
    public partial class FrmAlterProducto : Form
    {
        Producto nuevo;
        public FrmAlterProducto()
        {
            InitializeComponent();
        }

        private async void FrmAlterProducto_Load(object sender, EventArgs e)
        {
            nuevo = new Producto();
            await CargarAutosAsync();
            await CargarMarcasAsyinc();
            TxtCodigo.Enabled = false;
            DgvProductos.ForeColor = Color.Black;
        }


        private async Task CargarAutosAsync()
        {
            string url = "http://localhost:5239/autos";
            var result = await ClientSingleton.Getinstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Producto>>(result);
            foreach (Producto p in lst)
            {
                DgvProductos.Rows.Add(new object[] { p.Codigo, p.Descripcion, p.Precio, p.Stock, p.StockMin });
            }

        }

        private async Task CargarMarcasAsyinc()
        {
            string url = "http://localhost:5239/marcas";
            var result = await ClientSingleton.Getinstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Marca>>(result);
            CboMarca.DataSource = lst;
            CboMarca.DisplayMember = "Descripcion";
            CboMarca.ValueMember = "Id";

        }

        private async Task GuardarProductoAsync()
        {



            //datos del producto:
            nuevo.Codigo = Convert.ToInt32(TxtCodigo.Text);
            nuevo.Descripcion = TxtDescripcion.Text;
            nuevo.Precio = Convert.ToDouble(TxtPrecio.Text);
            if (RbtAuto.Checked)
            {
                nuevo.Tipo_prod = 1;
            }
            else
                nuevo.Tipo_prod = 2;
            nuevo.Stock = Convert.ToInt32(TxtStock.Text);
            nuevo.StockMin = Convert.ToInt32(TxtStockMin.Text);
            nuevo.Marca = (int)CboMarca.SelectedIndex + 1;
            nuevo.modelo = 1;


            string bodyContent = JsonConvert.SerializeObject(nuevo);

            string url = "http://localhost:5239/AlterProducto";
            var result = await ClientSingleton.Getinstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))
            {
                MessageBox.Show("Producto Guardado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo guardar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           




        }
        private bool ValidarInt(string txt)
        {
            bool valid = false;
            try
            {
                Convert.ToInt32(txt);
                valid = false;
            }
            catch (Exception)
            {

                valid = true;
            }
            return valid;
        }

        private async void BtnCargar_Click(object sender, EventArgs e)
        {
            if (TxtCodigo.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe Indicar un codigo", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (TxtDescripcion.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe Indicar la descripcion del articulo", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (TxtStock.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe Indicar el stock del articulo", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (TxtStockMin.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe Indicar el stock minimo del articulo", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (CboMarca.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe seleccionar una marca", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (RbtAuto.Checked == false && RbtRepuesto.Checked == false)
            {
                MessageBox.Show("Debe seleccionar el tipo de producto", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (ValidarInt(TxtCodigo.Text))
            {
                MessageBox.Show("algunos campos deben ser numeros", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           
            if (ValidarInt(TxtStock.Text))
            {
                MessageBox.Show("algunos campos deben ser numeros", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
                TxtStock.Focus();
            }
            if (ValidarInt(TxtStockMin.Text))
            {
                MessageBox.Show("algunos campos deben ser numeros", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
                TxtStockMin.Focus();
            }


            await GuardarProductoAsync();
            DgvProductos.Rows.Clear();
            await CargarAutosAsync();
        }

        private async void CargarCampos(int cod)
        {
            List<Producto> lst = await GetLstProd();
            foreach(Producto p in lst)
            {
                if(p.Codigo == cod)
                {
                    TxtCodigo.Text = p.Codigo.ToString();
                    TxtDescripcion.Text = p.Descripcion.ToString();
                    TxtPrecio.Text = p.Precio.ToString();
                    TxtStock.Text = p.Stock.ToString();
                    TxtStockMin.Text = p.StockMin.ToString();
                    CboMarca.SelectedIndex = p.Marca -1;
                    if (p.Tipo_prod == 1)
                    {
                        RbtAuto.Checked = true;
                    }
                    else
                        RbtRepuesto.Checked = true;
                }
            }
        }

        private async Task<List<Producto>> GetLstProd()
        {
            string url = "http://localhost:5239/autos";
            var result = await ClientSingleton.Getinstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Producto>>(result);
            return lst;
        }



        private async void DgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int cod = Convert.ToInt32(DgvProductos.CurrentRow.Cells["CmnCodigo"].Value.ToString());
            CargarCampos(cod);
        }
    }
}
