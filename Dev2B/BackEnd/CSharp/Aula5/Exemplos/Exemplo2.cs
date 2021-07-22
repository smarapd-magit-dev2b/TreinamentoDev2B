using Common.Classes.Pessoa.Fisica;
using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula5.Exemplos
{
    public class Exemplo2 : IExecute
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
                    DataNascimento = new DateTime(2015, 7, 3)
                },

                new PessoaFisica()
                {
                    Nome = "Robson",
                    Sobrenome = "Danil",
                    Cpf = "51480578934",
                    DataNascimento = new DateTime(320, 1, 2)
                }
            };

            var pessoasMaiores18 = pessoas.Where(pessoa => new DateTime((DateTime.Now - pessoa.DataNascimento).Ticks).Year >= 18);
            if(pessoasMaiores18 != null)
                foreach (var pessoa in pessoas)
                {
                    pessoa.Sobrenome += $"(Maior de Idade)";
                }
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
        }
    }
}
