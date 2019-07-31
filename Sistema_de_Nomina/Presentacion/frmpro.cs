﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.Runtime.InteropServices;

namespace Sistema_de_Nomina.Presentacion
{
    public partial class frmpro : Form
    {
        public frmpro()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            if (pnMenu.Width == 310)
            {
                pnMenu.Width = 70;
            }
            else { pnMenu.Width = 310; }
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMaximixar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {

                this.WindowState = FormWindowState.Normal;

            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

        }

        private void pbMinimixar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void pbMaximixar_DoubleClick(object sender, EventArgs e)
        {
          
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmpro_Load(object sender, EventArgs e)
        {
            btnDepartamento.Visible = false;
            btnEmpleados.Visible = false;
            btnUsuario.Visible = false;
            btnHistorial.Visible = false;
            btnEmpleado.Visible = false;
            btnNomina_Pago.Visible = false;
            btnCuentas_por_Cobrar.Visible = false;
            B_VerCuentas.Visible = false;
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
                btnDepartamento.Visible = true;
                btnEmpleados.Visible = true;
                btnUsuario.Visible = true;
             
            btnHistorial.Visible = false;
            btnEmpleado.Visible = false;
            btnNomina_Pago.Visible = false;
            btnCuentas_por_Cobrar.Visible = false;
            B_VerCuentas.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnDepartamento.Visible = false;
            btnEmpleados.Visible = false;
            btnUsuario.Visible = false;

            btnNomina_Pago.Visible = false;
            btnHistorial.Visible = false;
            btnEmpleado.Visible = false;
            btnEmpleados.Visible = false;
            btnCuentas_por_Cobrar.Visible = true;
            B_VerCuentas.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnNomina_Pago.Visible = true;
            btnHistorial.Visible = true;
            btnEmpleado.Visible = true;
            btnDepartamento.Visible = false;
            btnEmpleados.Visible = false;
            btnUsuario.Visible = false;
            btnCuentas_por_Cobrar.Visible = false;
            B_VerCuentas.Visible = false; ;

        }

        private void btnTazaDeducciones_Click(object sender, EventArgs e)
        {
            btnNomina_Pago.Visible = false;
            btnHistorial.Visible = false;
            btnEmpleado.Visible = false;
            btnDepartamento.Visible = false;
            btnEmpleados.Visible = false;
            btnUsuario.Visible = false;
            btnCuentas_por_Cobrar.Visible = false;
            B_VerCuentas.Visible = true;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pnMenu.Width == 70)
            {
                pnMenu.Width = 310;
            }
            









            btnDepartamento.Visible = true;
            btnEmpleados.Visible = true;
            btnUsuario.Visible = true;

            btnHistorial.Visible = false;
            btnEmpleado.Visible = false;
            btnNomina_Pago.Visible = false;
            btnCuentas_por_Cobrar.Visible = false;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pnMenu.Width == 70)
            {
                pnMenu.Width = 310;
            }
            
            btnNomina_Pago.Visible = true;
            btnHistorial.Visible = true;
            btnEmpleado.Visible = true;
            btnDepartamento.Visible = false;
            btnEmpleados.Visible = false;
            btnUsuario.Visible = false;
            btnCuentas_por_Cobrar.Visible = false;


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pnMenu.Width == 70)
            {
                pnMenu.Width = 310;
            }

            btnDepartamento.Visible = false;
            btnEmpleados.Visible = false;
            btnUsuario.Visible = false;

            btnNomina_Pago.Visible = false;
            btnHistorial.Visible = false;
            btnEmpleado.Visible = false;
            btnEmpleados.Visible = false;
            btnCuentas_por_Cobrar.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pnMenu.Width == 70)
            {
                pnMenu.Width = 310;
            }

            btnNomina_Pago.Visible = false;
            btnHistorial.Visible = false;
            btnEmpleado.Visible = false;
            btnDepartamento.Visible = false;
            btnEmpleados.Visible = false;
            btnUsuario.Visible = false;
            btnCuentas_por_Cobrar.Visible = false;
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
             
            MantenimientoEmpleado empleado = new MantenimientoEmpleado();
            empleado.MdiParent = this;
            empleado.Show();
            
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            MantenimientoDepartamento m = new MantenimientoDepartamento();
            m.MdiParent = this;
            m.Show();
           
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
           


        }

        private void btnNomina_Pago_Click(object sender, EventArgs e)
        {
            Mantenimiento_de__nomina m = new Mantenimiento_de__nomina();
            m.MdiParent = this;
            m.Show();
            pbMenu_Click(null, null);
        }

        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            BusquedaNomina b = new BusquedaNomina();
            b.MdiParent = this;
            b.Show();
            pbMenu_Click(null, null);

        }

        private void BtnEmpleado_Click(object sender, EventArgs e)
        {
            NominaEmpleado es = new NominaEmpleado();
            es.MdiParent = this;
            es.Show();
        }

        private void BtnCuentas_por_Cobrar_Click(object sender, EventArgs e)
        {
            PrestamosyBonificaciones p = new PrestamosyBonificaciones();
            p.MdiParent = this;
            p.Show();
        }
    }
}