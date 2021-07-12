using System;
using System.Collections.Generic;
using System.Text;
using Common.Entities;

namespace Common.Dto
{
    public class PessoaFilhosPutDto
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public string Raca { get; set; }
        public string Cpf { get; set; }
    }
}
