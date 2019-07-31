using System;

namespace Sistema_de_Nomina.Datos
{
    public class Nomina
    {
        private int idNomina;
        private decimal dollar;
        private DateTime Fecha;
        private DateTime fecha;

        private int Usuario;
        private string Estatus;
        private double salario;

        public decimal Dollar { get => dollar; set => dollar = value; }
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
        public int Usuario1 { get => Usuario; set => Usuario = value; }
        public string Estatus1 { get => Estatus; set => Estatus = value; }
        public int IdNomina { get => idNomina; set => idNomina = value; }
        public DateTime Fecha2 { get => fecha; set => fecha = value; }
        public double Salario { get => salario; set => salario = value; }
    }


    public class DetalleNomina
    {

        // @Id_Nomina, 
        //@Id_Empleado,
        //@Sueldo_neto,
        //@AFP,
        //@Seg_Med,          @ISR, 
        //@Otros
        private int _IdNomina;
        private int _Id_Empleado;
        private decimal _Sueldo_neto;
        private decimal _AFP;
        private decimal _Seg_Med;
        private decimal _Otros;
        private decimal _ISR;
        private string cedula;


        public int IdNomina { get => _IdNomina; set => _IdNomina = value; }
        public int Id_Empleado { get => _Id_Empleado; set => _Id_Empleado = value; }
        public decimal Sueldo_neto { get => _Sueldo_neto; set => _Sueldo_neto = value; }
        public decimal AFP { get => _AFP; set => _AFP = value; }
        public decimal Seg_Med { get => _Seg_Med; set => _Seg_Med = value; }
        public decimal Otros { get => _Otros; set => _Otros = value; }
        public decimal ISR { get => _ISR; set => _ISR = value; }
        public string Cedula { get => cedula; set => cedula = value; }
    }
}