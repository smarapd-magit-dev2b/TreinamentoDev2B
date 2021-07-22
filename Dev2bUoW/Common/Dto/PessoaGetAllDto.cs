using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Dto
{
    public class PessoaGetAllDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }

        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
    }
}
