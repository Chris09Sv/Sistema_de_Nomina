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
        public static DataSet VistaDeNomina( Nomina nomina)
        {
            SqlParameter[] dbparametro = new SqlParameter[]
            {
                                Conexiones.MakeParam("@dollar",SqlDbType.Decimal,0,nomina.Dollar)

            };
            return Conexiones.ExecuteDataSet("_cargar_nomina3", dbparametro);


        }
      //  @dollar decimal (18,2),@usuario int,@Estatus varchar(50),@fecha date


        public static int GuardarNomina(Nomina nomina)
        {
            SqlParameter[] dbparametro = new SqlParameter[]
            {
          //Conexiones.MakeParam("@IdNomina",SqlDbType.Int,0,nomina.IdNomina),

             Conexiones.MakeParam("@dollar",SqlDbType.Decimal,0,nomina.Dollar),
             Conexiones.MakeParam("@usuario",SqlDbType.Int,0,nomina.Usuario1),

          Conexiones.MakeParam("@Estatus",SqlDbType.Int,0,nomina.Estatus1),
          Conexiones.MakeParam("@fecha",SqlDbType.Int,0,nomina.Fecha1),


            };
            return Convert.ToInt32(Conexiones.ExecuteScalar("_Guardar_Nomina", dbparametro));
        }
    }
}
