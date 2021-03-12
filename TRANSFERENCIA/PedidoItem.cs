namespace TRANSFERENCIA
{
    public class PedidoItem
    {
        public int IDPedido { get; set; }
        public int IDProduto { get; set; }
        public string ProdutoNome { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal PercentualDesconto { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorTotalComDesconto { get; set; }

    }
}
