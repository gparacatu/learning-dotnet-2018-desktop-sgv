using System;

namespace TRANSFERENCIA
{
    public class RelatorioCaixa
    {
        public int IDCaixa { get; set; }
        public string Responsavel { get; set; }
        public DateTime dataAbertura { get; set; }
        public DateTime dataFechamento { get; set; }
        public Decimal valorInicial { get; set; }
        public Decimal valorTotal { get; set; }
        public Decimal valorFechamento { get; set; }
        public Decimal valorSangria { get; set; }
    }
}
