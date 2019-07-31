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
    public partial class MantenimientoDepartamento : Form
    {
        private DataTable dt;

        public MantenimientoDepartamento()
        {
            InitializeComponent();
        }


        private void MantenimientoDepartamento_Load(object sender, EventArgs e)
        {
            Limpiar();
            // P_Menu.Show();
            //P_Posicion.Hide();

            //P_Adm_Departamento.Show();
            //DgvDept.Visible = true;
            try
            {
                DataSet ds = ProDepartamento.VistaDepartamento();
                dt = ds.Tables[0];
                DgvDept.DataSource = dt;




                C_Departamento.DisplayMember = "Departamento";
                C_Departamento.ValueMember = "Id";
                C_Departamento.DataSource = dt;


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + error.StackTrace);
            }

            try
            {
                DataSet ds = ProDepartamento.VistaPosicion();

                dt = ds.Tables[0];
                DvgPosiciones.DataSource = dt;
                DvgPosiciones.Columns["Id"].Visible = false;
                
                // dt = ds.Tables[0];


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + error.StackTrace);
            }



        }

        private void B_NuevoDepartamento_Click(object sender, EventArgs e)
        {

            P_Posicion.Hide();

            P_Adm_Departamento.Show();
            DgvDept.Visible=true;
            try
            {
                DataSet ds = ProDepartamento.VistaDepartamento();
                dt = ds.Tables[0];
                DgvDept.DataSource = dt;

               


                C_Departamento.DisplayMember = "Departamento";
                C_Departamento.ValueMember = "Id";
                C_Departamento.DataSource = dt;


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + error.StackTrace);
            }

        }


        private void DgvDept_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvDept.CurrentRow != null)
            {
                T_Id.Text = DgvDept.CurrentRow.Cells[1].Value.ToString();
                T_Departamento.Text = DgvDept.CurrentRow.Cells[2].Value.ToString();
                //T_Departamento.Enabled = false;
            }
        }

        private void B_Guardar_Click(object sender, EventArgs e)
        {
            Departamentos d = new Departamentos();

            d.Departamento = T_Departamento.Text;
            //   d.Descripcion = T_Descripcion.Text;
            //d.Puesto = T_Puestos.Text;
            if (T_Id.Text == "")
            {

                if (ProDepartamento.NuevoDepartamento(d) > 0)
                {
                    MessageBox.Show("Departamento agregado");
                    MantenimientoDepartamento_Load(null, null);
                }
            }
            else
            {
                d.Id = Convert.ToInt32(T_Id.Text);

                if (ProDepartamento.ActualizarDepartamento(d) ==1)


                    MessageBox.Show("actualizar");
            }

        }

        private void DgvDept_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxCell checkEliminar = (DataGridViewCheckBoxCell)DgvDept.Rows[e.RowIndex].Cells["Eliminar"];
            checkEliminar.Value = !Convert.ToBoolean(checkEliminar.Value);
        }

        private void B_Eliminar_Click(object sender, EventArgs e)
        {
         
        }

        private void B_Guardar_Puesto_Click(object sender, EventArgs e)
        {

        }


        private void B_NuevoPuesto_Click(object sender, EventArgs e)
        {
            P_Adm_Departamento.Hide();
        
            P_Posicion.Show();
            DvgPosiciones.Show();
            DgvDept.Hide();
            try
            {
                DataSet ds = ProDepartamento.VistaPosicion();

                dt = ds.Tables[0];
                DvgPosiciones.DataSource = dt;
               // dt = ds.Tables[0];
        

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + error.StackTrace);
            }
        }

        private void DvgPosiciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DvgPosiciones.CurrentRow != null)
            {
                T_IDPuesto.Text = DvgPosiciones.CurrentRow.Cells[1].Value.ToString();
                T_Posicion.Text = DvgPosiciones.CurrentRow.Cells[2].Value.ToString();
                //T_Departamento.Enabled = false;
            //    C_Departamento.DisplayMember = DvgPosiciones.CurrentRow.Cells[3].Value.ToString();

                C_Departamento.Text = DvgPosiciones.CurrentRow.Cells[3].Value.ToString();

            }
        }

        private void PuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P_Adm_Departamento.Hide();
            G_Dept.Hide();
            G_Posiciones.Show();
            P_Posicion.Show();
            DvgPosiciones.Show();
            //DgvDept.Hide();
            DvgPosiciones.Enabled = false;

            try
            {
                DataSet ds = ProDepartamento.VistaPosicion();

                dt = ds.Tables[0];
                DvgPosiciones.DataSource = dt;
                // dt = ds.Tables[0];


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + error.StackTrace);
            }
        }

        private void DepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P_Posicion.Hide();
            G_Dept.Show();
            G_Posiciones.Hide();
            P_Adm_Departamento.Show();
            DgvDept.Visible = true;
            DgvDept.Enabled = false;
            try
            {
                DataSet ds = ProDepartamento.VistaDepartamento();
                dt = ds.Tables[0];
                DgvDept.DataSource = dt;




                C_Departamento.DisplayMember = "Departamento";
                C_Departamento.ValueMember = "Id";
                C_Departamento.DataSource = dt;


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + error.StackTrace);
            }
        }

        private void T_Departamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void B_EditarPosicion_Click(object sender, EventArgs e)
        {
            if (DgvDept.CurrentRow != null)
            {
                T_Id.Text = DgvDept.CurrentRow.Cells[1].Value.ToString();
                T_Departamento.Text = DgvDept.CurrentRow.Cells[2].Value.ToString();
                //T_Departamento.Enabled = false;
            }
        }

        private void B_NuevaPosicion_Click(object sender, EventArgs e)
        {
            DvgPosiciones.Enabled = false;

        }

        private void DvgPosiciones_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
         

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DgvDept.Enabled = false;

        }

        private void P_Adm_Departamento_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DgvDept.Enabled = true;

        }

        private void T_Buscar_Posicion_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(dt.Copy());
                dv.RowFilter = C_FiltroP.Text + " Like '" + T_Buscar_Posicion.Text + "%'";
                DvgPosiciones.DataSource = dv;
            }
            catch
            {

            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(dt.Copy());
                dv.RowFilter ="Departamento" +" Like '" + textBox1.Text + "%'";
                DgvDept.DataSource = dv;
            }
            catch
            {

            }
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
       

        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }

        private void DvgPosiciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxCell checkEliminar = (DataGridViewCheckBoxCell)DvgPosiciones.Rows[e.RowIndex].Cells["Eliminar1"];
            checkEliminar.Value = !Convert.ToBoolean(checkEliminar.Value);

        }

        private bool Check(string input)
        {
            //MessageBox.Show()


            return true;

        }
