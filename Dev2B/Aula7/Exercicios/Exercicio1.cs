using Aula6.Classes;
using Aula7.Exceptions;
using Aula7.Helpers;
using Domain.Interfaces;
using System;
using System.Linq;

namespace Aula7.Exercicios
{
    public class Exercicio1 : IExecute
    {
        public void Execute()
        {
            var todasPessoas = Pessoas.Lista
                .Union
                (
                    Pessoas.Lista
                    .Where(p => p.Filhos != null)
                    .SelectMany(p => p.Filhos)
                ).ToList();

            foreach (var pessoa in todasPessoas)
            {
                var idade = DateTimeHelper.Idade(pessoa.DataNascimento).Year;

                Console.WriteLine($"{pessoa.Nome} de {idade} anos");

                try
                {
                    if (idade > 90)
                        throw new NegocioException();
                }
                catch (NegocioException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}