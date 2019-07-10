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
          
        }

        private void B_GenerarNomina_Click(object sender, EventArgs e)
        {
            Nomina n = new Nomina();
            n.Dollar = Convert.ToDecimal(T_Dollar.Text);
            try
            {
                DataSet ds = ProNomina.VistaDeNomina(n);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + error.StackTrace);
            }
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            Nomina n = new Nomina();
            n.Dollar = Convert.ToDecimal(T_Dollar.Text);
            n.Usuario1= Convert.ToInt32(T_)


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal m = new MenuPrincipal();
            m.Show();
        }
    }
}
