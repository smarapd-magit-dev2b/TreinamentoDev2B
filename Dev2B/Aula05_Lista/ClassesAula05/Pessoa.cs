using System;
using System.Collections.Generic;
using System.Text;

namespace Aula05_Lista.ClassesAula05
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public DateTime Nascimento { get; set; }
        public string Telefone { get; set; }
        public decimal Salario { get; set; }
        public int QdtFilhos { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }

        public Pessoa (string nome, string sobrenome, string cpf, DateTime nascimento, string telefone, 
          decimal salario, int qtdFilhos, decimal altura, decimal peso, string nomePai, string nomeMae)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            CPF = cpf;
            Nascimento = nascimento;
            Telefone = telefone;
            Salario = salario;
            QdtFilhos = qtdFilhos;
            Altura = altura;
            Peso = peso;
            NomePai = nomePai;
            NomeMae = nomeMae;
        }
    }
}



   