using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Nomina.Presentacion
{
    public partial class DescuentosPorLey : Form
    {
        public DescuentosPorLey()
        {
            InitializeComponent();
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


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirHijo(new MantenimientoOtros());
        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirHijo(new MenuPrincipal());

        }
    }
}
