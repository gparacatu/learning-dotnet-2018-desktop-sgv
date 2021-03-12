using System;

namespace TRANSFERENCIA
{
    public class Caixa
    {
        public int IDCaixa { get; set; }
        public int IDUsuario { get; set; }
        public Decimal valorTotal { get; set; }
        public string Status { get; set; }
        public decimal valorInicial { get; set; }
        public DateTime dataAbertura { get; set; }
        public decimal valorSangria { get; set; }
        public DateTime dataFechamento { get; set; }
        public decimal valorFechamento { get; set; }
    }
}
