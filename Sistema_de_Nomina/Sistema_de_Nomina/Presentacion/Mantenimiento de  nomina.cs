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
        public static decimal count_Afp = 0;
        public static decimal count_Seg = 0;
        public static decimal count_ISR = 0;
        public static decimal count_Sueldo = 0;


        private void Mantenimiento_de__nomina_Load(object sender, EventArgs e)
        {
            Nomina n = new Nomina();
            string dc="Nomina";

            try
            {
                DataSet ds = ProNomina.SeleccionarIdNomina();
                dc = ds.Tables[0].Rows[0][0].ToString();

                t_IdNomina.Text=dc;


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + error.StackTrace);
            }

        }

        private void B_GenerarNomina_Click(object sender, EventArgs e)
        {

            Nomina n = new Nomina();


            if (T_Dollar.Text != "")
            {
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
            else
                MessageBox.Show("Por favor ingrese la tasa de cambio para calcular la nomina");
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                       count_Afp += Convert.ToDecimal(row.Cells["AFP"].Value);
                count_ISR += Convert.ToDecimal(row.Cells["Impuesto sobre la renta"].Value);
                count_Seg += Convert.ToDecimal(row.Cells["Seguro social"].Value);
                count_Sueldo += Convert.ToDecimal(row.Cells["Sueldo Neto"].Value);

            }
            label5.Text = " Fondo de pensiones $$ " + count_Afp.ToString();
          label2.Text = " Seguridad Social $$ " + count_Seg.ToString();
            label6.Text = " Impuesto sobre la renta $$ " + count_ISR.ToString();
            label7.Text = "Total a Pagar $$ " + count_Sueldo.ToString();



        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show("Empleado registrado correctamente");

         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal m = new MenuPrincipal();
            m.Show();
        }

        private void B_Guardar_Click(object sender, EventArgs e)
        {
               Nomina n = new Nomina();
            n.Dollar = Convert.ToDecimal(T_Dollar.Text);
            n.Usuario1 = Convert.ToInt32(T_Usuario.Text);
            n.Estatus1 = CBX_Estatus.Text;
            n.Fecha1 = DateTime.Today;
            ProNomina.GuardarNomina(n);
            try
            {

                if( ProNomina.GuardarNomina(n)>0 )
                    MessageBox.Show("la nomina se ha registrado correctamente");

            }
            catch
            {
                
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DetalleNomina dn = new DetalleNomina();

                dn.Cedula = row.Cells["Cedula"].Value.ToString();
                dn.IdNomina = Convert.ToInt32(t_IdNomina.Text);
                dn.AFP = Convert.ToDecimal(row.Cells["AFP"].Value.ToString());
                dn.Seg_Med = Convert.ToDecimal(row.Cells["Seguro social"].Value.ToString());
                dn.Sueldo_neto = Convert.ToDecimal(row.Cells["Sueldo neto"].Value.ToString());
                dn.ISR = Convert.ToDecimal(row.Cells["Impuesto sobre la renta"].Value.ToString());





                if (ProNomina.GuardarDetalleNomina(dn) > 0)
                    MessageBox.Show("la nomina se ha registrado correctamente");

            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal m = new MenuPrincipal();
            m.Show();
        }
    }
}
