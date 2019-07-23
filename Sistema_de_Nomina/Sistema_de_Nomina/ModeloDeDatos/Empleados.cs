using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Nomina.ModeloDeDatos
{
   public class Empleados
    {
        private int _Id;
        private string _Cedula;
        private string _Nombre;
        private string _Apellido;

        private DateTime _FechaDeNacimiento;
        private DateTime _FechaDeContratacion;
        private decimal _Sueldo;
        private string _Puesto;
        private string _Email;
        private string _Telefono;
        private string _Direccion;
        private int _IdPuesto;
        private string _Estado;
        private string _EstadoCivil;
        private int _NoCuenta;

        //   private string Departamento;

        public int Id { get => _Id; set => _Id = value; }
        public string Cedula { get => _Cedula; set => _Cedula = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public DateTime FechaDeNacimiento { get => _FechaDeNacimiento; set => _FechaDeNacimiento = value; }
        public DateTime FechaDeContratacion { get => _FechaDeContratacion; set => _FechaDeContratacion = value; }
        public decimal Sueldo { get => _Sueldo; set => _Sueldo = value; }
        public string Puesto { get => _Puesto; set => _Puesto = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public int IdPuesto { get => _IdPuesto; set => _IdPuesto = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string EstadoCivil { get => _EstadoCivil; set => _EstadoCivil = value; }
        public int NoCuenta { get => _NoCuenta; set => _NoCuenta = value; }
    }
}
