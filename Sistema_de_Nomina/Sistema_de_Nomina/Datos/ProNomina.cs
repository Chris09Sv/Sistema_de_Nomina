using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Nomina.ModeloDeDatos;

namespace Sistema_de_Nomina.Datos
{
  public  class ProNomina
    {

        public static DataSet SeleccionarIdNomina()
        {
            SqlParameter[] dbparametro = new SqlParameter[]
                {

                };
            return Conexiones.ExecuteDataSet("_Select_nomina_", dbparametro);

        }
        public static DataSet VistaNomina()
        {
            SqlParameter[] dbparametro = new SqlParameter[]
                {

                };
            return Conexiones.ExecuteDataSet("store_Vista_nomina", dbparametro);

        }

        public static DataSet Vistaprestamo()
        {
            SqlParameter[] dbparametro = new SqlParameter[]
                {
  // Conexiones.MakeParam("@dollar",SqlDbType.Decimal,0,nomina.Dollar)

                };
            return Conexiones.ExecuteDataSet("_store_vista_estado_prestamo", dbparametro);
        }
        public static DataSet VistaprestamoEmpleado(Empleados p)
        {
            SqlParameter[] dbparametro = new SqlParameter[]
                {
              Conexiones.MakeParam("@Id",SqlDbType.Decimal,0,p.Id)

                };
            return Conexiones.ExecuteDataSet("_store_vista_estado_prestamo_empleado", dbparametro);
        }
        public static DataSet VistaDeNomina( Nomina nomina)
        {
            SqlParameter[] dbparametro = new SqlParameter[]
            {
                                Conexiones.MakeParam("@dollar",SqlDbType.Decimal,0,nomina.Dollar)

            };
            return Conexiones.ExecuteDataSet("_cargar_nomina2", dbparametro);


        }

        public static DataSet VerNomina(Nomina nomina)
        {
            SqlParameter[] dbparametro = new SqlParameter[]
            {
         Conexiones.MakeParam("@Id",SqlDbType.Int,0,nomina.IdNomina)

            };
            return Conexiones.ExecuteDataSet("_ver_nomina", dbparametro);


        }
        public static DataSet ReporteTSS(Nomina nomina)
        {
            SqlParameter[] dbparametro = new SqlParameter[]
            {
         Conexiones.MakeParam("@Id",SqlDbType.Int,0,nomina.IdNomina)

            };
            return Conexiones.ExecuteDataSet("_Reporte_Tss", dbparametro);


        }
        //  @dollar decimal (18,2),@usuario int,@Estatus varchar(50),@fecha date


        public static int GuardarNomina(Nomina nomina)
        {
            SqlParameter[] dbparametro = new SqlParameter[]
            {
          //Conexiones.MakeParam("@IdNomina",SqlDbType.Int,0,nomina.IdNomina),

             Conexiones.MakeParam("@dollar",SqlDbType.Decimal,0,nomina.Dollar),
             Conexiones.MakeParam("@usuario",SqlDbType.Int,0,nomina.Usuario1),

          Conexiones.MakeParam("@Estatus",SqlDbType.VarChar,0,nomina.Estatus1),
          Conexiones.MakeParam("@Fecha",SqlDbType.Date,0,nomina.Fecha1),
          Conexiones.MakeParam("@Fecha2",SqlDbType.Date,0,nomina.Fecha2)


            };
            return Convert.ToInt32(Conexiones.ExecuteScalar("_Nueva_Nomina_", dbparametro));
        }

        public static int GuardarPrestamo(Prestamos_y_Bonificaciones pr)
        {
            SqlParameter[] dbparametro = new SqlParameter[]
            {
          //Conexiones.MakeParam("@IdNomina",SqlDbType.Int,0,nomina.IdNomina),

             Conexiones.MakeParam("@Id",SqlDbType.Int,0,pr.Cuenta),
                          Conexiones.MakeParam("@IdNomina",SqlDbType.Int,0,pr.Meses),





            };
            return Convert.ToInt32(Conexiones.ExecuteScalar("_Store_Pago", dbparametro));
        }


        public static int GuardarDetalleNomina(DetalleNomina nomina)
        {

            // @Id_Nomina, 
            //@Id_Empleado,
            //@Sueldo_neto,
            //@AFP,
            //@Seg_Med,          @ISR, 
            //@Otros
            SqlParameter[] dbparametro = new SqlParameter[]
            {
          //Conexiones.MakeParam("@IdNomina",SqlDbType.Int,0,nomina.IdNomina),

          Conexiones.MakeParam("@Id_Nomina",SqlDbType.Int,0,nomina.IdNomina),
                          Conexiones.MakeParam("@Id_Empleado",SqlDbType.Int,0,nomina.Id_Empleado),

          Conexiones.MakeParam("@Sueldo_neto",SqlDbType.Decimal,0,nomina.Sueldo_neto),
          Conexiones.MakeParam("@AFP",SqlDbType.Decimal,0,nomina.AFP),
          Conexiones.MakeParam("@Seg_Med",SqlDbType.Decimal,0,nomina.Seg_Med),
                Conexiones.MakeParam("@ISR",SqlDbType.Decimal,0,nomina.ISR),

                    Conexiones.MakeParam("@Otros",SqlDbType.Decimal,0,nomina.Otros),




            };
            return Convert.ToInt32(Conexiones.ExecuteScalar("_Nuevo_Detalle_Nomina_", dbparametro));
        }

    }
}
