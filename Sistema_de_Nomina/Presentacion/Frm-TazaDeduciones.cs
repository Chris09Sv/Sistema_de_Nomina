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
    public partial class Frm_TazaDeduciones : Form
    {
        private DataTable dt;

        public Frm_TazaDeduciones()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
              dgv_deducciones_CellClick(null, null);
        }

        private void Frm_TazaDeduciones_Load(object sender, EventArgs e)
        {
            //Limpiar();
            // P_Menu.Show();
            //P_Posicion.Hide();

            //P_Adm_Departamento.Show();
            //DgvDept.Visible = true;
            try
            {
                DataSet ds = Cdeducciones.Desc();
                dt = ds.Tables[0];
                dgv_deducciones.DataSource = dt;




                //C_Departamento.DisplayMember = "Departamento";
               // C_Departamento.ValueMember = "Id";
               // C_Departamento.DataSource = dt;


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + error.StackTrace);
            }

            try
            {


                DataSet ds = Cdeducciones.Desc();
                dt = ds.Tables[0];
                dgv_deducciones.DataSource = dt;





            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + error.StackTrace);
            }



        }

        private void dgv_deducciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_deducciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_deducciones.CurrentRow != null)
            {

                txtId.Text = dgv_deducciones.CurrentRow.Cells["Id"].Value.ToString();
                txtIsr.Text = dgv_deducciones.CurrentRow.Cells["ISR"].Value.ToString();
                txtAfp.Text = dgv_deducciones.CurrentRow.Cells["AFP"].Value.ToString();
                txtSegmed.Text = dgv_deducciones.CurrentRow.Cells["SEG_MED"].Value.ToString();
                txtSegsoc.Text = dgv_deducciones.CurrentRow.Cells["SEG_SOC"].Value.ToString();
                txtOtro.Text = dgv_deducciones.CurrentRow.Cells["OTROS_DESCUENTOS"].Value.ToString();
            }

        }
        public string ValidarDatos()
        {
            string Resultado = "";
            if (txtIsr.Text == "")
            {
                Resultado = Resultado + "ISR \n";
            }
            if (txtAfp.Text == "")
            {
                Resultado = Resultado + "AFP";

            }
            return Resultado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

                    
            try
            {

               string sResultado = ValidarDatos();
                if (sResultado == "")
                {
                    if (txtId.Text == "")
                    {
                        Ndeducciones n = new Ndeducciones();                      
                        n.ISR = Convert.ToDecimal(txtIsr.Text);
                        n.AFP = Convert.ToDecimal(txtAfp.Text);
                        n.SEG_MED = Convert.ToDecimal(txtSegmed.Text);
                        n.SEG_SOC = Convert.ToDecimal(txtSegsoc.Text);
                        n.OTROS_DESCUENTOS = Convert.ToDecimal(txtOtro.Text);


                        if (Cdeducciones.Guardar(n) > 0)
                        {

                            MessageBox.Show("Datos insertados correctamente");
                           Frm_TazaDeduciones_Load(null, null);

                        }
                    }
                    else
                    {
                        Ndeducciones n = new Ndeducciones();
                       // n.Id = Convert.ToInt32(txtId.Text);
                        n.ISR = Convert.ToDecimal(txtIsr.Text);
                        n.AFP = Convert.ToDecimal(txtAfp.Text);
                        n.SEG_MED = Convert.ToDecimal(txtSegmed.Text);
                        n.SEG_SOC = Convert.ToDecimal(txtSegsoc.Text);
                        n.OTROS_DESCUENTOS = Convert.ToDecimal(txtOtro.Text);

                       
                        if (Cdeducciones.Guardar(n)>0)
                        {

                            MessageBox.Show("Datos modificados correctamente");
                            Frm_TazaDeduciones_Load(null, null);

                        }
                    }
                }
                else {

                    MessageBox.Show("Falta cargar Datos: \n " + sResultado);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);


            }


        }


    }
}
