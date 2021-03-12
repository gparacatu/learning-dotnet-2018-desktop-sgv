using System;

namespace TRANSFERENCIA
{
    public class EstoqueMovimentacao
    {
        public int IDMovimentacao { get; set; }
        public int IDFilial { get; set; }
        public int IDProduto { get; set; }
        public int Quantidade { get; set; }
        public string EntradaSaida { get; set; }
        public DateTime DataHora { get; set; }

    }
}
