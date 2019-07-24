using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Nomina.Datos
{
   public  class Plogin
    {
        public static DataSet ValidarLogin(string sUsuario, string sContraseña)
        {


            SqlParameter[] dbParams = new SqlParameter[]
                {Conexiones.MakeParam("@Usuario",SqlDbType.VarChar,0,sUsuario),
                Conexiones.MakeParam("@Contraseña",SqlDbType.VarChar,0,sContraseña)
                };

            return Conexiones.ExecuteDataSet("usp_PLogin_ValidarLogin", dbParams);



        }

    }
}
