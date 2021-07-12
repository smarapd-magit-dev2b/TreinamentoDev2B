using System;

namespace Common.Dtos
{
    public class PessoaPutDto
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public string Raca { get; set; }
    }
}
