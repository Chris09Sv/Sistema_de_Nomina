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
            AddHeaderCheckBox();

            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
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

                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView1.MultiSelect = false;

                    dataGridView1.BackgroundColor = Color.Honeydew;

                //    dataGridView1.Columns["Id"].Visible = false;
                    dataGridView1.Columns["CuentaId"].Visible = false;

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
                //if ((row.Cells["Prestamo"].ToString())== "")
                //{
                //    row.Cells["Prestamo"].Value = 0;
                //}
                if (string.IsNullOrEmpty(   row.Cells["Otros"].Value.ToString() ) )
                    row.Cells["Otros"].Value = 0;

        

                    double total = Convert.ToDouble(row.Cells["Sueldo Neto"].Value) - Convert.ToDouble(row.Cells["Otros"].Value);
                count_Afp += Convert.ToDecimal(row.Cells["AFP"].Value);
                count_ISR += Convert.ToDecimal(row.Cells["Impuesto sobre la renta"].Value);
                count_Seg += Convert.ToDecimal(row.Cells["Seguro social"].Value);
                count_Sueldo += Convert.ToDecimal(row.Cells["Sueldo Neto"].Value);
              //  row.Cells[8].Value = total;
                row.Cells["Sueldo Neto"].Value = total;

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
            n.Fecha2 = DTP_FechaNomina.Value;
          // ProNomina.GuardarNomina(n);
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
                Prestamos_y_Bonificaciones p = new Prestamos_y_Bonificaciones();

                dn.Id_Empleado = Convert.ToInt32(row.Cells["Id"].Value.ToString());
                dn.IdNomina = Convert.ToInt32(t_IdNomina.Text);
                p.Meses = Convert.ToInt32(t_IdNomina.Text);
                dn.AFP = Convert.ToDecimal(row.Cells["AFP"].Value.ToString());
                dn.Seg_Med = Convert.ToDecimal(row.Cells["Seguro social"].Value.ToString());
                dn.Sueldo_neto = Convert.ToDecimal(row.Cells["Sueldo neto"].Value.ToString());
                dn.ISR = Convert.ToDecimal(row.Cells["Impuesto sobre la renta"].Value.ToString());
                dn.Otros = Convert.ToDecimal(row.Cells["Otros"].Value);
                p.Cuota1 = Convert.ToDecimal(row.Cells["Otros"].Value);
                if ( p.Cuota1 >0)
                {
                    p.Cuenta = Convert.ToInt32(row.Cells["CuentaId"].Value);
                    if (ProNomina.GuardarDetalleNomina(dn) > 0)
                        MessageBox.Show("la nomina se ha registrado correctamente");

                    if (ProNomina.GuardarPrestamo(p) > 0)
                        MessageBox.Show("Prestamo");

                }
                else
                {
                    if (ProNomina.GuardarDetalleNomina(dn) > 0)
                        MessageBox.Show("la nomina se ha registrado correctamente");

                }


            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal m = new MenuPrincipal();
            m.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Nomina", "Crear Nomina", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {

                        if ((Convert.ToBoolean(row.Cells["Seleccionar"].Value)))
                        {

                            DetalleNomina dn = new DetalleNomina();

                            dn.Cedula = row.Cells["Cedula"].Value.ToString();
                            dn.IdNomina = Convert.ToInt32(t_IdNomina.Text);
                            dn.AFP = Convert.ToDecimal(row.Cells["AFP"].Value.ToString());
                            dn.Seg_Med = Convert.ToDecimal(row.Cells["Seguro social"].Value.ToString());
                            dn.Sueldo_neto = Convert.ToDecimal(row.Cells["Sueldo neto"].Value.ToString());
                            dn.ISR = Convert.ToDecimal(row.Cells["Impuesto sobre la renta"].Value.ToString());





                            if (ProNomina.GuardarDetalleNomina(dn) > 0)
                                MessageBox.Show("la nomina se ha registrado correctamente"); ;
                          
                        }


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxCell checkSeleccionar = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells["Seleccionar"];
            checkSeleccionar.Value = !Convert.ToBoolean(checkSeleccionar.Value);

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(dt.Copy());
                dv.RowFilter = comboBox1.Text + " Like '%" + textBox1.Text + "%'";
                dataGridView1.DataSource = dv;
            }
            catch
            {

            }
        }

        CheckBox HeaderCheckBox = null;
        bool isHeaderCheckBox = false;
        private void AddHeaderCheckBox()
        {
            HeaderCheckBox = new CheckBox();
            HeaderCheckBox.Size = new Size(15, 15);
            this.dataGridView1.Controls.Add(HeaderCheckBox);
        }

        private void HeaderCheckBoxClick( CheckBox Seleccionar)
        {
            isHeaderCheckBox = true;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                ((DataGridViewCheckBoxCell)row.Cells["Seleccionar"]).Value = Seleccionar.Checked;
               
            }
            dataGridView1.RefreshEdit();
            isHeaderCheckBox = false;
        }
       private void HeaderCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            HeaderCheckBoxClick((CheckBox)sender);
        }
    }
}
