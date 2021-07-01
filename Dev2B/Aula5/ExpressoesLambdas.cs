using Aula5.Classes;
using Aula5.Exercicio1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

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
            List<Classes.Pessoa> PessoaCollection = new List<Classes.Pessoa>
            {
                new Classes.Pessoa
                {
                    Id = 1,
                    Nome = "José",
                    Altura = 1.9m,
                    DataNascimento = new DateTime(1993, 12, 9),
                    Peso = 80.0m,
                    Raca = "Branca",
                    Endereco = new Classes.Endereco { Logradouro = "Rua Altair Gonçalves", Bairro = "Vila Tibério", Complemento = "Apartamento", Numero = 85 },
                    Filhos = new List<Classes.Pessoa>
                                    {
                                        new Classes.Pessoa
                                        {
                                            Id = 2,
                                            Nome = "Felipe",
                                            Altura = 1.5m,
                                            DataNascimento = new DateTime(2000, 3, 3),
                                            Peso = 50.0m,
                                            Raca = "Branca",
                                            Endereco = new Classes.Endereco { Logradouro = "Rua Altair Gonçalves", Bairro = "Vila Tibério", Complemento = "Apartamento", Numero = 85 },
                                            Filhos = null
                                        },
                                        new Classes.Pessoa
                                        {
                                            Id = 3,
                                            Nome = "Luis",
                                            Altura = 1.9m,
                                            DataNascimento = new DateTime(1999, 3, 15),
                                            Peso = 100.0m,
                                            Raca = "Branca",
                                            Endereco = new Classes.Endereco { Logradouro = "Rua Altair Gonçalves", Bairro = "Vila Tibério", Complemento = "Apartamento", Numero = 85 },
                                            Filhos = null
                                        }
                                    }
                },
                new Classes.Pessoa
                {
                    Id = 4,
                    Nome = "Willian",
                    Altura = 1.7m,
                    DataNascimento = new DateTime(1950, 10, 4),
                    Peso = 100.0m,
                    Raca = "Negro",
                    Endereco = new Classes.Endereco { Logradouro = "Rua Guilherme Schmdit", Bairro = "Centro", Complemento = "Casa", Numero = 111 },
                    Filhos = new List<Classes.Pessoa>
                                    {
                                        new Classes.Pessoa
                                        {
                                            Id = 5,
                                            Nome = "Joaquim",
                                            Altura = 2m,
                                            DataNascimento = new DateTime(1986, 5, 3),
                                            Peso = 50.0m,
                                            Raca = "Negro",
                                            Endereco = new Classes.Endereco { Logradouro = "Avenida Benedito Ferreira", Bairro = "Vila Almeida", Complemento = "Apartamento", Numero = 99 },
                                            Filhos = null
                                        },
                                        new Classes.Pessoa
                                        {
                                            Id = 6,
                                            Nome = "Gabriel",
                                            Altura = 1.3m,
                                            DataNascimento = new DateTime(2005, 5, 15),
                                            Peso = 69.0m,
                                            Raca = "Negro",
                                            Endereco = new Classes.Endereco { Logradouro = "Rua Guilherme Schmdit", Bairro = "Centro", Complemento = "Casa", Numero = 111 },
                                            Filhos = null
                                        },
                                        new Classes.Pessoa
                                        {
                                            Id = 7,
                                            Nome = "Pedro",
                                            Altura = 1.86m,
                                            DataNascimento = new DateTime(1995, 7, 22),
                                            Peso = 69.5m,
                                            Raca = "Negro",
                                            Endereco = new Classes.Endereco { Logradouro = "Rua Guilherme Schmdit", Bairro = "Centro", Complemento = "Casa", Numero = 111 },
                                            Filhos = null
                                        }
                                    }
                },
                new Classes.Pessoa
                {
                    Id = 4,
                    Nome = "Silas",
                    Altura = 1.78m,
                    DataNascimento = new DateTime(1968, 2, 2),
                    Peso = 92.0m,
                    Raca = "Branca",
                    Endereco = new Classes.Endereco { Logradouro = "Rua Joaquim Nabuco", Bairro = "Bairro Xis", Complemento = "Casa", Numero = 854 },
                    Filhos = null
                }
            };
            var resultado1 = PessoaCollection.Where(x => x.Id == 1).FirstOrDefault();

            var resultado2 = PessoaCollection.Where(x => x.Nome.Contains("A")).ToList();

            var resultadoAny = PessoaCollection.Where(x => x.Filhos != null).ToList();

            var resultadoCount = PessoaCollection.Count();

            var resultadoSelect = PessoaCollection.Select(x => new
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
            Base bse = new Base();

            #region Exercicio 1
            Console.WriteLine("Exercicio 1");
            var exercicio1 = bse.PessoaCollection.Where(x => x.Nome.Contains("a")).ToList();
            exercicio1.ForEach(x =>
            {
                Console.WriteLine($"Nome: {x.Nome}");
            });
            #endregion
            #region Exercicio 2
            Console.WriteLine("Exercicio 2");
            var exercicio2 = bse.PessoaCollection.Where(x => x.Endereco.Logradouro.Contains("a"))
                .Select(p => new
                {
                    p.Nome,
                    p.Altura,
                    Idade = DateTime.Now.Year - p.DataNascimento.Year
                })
                .ToList();
            exercicio2.ForEach(x =>
            {
                Console.WriteLine($"Nome: {x.Nome}");
                Console.WriteLine($"Idade: {x.Idade}");
                Console.WriteLine($"Altura: {x.Altura}");
            });
            #endregion
            #region Exercicio 3
            Console.WriteLine("Exercicio 3");
            var exercicio3 = bse.PessoaCollection.Where(x => x.Filhos != null && x.Filhos.Any())
                .Select(p => new
                {
                    p.Nome
                }).ToList();
            exercicio3.ForEach(x =>
            {
                Console.WriteLine($"Nome: {x.Nome}");
            });
            #endregion
            #region Exercicio 4
            Console.WriteLine("Exercicio 4");
            var exercicio4 = bse.PessoaCollection.Where(x => x.Filhos != null && x.Filhos.Count > 2)
                .Select(p => new
                {
                    Nome = p.Nome,
                    DataNascimento = p.DataNascimento.ToString("dd/MM/yyyy"),
                    Peso = p.Peso,
                    Logradouro = p.Endereco.Logradouro,
                    Bairro = p.Endereco.Bairro,
                    Complemento = p.Endereco.Complemento
                }).ToList();

            exercicio4.ForEach(x =>
            {
                Console.WriteLine($"Nome: {x.Nome}");
                Console.WriteLine($"Data de Nascimento: {x.DataNascimento}");
                Console.WriteLine($"Peso: {x.Peso}");
                Console.WriteLine($"Logradouro: {x.Logradouro}");
                Console.WriteLine($"Logradouro: {x.Bairro}");
                Console.WriteLine($"Complemento: {x.Complemento}");
            });
            #endregion
            #region Exercicio 5
            Console.WriteLine("Exercicio 5");
            var exercicio5 = bse.PessoaCollection.Where(x => x.Filhos == null || !x.Filhos.Any())
                .Select(p => new
                {
                    Nome = p.Nome,
                    Idade = DateTime.Now.Year - p.DataNascimento.Year,
                    Altura = p.Altura

                }).ToList();

            exercicio5.ForEach(x =>
            {
                Console.WriteLine($"Nome: {x.Nome}");
                Console.WriteLine($"Idade: {x.Idade}");
                Console.WriteLine($"Altura: {x.Altura}");
            });
            #endregion
            #region Exercicio 6
            Console.WriteLine("Exercicio 6");
            var exercicio6 = bse.PessoaCollection.Where(x => x.Filhos != null)
                .Select(p => new
                {
                    p.Nome,
                    Filhos = p.Filhos.Select(f => new
                    {
                        Nome = f.Nome,
                        DataNascimento = f.DataNascimento
                    }).ToList()
                })
                .ToList();

            exercicio6.ForEach(x =>
            {
                Console.WriteLine($"Nome: {x.Nome}");
                x.Filhos.ForEach(f =>
                {
                    Console.WriteLine($"Nome Filho: {f.Nome}");
                    Console.WriteLine($"Data nascimento: {f.DataNascimento.ToString("dd/MM/yyyy")}");
                });
            });
            #endregion
            #region Exercicio 7
            Console.WriteLine("Exercicio 7");
            var exercicio7 = bse.PessoaCollection.Count(x => x.Filhos != null
            && x.Filhos.Where(f => DateTime.Now.Year - f.DataNascimento.Year > 25).Any());

            Console.WriteLine($"Quantidade: {exercicio7}");
            #endregion
        }

    }
}
