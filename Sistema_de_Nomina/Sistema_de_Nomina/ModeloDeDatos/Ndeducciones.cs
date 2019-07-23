namespace Sistema_de_Nomina.Datos
{
    public class Ndeducciones
    {
        private int _Id;
        private decimal _ISR;
        private decimal _AFP;
        private decimal _SEG_MED;
        private decimal _SEG_SOC;
        private decimal _OTROS_DESCUENTOS;

        public int Id { get => _Id; set => _Id = value; }
        public decimal ISR { get => _ISR; set => _ISR = value; }
        public decimal AFP { get => _AFP; set => _AFP = value; }
        public decimal SEG_MED { get => _SEG_MED; set => _SEG_MED = value; }
        public decimal SEG_SOC { get => _SEG_SOC; set => _SEG_SOC = value; }
        public decimal OTROS_DESCUENTOS { get => _OTROS_DESCUENTOS; set => _OTROS_DESCUENTOS = value; }

    }
}