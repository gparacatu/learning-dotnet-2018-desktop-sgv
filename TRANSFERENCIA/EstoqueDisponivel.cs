using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSFERENCIA
{
    public class EstoqueDisponivel
    {
        public string NomeProduto { get; set; }
        public int QuantidadeEstoque { get; set; }
        public int QuantidadeReservada { get; set; }
        public int QuantidadeDisponivel { get; set; }
        public string Filial { get; set; }
        public string FilialTipo { get; set; }

    }
}
