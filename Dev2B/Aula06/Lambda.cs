using Aula06.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula06
{
    public class Lambda
    {
        public void Execute()
        {
            Ex1();
        }

        static void Ex1()
        {
            List<Pessoa> PessoaCollection = new List<Pessoa>
            {
                new Pessoa
                {
                    Id = 1,
                    Nome = "José",
                    Altura = 1.9m,
                    DataNascimento = new DateTime(1993, 12, 9),
                    Peso = 80.0m,
                    Raca = "Branca",
                    Endereco = new Endereco { Logradouro = "Rua Altair Gonçalves", Bairro = "Vila Tibério", Complemento = "Apartamento", Numero = 85 },
                    Filhos = new List<Pessoa>
                                    {
                                        new Pessoa
                                        {
                                            Id = 2,
                                            Nome = "Felipe",
                                            Altura = 1.5m,
                                            DataNascimento = new DateTime(2000, 3, 3),
                                            Peso = 50.0m,
                                            Raca = "Branca",
                                            Endereco = new Endereco { Logradouro = "Rua Altair Gonçalves", Bairro = "Vila Tibério", Complemento = "Apartamento", Numero = 85 },
                                            Filhos = null
                                        },
                                        new Pessoa
                                        {
                                            Id = 3,
                                            Nome = "Luis",
                                            Altura = 1.9m,
                                            DataNascimento = new DateTime(1999, 3, 15),
                                            Peso = 100.0m,
                                            Raca = "Branca",
                                            Endereco = new Endereco { Logradouro = "Rua Altair Gonçalves", Bairro = "Vila Tibério", Complemento = "Apartamento", Numero = 85 },
                                            Filhos = null
                                        }
                                    }
                },
                new Pessoa
                {
                    Id = 10,
                    Nome = "Willian",
                    Altura = 1.7m,
                    DataNascimento = new DateTime(1950, 10, 4),
                    Peso = 100.0m,
                    Raca = "Negro",
                    Endereco = new Endereco { Logradouro = "Rua Guilherme Schmdit", Bairro = "Centro", Complemento = "Casa", Numero = 111 },
                    Filhos = new List<Pessoa>
                                    {
                                        new Pessoa
                                        {
                                            Id = 5,
                                            Nome = "Joaquim",
                                            Altura = 2m,
                                            DataNascimento = new DateTime(1986, 5, 3),
                                            Peso = 50.0m,
                                            Raca = "Negro",
                                            Endereco = new Endereco { Logradouro = "Avenida Benedito Ferreira", Bairro = "Vila Almeida", Complemento = "Apartamento", Numero = 99 },
                                            Filhos = null
                                        },
                                        new Pessoa
                                        {
                                            Id = 6,
                                            Nome = "Gabriel",
                                            Altura = 1.3m,
                                            DataNascimento = new DateTime(2005, 5, 15),
                                            Peso = 69.0m,
                                            Raca = "Negro",
                                            Endereco = new Endereco { Logradouro = "Rua Guilherme Schmdit", Bairro = "Centro", Complemento = "Casa", Numero = 111 },
                                            Filhos = null
                                        },
                                        new Pessoa
                                        {
                                            Id = 7,
                                            Nome = "Pedro",
                                            Altura = 1.86m,
                                            DataNascimento = new DateTime(1995, 7, 22),
                                            Peso = 69.5m,
                                            Raca = "Negro",
                                            Endereco = new Endereco { Logradouro = "Rua Guilherme Schmdit", Bairro = "Centro", Complemento = "Casa", Numero = 111 },
                                            Filhos = null
                                        }
                                    }
                },
                new Pessoa
                {
                    Id = 4,
                    Nome = "Silas",
                    Altura = 1.78m,
                    DataNascimento = new DateTime(1968, 2, 2),
                    Peso = 92.0m,
                    Raca = "Branca",
                    Endereco = new Endereco { Logradouro = "Rua Joaquim Nabuco", Bairro = "Bairro Xis", Complemento = "Casa", Numero = 854 },
                    Filhos = null
                }
            };

            List<Pessoa> PessoaCollection2 = new List<Pessoa>();


            //var resultado = PessoaCollection.Where(x => x.Id == 1).FirstOrDefault();

            //var resultado2 = PessoaCollection.Where(x => x.Nome.Contains("a")).ToList();

            //var resultadoAny = PessoaCollection.Where(x => x.Filhos != null && x.Filhos.Any()).ToList();

            //var resultadoAny2 = PessoaCollection2.Any();

            //var resultadoCount = PessoaCollection.Count();

            //var resultadoCount2 = PessoaCollection2.Count();

            //var resultadoSelect = PessoaCollection.Select(t => new
            //{
            //    t.Nome,
            //    t.Id,
            //}).ToList();

            //foreach (var pessoa in resultadoSelect)
            //{
            //    Console.WriteLine($"Nome: {pessoa.Nome}");
            //    Console.WriteLine($"Id: {pessoa.Id}");
            //    Console.WriteLine($"------------------");
            //}


            //• Exiba todas as pessoas que contenha a letra “a” no nome.

            var resultadoSelect = PessoaCollection.Select(r => new
            {
                Nome = r.Nome
            }).ToList();
            var consulta1 = resultadoSelect.Where(pessoa => pessoa.Nome.Contains("a")).ToList();
            foreach (var pessoa in consulta1)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}");
            }
            Console.WriteLine("\n------------------\n");

            //• Exiba o Nome, a Idade e a Altura das pessoas que contenha a letra “a” no Logradouro de seu Endereço.

            var consulta2 = PessoaCollection.Where(pessoa => pessoa.Endereco.Logradouro.Contains("a")).ToList();
            foreach (var pessoa in consulta2)
            {
                int idade = DateTime.Today.Year - pessoa.DataNascimento.Year;
                if (DateTime.Today.DayOfYear < pessoa.DataNascimento.DayOfYear)
                    idade--;
                Console.WriteLine($"Nome: {pessoa.Nome}  Idade:{idade} Altura:{pessoa.Altura}");
            }
            Console.WriteLine("\n------------------\n");

            //• Exiba o Nome de todas as pessoas que possuem filhos
            var consulta3 = PessoaCollection.Where(pessoa => pessoa.Filhos != null && pessoa.Filhos.Any()).ToList();
            foreach (var pessoa in consulta3)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}");
            }
            Console.WriteLine("\n------------------\n");

            //• Exiba o Nome, Data Nascimento, Peso, Logradouro, Bairro e o Complemento das pessoas que possuem mais de dois filhos
            var consulta4 = PessoaCollection.Where(pessoa => pessoa.Filhos != null && pessoa.Filhos.Count > 2)
               .Select(p => new
               {
                   Nome = p.Nome,
                   DataNascimento = p.DataNascimento.ToString("dd/MM/yyyy"),
                   Peso = p.Peso,
                   Logradouro = p.Endereco.Logradouro,
                   Bairro = p.Endereco.Bairro,
                   Complemento = p.Endereco.Complemento

               }).ToList();

            foreach (var pessoa in consulta4)                
            {
                Console.WriteLine($"Nome: {pessoa.Nome}");
                Console.WriteLine($"Data de Nascimento: {pessoa.DataNascimento}");
                Console.WriteLine($"Peso: {pessoa.Peso}");
                Console.WriteLine($"Logradouro: {pessoa.Logradouro}");
                Console.WriteLine($"Logradouro: {pessoa.Bairro}");
                Console.WriteLine($"Complemento: {pessoa.Complemento}");
            }
            Console.WriteLine("\n------------------\n");

            //• Exiba Nome, a Idade e a Altura das pessoas que não possuem filhos.
            var consulta5 = PessoaCollection.Where(pessoa => pessoa.Filhos == null || !(pessoa.Filhos.Any())).ToList();
            foreach (var pessoa in consulta5)
            {
                int idade = DateTime.Today.Year - pessoa.DataNascimento.Year;
                if (DateTime.Today.DayOfYear < pessoa.DataNascimento.DayOfYear)
                    idade--;
                Console.WriteLine($"Nome: {pessoa.Nome}  Idade:{idade} Altura:{pessoa.Altura}");
            }
            Console.WriteLine("\n------------------\n");

            //• Exiba o Nome das pessoas com os seus respectivos filhos(Nome e Data de Nascimento)

            var consulta6 = PessoaCollection.Where(pessoa => pessoa.Filhos != null && pessoa.Filhos.Any())
                .Select(p => new
                {
                    p.Nome,
                    p.DataNascimento,
                    Filhos = p.Filhos.Select(f => new
                    {
                        f.Nome,
                        f.DataNascimento
                    }).ToList()
                })
                .ToList();

            foreach (var pessoa in consulta6)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}");
                Console.WriteLine($"Data nascimento: {pessoa.DataNascimento.ToString("dd/MM/yyyy")}");

                foreach (var filho in pessoa.Filhos)
                {
                    Console.WriteLine($"Nome Filho: {filho.Nome}");
                    Console.WriteLine($"Data nascimento: {filho.DataNascimento.ToString("dd/MM/yyyy")}");
                }
            }
            Console.WriteLine("\n------------------\n");

            //• Quantidade de Pessoas que possuam Filhos maiores de 25 anos
            int quantidade=PessoaCollection.Count(pessoa => pessoa.Filhos != null && pessoa.Filhos.Where(filho => DateTime.Now.Year - filho.DataNascimento.Year > 25).Any());
            Console.WriteLine($"Quantidade: {quantidade}");


        }


    }
}
