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
    public partial class MantenimientoEmpleado : Form
    {
        private DataTable dt;

        public MantenimientoEmpleado()
        {
            InitializeComponent();
        }

        private void Empleados_Click(object sender, EventArgs e)
        {
            G_Busqueda.Hide();
            G_Empleado.Show();

            try
            {
                DataSet ds =ProDepartamento.VistaDePuestos();
                dt = ds.Tables[0];
                C_Puesto.DisplayMember = "Posicion";
                C_Puesto.ValueMember = "Id";
                C_Puesto.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + error.StackTrace);
            }
        }

        private void BusquedaEmpleado_Click(object sender, EventArgs e)
        {
            G_Busqueda.Show();
            G_Empleado.Hide();
            try
            {
                DataSet ds = PEmpleados.Vista();
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + error.StackTrace);
            }

        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void B_Guardar_Click(object sender, EventArgs e)
        {
            Empleados empleados = new Empleados();
          //  empleados.Id;
            empleados.Nombre=T_Nombre.Text;
            empleados.Apellido=T_Apellido.Text;
            empleados.Cedula=T_Cedula.Text;
            empleados.Direccion=T_Direccion.Text;
            empleados.Email=T_Correo.Text;
            empleados.Telefono=T_Telefono.Text;
           empleados.IdPuesto=Convert.ToInt32(C_Puesto.SelectedValue.ToString());
            empleados.FechaDeNacimiento = DTP_FechaNacimiento.Value;
            empleados.FechaDeContratacion= DTP_FechaIngreso.Value;
            empleados.Sueldo = Convert.ToDecimal(T_Salario.Text);
            empleados.EstadoCivil = T_EstadoCivil.Text;
            empleados.Estado=T_Status.Text;
            empleados.NoCuenta =Convert.ToInt32(T_NoCuenta.Text);

            if (lbl_id.Text == "")
            {
                if (PEmpleados.Insertar(empleados) > 0)
                {
                    MessageBox.Show("Empleado registrado correctamente");
                }
            }
            else
            {
                empleados.Id = Convert.ToInt32(lbl_id.Text);

                if (PEmpleados.Modificar(empleados) == 1)
                {
                    MessageBox.Show("Empleado modificado Correctamente");
                }
            }

        }

        private void T_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxCell checkEliminar = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells["Eliminar"];
            checkEliminar.Value = !Convert.ToBoolean(checkEliminar.Value);
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(dataGridView1.CurrentRow!= null)
            //{

            //}
        }

        private void B_Editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {

                //Txt_ID.Text = dgvProductos.CurrentRow.Cells["Id"].Value.ToString();
                lbl_id.Text= dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                T_Nombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                T_Apellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                T_Cedula.Text = dataGridView1.CurrentRow.Cells["Cedula"].Value.ToString();

                T_Direccion.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                T_Telefono.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                T_Correo.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
             T_EstadoCivil.Text = dataGridView1.CurrentRow.Cells["Estado_Civil"].Value.ToString();

                T_Salario.Text = dataGridView1.CurrentRow.Cells["Salario"].Value.ToString();
                T_NoCuenta.Text = dataGridView1.CurrentRow.Cells["NoCuenta"].Value.ToString();
                T_Status.Text = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
                //  C_Puesto.Text = dataGridView1.CurrentRow.Cells["Departamento"].Value.ToString();


                G_Busqueda.Hide();
                G_Empleado.Show();
            }
        }

        private void B_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Esta Seguro de que desea Eliminar el Empleado Seleccionado?", "Eliminar Empleados", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {

                        if ((Convert.ToBoolean(row.Cells["Eliminar"].Value)))
                        { 

                            Empleados empleados = new Empleados();
                        empleados.Id = Convert.ToInt32(row.Cells["Id"].Value);
                        if (PEmpleados.Eliminar(empleados) != 1)
                        {
                            MessageBox.Show("El empleado  no pudo ser eliminado", "Eliminacion de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void MantenimientoEmpleado_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = ProDepartamento.VistaDePuestos();
                dt = ds.Tables[0];
                C_Puesto.DisplayMember = "Posicion";
                C_Puesto.ValueMember = "Id";
                C_Puesto.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + error.StackTrace);
            }

            G_Busqueda.Show();
            G_Empleado.Hide();
            try
            {
                DataSet ds = PEmpleados.Vista();
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
            try
            {
                DataView dv = new DataView(dt.Copy());
                dv.RowFilter = comboBox1.Text + " Like '" + T_Buscar.Text + "%'";
                dataGridView1.DataSource = dv;
            }
            catch
            {

            }
        }
    }
}
