using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AutomotrizFront.Presentacion
{
    public partial class frmPrincipal : Form
    {


        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL",EntryPoint ="SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,int wMsg,int wParam,int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void AbrirSubForm(object formHijo)
        {
            if (PanelContenedor.Controls.Count>0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }
            Form frm = formHijo as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(frm);
            this.PanelContenedor.Tag = frm;
            frm.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirSubForm(new NuevaFactura()); ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirSubForm(new frmVendedores());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnMinimizarTamanio.Visible = true;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMax.Visible = true;
            btnMinimizarTamanio.Visible = false;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
