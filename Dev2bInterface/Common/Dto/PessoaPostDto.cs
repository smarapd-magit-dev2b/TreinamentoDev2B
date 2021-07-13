using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Dto
{
    //Dto para adicionar pessoa pelo ID.
    public class PessoaPostDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public string Raca { get; set; }
        public bool UsuarioAtivo { get; set; }
        public string Cpf { get; set; }
        public List<Pessoa> Filhos { get; set; }

    }
}
