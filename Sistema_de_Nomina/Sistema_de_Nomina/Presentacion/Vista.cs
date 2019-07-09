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
                DataSet ds = PEmpleados.Vista();
                dt = ds.Tables[0];
                DgvEmpleados.DataSource = dt;

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
                T_Id.Text = DgvEmpleados.CurrentRow.Cells["Id"].Value.ToString();
                T_Nombre.Text = DgvEmpleados.CurrentRow.Cells["Nombre"].Value.ToString();
                T_Apellido.Text = DgvEmpleados.CurrentRow.Cells["Apellido"].Value.ToString();
                T_Direccion.Text = DgvEmpleados.CurrentRow.Cells["Direccion"].Value.ToString();
                T_Email.Text = DgvEmpleados.CurrentRow.Cells["Email"].Value.ToString();
                T_Telefono.Text = DgvEmpleados.CurrentRow.Cells["Telefono"].Value.ToString();
                T_Puesto.Text = DgvEmpleados.CurrentRow.Cells["Puesto"].Value.ToString();


            }
        }

        private void B_Guardar_Click(object sender, EventArgs e)
        {
            Empleados ep = new Empleados();
            ep.Id = Convert.ToInt32(T_Id.Text); 
            ep.Nombre = T_Nombre.Text;
            ep.Apellido = T_Apellido.Text;
            ep.Cedula = T_Cedula.Text;
            ep.Direccion = T_Direccion.Text;
            ep.Email = T_Email.Text;
            ep.Telefono = T_Telefono.Text;
            ep.FechaDeNacimiento = T_FechaDeNacimiento.Value;
            ep.FechaDeContratacion = T_FechaDeContratacion.Value;
            ep.Puesto = T_Puesto.Text;
         ///   ep.Departamento = T_Departamento.Text;
            //  ep.Sueldo = Convert.ToByte(T_Sueldo.Text);

            if (PEmpleados.Modificar(ep) == 1)
            {
                MessageBox.Show("Datos Modificados correctamente!");
                Form1_Load(null, null);
                    
                    
              }
        }
    }
}
