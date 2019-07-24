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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            DataSet ds =Plogin.ValidarLogin (txtUsuario.Text, txtContraseña.Text);
            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count > 0)
            {
                Login login = new Login();
                login.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                //Usuario.Nombre = dt.Rows[0]["Nombre"].ToString();
                //Usuario.Apellido = dt.Rows[0]["Apellido"].ToString();
                //Usuario.Tipo = dt.Rows[0]["Tipo"].ToString();
                login.Usuario = dt.Rows[0]["Usuario"].ToString();
                login.Contraseña = dt.Rows[0]["Contraseña"].ToString();
                // if (Login.Tipo == "Administrador")
                //  {
              frmpro f1 = new frmpro();
                f1.Show();
              this.Hide();
                //  }
                // else
                //{
                //Form2 f = new Form2();
                // f.Show();
                // this.Hide();

                // }




            }
            else
            {

                MessageBox.Show("Usuario y/o contraseña incorrecta");
                txtContraseña.Text = "";
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (txtContraseña.PasswordChar == '*')
                {
                    txtContraseña.PasswordChar = '\0';


                }
                else {


                    txtContraseña.PasswordChar = '*';
                }


            }
        }
    }
}
