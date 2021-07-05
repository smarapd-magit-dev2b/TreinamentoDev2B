using System;
using System.Collections.Generic;
using System.Linq;
using Aula5.Exercicio1.Classes;
using Endereco = Aula5.Classes.Endereco;

namespace Aula5
{
    public class ExpressoesLambdas
    {
        public void Execute()
        {
            //Exercicio1();
            Exercicio2();
        }

        private void Exercicio1()
        {
            var PessoaCollection = new List<Classes.Pessoa>
            {
                new()
                {
                    Id = 1,
                    Nome = "José",
                    Altura = 1.9m,
                    DataNascimento = new DateTime(1993, 12, 9),
                    Peso = 80.0m,
                    Raca = "Branca",
                    Endereco = new Endereco
                    {
                        Logradouro = "Rua Altair Gonçalves", Bairro = "Vila Tibério", Complemento = "Apartamento",
                        Numero = 85
                    },
                    Filhos = new List<Classes.Pessoa>
                    {
                        new()
                        {
                            Id = 2,
                            Nome = "Felipe",
                            Altura = 1.5m,
                            DataNascimento = new DateTime(2000, 3, 3),
                            Peso = 50.0m,
                            Raca = "Branca",
                            Endereco = new Endereco
                            {
                                Logradouro = "Rua Altair Gonçalves", Bairro = "Vila Tibério",
                                Complemento = "Apartamento", Numero = 85
                            },
                            Filhos = null
                        },
                        new()
                        {
                            Id = 3,
                            Nome = "Luis",
                            Altura = 1.9m,
                            DataNascimento = new DateTime(1999, 3, 15),
                            Peso = 100.0m,
                            Raca = "Branca",
                            Endereco = new Endereco
                            {
                                Logradouro = "Rua Altair Gonçalves", Bairro = "Vila Tibério",
                                Complemento = "Apartamento", Numero = 85
                            },
                            Filhos = null
                        }
                    }
                },
                new()
                {
                    Id = 4,
                    Nome = "Willian",
                    Altura = 1.7m,
                    DataNascimento = new DateTime(1950, 10, 4),
                    Peso = 100.0m,
                    Raca = "Negro",
                    Endereco = new Endereco
                        {Logradouro = "Rua Guilherme Schmdit", Bairro = "Centro", Complemento = "Casa", Numero = 111},
                    Filhos = new List<Classes.Pessoa>
                    {
                        new()
                        {
                            Id = 5,
                            Nome = "Joaquim",
                            Altura = 2m,
                            DataNascimento = new DateTime(1986, 5, 3),
                            Peso = 50.0m,
                            Raca = "Negro",
                            Endereco = new Endereco
                            {
                                Logradouro = "Avenida Benedito Ferreira", Bairro = "Vila Almeida",
                                Complemento = "Apartamento", Numero = 99
                            },
                            Filhos = null
                        },
                        new()
                        {
                            Id = 6,
                            Nome = "Gabriel",
                            Altura = 1.3m,
                            DataNascimento = new DateTime(2005, 5, 15),
                            Peso = 69.0m,
                            Raca = "Negro",
                            Endereco = new Endereco
                            {
                                Logradouro = "Rua Guilherme Schmdit", Bairro = "Centro", Complemento = "Casa",
                                Numero = 111
                            },
                            Filhos = null
                        },
                        new()
                        {
                            Id = 7,
                            Nome = "Pedro",
                            Altura = 1.86m,
                            DataNascimento = new DateTime(1995, 7, 22),
                            Peso = 69.5m,
                            Raca = "Negro",
                            Endereco = new Endereco
                            {
                                Logradouro = "Rua Guilherme Schmdit", Bairro = "Centro", Complemento = "Casa",
                                Numero = 111
                            },
                            Filhos = null
                        }
                    }
                },
                new()
                {
                    Id = 4,
                    Nome = "Silas",
                    Altura = 1.78m,
                    DataNascimento = new DateTime(1968, 2, 2),
                    Peso = 92.0m,
                    Raca = "Branca",
                    Endereco = new Endereco
                        {Logradouro = "Rua Joaquim Nabuco", Bairro = "Bairro Xis", Complemento = "Casa", Numero = 854},
                    Filhos = null
                }
            };
            var resultado1 = PessoaCollection.Where(x => x.Id == 1).FirstOrDefault();

            var resultado2 = PessoaCollection.Where(x => x.Nome.Contains("A")).ToList();

            var resultadoAny = PessoaCollection.Where(x => x.Filhos != null).ToList();

            var resultadoCount = PessoaCollection.Count();

            var resultadoSelect = PessoaCollection.Select(x =>
                new
                {
                    x.Id,
                    x.Nome
                }).ToList();

            resultadoSelect.ForEach(x =>
            {
                Console.WriteLine($"Nome: {x.Nome}");
                Console.WriteLine($"Id: {x.Id}");
            });
        }

