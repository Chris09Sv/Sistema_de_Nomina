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
    public partial class R23 : Form
    {
        public R23()
        {
            InitializeComponent();
        }
        //DETALLE DE NOMINA

            public void GetNomina(int nomina)
        {
            T_IDNomina.Text = nomina.ToString();
        }

        private void R23_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportes._ver_nominaD' table. You can move, or remove it, as needed.
            this._ver_nominaDTableAdapter.Fill(this.reportes._ver_nominaD,Convert.ToInt32(T_IDNomina.Text));

            this.reportViewer1.RefreshReport();
        }
    }
}
