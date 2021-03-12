namespace TRANSFERENCIA
{
    public class Produto
    {
        //Campos de Cadastro
        public int IDProduto { get; set; }
        public string Nome { get; set; }
        public int Categoria { get; set; }
        public int IDStatus { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal PrecoCusto { get; set; }
        public string  Foto { get; set; }
        public int IDFilial { get; set; }

        //Campos adicionais de consulta
        public string CategoriaDescricao { get; set; }
        public string StatusDescricao { get; set; }
        public int Estoque { get; set; }

    }
}
