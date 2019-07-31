using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Nomina.Datos
{
    public class Cdeducciones
    {
        public static DataSet Desc()
        {
            SqlParameter[] dbparams = new SqlParameter[]
            {

            };
            return Conexiones.ExecuteDataSet("stpverdes", dbparams);
        }
        public static DataSet verdes()
        {
            SqlParameter[] dbparametro = new SqlParameter[]
            {

            };
            return Conexiones.ExecuteDataSet("stpverdes", dbparametro);


        }
        public static int Guardar(Ndeducciones guard)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                                Conexiones.MakeParam("@Id",SqlDbType.Int,0,guard.Id),

                              Conexiones.MakeParam("@ISR",SqlDbType.Decimal,0,guard.ISR),

                              Conexiones.MakeParam("@AFP",SqlDbType.Decimal,0,guard.AFP),
                              Conexiones.MakeParam("@SEG_MED",SqlDbType.Decimal,0,guard.SEG_MED),
                              Conexiones.MakeParam("@SEG_SOC",SqlDbType.Decimal,0,guard.SEG_SOC),
                              Conexiones.MakeParam("@OTROS_DESCUENTOS",SqlDbType.Decimal,0,guard.OTROS_DESCUENTOS),




            };
            return Convert.ToInt32(Conexiones.ExecuteScalar("stp_guardardesc", dbParams));
        }

        public static int Modificar(Ndeducciones deduccion)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                                Conexiones.MakeParam("@Id",SqlDbType.Int,0,deduccion.Id),

                              Conexiones.MakeParam("@ISR",SqlDbType.Decimal,0,deduccion.ISR),

                              Conexiones.MakeParam("@AFP",SqlDbType.Decimal,0,deduccion.AFP),
                              Conexiones.MakeParam("@SEG_MED",SqlDbType.Decimal,0,deduccion.SEG_MED),
                              Conexiones.MakeParam("@SEG_SOC",SqlDbType.Decimal,0,deduccion.SEG_SOC),
                              Conexiones.MakeParam("@OTROS_DESCUENTOS",SqlDbType.Decimal,0,deduccion.OTROS_DESCUENTOS),




            };
            return Convert.ToInt32(Conexiones.ExecuteScalar("stp_actualizardesc", dbParams));
        }
    }
}

