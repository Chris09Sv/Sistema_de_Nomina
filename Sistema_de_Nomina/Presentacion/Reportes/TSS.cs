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
    public partial class TSS : Form
    {
        public TSS()
        {
            InitializeComponent();
        }

        private void TSS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportes._Reporte_Tss' table. You can move, or remove it, as needed.
           // this._Reporte_TssTableAdapter.Fill(this.reportes._Reporte_Tss);
            // TODO: This line of code loads data into the 'reportes._Reporte_Tss' table. You can move, or remove it, as needed.
            this._Reporte_TssTableAdapter.Fill(this.reportes._Reporte_Tss);

            this.reportViewer1.RefreshReport();
        }

        private void ReportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
