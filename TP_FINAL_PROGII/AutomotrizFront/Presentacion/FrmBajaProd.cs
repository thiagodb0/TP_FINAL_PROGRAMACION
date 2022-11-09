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
    public partial class FrmBajaProd : Form
    {
        public FrmBajaProd()
        {
            InitializeComponent();
        }

        private async void FrmBajaProd_Load(object sender, EventArgs e)
        {
            await CargarAutosAsync();
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

        private async Task BajarProd(NroParam nro)
        {
            string bodyContent = JsonConvert.SerializeObject(nro);

            string url = "http://localhost:5239/bajaProd";
            var result = await ClientSingleton.Getinstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))
            {
                MessageBox.Show("PRODUCTO dada de baja", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo dar de baja el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBaja_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(DgvProductos.CurrentRow.Cells["Cmncodigo"].Value.ToString());
            NroParam nro = new NroParam(num);
            BajarProd(nro);
        }
    }
}
