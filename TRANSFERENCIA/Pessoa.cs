using System;

namespace TRANSFERENCIA
{
    public class Pessoa
    {
        public int IDPessoa { get; set; }
        public PessoaTipo PessoaTipo { get; set; }
        public Status Status { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
