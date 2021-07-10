using System;
using System.Collections.Generic;

namespace Commom.Dto
{
    public class PessoaGetDtoPorCodigo
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public string Raca { get; set; }
        public bool UsuarioAtivo { get; set; }
        public string DocumentoCpf { get; set; }
        public List<PessoaGetDto> Filhos { get; set; }
    }
}
