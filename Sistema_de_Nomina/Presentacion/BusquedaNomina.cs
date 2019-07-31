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
    public partial class BusquedaNomina : Form
    {
        public BusquedaNomina()
        {
            InitializeComponent();
        }
        private DataTable dt;

        public static decimal count_Afp = 0;
        public static decimal count_Seg = 0;
        public static decimal count_SRl = 0;
        public static decimal count_Infotep = 0;
        private void BusquedaNomina_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = Datos.ProNomina.VistaNomina();
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + error.StackTrace);
            }

            b_volver.Enabled = false; B_Salir.Enabled = true;
            B_Eliminar.Enabled = true; 
            Seguro.Text = "";
            AFP.Text = "";
            SRL.Text = "" ;
            Infotep.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Nomina n = new Nomina();
                n.IdNomina= Convert.ToInt32(dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString());
                DataSet ds = Datos.ProNomina.VerNomina(n);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;

                GrupoMostrarNomina.Show();

                b_volver.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + error.StackTrace);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void B_Volver_Click(object sender, EventArgs e)
        {

            BusquedaNomina_Load(null, null);
            B_Salir.Enabled = true;
            B_Eliminar.Enabled = true;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Seguro.Text = "";
            try
            {
                Nomina n = new Nomina();
                n.IdNomina = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString());
                DataSet ds = Datos.ProNomina.ReporteTSS(n);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;

                GrupoMostrarNomina.Show();

                b_volver.Enabled = true;
                B_Salir.Enabled = true;
                B_Eliminar.Enabled = false;
                B_verNomina.Enabled = false;
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {


                count_Afp += Convert.ToDecimal(row.Cells["AFP"].Value);
                count_SRl += Convert.ToDecimal(row.Cells["SRL"].Value);
                count_Seg += Convert.ToDecimal(row.Cells["Seguro Familiar de Salud"].Value);
                count_Infotep += Convert.ToDecimal(row.Cells["Infotep"].Value);
                   
                }
                Seguro.Text = "Seguro de Salud $$" + count_Seg;
                AFP.Text = "AFP $$" + count_Afp;
                SRL.Text = "Seguro de Riesgos laborales $$" + count_SRl;
                Infotep.Text = " Infotep $$" + count_Infotep;

              //  b_volver.Enabled = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + error.StackTrace);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                Nomina n = new Nomina();
                n.IdNomina = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString());
                DataSet ds = Datos.ProNomina.VerNomina(n);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;

                GrupoMostrarNomina.Show();

                b_volver.Enabled = true;
                B_verNomina.Enabled = false;
                B_Eliminar.Enabled = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + error.StackTrace);
            }

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void B_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
