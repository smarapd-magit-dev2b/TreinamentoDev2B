using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.Exercicio5Classes
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public int RA { get; set; }
        public DateTime DataNascimento { get; set; }

        public Aluno(int id, string nome, int idade, string nomePai, string nomeMae, int ra, DateTime dataNasc)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            NomePai = nomePai;
            NomeMae = nomeMae;
            RA = ra;
            DataNascimento = dataNasc;
        }

        public string AlunoToString()
        {
            return $"\nID: {Id}. \nNome: {Nome}. \nIdade: {Idade} \nNome do pai: {NomePai}. \nNome da mãe: {NomeMae}." +
                $"\nRA: {RA} \nData de Nascimento: {DataNascimento.ToString("dd/MM/yyyy")}.";
        }

    }
}
