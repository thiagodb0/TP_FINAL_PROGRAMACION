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
    public partial class FrmRevFact : Form
    {
        private int nroFact;
        public FrmRevFact(int nro)
        {
            InitializeComponent();
            nroFact = nro;
        }

        
        private async void FrmRevFact_Load(object sender, EventArgs e)
        {
            LblNro.Text = "Nro: " + nroFact.ToString();
            await CargarFactura(nroFact);
        }

        private async Task CargarFactura(int nro)
        {
            string url = "http://localhost:5239/DetalleRev/" + nro;
            var result = await ClientSingleton.Getinstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<DetalleRev>>(result);
            foreach (DetalleRev f in lst)
            {
                DgvDetalles.Rows.Add(new object[] { f.Factura, f.detalle, f.producto, f.precio, f.cantidad, f.precio * f.cantidad });
            }
        }

        
    }
}
