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
        public static int idnomina;
        public static decimal count_Afp = 0;
        public static decimal count_Seg = 0;
        public static decimal count_SRl = 0;
        public static decimal count_Infotep = 0;

        public string fecha;
        public string NominaNo;
        public string dolar;
        public string Cedula;
        public string Nombre;
        public string Departamento;
        public string Posicion;
        public string Salario;
        public string Isr;
        public string Seg_Med;
        public string Afp;
        public string otros;
        public string Descuentos;
        public string sueldo_neto;



        private void BusquedaNomina_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = Datos.ProNomina.VistaNomina();
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + error.StackTrace);
            }

            b_volver.Enabled = false; 
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
                Datos.Nomina n = new Datos.Nomina();
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
         //  B_Salir.Enabled = true;
            B_Eliminar.Enabled = true;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Seguro.Text = "";
            try
            {
                Datos.Nomina n = new Datos.Nomina();
                n.IdNomina = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString());
///                idnomina = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString());

                DataSet ds = Datos.ProNomina.ReporteTSS();
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;

                GrupoMostrarNomina.Show();
                dataGridView1.Columns["Id"].Visible = false;

                b_volver.Enabled = true;
             //   B_Salir.Enabled = true;
                B_Eliminar.Enabled = false;
                B_verNomina.Enabled = false;
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {

                    //double total = Convert.ToDouble(row.Cells["Sueldo Neto"].Value) - Convert.ToDouble(row.Cells["Otros"].Value);
                    //decimal.Round(calculo_isr, 2, MidpointRounding.AwayFromZero);

                    count_Afp += Convert.ToDecimal(row.Cells["AFP"].Value);
                count_SRl += Convert.ToDecimal(row.Cells["SRL"].Value);
                count_Seg += Convert.ToDecimal(row.Cells["Seguro Familiar de Salud"].Value);
                count_Infotep += Convert.ToDecimal(row.Cells["Infotep"].Value);
                   
                }
                //Seguro.Text = "Seguro de Salud $$" + count_Seg;
                //AFP.Text = "AFP $$" + count_Afp;
                //SRL.Text = "Seguro de Riesgos laborales $$" + count_SRl;
                //Infotep.Text = " Infotep $$" + count_Infotep;

              //  b_volver.Enabled = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + error.StackTrace);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    Datos.Nomina n = new Datos.Nomina();

                    n.IdNomina = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString());
                    idnomina = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString());

                    DataSet ds = Datos.ProNomina.VerNomina(n);
                    dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;

                    GrupoMostrarNomina.Show();
                    dataGridView1.Columns["Id"].Visible = false;

                    b_volver.Enabled = true;
                    B_verNomina.Enabled = false;
                    B_Eliminar.Enabled = false;
                    button2.Visible = true;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message + error.StackTrace);
                }

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

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Datos.Nomina n = new Datos.Nomina();
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

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label20_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {


                DetalleNomina d = new DetalleNomina();
                d.IdNomina = idnomina;
                d.Id_Empleado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                DataSet ds = ProNomina.SeleccionarNominaEmpleado(d);

                L_Fecha.Text = ("Fecha " + ds.Tables[0].Rows[0][0].ToString());
                L_NoNomina.Text = ("Nomina No. " + ds.Tables[0].Rows[0][1].ToString());
                L_Dollar.Text = ("Tasa de Cambio " + ds.Tables[0].Rows[0]["dolar"].ToString());
                L_Cedula.Text = ("Cedula " + ds.Tables[0].Rows[0]["Cedula"].ToString());
                L_Nombre.Text = ("Nombre :" + ds.Tables[0].Rows[0]["Nombre"].ToString());
                L_Departamento.Text = ("Departamento " + ds.Tables[0].Rows[0]["Departamento"].ToString());
                L_Cargo.Text = ("Cargo " + ds.Tables[0].Rows[0]["Posicion"].ToString());
                L_Salario.Text = ("Salario " + ds.Tables[0].Rows[0]["Salario"].ToString());
                L_ISR.Text = ("" + ds.Tables[0].Rows[0]["ISR"].ToString());
                L_Seg_Social.Text = ("" + ds.Tables[0].Rows[0]["Seg_Med"].ToString());
                L_AFP.Text = ds.Tables[0].Rows[0]["AFP"].ToString();
                L_Descuentos.Text = ds.Tables[0].Rows[0]["Otros"].ToString();
                L_TotalDescuentos.Text = ("Total Descuentos : " + ds.Tables[0].Rows[0]["Descuentos"].ToString());
                L_Neto.Text = ("Sueldo neto " + ds.Tables[0].Rows[0]["Sueldo Neto"].ToString());
                L_Total.Text = ("Salario  " + ds.Tables[0].Rows[0]["Salario"].ToString());
                /// L_Fecha.Text += ds.Tables[0].Rows[0][0].ToString();

                GrupoMostrarNomina.Hide();
                groupBox1.Show();
            }

        }

        //            try
        //    {
        //        DataSet ds = ProNomina.SeleccionarIdNomina();
        //
        // dc = ds.Tables[0].Rows[0][0].ToString();
        //ultima_nomina= Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString());
        //        t_IdNomina.Text = dc;

        //  //      B_Guardar.Enabled = false;
        //        T_Dollar.Focus();

        //    }
        //    catch (Exception error)
        //    {
        //        MessageBox.Show(error.Message + error.StackTrace);
        //    }



        //DataSet ds = ProNomina.SeleccionarIdNomina();
        //dc = ds.Tables[0].Rows[0][0].ToString();
        //ultima_nomina= Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString());
        //        t_IdNomina.Text = dc;



        //DataSet ds = ProNomina.VistaDeNomina();
        //dt = ds.Tables[0];
        //            dataGridView1.DataSource = dt;

        //            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //            dataGridView1.MultiSelect = false;
        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            GrupoMostrarNomina.Show();
            groupBox1.Hide();
            clear();
        }
        private void clear()
        {
            L_Fecha.Text = "";
                //+= (" " + ds.Tables[0].Rows[0][0].ToString());
            //L_NoNomina.Text += ds.Tables[0].Rows[0][1].ToString();
            //L_Dollar.Text += (" " + ds.Tables[0].Rows[0]["dolar"].ToString());
            //L_Cedula.Text += (" " + ds.Tables[0].Rows[0]["Cedula"].ToString());
            //L_Nombre.Text += ds.Tables[0].Rows[0]["Nombre"].ToString();
            //L_Departamento.Text += (" " + ds.Tables[0].Rows[0]["Departamento"].ToString());
            //L_Cargo.Text += (" " + ds.Tables[0].Rows[0]["Posicion"].ToString());
            //L_Salario.Text += (" " + ds.Tables[0].Rows[0]["Salario"].ToString());
            //L_ISR.Text += (" " + ds.Tables[0].Rows[0]["ISR"].ToString());
            //L_Seg_Social.Text += (" " + ds.Tables[0].Rows[0]["Seg_Med"].ToString());
            //L_AFP.Text += ds.Tables[0].Rows[0]["AFP"].ToString();
            //L_Descuentos.Text += ds.Tables[0].Rows[0]["Otros"].ToString();
            //L_TotalDescuentos.Text += (" " + ds.Tables[0].Rows[0]["Descuentos"].ToString());
            //L_Neto.Text += (" " + ds.Tables[0].Rows[0]["Sueldo Neto"].ToString());
            //L_Total.Text += (" " + ds.Tables[0].Rows[0]["Salario"].ToString());
        }
    }
}
