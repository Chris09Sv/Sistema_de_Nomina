﻿using System;
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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void EMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoEmpleado empleado = new MantenimientoEmpleado();
            empleado.Show();
            this.Hide();
        }

        private void DEPARTAMENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoDepartamento m = new MantenimientoDepartamento();
            m.Show();
            this.Hide();
        }

        private void NOMINADEPAGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento_de__nomina mn = new Mantenimiento_de__nomina();
            mn.Show();
            this.Hide();

        }

        private void hISTORIALDENOMINAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusquedaNomina b = new BusquedaNomina();
            b.Show();
        }
    }
}
