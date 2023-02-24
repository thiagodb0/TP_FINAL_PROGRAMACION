using AutomotrizFront.Presentacion;
using AutomotrizFront.Servicios;
using DataAPIAutomo.Dominio;
using Newtonsoft.Json;

namespace AutomotrizFront
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            

            string user = txtCuenta.Text;
            string clave = txtContraseña.Text;

            if (await CheckCredenciales(user,clave))
            {
                frmPrincipal frm = new frmPrincipal();
                frm.Show();
                this.Hide();
                
            }
            else
            {
                txtContraseña.Clear();
                txtContraseña.Focus();
                LblIncorrecto.Text = "Usuario o contraseña incorrecta";
            }
        }

        private async void frmInicio_Load(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
            LblIncorrecto.ForeColor = Color.OrangeRed;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task<bool> CheckCredenciales(string user, string clave)
        {
            string url = "http://localhost:5239/usuarios";
            var result = await ClientSingleton.Getinstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Usuario>>(result);

            bool aux = true;
            foreach(Usuario u in lst)
            {
                if(u.nombre == user && u.clave == clave )
                {
                    aux = true;
                }
                else
                {
                    aux = false;
                }
            }
            return aux;
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}