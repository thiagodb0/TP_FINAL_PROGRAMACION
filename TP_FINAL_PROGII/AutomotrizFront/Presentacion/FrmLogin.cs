using AutomotrizFront.Presentacion;

namespace AutomotrizFront
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCuenta.Text=="Admin" && txtContraseña.Text=="1234")
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

        private void frmInicio_Load(object sender, EventArgs e)
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

        
    }
}