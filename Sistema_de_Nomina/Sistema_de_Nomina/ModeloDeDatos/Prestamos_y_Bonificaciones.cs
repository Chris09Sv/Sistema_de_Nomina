using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Nomina.ModeloDeDatos
{
   public class Prestamos_y_Bonificaciones
    {
        private int IdEmpleado;
        private decimal Prestamo;
        private decimal Cuota;
        private decimal Interes;

        private int meses;
        private DateTime Fecha;
        private int cuenta;

        public int IdEmpleado1 { get => IdEmpleado; set => IdEmpleado = value; }
        public decimal Prestamo1 { get => Prestamo; set => Prestamo = value; }
        public decimal Cuota1 { get => Cuota; set => Cuota = value; }
        public int Meses { get => meses; set => meses = value; }
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
        public decimal Interes1 { get => Interes; set => Interes = value; }
        public int Cuenta { get => cuenta; set => cuenta = value; }
    }
}
