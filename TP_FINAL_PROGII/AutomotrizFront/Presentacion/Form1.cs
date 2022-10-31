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
            if (txtCuenta.Text=="Admin" && txtContrase�a.Text=="1234")
            {
                frmPrincipal frm = new frmPrincipal();
                frm.Show();
                this.Hide();
                
            }
            else
            {
                txtContrase�a.Clear();
                txtContrase�a.Focus();
            }
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            txtContrase�a.UseSystemPasswordChar = true;
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