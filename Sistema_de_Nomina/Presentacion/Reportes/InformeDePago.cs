using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Nomina.Presentacion.Reportes
{
    public partial class InformeDePago : Form
    {
        public InformeDePago()
        {
            InitializeComponent();
        }

        private void InformeDePago_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportes.PagoDeNomina' table. You can move, or remove it, as needed.
            this.pagoDeNominaTableAdapter.Fill(this.reportes.PagoDeNomina,2);
            // TODO: This line of code loads data into the 'reportes.PagoDeNomina' table. You can move, or remove it, as needed.
            //this.pagoDeNominaTableAdapter.Fill(this.reportes.PagoDeNomina,2);

            this.reportViewer1.RefreshReport();
        }
    }
}
