using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Nomina.ModeloDeDatos
{
    public class Departamentos
    {
        private int _Id;
        private string _Departamento;
        public int Id { get => _Id; set => _Id = value; }
        public string Departamento { get => _Departamento; set => _Departamento = value; }
       
    }

}
