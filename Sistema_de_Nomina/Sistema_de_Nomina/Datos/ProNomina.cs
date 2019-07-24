using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Nomina.Datos
{
  public  class ProNomina
    {
        public static DataSet VistaDeNomina()
        {
            SqlParameter[] dbparametro = new SqlParameter[]
            {

            };
            return Conexiones.ExecuteDataSet("store_Vista_nomina", dbparametro);


        }
    }
}
