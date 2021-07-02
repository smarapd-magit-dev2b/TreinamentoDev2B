using System;
using System.Collections.Generic;
using System.Text;

namespace Aula6.Exemplo1AulaClasses
{
    public class PessoaExemplo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public string Raca { get; set; }
        public EnderecoExemplo Endereco { get; set; }
        public List<PessoaExemplo> Filhos { get; set; }
    }
}
