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
    public partial class Vista : Form
    {
        public Vista()
        {
            InitializeComponent();
        }
        private static DataTable dt = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = PEmpleados.VistaPrestamo();
                dt = ds.Tables[0];
                DgvEmpleados.DataSource = dt;
                DgvEmpleados.Columns["Id"].Visible = false;
                if (dt.Rows.Count > 0)
                {

                }
                else
                {

                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message + Error.StackTrace);
            }


        }

        private void DgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvEmpleados.CurrentRow != null)
            {
                //T_Id.Text = DgvEmpleados.CurrentRow.Cells["Id"].Value.ToString();
                //T_Nombre.Text = DgvEmpleados.CurrentRow.Cells["Nombre"].Value.ToString();
                //T_Apellido.Text = DgvEmpleados.CurrentRow.Cells["Apellido"].Value.ToString();
                //T_Direccion.Text = DgvEmpleados.CurrentRow.Cells["Direccion"].Value.ToString();
                //T_Email.Text = DgvEmpleados.CurrentRow.Cells["Email"].Value.ToString();
                //T_Telefono.Text = DgvEmpleados.CurrentRow.Cells["Telefono"].Value.ToString();
                //T_Puesto.Text = DgvEmpleados.CurrentRow.Cells["Puesto"].Value.ToString();


            }
        }
        private bool check = false;
        public void setFlag(bool value)
        {
            check = value;

        }
        private void DgvEmpleados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (check == true)
            {
                PrestamosyBonificaciones p = PrestamosyBonificaciones.GetInstancia();
                p.setEmpleao(DgvEmpleados.CurrentRow.Cells["Id"].Value.ToString(), DgvEmpleados.CurrentRow.Cells["Nombre"].Value.ToString(), DgvEmpleados.CurrentRow.Cells["Apellido"].Value.ToString(), DgvEmpleados.CurrentRow.Cells["Salario"].Value.ToString());
                // p.Enabled = true;
                //  
                p.Show();               // MessageBox.Show(" ");

                Hide();
            }

        }

        private void B_Guardar_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                PrestamosyBonificaciones p = PrestamosyBonificaciones.GetInstancia();
                p.setEmpleao(DgvEmpleados.CurrentRow.Cells["Id"].Value.ToString(), DgvEmpleados.CurrentRow.Cells["Nombre"].Value.ToString(), DgvEmpleados.CurrentRow.Cells["Apellido"].Value.ToString(), DgvEmpleados.CurrentRow.Cells["Salario"].Value.ToString());
                // p.Enabled = true;
                //  
                p.Show();               // MessageBox.Show(" ");

                Hide();
              //  p.Show();
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {
                DataView dv = new DataView(dt.Copy());
                dv.RowFilter = "Nombre"+ " Like '%" + T_Buscar.Text + "%'";
                DgvEmpleados.DataSource = dv;
            }
            catch
            {

            }
        }
    }
}
