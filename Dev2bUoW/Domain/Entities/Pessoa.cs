using System;

namespace Domain.Entities
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
        public int Numero { get; set; }
    }
}
