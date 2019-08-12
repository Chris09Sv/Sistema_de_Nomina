using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Nomina.Presentacion.Nomina
{
    public partial class ContenedorDeNominas : Form
    {
        public ContenedorDeNominas()
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

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirHijo(new Nomina13());

        }

        private void FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirHijo(new BusquedaNomina());
        }

        private void ContenedorDeNominas_Load(object sender, EventArgs e)
        {
            AbrirHijo(new BusquedaNomina());

        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AbrirHijo(new Mantenimiento_de__nomina());

        }

        private void PuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro de que desea salir de seccion?", "Salir ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                this.Close();

        }
    }
}
