using System;
using System.Collections.Generic;

namespace TRANSFERENCIA
{
    public class ProdutoPrecoColecao : List<ProdutoPreco>
    {
        public static implicit operator ProdutoPrecoColecao(ProdutoCategoriaColecao v)
        {
            throw new NotImplementedException();
        }
    }
}
