using Sistema_de_Nomina.Datos;
using Sistema_de_Nomina.ModeloDeDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Nomina.Presentacion
{
    public partial class FDepartamento : Form
    {
        public FDepartamento()
        {
            InitializeComponent();
        }
        private DataTable dt = new DataTable();

        private void Button1_Click(object sender, EventArgs e)
        {
            P_Grid.Hide();
            P_Menu.Hide();
          //  Portada_Panel.Show();
     }

        SqlDataAdapter da = new SqlDataAdapter();


        private void FDepartamento_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = ProDepartamento.VistaDepartamento();
                dt = ds.Tables[0];
                DgvDept.DataSource = dt;
                comboBox2.DisplayMember = "Departamento";
                comboBox2.ValueMember = "Id";
                comboBox2.DataSource = dt;
                
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message + error.StackTrace);
            }
            P_Posicion.Hide();
          P_Menu.Show();
        }

        private void B_Guardar_Click(object sender, EventArgs e)
        {
            Departamentos d = new Departamentos();
            // d.Id = Convert.ToInt32(T_Id.Text);
         //   d.Id = T_Id.Text;

            d.Departamento = T_Departamento.Text;
         //   d.Descripcion = T_Descripcion.Text;
            //d.Puesto = T_Puestos.Text;
            if (ProDepartamento.NuevoDepartamento(d) > 0)
            {
                MessageBox.Show("Departamento agregado");
                FDepartamento_Load(null, null);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // boton nuevo departamento, ocultara los demas paneles y solo mostrara los departamentos. Cargara los departamentos existentes al GridView

            P_Grid.Hide();
            P_Menu.Show();

        }

      

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
        
        private void Button3_Click(object sender, EventArgs e)
        {
            DgvDept.Hide();
            P_Adm_Departamento.Hide();
            P_Posicion.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
           Posiciones p = new Posiciones();
            // d.Id = Convert.ToInt32(T_Id.Text);
            //   d.Id = T_Id.Text;

            p.Posicion = T_Posicion.Text;
            p.IdDepartamento = Convert.ToInt32(comboBox2.SelectedValue.ToString());
             
                //   d.Descripcion = T_Descripcion.Text;
            //d.Puesto = T_Puestos.Text;
            if (ProDepartamento.NuevaPosicion(p) > 0)
            {
                MessageBox.Show("Posicion agregada");
                FDepartamento_Load(null, null);
            }
        }

        private void P_Posicion_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
