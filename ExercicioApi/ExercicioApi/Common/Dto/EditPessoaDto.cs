using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Dto
{
    public class EditPessoaDto
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public decimal Altura { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Peso { get; set; }
        public string Raca { get; set; }
        public bool UsuarioAtivo { get; set; }
    }
}
