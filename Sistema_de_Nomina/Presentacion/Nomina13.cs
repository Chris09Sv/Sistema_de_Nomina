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
    public partial class Nomina13 : Form
    {
        public Nomina13()
        {
            InitializeComponent();
        }

        private void Nomina13_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistema_de_NominaDataSet3._store_nomina_13' table. You can move, or remove it, as needed.
            this._store_nomina_13TableAdapter1.Fill(this.sistema_de_NominaDataSet3._store_nomina_13);

        }

        private void B_Guardar_Click(object sender, EventArgs e)
        {

            if (DateTime.Today.Month == 12)
            {
                MessageBox.Show("Aun no esta permitido generar la nomina de regalia " + "dias");

            }
            else
            { Nomina n = new Nomina();


            n.Dollar = Convert.ToDecimal(T_Dollar.Text);

            n.Usuario1 = Convert.ToInt32(T_Usuario.Text);
            n.Estatus1 = "Nomina Numero 13";
            n.Fecha1 = DateTime.Today;
            n.Fecha2 = DTP_FechaNomina.Value;
                // ProNomina.GuardarNomina(n);

                if (MessageBox.Show("Esta seguro que desea cerrar la nomina #" + DateTime.Today.Month + "? ", "Registrar Nomina ", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) == DialogResult.OK)
                {

                }
                else
                {


                    //   if(CBX_Estatus.Text==)
                    if (ProNomina.GuardarNomina(n) > 0)
                        MessageBox.Show("la nomina se ha registrado correctamente");
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        DetalleNomina dn = new DetalleNomina();
                        Prestamos_y_Bonificaciones p = new Prestamos_y_Bonificaciones();



                        dn.Id_Empleado = Convert.ToInt32(row.Cells["Id"].Value.ToString());
                        dn.IdNomina = Convert.ToInt32(t_IdNomina.Text);
                        //   p.Meses = Convert.ToInt32(t_IdNomina.Text);
                        dn.AFP = 0;
                        dn.Seg_Med = 0;
                        dn.Sueldo_neto = Convert.ToDecimal(row.Cells["salario"].Value.ToString());
                        dn.Salario = Convert.ToDecimal(row.Cells["salario"].Value.ToString());

                        dn.ISR = 0;
                        dn.Otros = 0;
                        p.Cuota1 = 0;
                        if (p.Cuota1 > 0)
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
                }
            }


        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

