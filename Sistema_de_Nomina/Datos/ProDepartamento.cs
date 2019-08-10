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


        public static DataSet VistaPosicion()
        {
            SqlParameter[] dbparametro = new SqlParameter[]
            {

            };
            return Conexiones.ExecuteDataSet("store_Vista_Posicion", dbparametro);


        }

        public static DataSet VistaDePuestos()
        {
            SqlParameter[] dbparametro = new SqlParameter[]
            {

            };
            return Conexiones.ExecuteDataSet("store_Vista_Puestos", dbparametro);


        }

        public static int NuevoDepartamento(Departamentos dept)
        {
            SqlParameter[] dbparametro = new SqlParameter[]
            {
                Conexiones.MakeParam("@Departamento",SqlDbType.VarChar,0,dept.Departamento)
         

            };
            return Convert.ToInt32(Conexiones.ExecuteScalar("store_Nuevo_Departamento", dbparametro));
        }
        public static int ActualizarDepartamento(Departamentos dept)
        {
            SqlParameter[] dbparametro = new SqlParameter[]
          {
                Conexiones.MakeParam("@Id",SqlDbType.Int,0,dept.Id),

                Conexiones.MakeParam("@Departamento",SqlDbType.VarChar,0,dept.Departamento)


          };
            return Convert.ToInt32(Conexiones.ExecuteScalar("store_Actualizar_Departamento", dbparametro));


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
        public static int ActualizarPosicion(Posiciones posiciones)
        {
            SqlParameter[] dbparametro = new SqlParameter[]
          {
              Conexiones.MakeParam("@Id",SqlDbType.Int,0,posiciones.Id),

                Conexiones.MakeParam("@Posicion",SqlDbType.VarChar,0,posiciones.Posicion),

                Conexiones.MakeParam("@IdDepartamento",SqlDbType.Int,0,posiciones.IdDepartamento)


            };
            return Convert.ToInt32(Conexiones.ExecuteScalar("store_Actualizar_Posicion", dbparametro));


        }
        

        public static int EliminarPosicion(Posiciones posiciones)
        {
            SqlParameter[] dbParametro = new SqlParameter[]
            {
             Conexiones.MakeParam("@Id",SqlDbType.Int,0,posiciones.Id)

            };

            return Convert.ToInt32(Conexiones.ExecuteScalar("store_Eliminar_Posicion", dbParametro));
        }

        public static int ValidarDepartamento(Departamentos departamentos)
        {
            SqlParameter[] dbparametro = new SqlParameter[]
            {
             Conexiones.MakeParam("@Departamento",SqlDbType.VarChar,0,departamentos.Departamento)

            };
          //  return Conexiones.ExecuteDataSet("store_Validar_Departamento", dbparametro);

            return Convert.ToInt32(Conexiones.ExecuteScalar("store_Validar_Departamento", dbparametro));

        }
        public static int ValidarPuesto(Posiciones posiciones)
        {
            SqlParameter[] dbparametro = new SqlParameter[]
            {
                             Conexiones.MakeParam("@Departamento",SqlDbType.Int,0,posiciones.IdDepartamento),
                              Conexiones.MakeParam("@posicion",SqlDbType.VarChar,0,posiciones.Posicion)



            };
            //  return Conexiones.ExecuteDataSet("store_Validar_Departamento", dbparametro);

            return Convert.ToInt32(Conexiones.ExecuteScalar("store_Validar_Puesto", dbparametro));

        }
    }

}
