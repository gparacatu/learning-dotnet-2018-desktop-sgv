using System;

namespace TRANSFERENCIA
{
    public class PessoaCliente
    {
        public int IDCliente { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string CPFCNPJ { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int IDStatus { get; set; }

    }
}
