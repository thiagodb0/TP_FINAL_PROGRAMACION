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
    public partial class BajaFactura : Form
    {
        
        public BajaFactura()
        {
            InitializeComponent();
        }

        private async void BajaFactura_Load(object sender, EventArgs e)
        {
           await CargarFacturasAsync();
           
        }


        private async Task CargarFacturasAsync()
        {
            string url = "http://localhost:5239/facturas";
            var result = await ClientSingleton.Getinstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Factura>>(result);
            foreach(Factura f in lst)
            {
                Dgfacturas.Rows.Add(new object[] { f.CodFactura, f.Fecha, f.Cliente.Nombre, f.Vendedor.Nombre, f.Forma_Pago.Descripcion });
            }

        }


        private async Task BajarFactura(NroParam nro)
        {
            string bodyContent = JsonConvert.SerializeObject(nro);

            string url = "http://localhost:5239/bajaFact";
            var result = await ClientSingleton.Getinstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))
            {
                MessageBox.Show("Factura dada de baja", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo dar de baja la Factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int nroF = 0;

        private void Dgfacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        

        private async void BtnDarBaja_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(Dgfacturas.CurrentRow.Cells["CmnNroFact"].Value.ToString());
            NroParam nro = new NroParam(num);
            await BajarFactura(nro);
        }

        private void BtnRevisar_Click(object sender, EventArgs e)
        {
            int nro = Convert.ToInt32(Dgfacturas.CurrentRow.Cells[0].Value.ToString());
            FrmRevFact frm = new FrmRevFact(nro);
            frm.ShowDialog();
        }
    }
}
