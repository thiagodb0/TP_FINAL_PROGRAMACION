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
using ReportAutomotriz;

namespace AutomotrizFront.Presentacion
{
    public partial class frmPrincipal : Form
    {


        public frmPrincipal()
        {
            InitializeComponent();
            CambiarDiseño();
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


        private void CambiarDiseño()
        {
            PanelSubemnuProd.Visible = false;
            PanelSubMenClientes.Visible = false;
            PanelSubMenVentas.Visible = false;
        }

        private void ocultarSubMen()
        {
            if (PanelSubemnuProd.Visible == true)
                PanelSubemnuProd.Visible = false;
            if (PanelSubMenClientes.Visible == true)
                PanelSubMenClientes.Visible = false;
            if(PanelSubMenVentas.Visible == true)
                PanelSubMenVentas.Visible=false;    
        }


        private void MostrarSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                ocultarSubMen();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        //private void AbrirSubForm(object formHijo)
        //{
        //    if (PanelContenedor.Controls.Count>0)
        //    {
        //        this.PanelContenedor.Controls.RemoveAt(0);

        //    }
        //    Form frm = formHijo as Form;
        //    frm.TopLevel = false;
        //    frm.Dock = DockStyle.Fill;
        //    this.PanelContenedor.Controls.Add(frm);
        //    this.PanelContenedor.Tag = frm;
        //    frm.Show();

        //}




        private Form activeForm = null;
        private void AbrirSubForm(Form formHijo)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            PanelContenedor.Controls.Add(formHijo);
            PanelContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();

        }
        private void button5_Click(object sender, EventArgs e)
        {
            AbrirSubForm(new NuevaFactura());
            ocultarSubMen();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            MostrarSubMenu(PanelSubMenClientes);
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

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            
            MostrarSubMenu(PanelSubemnuProd);
            
        }

        private void LkbAcercaDe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirSubForm(new FrmAcercaDe());
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirSubForm(new BajaFactura());
            ocultarSubMen();
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            AbrirSubForm(new FrmClientesReport());
            ocultarSubMen();
        }

        private void BtnAltaCliiente_Click(object sender, EventArgs e)
        {

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelSubMenVentas);
        }

        private void BtnConsClientes_Click(object sender, EventArgs e)
        {
            AbrirSubForm(new frmClientes());
            ocultarSubMen();
        }

        private void BtnAltaPrd_Click(object sender, EventArgs e)
        {
            AbrirSubForm(new FrmProductos());
            ocultarSubMen();
        }
    }
}
