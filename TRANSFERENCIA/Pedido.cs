using System;

namespace TRANSFERENCIA
{
    public class Pedido
    {
        public int IDPedido { get; set; }
        public int IDOperacao { get; set; }
        public int IDSituacao { get; set; }
        public DateTime DataHora { get; set; }
        public int IDPessoaEmitente { get; set; }
        public int IDPessoaDestinatario { get; set; }
        public decimal ValorTotalComDesconto { get; set; }
        public decimal PorcentagemDesconto { get; set; }
        public decimal ValorTotal { get; set; }
        public int IDCaixa { get; set; }
        public int IDPagamento { get; set; }

    }
}
