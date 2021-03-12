using System;

namespace TRANSFERENCIA
{
    public class RelatorioPedidos
    {
        public int IDPedido { get; set; }
        public DateTime DataHora { get; set; }
        public String Emitente { get; set; }
        public String Destinatario { get; set; }
        public Decimal ValorTotal { get; set; }
        public Decimal ValorTotalComDesconto { get; set; }
        public Decimal PorcentagemDesconto { get; set; }
        public String Pagamento { get; set; }

    }
}
