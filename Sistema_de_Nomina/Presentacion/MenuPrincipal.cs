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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void EMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoEmpleado empleado = new MantenimientoEmpleado();
            empleado.Show();
            this.Hide();
        }

        private void DEPARTAMENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoDepartamento m = new MantenimientoDepartamento();
            m.Show();
            this.Hide();
        }

        private void NOMINADEPAGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento_de__nomina mn = new Mantenimiento_de__nomina();
            mn.Show();
            this.Hide();

        }

        private void hISTORIALDENOMINAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusquedaNomina b = new BusquedaNomina();
            b.Show();
            Hide();
        }

        private void SALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
           // this.Close();
                
        }

        private void TASADEDEDUCIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_TazaDeduciones f = new Frm_TazaDeduciones();
            f.Show();
                
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void USUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esto lo veremos en la proxima entrega" );
            
        }

        private void BonificacionesYPrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrestamosyBonificaciones m = new PrestamosyBonificaciones();
            m.Show();
            Hide();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistema_de_NominaDataSet.store_Vista_nomina' table. You can move, or remove it, as needed.
            this.store_Vista_nominaTableAdapter.Fill(this.sistema_de_NominaDataSet.store_Vista_nomina);


        }

        private void EmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NominaEmpleado n = new NominaEmpleado();
            n.Show();
            this.Hide();
        }

        private void CuentasPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cuentas_por_cobrar c = new Cuentas_por_cobrar();
            c.Show();
            Hide();
        }

        private void CuentasPorCobrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cuentas_por_cobrar c = new Cuentas_por_cobrar();
            c.Show();
            Hide();
        }
    }
}
