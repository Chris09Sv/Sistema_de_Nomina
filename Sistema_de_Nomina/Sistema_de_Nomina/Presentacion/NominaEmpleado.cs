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
    public partial class NominaEmpleado : Form
    {
        public NominaEmpleado()
        {
            InitializeComponent();
        }
        private DataTable dt;
        private void NominaEmpleado_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Nombre";
            try
            {
                DataSet ds = PEmpleados.Vista();
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Id"].Visible = false;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + error.StackTrace);
            }
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
          //  dataGridView1.Columns[1].Visible = false;
        }

        private void T_Buscar_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt.Copy());
            dv.RowFilter = comboBox1.Text + " Like '%" + T_Buscar.Text + "%'";
            dataGridView1.DataSource = dv;
        }
        private int idEmpleado;
        private void Button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Empleados empleados = new Empleados();
                empleados.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());

                try
                {
                    DataSet ds = PEmpleados.VistaNominaIndividual(empleados);
                    dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                   // dataGridView1.Columns["Id"].Visible = false;
                   foreach(DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (string.IsNullOrEmpty(row.Cells["Cuota Por Prestamo"].Value.ToString()))
                            row.Cells["Cuota Por Prestamo"].Value = 0;
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message + error.StackTrace);
                }
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                MessageBox.Show(idEmpleado.ToString());
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            NominaEmpleado_Load(null, null);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MenuPrincipal m = new MenuPrincipal();
            m.Show();
            this.Close();
        }
    }
}
