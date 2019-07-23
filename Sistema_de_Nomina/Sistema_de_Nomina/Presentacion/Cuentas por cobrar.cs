using Sistema_de_Nomina.Datos;
using Sistema_de_Nomina.ModeloDeDatos;
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
    public partial class Cuentas_por_cobrar : Form
    {
        public Cuentas_por_cobrar()
        {
            InitializeComponent();
        }
        private DataTable dt;

        private void Cuentas_por_cobrar_Load(object sender, EventArgs e)
        {
            try
            {
                //Empleados p = new Empleados();
                DataSet ds = Datos.ProNomina.Vistaprestamo();
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + error.StackTrace);
            }
        }

        private void T_Buscar_TextChanged(object sender, EventArgs e)
        {

            DataView dv = new DataView(dt.Copy());
            dv.RowFilter = comboBox1.Text + " Like '%" + T_Buscar.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Empleados empleados = new Empleados();
                empleados.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());

                try
                {
                    DataSet ds = ProNomina.VistaprestamoEmpleado(empleados);
                    dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                    // dataGridView1.Columns["Id"].Visible = false;
                 
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message + error.StackTrace);
                }
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
             //   MessageBox.Show(idEmpleado.ToString());
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Cuentas_por_cobrar_Load(null, null);
        }
    }
}
