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
    public partial class MantenimientoOtros : Form
    {
        public MantenimientoOtros()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MantenimientoOtros_Load(object sender, EventArgs e)
        {

            MessageBox.Show("Esto lo veremos en la proxima entrega", "Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Stop);

            

        }

        private void SalirToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            MenuPrincipal s = new MenuPrincipal();
            this.Close();
            s.Show();
        }
    }
}
