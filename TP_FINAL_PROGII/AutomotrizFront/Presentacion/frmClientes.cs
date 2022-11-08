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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private async Task GetClientes(string nombre)
        {
            string url = "http://localhost:5239/clientRepor/" + nombre;
            var result = await ClientSingleton.Getinstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<ClienteReport>>(result);
            foreach (ClienteReport cr in lst)
            {
                DgvCliente.Rows.Add(new object[] { cr.cliente.Id, cr.cliente.Nombre, cr.total, cr.promedio, cr.fecha });
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            DgvCliente.Rows.Clear();
            string nombre = TxtNombre.Text;
            await GetClientes(nombre);
        }
    }
}
