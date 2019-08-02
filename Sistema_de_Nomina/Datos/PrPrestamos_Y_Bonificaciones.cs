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
  public class PrPrestamos_Y_Bonificaciones
    {
        public static int Insertar(Prestamos_y_Bonificaciones  Prestamo)
        {
            SqlParameter[] dbParametro = new SqlParameter[]
           {

            Conexiones.MakeParam("@IdEmpleado",SqlDbType.Int,0,Prestamo.IdEmpleado1),
            Conexiones.MakeParam("@Prestamo",SqlDbType.Decimal,0,Prestamo.Prestamo1),
            Conexiones.MakeParam("@Cuota",SqlDbType.Decimal,0,Prestamo.Cuota1),
            Conexiones.MakeParam("@Interes",SqlDbType.Decimal,0,Prestamo.Interes1),

               Conexiones.MakeParam("@Meses",SqlDbType.Int,0,Prestamo.Meses),
            Conexiones.MakeParam("@Fecha",SqlDbType.Date,0,Prestamo.Fecha1)

           };
            return Convert.ToInt32(Conexiones.ExecuteScalar("_Store_Nuevo_Prestamo", dbParametro));

        }

        public static int Update (Prestamos_y_Bonificaciones Prestamo)
        {
            SqlParameter[] dbParametro = new SqlParameter[]
           {

            Conexiones.MakeParam("@Id",SqlDbType.Int,0,Prestamo.Id),
            Conexiones.MakeParam("@Prestamo",SqlDbType.Decimal,0,Prestamo.Prestamo1),
            Conexiones.MakeParam("@Cuota",SqlDbType.Decimal,0,Prestamo.Cuota1),

               Conexiones.MakeParam("@Meses",SqlDbType.Int,0,Prestamo.Meses),

           };
            return Convert.ToInt32(Conexiones.ExecuteScalar("_Store_Update_Prestamo", dbParametro));

        }
    }
}
