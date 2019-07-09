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

namespace Sistema_de_Nomina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void B_Guardar_Click(object sender, EventArgs e)
        {
            Empleados ep = new Empleados();
            ep.Nombre = T_Nombre.Text;
            ep.Apellido = T_Apellido.Text;
            ep.Cedula = T_Cedula.Text;
            ep.Direccion = T_Direccion.Text;
            ep.Email = T_Email.Text;
            ep.Telefono = T_Telefono.Text;
            ep.FechaDeNacimiento = T_FechaDeNacimiento.Value;
            ep.FechaDeContratacion = T_FechaDeContratacion.Value;
            ep.Puesto = T_Puesto.Text;
          //  ep.Departamento = T_Departamento.Text;
          //  ep.Sueldo = Convert.ToByte(T_Sueldo.Text);

            if (PEmpleados.Insertar(ep) > 0)
            {
                MessageBox.Show("Datos insertados correctamente!");
            }
        }
    }
}
