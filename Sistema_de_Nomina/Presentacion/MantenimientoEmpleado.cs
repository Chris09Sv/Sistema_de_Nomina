using Sistema_de_Nomina.Datos;
using Sistema_de_Nomina.ModeloDeDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Nomina.Presentacion
{
    public partial class MantenimientoEmpleado : Form
    {
        private DataTable dt;
        private static MantenimientoEmpleado _instancia = null;

        public MantenimientoEmpleado()
        {
            InitializeComponent();
        }
        public static MantenimientoEmpleado GetInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
                _instancia = new MantenimientoEmpleado();
            return _instancia;
        }


        private void Empleados_Click(object sender, EventArgs e)
        {
            G_Busqueda.Hide();
            G_Empleado.Show();
            cancelar();

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
        }

        private void BusquedaEmpleado_Click(object sender, EventArgs e)
        {
            G_Busqueda.Show();
            G_Empleado.Hide();
           // Limpiar();
            cancelar();
            try
            {
                DataSet ds = PEmpleados.Vista();
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Id"].Visible = false;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + error.StackTrace);
            }
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns[1].Visible = false;
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

//            errorProvider1.Clear();
          
            // this.Dispose();
            //Dispose();
        }

        private void B_Guardar_Click(object sender, EventArgs e)
        {
            
                if (T_Nombre.Text == "" || T_Apellido.Text == "" || T_Cedula.Text == "" || T_Direccion.Text == "" || T_Telefono.Text == "")
                {
                    MessageBox.Show("Complete los datos antes de continuar.");
                }
                else
                {
                    MessageBox.Show("Empleado registrado correctamente");

                    Empleados empleados = new Empleados();
                    //  empleados.Id;
                    empleados.Nombre = T_Nombre.Text;
                    empleados.Apellido = T_Apellido.Text;
                    empleados.Cedula = T_Cedula.Text;
                    empleados.Direccion = T_Direccion.Text;
                    empleados.Email = T_Correo.Text;
                    empleados.Telefono = T_Telefono.Text;
                    empleados.IdPuesto = Convert.ToInt32(C_Puesto.SelectedValue.ToString());
                    empleados.FechaDeNacimiento = DTP_FechaNacimiento.Value;
                    empleados.FechaDeContratacion = DTP_FechaIngreso.Value;
                    empleados.Sueldo = Convert.ToDecimal(T_Salario.Text);
                    empleados.EstadoCivil = T_EstadoCivil.Text;
                    empleados.Estado = T_Status.Text;
                    empleados.NoCuenta = Convert.ToInt32(T_NoCuenta.Text);

                    if (lbl_id.Text == "")
                    {
                        if (PEmpleados.Insertar(empleados) > 0)
                        {
                            MessageBox.Show("Empleado registrado correctamente");
                            Limpiar();
                            MantenimientoEmpleado_Load(null, null);

                        }
                    }
                    else
                    {
                        empleados.Id = Convert.ToInt32(lbl_id.Text);

                        if (PEmpleados.Modificar(empleados) == 1)
                        {
                            Limpiar();

                            MantenimientoEmpleado_Load(null, null);
                            MessageBox.Show("Empleado modificado Correctamente");
                        }
                    }

                }
            


         
        }

        private void T_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewCheckBoxCell checkEliminar = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells["Eliminar"];
            //checkEliminar.Value = !Convert.ToBoolean(checkEliminar.Value);
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
                lbl_id.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                T_Nombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                T_Apellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                T_Cedula.Text = dataGridView1.CurrentRow.Cells["Cedula"].Value.ToString();

                T_Direccion.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                T_Telefono.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                T_Correo.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells["Posicion"].Value.ToString();

                T_EstadoCivil.Text = dataGridView1.CurrentRow.Cells["Estado_Civil"].Value.ToString();
                DTP_FechaIngreso.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Fecha de ingreso"].Value);
                DTP_FechaNacimiento.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Fecha de nacimiento"].Value);

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
                if (MessageBox.Show("Esta Seguro de que desea Cancelar el Empleado Seleccionado?", "Cancelar Empleados", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {

                        if ((Convert.ToBoolean(row.Cells["Eliminar"].Value)))
                        {

                            Empleados empleados = new Empleados();
                            empleados.Id = Convert.ToInt32(row.Cells["Id"].Value);
                            if (PEmpleados.Eliminar(empleados) != 1)
                            {
                                MessageBox.Show("El empleado  no pudo ser cancelado", "Cancelar Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                            else
                            {
                                MantenimientoEmpleado_Load(null, null);
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
            T_NoCuenta.Text = "0";
            T_Salario.Text = "0";
            comboBox1.Text = "Nombre";

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
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
             
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
                dv.RowFilter = comboBox1.Text + " Like '%" + T_Buscar.Text + "%'";
                dataGridView1.DataSource = dv;
            }
            catch
            {

            }
        }

        private void T_Apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void T_Correo_TextChanged(object sender, EventArgs e)
        {

        }

        private void G_Empleado_Enter(object sender, EventArgs e)
        {

        }

        private void B_Nuevo_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Limpiar()
        {
            T_Nombre.Text = "";
            T_Apellido.Text = "";
            T_Cedula.Text = "";
            T_Direccion.Text = "";
            T_Correo.Text = "";
            T_Telefono.Text = "";
            //  Convert.ToInt32(C_Puesto.SelectedValue.ToString());

            T_Salario.Text = "";

            T_NoCuenta.Text = "";
            errorProvider1.Clear();
        }

        private void T_Status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void B_Eliminar_Click_1(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void T_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                L_Error.ForeColor = System.Drawing.Color.Red;
                L_Error.Text = "Solo se permiten letras";
                //ErrorProvider ep; ep.Icon = SystemIcons.Error;
                //ep.SetError(e, "Solo se admiten Letras");

            }
        }

        private void T_Nombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(T_Nombre.Text))
            {
            //    e.Cancel = true;
                T_Nombre.Focus();
                errorProvider1.SetError(T_Nombre, "Por favor introduzca el nombre del empleado");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(T_Nombre, null);
            }
        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void T_Cedula_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(T_Cedula.Text))
            {
            //    e.Cancel = true;
                T_Cedula.Focus();
                errorProvider1.SetError(T_Cedula, "Por favor introduzca la cedula del empleado");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(T_Cedula, null);
            }
        }
        //   public change;
        //   public static void soloLetrasPermitirNumeros(TextBox txt, bool EsCampoObligatorio, Label lblError, ErrorProvider ep, int charPermitidos)

        private void T_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar )|| char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                OnTabIndexChanged(e);
            }
            else
            {
                e.Handled = true;
            }            //  charSoloNumerosDecimal(T_Cedula, valor, L_Cedula, errorProvider1);
            ValidarCampo.soloNumeros(T_Cedula, e,true, L_Cedula, errorProvider1, 11);
        }

        private void T_Cedula_TextChanged(object sender, EventArgs e)
        {
            //     T_Cedula_KeyPress(null, null);
        }
        public static void charSoloNumerosDecimal(TextBox txt, KeyPressEventArgs valor, Label lblError, ErrorProvider ep)
        {

            if (!string.IsNullOrEmpty(txt.Text))
            {
                if (char.IsDigit(valor.KeyChar))
                {
                    valor.Handled = false;
                }
                else if (char.IsSeparator(valor.KeyChar))
                {
                    valor.Handled = false;
                }
                else if (char.IsControl(valor.KeyChar))
                {
                    valor.Handled = false;
                }
                else if (valor.KeyChar.ToString().Equals("."))
                {
                    valor.Handled = false;
                }
                else //Si el TextBox esta vacio, y quedo visualizando la ultima advertencia..
                {
                    valor.Handled = true;
                    //Mostrar Label debajo del campo con texto de error en rojo y el Error Provider
                    lblError.Visible = true;
                    lblError.ForeColor = System.Drawing.Color.Red;
                    lblError.Text = "Recuerda que debes ingresar solamente numeros decimales";
                    ep.Icon = SystemIcons.Error;
                    ep.SetError(txt, "Solo se admiten Numeros decimales");
                }
            }
            else //Si el TextBox esta vacio, y quedo visualizando la ultima advertencia...
            {
                //Se limpia el label de error y el Error Provider cuando se ingrese texto      
                lblError.Visible = false;
                ep.Clear();

            }


        }

        private void T_Telefono_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(T_Telefono.Text))
            {
             //   e.Cancel = true;
                T_Telefono.Focus();
                errorProvider1.SetError(T_Telefono, "Por favor introduzca el telefono del empleado");
                L_Telefono.ForeColor = Color.Red;
                L_Telefono.Text = "Por favor introduzca el telefono del empleado";
            }
            else if (T_Telefono.TextLength > 11 || T_Telefono.TextLength < 11)
            {
              //  e.Cancel = true;
                T_Telefono.Focus();
                errorProvider1.SetError(T_Telefono, "Por favor introduzca un numero de telefono valido");
                L_Telefono.ForeColor = Color.Red;
                L_Telefono.Text = "Por favor introduzca un numero de telefono valido";
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(T_Telefono, null);
            }
        }

        private void T_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {

            ValidarCampo.soloNumeros(T_Telefono,e, true, L_Telefono, errorProvider1, 11);
        }

        private void T_Salario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCampo.charSoloNumerosDecimal(T_Salario, e, L_Salario, errorProvider1);
            ValidarCampo.soloNumerosDecimales(T_Salario, e, errorProvider1);
         
        }

        private void T_Salario_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(T_Salario.Text))
            {
            //    e.Cancel = true;
                T_Salario.Focus();
                L_Salario.ForeColor = Color.Red;

                L_Salario.Text = "Por favor introduzca el salario del empleado";
                errorProvider1.SetError(T_Salario, "Por favor introduzca el salario del empleado");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(T_Salario, null);
            }
        }

        private void T_Apellido_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(T_Apellido.Text))
            {
               // e.Cancel = true;
                T_Apellido.Focus();
                errorProvider1.SetError(T_Apellido, "Por favor introduzca el apellido del empleado");
                L_Apellido.ForeColor = Color.Red;
                L_Apellido.Text = "Por favor introduzca el apellido del empleado";
            }
      
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(T_Apellido, null);
            }
        }
        
        private void T_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCampo.charSoloLetras(T_Apellido,e,  L_Apellido, errorProvider1);
        }

        private void T_Correo_Validating(object sender, CancelEventArgs e)
        {


            if (validarEmail(T_Correo.Text) == false)
            {
                errorProvider1.SetError(T_Correo, "Correo no valido");
               // e.Cancel = true;
                T_Correo.Focus();
                L_Correo.ForeColor = Color.Red;
                L_Correo.Text = "Correo no valido";
            }
            else
            {
        e.Cancel = false
                    ;
               // T_Correo.Focus();
                L_Correo.Visible = false;
            }
                            
            //if (!string.IsNullOrEmpty(T_Correo.Text))
            //{
            //    if (ValidarCampo.validarEmail(T_Correo))
            //    {
            //        L_Correo.ForeColor = Color.Green;
            //        L_Correo.Text = "Bien";
            //    }
            //    else
            //    {

            //        errorProvider1.SetError(T_Correo, "Correo no valido");
            //        e.Cancel = true;
            //        T_Correo.Focus();
            //        L_Correo.ForeColor = Color.Red;
            //        L_Correo.Text = "Correo no valido";
            //    }
            //}
            //else
            //{

            //    errorProvider1.SetError(T_Correo, "Correo no valido");
            //    e.Cancel = true;
            //    T_Correo.Focus();
            //    L_Correo.ForeColor = Color.Red;
            //    L_Correo.Text = "Correo no valido";
            //}
        }

        private void T_Correo_KeyPress(object sender, KeyPressEventArgs e)
        {
         

        }
         
        private void Button1_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - DTP_FechaNacimiento.Value.Year;

            if (DTP_FechaNacimiento.Value > hoy)
            {
                L_Fecha_Nacimiento.Text = "Debe ser mayor de 18 "+edad;
            }
            else
            {
                L_Fecha_Nacimiento.Text =edad.ToString() ;

            }

        }
        public bool validarEmail(string email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }



        }

        private void DTP_FechaNacimiento_Validating(object sender, CancelEventArgs e)
        {
            //if (DTP_FechaNacimiento.Value.AddYears(18) > DateTime.Today)

            //    MessageBox.Show(DTP_FechaNacimiento.Value.AddYears(18).ToShortDateString() );
        }

        private void DTP_FechaIngreso_Validating(object sender, CancelEventArgs e)
        {

            //DateTime hoy = DateTime.Today;
            //if (DTP_FechaIngreso.Value== hoy || DTP_FechaIngreso.Value.Month==hoy.Month)
            //{
          
            //    L_FechaIngreso.ForeColor = Color.Green;
            //}
            //else
            //{
            //    e.Cancel = true;

            //    errorProvider1.SetError(DTP_FechaIngreso, "Fecha no valida");
            //    DTP_FechaIngreso.Focus();
            //    L_FechaIngreso.ForeColor = Color.Red;
            //    L_FechaIngreso.Text = " fecha no valida";
            //}
        }

        private void T_NoCuenta_Validating(object sender, CancelEventArgs e)
        {

        }

        private void T_NoCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            ValidarCampo.charSoloNumerosEnteros(T_NoCuenta, e, L_Numero_Cuenta, errorProvider1);
            
        }

        private void T_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCampo.soloLetrasPermitirNumeros(T_Direccion, true, L_Direccion, errorProvider1, 50);
        }

        private void T_Direccion_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(T_Direccion.Text))
            {
                T_Direccion.Focus();
                errorProvider1.SetError(T_Apellido, "Por favor introduzca el apellido del empleado");
                L_Direccion.ForeColor = Color.Red;
                L_Direccion.Text = "Por favor introduzca el apellido del empleado";
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(L_Direccion, null);
            }
        }
        public void cancelar()
        {
            lbl_id.Text = "";
            T_Nombre.Clear(); T_Apellido.Clear(); T_Direccion.Clear(); T_Correo.Clear(); T_Telefono.Clear(); C_Puesto.Text = "Indique la posicion"; T_Cedula.Clear();
            T_Salario.Text = "0"; T_NoCuenta.Text = "0";
            errorProvider1.Clear();
        }
        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            Empleados_Click(null, null);
            MantenimientoEmpleado_Load(null, null);
            cancelar();
            Limpiar();
            errorProvider1.Clear();
            


           


        }

        private void DTP_FechaIngreso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            G_Busqueda.Show();
            G_Empleado.Hide();
            try
            {
                DataSet ds = PEmpleados.VistaInactivos();
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + error.StackTrace);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
              