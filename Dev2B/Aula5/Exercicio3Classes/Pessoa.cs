using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.Exercicio3Classes
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Salario { get; set; }
        public int QtdFilhos { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }

        public Pessoa(string nome, string telefone, DateTime datNasc, decimal salario, int qtdFilhos,
            decimal altura, decimal peso, string nomePai, string nomeMae)
        {
            Nome = nome;
            Telefone = telefone;
            DataNascimento = datNasc;
            Salario = salario;
            QtdFilhos = qtdFilhos;
            Altura = altura;
            Peso = peso;
            NomePai = nomePai;
            NomeMae = nomeMae;
        }

        public override string ToString()
        {
            return $"\nNome: {Nome}. \nTelefone: {Telefone}. \nData de Nascimento: {DataNascimento.ToString("dd/MM/yyyy")}." +
                $"\nSalario R$: {Salario}. \nQuantidade de filhos: {QtdFilhos}. \nAltura: {Altura}. \nPeso:{Peso}." +
                $"\nNome do pai: {NomePai}. \nNome da mãe: {NomeMae}.";
        }
    }
}
