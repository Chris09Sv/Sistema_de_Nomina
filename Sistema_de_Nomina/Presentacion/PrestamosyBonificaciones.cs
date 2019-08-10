using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Nomina.Datos;
using Sistema_de_Nomina.ModeloDeDatos;


namespace Sistema_de_Nomina.Presentacion
{
    public partial class PrestamosyBonificaciones : Form
    {
        public PrestamosyBonificaciones()
        {
            InitializeComponent();
        }
        private int IdEmpleado = 0;
        private int CuentaP = 0;


        public void setEmpleao(string cuenta,string Id,string Nombre, string apellido, string salario,string Cantidad)
        {
            MessageBox.Show(cuenta);
            if (cuenta == "" || string.IsNullOrWhiteSpace(cuenta))
            {
                CuentaP = 0;
            }
            else { CuentaP = Convert.ToInt32(cuenta); } 
            IdEmpleado =Convert.ToInt32( Id);
            T_Nombre.Text = Nombre + " " + apellido;
            T_Salario.Text = salario.ToString();
        //    T_NuevaCantidad.Text=NuevaCantidad.ToString();
            T_Cantidad.Text=Cantidad.ToString();
            if (T_Cantidad.Text != "0" )
            {
                T_NuevaCantidad.Visible = true;
                T_Cantidad.Enabled = false; 

            }

        }
        public static PrestamosyBonificaciones _instancia = null;
        public static PrestamosyBonificaciones GetInstancia()
        {
            if (_instancia == null)
                _instancia = new PrestamosyBonificaciones();
            return _instancia;

        }
        private void Button3_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        private bool flag = false;
        private void Button1_Click(object sender, EventArgs e)
        {
            frmpro fm = new frmpro();

            Vista m = new Vista();

            m.setFlag(true);
            Hide();
            m.ShowDialog();

            //PrestamosyBonificaciones p = new PrestamosyBonificaciones();
            //p.MdiParent = this;
            //p.Show();
            //pbMenu_Click(null, null);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Prestamos_y_Bonificaciones P = new Prestamos_y_Bonificaciones();

            P.IdEmpleado1 = IdEmpleado;


            P.Prestamo1 = prestamo;
            P.Cuota1 = Convert.ToDecimal(T_Cuota.Text);
            P.Interes1 = Convert.ToDecimal(T_Interes.Text);
            P.Meses = Convert.ToInt32(comboBox1.Text);
            P.Fecha1 = Convert.ToDateTime(T_Fecha.Text);
            decimal salario = Convert.ToDecimal(T_Salario.Text);
            if (P.Cuota1 >= salario / 2)
            {
                MessageBox.Show("El prestamo excede la capacidad de pagar del empleado");
            }
            else
            {

                if(CuentaP==0)
                {
                    if (PrPrestamos_Y_Bonificaciones.Insertar(P) > 0)
                    {
                        MessageBox.Show("Prestamo Registrado ");
                        //MenuPrincipal m = new MenuPrincipal();
                        //m.Show();

                        this.Close();
                    }
                }
                else
                {
                    P.Id = CuentaP;
                    if (PrPrestamos_Y_Bonificaciones.Update(P) > 0)
                    {
                        MessageBox.Show("Prestamo actualizado ");
                        //MenuPrincipal m = new MenuPrincipal();
                        //m.Show();

                        this.Close();
                    }

                }
               
            }
        }
        private decimal prestamo;
        private decimal cuota;
        private decimal duracion;


        private void T_Cantidad_TextChanged(object sender, EventArgs e)
        {
            //T_Cuota.Text;


        }

        private void T_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        

       }

        private void T_Salario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void Duracion_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  T_Cantidad_TextChanged(null,null);
            if (T_Cantidad.Text != "")
            {
              //  if(T_NuevaCantidad.Text!=0)
                prestamo = Convert.ToDecimal(T_Cantidad.Text)+Convert.ToDecimal(T_NuevaCantidad.Text);
                duracion = Convert.ToDecimal(comboBox1.Text);

                cuota = prestamo / duracion;

                T_Cuota.Text = decimal.Round(cuota, 2, MidpointRounding.AwayFromZero).ToString();
            }
        }

        private void PrestamosyBonificaciones_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }

        }
    }
}