        private void Exercicio2()
        {
            var bse = new Base();

            #region Exercicio 1

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Exercicio 1\n");

            var exercicio1 = bse.PessoaCollection.Where(x => x.Nome.Contains("a")).ToList();
            exercicio1.ForEach(x => { Console.WriteLine($"Nome: {x.Nome}"); });

            #endregion

            #region Exercicio 2

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Exercicio 2\n");

            var exercicio2 = bse.PessoaCollection.Where(x => x.Endereco.Logradouro.Contains("a"))
                .Select(p => new
                {
                    p.Nome,
                    p.Altura,
                    Idade = DateTime.Now.Year - p.DataNascimento.Year
                })
                .ToList();

            foreach (var item in exercicio2)
            {
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Idade: {item.Idade}");
                Console.WriteLine($"Altura: {item.Altura}");
            }

            #endregion

            #region Exercicio 3

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Exercicio 3\n");

            var exercicio3 = bse.PessoaCollection.Where(x => x.Filhos != null && x.Filhos.Any())
                .Select(p => new
                {
                    p.Nome
                })
                .ToList();


            foreach (var item in exercicio3) Console.WriteLine($"Nome: {item.Nome}");

            #endregion

            #region Exercicio 4

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Exercicio 4\n");

            var exercicio4 = bse.PessoaCollection.Where(x => x.Filhos != null && x.Filhos.Count > 2)
                .Select(p => new
                {
                    p.Nome,
                    DataNascimento = p.DataNascimento.ToString("dd/MM/yyyy"),
                    p.Peso,
                    p.Endereco.Logradouro,
                    p.Endereco.Bairro,
                    p.Endereco.Complemento
                })
                .ToList();

            foreach (var item in exercicio4)
            {
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Data de Nascimento: {item.DataNascimento}");
                Console.WriteLine($"Peso: {item.Peso}");
                Console.WriteLine($"Logradouro: {item.Logradouro}");
                Console.WriteLine($"Logradouro: {item.Bairro}");
                Console.WriteLine($"Complemento: {item.Complemento}");
            }

            #endregion

            #region Exercicio 5

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Exercicio 5\n");

            var exercicio5 = bse.PessoaCollection.Where(x => x.Filhos == null || !x.Filhos.Any())
                .Select(p => new
                {
                    p.Nome,
                    Idade = DateTime.Now.Year - p.DataNascimento.Year,
                    p.Altura
                })
                .ToList();

            foreach (var item in exercicio5)
            {
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Idade: {item.Idade}");
                Console.WriteLine($"Altura: {item.Altura}");
            }

            #endregion

            #region Exercicio 6

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Exercicio 6\n");

            var exercicio6 = bse.PessoaCollection.Where(x => x.Filhos != null)
                .Select(p => new
                {
                    p.Nome,
                    Filhos = p.Filhos.Select(f => new
                    {
                        f.Nome, f.DataNascimento
                    }).ToList()
                })
                .ToList();

            foreach (var p in exercicio6)
            {
                Console.WriteLine($"Nome: {p.Nome}");

                foreach (var f in p.Filhos)
                {
                    Console.WriteLine($"Nome Filho: {f.Nome}");
                    Console.WriteLine($"Data nascimento: {f.DataNascimento.ToString("dd/MM/yyyy")}");
                }
            }

            #endregion

            #region Exercicio 7

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Exercicio 7\n");

            var exercicio7 = bse.PessoaCollection
                .Count(x => x.Filhos != null && x.Filhos
                    .Where(f => DateTime.Now.Year - f.DataNascimento.Year >= 25)
                    .Any());

            Console.WriteLine($"Quantidade: {exercicio7}");

            #endregion

            #region Exercicio 8

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Exercucuio 8\n");
            var exercicio8 = bse.PessoaCollection.GroupBy(x => x.Raca).ToList();

            foreach (var item in exercicio8)
            {
                Console.WriteLine($"Raca: {item.Key}");
                
                foreach (var n in item)
                {
                    Console.WriteLine($"- Nome: {n.Nome}");
                }

                Console.WriteLine($"Quantidade: {item.Count()}");
            }

            #endregion

            #region Exercicio 9

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Exercicio 9\n");

            var menorPeso = bse.PessoaCollection.OrderBy(x => x.Peso).FirstOrDefault();
            Console.WriteLine($"Pessoa com menor peso: {menorPeso.Nome}");

            #endregion

            #region Exercicio 10

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Exercicio 10\n");

            var maiorAltura = bse.PessoaCollection.OrderByDescending(x => x.Altura).FirstOrDefault();

            Console.WriteLine($"Pessoa com maior altura: {menorPeso.Nome}");

            #endregion

            #region Exercicio 11

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Exercicio 11\n");

            var exercicio9 = bse.PessoaCollection.OrderBy(x => x.Nome).GroupBy(x => x.Nome.First()).ToList();

            foreach (var item in exercicio9)
            {
                Console.WriteLine($"{item.Key}");

                foreach (var n in item) Console.WriteLine($" Nome: {n.Nome}");
            }

            #endregion

            #region Exercicio 12

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Exercicio 12\n");


            Func<Pessoa, int> filtro = x => { return DateTime.Now.Year - x.DataNascimento.Year; };


            var execicio14 = bse.PessoaCollection.OrderBy(x => DateTime.Now.Year - x.DataNascimento.Year).ToList();

            foreach (var item in execicio14) Console.WriteLine($"Idade: {item.Nome} | Idade: {item.DataNascimento}");

            #endregion

            #region Exercicio 13

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Exercicio 13\n");

            var exercicio10 = bse.PessoaCollection
                .Where(pessoa1 => pessoa1.Filhos != null)
                .SelectMany(a => a.Filhos)
                .Select(x => x.Nome)
                .ToList();

            foreach (var item in exercicio10) Console.WriteLine($"Nome: {item}");

            #endregion

            #region Exercicio 14

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Exercicio 14\n");

            var exercicio13 = bse.PessoaCollection
                .Union(
                    bse.PessoaCollection
                        .Where(pessoa1 => pessoa1.Filhos != null)
                        .SelectMany(a => a.Filhos)
                ).Average(x => x.Altura);

            Console.WriteLine($"A media e: {exercicio13}");

            #endregion
        }
    }

    public static class NovaClassa
    {
        public static IOrderedEnumerable<Pessoa> OrderByDataNascimento(this IEnumerable<Pessoa> source)
        {
            return source.OrderBy(x => new DateTime((DateTime.Now - x.DataNascimento).Ticks));
        }
    }
}