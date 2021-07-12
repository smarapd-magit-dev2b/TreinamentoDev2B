using System;
using System.Collections.Generic;
using Common.Entities;

namespace Common.Dto
{
    public class PessoaPostDto
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public string Raca { get; set; }
        public int Idade { get; set; }
        public bool UsuarioAtivo { get; set; }
        public string Cpf { get; set; }
        public List<Pessoa> Filhos { get; set; }
    }
}
