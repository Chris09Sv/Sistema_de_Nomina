using Sistema_de_Nomina.Datos;
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
    public partial class Mantenimiento_de__nomina : Form
    {
        private DataTable dt;

        public Mantenimiento_de__nomina()
        {
            InitializeComponent();
        }

        private void Mantenimiento_de__nomina_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = ProNomina.VistaDeNomina();
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + error.StackTrace);
            }
        }
    }
}
