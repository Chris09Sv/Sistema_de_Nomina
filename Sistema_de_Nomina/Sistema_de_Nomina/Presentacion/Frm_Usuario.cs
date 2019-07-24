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
    public partial class Frm_Usuario : Form
    {
        private static DataTable dt = new DataTable();
        public Frm_Usuario()
        {
            InitializeComponent();
        }

        public string ValidarDatos()
        {
            string Resultado = "";
            if (txtNombre.Text == "")
            {
                Resultado = Resultado + "Nombre \n";
            }
            if (txtUsuario.Text == "")
            {
                Resultado = Resultado + "Usuario\n";
            }
            if (txtContresena.Text == "")
            {
                Resultado = Resultado + "Contraseña \n";
            }

            return Resultado;
        }
        public void MostrarGuardarCancelar(bool b)
        {
            btnGuardar.Visible = b;
            btnCancelar.Visible = b;
            btnEditar.Visible = !b;
            btnEliminar.Visible = !b;
            btnNuevo.Visible = !b;

            dgv_usuarios.Enabled = !b;
            txtNombre.Enabled = b;
            txtContresena.Enabled = b;
            txtUsuario.Enabled = b;


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            try
            {
                string sResultado = ValidarDatos();
                if (txtContresena.TextLength >= 8)
                {

                    if (sResultado == "")
                    {
                        if (txtId.Text == "")
                        {

                            login.Nombre = txtNombre.Text;

                            login.Usuario = txtUsuario.Text;
                            login.Contraseña = txtContresena.Text;

                            if (DUsuario.Insertar(login) > 0)
                            {
                                MessageBox.Show("Datos insertados correctamente");
                                Frm_Usuario_Load(null, null);
                            }
                        }
                        else
                        {

                            login.Id = Convert.ToInt32(txtId.Text);
                            login.Nombre = txtNombre.Text;

                            login.Usuario = txtUsuario.Text;
                            login.Contraseña = txtContresena.Text;


                            // MessageBox.Show("" + login.Nombre + " " + login.Id + login.Contraseña);

                            if (DUsuario.Actualizar(login) > 0)
                            {
                                MessageBox.Show("Datos modificados correctamente");
                                Frm_Usuario_Load(null, null);
                            }
                        }

                    }
                    else
                    {

                        MessageBox.Show("Faltan cargar Datos: \n" + sResultado);
                    }
                }

                else
                {
                    MessageBox.Show("La contraseña debe ser superior a 8 caracteres");
                }
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Frm_Usuario_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = DUsuario.GetAll();
                dt = ds.Tables[0];
                dgv_usuarios.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    lblDatosNoEncontrados.Visible = false;
                    dgvUsuario_CellClick(null, null);
                }
                else
                {
                    lblDatosNoEncontrados.Visible = true;

                }


                MostrarGuardarCancelar(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);

            txtId.Text = "";
            txtNombre.Text = "";
            txtUsuario.Text = "";
            txtContresena.Text = "";

        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);
            dgv_usuarios_CellClick(null, null);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(false);
            dgv_usuarios_CellClick(null, null);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
        }

        private void dgv_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgv_usuarios.CurrentRow != null)
            {

                txtId.Text = dgv_usuarios.CurrentRow.Cells["Id"].Value.ToString();
                txtNombre.Text = dgv_usuarios.CurrentRow.Cells["Nombre"].Value.ToString();

                txtUsuario.Text = dgv_usuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                txtContresena.Text = dgv_usuarios.CurrentRow.Cells["Contraseña"].Value.ToString();

            }
        }

        private void dgv_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_usuarios.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ckEliminar = (DataGridViewCheckBoxCell)dgv_usuarios.Rows[e.RowIndex].Cells["Eliminar"];
                ckEliminar.Value = !Convert.ToBoolean(ckEliminar.Value);

            }

        }

        private void txtContresena_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Realmente desea eliminar los usuario seleccionados?", "Eliminacion de usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dgv_usuarios.Rows)
                    {


                        if (Convert.ToBoolean(row.Cells["Eliminar"].Value))
                        {

                            Login login = new Login();
                            login.Id = Convert.ToInt32(row.Cells["Id"].Value);
                            if (DUsuario.Eliminar(login) > 1)
                            {
                                MessageBox.Show("El cliente no pudo ser eliminado", "Eliminacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                    }
                    Frm_Usuario_Load(null, null);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }
    }
}