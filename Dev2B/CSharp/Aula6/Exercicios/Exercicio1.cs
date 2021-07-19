using Aula6.Classes;
using Common.Classes;
using Common.Interfaces;
using System;
using System.Linq;

namespace Aula6.Exercicios
{
    public class Exercicio1 : IExecute
    {
        public void Execute()
        {
            var todasPessoas =
                Pessoas.Lista.Union(
                    Pessoas.Lista.Where(pessoa1 => pessoa1.Filhos != null)
                    .SelectMany(a => a.Filhos)
                ).ToList();

            #region Exercicio 1
            Console.WriteLine("\nPessoas que contêm 'a' no Nome:");
            foreach (var pessoa in todasPessoas
                .Where(p => p.Nome
                .ToLower().Contains("a"))
                .Select(p => new
                {
                    p.Id,
                    p.Nome,
                    p.DataNascimento,
                    p.Altura,
                    p.Peso,
                    p.Raca,
                    p.Endereco
                })) WriteTree.Propriedades(pessoa, "Pessoa");
            #endregion

            #region Exercicio 2
            Console.WriteLine("Nome e Altura de Pessoas que contêm 'a' no Logradouro:");
            foreach (
                var pessoa in todasPessoas
                .Where(p => p.Endereco.Logradouro.Contains("a"))
                .Select(p => new
                {
                    p.Nome,
                    Idade = new DateTime((DateTime.Now - p.DataNascimento).Ticks).Year,
                    p.Altura
                }
                ).ToList()
                ) WriteTree.Propriedades(pessoa, "Pessoa");
            #endregion

            #region Exercício 3
            Console.WriteLine("Nome das Pessoas que possuem filhos:");
            foreach (
                var pessoa in todasPessoas
                .Where(p => p.Filhos != null && p.Filhos.Any())
                .Select(p => new
                {
                    p.Nome
                }
                ).ToList()
                ) WriteTree.Propriedades(pessoa, "Pessoa");
            #endregion

            #region Exercicio 4
            Console.WriteLine("Nome das Pessoas que possuem mais de 2 filhos:");
            foreach (
                var pessoa in todasPessoas
                .Where(p => p.Filhos != null && p.Filhos.Any() && p.Filhos.Count == 2)
                .Select(p => new
                {
                    p.Nome,
                    p.DataNascimento,
                    p.Peso,
                    p.Endereco.Logradouro,
                    p.Endereco.Bairro,
                    p.Endereco.Complemento
                }
                ).ToList()
                ) WriteTree.Propriedades(pessoa, "Pessoa");
            #endregion

            #region Exercicio 5
            Console.WriteLine("Nome, a Idade e a Altura das pessoas que não possuem filhos:");
            foreach (
                var pessoa in todasPessoas
                .Where(p => p.Filhos == null)
                .Select(p => new
                {
                    p.Nome,
                    Idade = new DateTime((DateTime.Now - p.DataNascimento).Ticks).Year,
                    p.Altura,
                }
                ).ToList()
                ) WriteTree.Propriedades(pessoa, "Pessoa");
            #endregion

            #region Exercicio 6
            Console.WriteLine("Nome das pessoas com os seus respectivos filhos (Nome e Data de Nascimento):");
            foreach (
                var pessoa in todasPessoas
                .Where(p => p.Filhos != null)
                .Select(p => new
                {
                    p.Nome,
                    Filhos = p.Filhos.Select(f => new
                    {
                        f.Nome,
                        f.DataNascimento
                    })
                }
                ).ToList()
                ) WriteTree.Propriedades(pessoa, "Pessoa", "Filho");
            #endregion

            #region Exercicio 7

            var quantidadePessoasFilhosMaior25Anos =
                todasPessoas
                .Where(p => p.Filhos != null && p.Filhos.Where(f => new DateTime((DateTime.Now - f.DataNascimento).Ticks).Year > 25) != null)
                .Count();

            Console.WriteLine($"Quantidade de Pessoas que possuam Filhos maiores de 25 anos: {quantidadePessoasFilhosMaior25Anos}");

            #endregion

            #region Exercicio 8
            Console.WriteLine();
            foreach (var pessoa in todasPessoas
                    .GroupBy(p => p.Raca)
                    .ToList())
                Console.WriteLine($"   Há {pessoa.Count()} {(pessoa.Key == "Branca" ? "Brancos" : "Negros")}\n");
            #endregion

            #region Exercício 9
            var pessoaComMenorPeso = Pessoas.Lista.OrderBy(p => p.Peso)
                .Select(p => new
                {
                    p.Id,
                    p.Nome,
                    p.DataNascimento,
                    p.Altura,
                    p.Peso,
                    p.Raca,
                    p.Endereco
                })
                .First();
            Console.WriteLine("Pessoa com menor peso: ");
            WriteTree.Propriedades(pessoaComMenorPeso, "Pessoa");
            #endregion

            #region Exercício 10
            var pessoaMaisAlta = Pessoas.Lista.OrderByDescending(p => p.Altura)
                .Select(p => new
                {
                    p.Id,
                    p.Nome,
                    p.DataNascimento,
                    p.Altura,
                    p.Peso,
                    p.Raca,
                    p.Endereco
                })
                .First();
            Console.WriteLine("Pessoa mais alta: ");
            WriteTree.Propriedades(pessoaMaisAlta, "Pessoa");
            #endregion

            #region Exercício 11
            Console.WriteLine("Pessoas agrupadas pelo primeiro nome:\n");
            foreach (var primeiraLetra in todasPessoas
                    .OrderBy(p => p.Nome)
                    .Select(p => new
                    {
                        p.Id,
                        p.Nome,
                        p.DataNascimento,
                        p.Altura,
                        p.Peso,
                        p.Raca,
                        p.Endereco
                    })
                    .GroupBy(p => p.Nome.First()).ToList())
            {
                Console.WriteLine(primeiraLetra.Key);
                foreach (var pessoa in primeiraLetra)
                    WriteTree.Propriedades(pessoa, "Pessoa");
            }
            #endregion

            #region Exercício 12
            Console.WriteLine("Pessoas em ordem de idade: ");
            foreach (var pessoa in todasPessoas
                    .Select(p => new
                    {
                        p.Id,
                        p.Nome,
                        p.DataNascimento,
                        p.Altura,
                        p.Peso,
                        p.Raca,
                        p.Endereco
                    })
                    .OrderByDescending(p => p.DataNascimento.Year))
                    
                WriteTree.Propriedades(pessoa, "Pessoa");
            #endregion

            #region Exercício 13
            Console.WriteLine("Nomes de todos os filhos: ");
            foreach (var filho in Pessoas.Lista.Where(pessoa1 => pessoa1.Filhos != null)
                       .SelectMany(a => a.Filhos.Select(f => new
                       {
                           f.Nome
                       }))) WriteTree.Propriedades(filho, "Filho");

            #endregion

            #region Exercicio 14
            var mediaDeAlturasDePessoas = Pessoas.Lista.Union(
                        Pessoas.Lista.Where(pessoa1 => pessoa1.Filhos != null)
                        .SelectMany(a => a.Filhos)
                    ).Average(p => p.Altura);

            Console.WriteLine($"Média das alturas: {mediaDeAlturasDePessoas}");
            #endregion
        }
    }
}
