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
using Sistema_de_Nomina.Presentacion;
using Sistema_de_Nomina.Presentacion.Nomina;

namespace Sistema_de_Nomina
{
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btninicio_Click(null ,e);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
           // SubmenuReportes.Visible = true;
        }

        private void btnrptventa_Click(object sender, EventArgs e)
        {
            //SubmenuReportes.Visible = false;
        }

        private void btnrptcompra_Click(object sender, EventArgs e)
        {
            //S//ubmenuReportes.Visible = false;
        }

        private void btnrptpagos_Click(object sender, EventArgs e)
        {
            //SubmenuReportes.Visible = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                if (MessageBox.Show("Esta Seguro de que desea cambiar de seccion?", "Cambio de seccion ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    this.panelContenedor.Controls.RemoveAt(0);
                    Form fh = formhija as Form;
                    fh.TopLevel = false;
                    fh.Dock = DockStyle.Fill;
                    this.panelContenedor.Controls.Add(fh);
                    this.panelContenedor.Tag = fh;
                    fh.Show();
                }


            }
            else
            {
                Form fh = formhija as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(fh);
                this.panelContenedor.Tag = fh;
                fh.Show();

            }

        }

        public void receptor(Form formhija)
        {
            AbrirFormHija(formhija);
        }
        public void AbrirHijo(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                if (MessageBox.Show("Esta Seguro de que desea cambiar de seccion?", "Cambio de seccion ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    this.panelContenedor.Controls.RemoveAt(0);
                    Form fh = formhija as Form;
                    fh.TopLevel = false;
                    fh.Dock = DockStyle.Fill;
                    this.panelContenedor.Controls.Add(fh);
                    this.panelContenedor.Tag = fh;
                    fh.Show();
                }


            }
            else
            {
                Form fh = formhija as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(fh);
                this.panelContenedor.Tag = fh;
                fh.Show();

            }

        }

        private void btninicio_Click(object sender, EventArgs e)
        {
        //    AbrirFormHija(new ());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new MantenimientoDepartamento());
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new MantenimientoEmpleado());

        }

        private void BTNventas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ContenedorDeNominas ());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new BusquedaNomina());
        }

        private void Button6_Click(object sender, EventArgs e)
        {
        //    AbrirFormHija(new PrestamosyBonificaciones());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new DescuentosPorLey());
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            AbrirFormHija(new PrestamosyBonificaciones());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Frm_Usuario());

        }
    }
}
