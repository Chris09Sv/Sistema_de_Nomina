using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Nomina.ModeloDeDatos
{
   public class Posiciones
    {
        private int _Id;
        private string _Posicion;
        private Departamentos _departamentos;
        private int _IdDepartamento;
        private string _Posicion2;

        public int Id { get => _Id; set => _Id = value; }
        public string Posicion { get => _Posicion; set => _Posicion = value; }
        public Departamentos Departamentos { get => _departamentos; set => _departamentos = value; }
        public int IdDepartamento { get => _IdDepartamento; set => _IdDepartamento = value; }
        public string Posicion2 { get => _Posicion2; set => _Posicion2 = value; }
    }
}
