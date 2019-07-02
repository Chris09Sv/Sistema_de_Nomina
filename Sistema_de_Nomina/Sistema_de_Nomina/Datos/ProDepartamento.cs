using Sistema_de_Nomina.ModeloDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Nomina.Datos
{
    public class ProDepartamento
    {

        public static DataSet VistaDepartamento()
        {
            SqlParameter[] dbparametro = new SqlParameter[]
            {

            };
            return Conexiones.ExecuteDataSet("store_Vista_Departamento", dbparametro);
               

        }
        public static int NuevoDepartamento(Departamentos dept)
        {
            SqlParameter[] dbparametro = new SqlParameter[]
            {
                Conexiones.MakeParam("@Departamento",SqlDbType.VarChar,0,dept.Departamento)
         

            };
            return Convert.ToInt32(Conexiones.ExecuteScalar("store_Nuevo_Departamento", dbparametro));
        }

        public static int NuevaPosicion(Posiciones posiciones)
        {
            SqlParameter[] dbparametro = new SqlParameter[]
            {

                Conexiones.MakeParam("@Posicion",SqlDbType.VarChar,0,posiciones.Posicion),

                Conexiones.MakeParam("@Id",SqlDbType.Int,0,posiciones.IdDepartamento)


            };
            return Convert.ToInt32(Conexiones.ExecuteScalar("store_Nueva_Posicion", dbparametro));
        }
    }
}
