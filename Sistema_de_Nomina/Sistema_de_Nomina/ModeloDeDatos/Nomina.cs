using System;

namespace Sistema_de_Nomina.Datos
{
    public class Nomina
    {
        private int idNomina;
        private decimal dollar;
        private DateTime Fecha;
        private int Usuario;
        private string Estatus;


        public decimal Dollar { get => dollar; set => dollar = value; }
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
        public int Usuario1 { get => Usuario; set => Usuario = value; }
        public string Estatus1 { get => Estatus; set => Estatus = value; }
        public int IdNomina { get => idNomina; set => idNomina = value; }
    }
}