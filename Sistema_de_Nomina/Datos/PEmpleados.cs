﻿using Sistema_de_Nomina.ModeloDeDatos;
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
            return Conexiones.ExecuteDataSet("store_Vista_Empleado", dbparams);
        }
        public static DataSet VistaInactivos()
        {
            SqlParameter[] dbparams = new SqlParameter[]
            {

            };
            return Conexiones.ExecuteDataSet("store_Vista_Empleado_NoActivos", dbparams);
        }
        public static DataSet VistaNominaIndividual(Empleados empleado)
        {
            SqlParameter[] dbparams = new SqlParameter[]
            {
             Conexiones.MakeParam("@IdEmpleado",SqlDbType.Int,0,empleado.Id),

            };
            return Conexiones.ExecuteDataSet("_Ver_Nomina_individual", dbparams);
        }
        
        public static DataSet VistaPrestamo()
        {
            SqlParameter[] dbparams = new SqlParameter[]
            {

            };
            return Conexiones.ExecuteDataSet("_store_vista_Prestamo", dbparams);
        }
        
        public static int Insertar(Empleados empleado)
        {
            SqlParameter[] dbParametro = new SqlParameter[]
            {
                Conexiones.MakeParam("@Cedula",SqlDbType.VarChar,0,empleado.Cedula),
                Conexiones.MakeParam("@Nombre",SqlDbType.VarChar,0,empleado.Nombre),
                Conexiones.MakeParam("@Apellido",SqlDbType.VarChar,0,empleado.Apellido),
                Conexiones.MakeParam("@Direccion",SqlDbType.VarChar,0,empleado.Direccion),
              Conexiones.MakeParam("@Telefono",SqlDbType.VarChar,0,empleado.Telefono),

                Conexiones.MakeParam("@Email",SqlDbType.VarChar,0,empleado.Email),
                Conexiones.MakeParam("@Fecha_de_Nacimiento",SqlDbType.Date,0,empleado.FechaDeNacimiento),
                 Conexiones.MakeParam("@Estado_Civil",SqlDbType.VarChar,0,empleado.EstadoCivil),

                Conexiones.MakeParam("@Fecha_de_Ingreso",SqlDbType.Date,0,empleado.FechaDeContratacion),
                                Conexiones.MakeParam("@IdPuesto",SqlDbType.Int,0,empleado.IdPuesto),

               Conexiones.MakeParam("@Salario",SqlDbType.Decimal,0,empleado.Sueldo),
                              Conexiones.MakeParam("@Estado",SqlDbType.VarChar,0,empleado.Estado),
                                 Conexiones.MakeParam("@NoCuenta",SqlDbType.VarChar,0,empleado.NoCuenta)




            };
            return Convert.ToInt32(Conexiones.ExecuteScalar("store_Nuevo_Empleado", dbParametro));
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
              Conexiones.MakeParam("@Telefono",SqlDbType.VarChar,0,empleado.Telefono),

                Conexiones.MakeParam("@Email",SqlDbType.VarChar,0,empleado.Email),
                Conexiones.MakeParam("@Fecha_de_Nacimiento",SqlDbType.Date,0,empleado.FechaDeNacimiento),
                Conexiones.MakeParam("@Estado_Civil",SqlDbType.VarChar,0,empleado.EstadoCivil),

               Conexiones.MakeParam("@Fecha_de_Ingreso",SqlDbType.Date,0,empleado.FechaDeContratacion),
               Conexiones.MakeParam("@IdPuesto",SqlDbType.Int,0,empleado.IdPuesto),

               Conexiones.MakeParam("@Salario",SqlDbType.Decimal,0,empleado.Sueldo),
               Conexiones.MakeParam("@NoCuenta",SqlDbType.VarChar,0,empleado.NoCuenta)

            };
            return Convert.ToInt32(Conexiones.ExecuteScalar("store_Modificar_Empleado", dbParametro));
        }


        public static int Eliminar(Empleados empleado)
        {
            SqlParameter[] dbParametro = new SqlParameter[]
            {
                    Conexiones.MakeParam("@Id",SqlDbType.Int,0,empleado.Id),

            };

            return Convert.ToInt32(Conexiones.ExecuteScalar("store_Eliminar_Empleado", dbParametro));
        }

    }
}
