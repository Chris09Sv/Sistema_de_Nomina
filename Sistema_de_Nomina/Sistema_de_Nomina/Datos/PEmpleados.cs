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
    public class PEmpleados
    {
        public static DataSet Vista()
        {
            SqlParameter[] dbparams = new SqlParameter[]
            {

            };
            return Conexiones.ExecuteDataSet("store_Vista_Empleados", dbparams);
        }
        public static int Insertar(Empleados empleado)
        {
            SqlParameter[] dbParametro = new SqlParameter[]
            {
                Conexiones.MakeParam("@Cedula",SqlDbType.VarChar,0,empleado.Cedula),
                Conexiones.MakeParam("@Nombre",SqlDbType.VarChar,0,empleado.Nombre),
                Conexiones.MakeParam("@Apellido",SqlDbType.VarChar,0,empleado.Apellido),
                Conexiones.MakeParam("@Direccion",SqlDbType.VarChar,0,empleado.Direccion),
                Conexiones.MakeParam("@Email",SqlDbType.VarChar,0,empleado.Email),
                Conexiones.MakeParam("@Telefono",SqlDbType.VarChar,0,empleado.Telefono),
                Conexiones.MakeParam("@Fecha_de_Nacimiento",SqlDbType.Date,0,empleado.FechaDeNacimiento),
                Conexiones.MakeParam("@Fecha_de_Contratacion",SqlDbType.Date,0,empleado.FechaDeContratacion),
                Conexiones.MakeParam("@Departamento",SqlDbType.VarChar,0,empleado.Departamento),
                Conexiones.MakeParam("@Puesto",SqlDbType.VarChar,0,empleado.Puesto)


            };
            return Convert.ToInt32(Conexiones.ExecuteScalar("InsertarEmpleado", dbParametro));
        }

        public static int Modificar(Empleados empleado)
        {
            SqlParameter[] dbParametro = new SqlParameter[]
            {
                                Conexiones.MakeParam("@Id",SqlDbType.Int,0,empleado.Id),

                Conexiones.MakeParam("@Cedula",SqlDbType.VarChar,0,empleado.Cedula),
                Conexiones.MakeParam("@Nombre",SqlDbType.VarChar,0,empleado.Nombre),
                Conexiones.MakeParam("@Apellido",SqlDbType.VarChar,0,empleado.Apellido),
                Conexiones.MakeParam("@Direccion",SqlDbType.VarChar,0,empleado.Direccion),
                Conexiones.MakeParam("@Email",SqlDbType.VarChar,0,empleado.Email),
                Conexiones.MakeParam("@Telefono",SqlDbType.VarChar,0,empleado.Telefono),
                Conexiones.MakeParam("@Fecha_de_Nacimiento",SqlDbType.Date,0,empleado.FechaDeNacimiento),
                Conexiones.MakeParam("@Fecha_de_Contratacion",SqlDbType.Date,0,empleado.FechaDeContratacion),
                Conexiones.MakeParam("@Departamento",SqlDbType.VarChar,0,empleado.Departamento),
                Conexiones.MakeParam("@Puesto",SqlDbType.VarChar,0,empleado.Puesto)


            };
            return Convert.ToInt32(Conexiones.ExecuteScalar("store_Modificar_Empleados", dbParametro));
        }

    }
}
