using Common.Classes.Pessoa.Fisica;
using Common.Interfaces;
using System;
using System.Collections.Generic;

namespace Aula5.Exemplos
{
    class Exemplo1 : IExecute
    {
        public void Execute()
        {
            var pessoas = new List<PessoaFisica>() { 
                new PessoaFisica()
                {
                    Nome = "Luis",
                    Sobrenome = "Roberto",
                    Cpf = "159385015092",
                    DataNascimento = new DateTime(2002, 12, 15)
                },

                new PessoaFisica()
                {
                    Nome = "Pericles",
                    Sobrenome = "Nascimento",
                    Cpf = "6578423",
                    DataNascimento = new DateTime(2031, 7, 3)
                },

                new PessoaFisica()
                {
                    Nome = "Robson",
                    Sobrenome = "Danil",
                    Cpf = "51480578934",
                    DataNascimento = new DateTime(320, 1, 2)
                }
            };

            foreach (var pessoa in pessoas)
                Console.WriteLine($"{pessoa.Nome} {pessoa.Sobrenome} do CPF: {pessoa.Cpf}; Nascida em {pessoa.DataNascimento:dd/MM/yyyy}");
        }
    }
}
