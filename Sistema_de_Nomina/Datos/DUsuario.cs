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
    public class DUsuario
    {



        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {

               };
            return Conexiones.ExecuteDataSet("usp_ver_Usuario", dbParams);

        }



        public static int Insertar(Login login)
        {


            SqlParameter[] dbParams = new SqlParameter[]
                {
                        Conexiones.MakeParam("@Nombre",SqlDbType.VarChar,0,login.Nombre),
                         Conexiones.MakeParam("@Usuario",SqlDbType.VarChar,0,login.Usuario),
                     Conexiones.MakeParam("@Contraseña",SqlDbType.VarChar,0,login.Contraseña),


                };
            return Convert.ToInt32(Conexiones.ExecuteScalar("usp_Insertar_Usuario", dbParams));



        }

        public static int Actualizar(Login login)

        {


            SqlParameter[] dbParams = new SqlParameter[]
                {  Conexiones.MakeParam("@Id",SqlDbType.VarChar,0,login.Id),
                        Conexiones.MakeParam("@Nombre",SqlDbType.VarChar,0,login.Nombre),

                         Conexiones.MakeParam("@Usuario",SqlDbType.VarChar,0,login.Usuario),
                     Conexiones.MakeParam("@Contraseña",SqlDbType.VarChar,0,login.Contraseña)
                       


                };
            return Convert.ToInt32(Conexiones.ExecuteScalar("usp_Actualizar_usuario", dbParams));

            }

        public static int Eliminar(Login login)
        {


            SqlParameter[] dbParams = new SqlParameter[]
                {
                       Conexiones.MakeParam("@Id",SqlDbType.Int,0,login.Id),


                };
            return Convert.ToInt32(Conexiones.ExecuteScalar("usp_eliminar_usuario", dbParams));



        }


    }





}

