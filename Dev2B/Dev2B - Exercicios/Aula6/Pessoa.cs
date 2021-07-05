using System;
using System.Collections.Generic;
using System.Text;

namespace Lambdas
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public string Raca { get; set; }
        public Endereco Endereco { get; set; }

        public int Idade { get; set; }
        public List<Pessoa> Filhos { get; set; }

        public override string ToString()
        {
            return $"ID: {Id} | Nome: {Nome} | Data nascimento: {DataNascimento.ToString("dd/MM/yyyy")} | Altura {Altura} | Peso: {Peso} | Raça: {Raca} | Endereço: {Endereco} ";
        }

    }
}
