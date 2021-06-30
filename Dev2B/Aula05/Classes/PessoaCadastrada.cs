using System;
using System.Collections.Generic;
using System.Text;

namespace Aula05.Classes
{
    public class PessoaCadastrada
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Salario { get; set; }
        public int QuantidadeFilhos { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }

        public PessoaCadastrada(string nome, string telefone, DateTime dataNascimento, decimal salario, int quantidadeFilhos, decimal altura,
            decimal peso, string nomePai, string nomeMae)
        {
            Nome = nome;
            Telefone = telefone;
            DataNascimento = dataNascimento;
            Salario = salario;
            QuantidadeFilhos = quantidadeFilhos;
            Altura = altura;
            Peso = peso;
            NomePai = nomePai;
            NomeMae = nomeMae;
        }

    }
}
