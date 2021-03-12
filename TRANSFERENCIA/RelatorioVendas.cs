using System;

namespace TRANSFERENCIA
{
    public class RelatorioVendas
    {
        public int IDPedido { get; set; }
        public DateTime DataHora { get; set; }
        public String Emitente { get; set; }
        public String Destinatario { get; set; }
        public Decimal ValorTotal { get; set; }
        public Decimal ValorTotalComDesconto { get; set; }
        public Decimal PorcentagemDesconto { get; set; }
        public String Pagamento { get; set; }
        public String Produto { get; set; }
        public int Quantidade { get; set; }
        public Decimal ValorUnitario { get; set; }
        public Decimal PercentualDesconto { get; set; }
        public Decimal ValorDesconto { get; set; }
        public Decimal ValorTotalItem { get; set; }
        public Decimal ValorTotalComDescontoItem { get; set; }
    }
}