public void Limpiar()
        {
            T_Buscar_Posicion.Clear();
            T_Departamento.Clear();
            T_IDPuesto.Text = "";
            T_Posicion.Clear();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (DvgPosiciones.CurrentRow != null)
            {
                T_IDPuesto.Text = DvgPosiciones.CurrentRow.Cells["Id"].Value.ToString();
                T_Posicion.Text = DvgPosiciones.CurrentRow.Cells["Puestos"].Value.ToString();
                //T_Departamento.Enabled = false;
                //    C_Departamento.DisplayMember = DvgPosiciones.CurrentRow.Cells[3].Value.ToString();

                C_Departamento.Text = DvgPosiciones.CurrentRow.Cells["Departamento"].Value.ToString();

            }
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            MantenimientoDepartamento_Load(null, null);
        }

        private void B_elimina_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Esta seguro que desea eliminar las posiciones seleccionadas?", "Eliminar Puestos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in DvgPosiciones.Rows)
                    {
                        if ((Convert.ToBoolean(row.Cells["Eliminar"].Value)))
                        {
                            Posiciones p = new Posiciones();
                            p.Id = Convert.ToInt32(row.Cells["Id"].Value);
                            if (ProDepartamento.EliminarPosicion(p) != 1)
                            {
                                MessageBox.Show("El departamento no pudo ser eliminado", "Eliminar Puesto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            T_Posicion.Clear();
           
        }

        private void DgvDept_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
