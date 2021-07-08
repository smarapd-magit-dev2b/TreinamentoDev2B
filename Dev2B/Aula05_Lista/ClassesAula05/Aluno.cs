using System;
using System.Collections.Generic;
using System.Text;

namespace Aula05_Lista.ClassesAula05
{
    public class Aluno
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public string Ra { get; set; }
        public DateTime DataNascimento { get; set; }

        public Aluno(string id, string nome, int idade, string nomePai, string nomeMae, string ra, DateTime dataNascimento)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            NomePai = nomePai;
            NomeMae = nomeMae;
            Ra = ra;
            DataNascimento = dataNascimento;
        }
    }
}
