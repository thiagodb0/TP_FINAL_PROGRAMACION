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
    public partial class FrmClienteNuevo : Form
    {
        public FrmClienteNuevo()
        {
            InitializeComponent();
        }

        private async void FrmClienteNuevo_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


        //private async Task CargarTipoDoc()
        //{
        //    string url = "http://localhost:5239/marcas";
        //    var result = await ClientSingleton.Getinstance().GetAsync(url);
        //    var lst = JsonConvert.DeserializeObject<List<Marca>>(result);
        //    CboMarca.DataSource = lst;
        //    CboMarca.DisplayMember = "Descripcion";
        //    CboMarca.ValueMember = "Id";
        //}
    }
}
