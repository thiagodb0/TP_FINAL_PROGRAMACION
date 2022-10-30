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
                frm.ShowDialog();
                this.Close();
            }
        }
    }
}