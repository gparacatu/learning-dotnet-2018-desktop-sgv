using System;

namespace TRANSFERENCIA
{
    public class RelatorioPedidoItem
    {
        public String Produto { get; set; }
        public int Quantidade { get; set; }
        public Decimal ValorUnitario { get; set; }
        public Decimal PercentualDesconto { get; set; }
        public Decimal ValorDesconto { get; set; }
        public Decimal ValorTotal { get; set; }
        public Decimal ValorTotalComDesconto { get; set; }        
    }
}
