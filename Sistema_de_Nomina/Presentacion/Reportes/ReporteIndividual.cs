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
    public partial class ReporteIndividual : Form
    {
        public ReporteIndividual()
        {
            InitializeComponent();
        }
        public void getID(int idNomina, int idEmpleado)
        {
            T_IdEmpleado.Text = idEmpleado.ToString();
            T_IdNomina.Text = idNomina.ToString();

        }
        private void ReporteIndividual_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportes._Ver_Nomina_individual' table. You can move, or remove it, as needed.
            this._Ver_Nomina_individualTableAdapter.Fill(this.reportes._Ver_Nomina_individual,Convert.ToInt32(T_IdEmpleado.Text),Convert.ToInt32(T_IdNomina.Text));

            this.reportViewer1.RefreshReport();
        }
    }
}
