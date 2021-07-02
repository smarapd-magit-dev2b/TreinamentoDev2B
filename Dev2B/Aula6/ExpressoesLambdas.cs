using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aula6.Exemplo1AulaClasses;
using Aula6.Exercicio1Classes;

namespace Aula6
{
    public class ExpressoesLambdas
    {
        public void Execute()
        {
            //Exemplo1Aula();
            Ex1();
        }

        private void Exemplo1Aula()
        {
            List<PessoaExemplo> PessoaCollection1 = new List<PessoaExemplo>
            {
                new PessoaExemplo
                {
                    Id = 1,
                    Nome = "José",
                    Altura = 1.9m,
                    DataNascimento = new DateTime(1993, 12, 9),
                    Peso = 80.0m,
                    Raca = "Branca",
                    Endereco = new EnderecoExemplo { Logradouro = "Rua Altair Gonçalves", Bairro = "Vila Tibério", Complemento = "Apartamento", Numero = 85 },
                    Filhos = new List<PessoaExemplo>
                                    {
                                        new PessoaExemplo
                                        {
                                            Id = 2,
                                            Nome = "Felipe",
                                            Altura = 1.5m,
                                            DataNascimento = new DateTime(2000, 3, 3),
                                            Peso = 50.0m,
                                            Raca = "Branca",
                                            Endereco = new EnderecoExemplo { Logradouro = "Rua Altair Gonçalves", Bairro = "Vila Tibério", Complemento = "Apartamento", Numero = 85 },
                                            Filhos = null
                                        },
                                        new PessoaExemplo
                                        {
                                            Id = 3,
                                            Nome = "Luis",
                                            Altura = 1.9m,
                                            DataNascimento = new DateTime(1999, 3, 15),
                                            Peso = 100.0m,
                                            Raca = "Branca",
                                            Endereco = new EnderecoExemplo { Logradouro = "Rua Altair Gonçalves", Bairro = "Vila Tibério", Complemento = "Apartamento", Numero = 85 },
                                            Filhos = null
                                        }
                                    }
                },
                new PessoaExemplo
                {
                    Id = 4,
                    Nome = "Willian",
                    Altura = 1.7m,
                    DataNascimento = new DateTime(1950, 10, 4),
                    Peso = 100.0m,
                    Raca = "Negro",
                    Endereco = new EnderecoExemplo { Logradouro = "Rua Guilherme Schmdit", Bairro = "Centro", Complemento = "Casa", Numero = 111 },
                    Filhos = new List<PessoaExemplo>
                                    {
                                        new PessoaExemplo
                                        {
                                            Id = 5,
                                            Nome = "Joaquim",
                                            Altura = 2m,
                                            DataNascimento = new DateTime(1986, 5, 3),
                                            Peso = 50.0m,
                                            Raca = "Negro",
                                            Endereco = new EnderecoExemplo { Logradouro = "Avenida Benedito Ferreira", Bairro = "Vila Almeida", Complemento = "Apartamento", Numero = 99 },
                                            Filhos = null
                                        },
                                        new PessoaExemplo
                                        {
                                            Id = 6,
                                            Nome = "Gabriel",
                                            Altura = 1.3m,
                                            DataNascimento = new DateTime(2005, 5, 15),
                                            Peso = 69.0m,
                                            Raca = "Negro",
                                            Endereco = new EnderecoExemplo { Logradouro = "Rua Guilherme Schmdit", Bairro = "Centro", Complemento = "Casa", Numero = 111 },
                                            Filhos = null
                                        },
                                        new PessoaExemplo
                                        {
                                            Id = 7,
                                            Nome = "Pedro",
                                            Altura = 1.86m,
                                            DataNascimento = new DateTime(1995, 7, 22),
                                            Peso = 69.5m,
                                            Raca = "Negro",
                                            Endereco = new EnderecoExemplo { Logradouro = "Rua Guilherme Schmdit", Bairro = "Centro", Complemento = "Casa", Numero = 111 },
                                            Filhos = null
                                        }
                                    }
                },
                new PessoaExemplo
                {
                    Id = 4,
                    Nome = "Silas",
                    Altura = 1.78m,
                    DataNascimento = new DateTime(1968, 2, 2),
                    Peso = 92.0m,
                    Raca = "Branca",
                    Endereco = new EnderecoExemplo { Logradouro = "Rua Joaquim Nabuco", Bairro = "Bairro Xis", Complemento = "Casa", Numero = 854 },
                    Filhos = null
                }
            };

            List<PessoaExemplo> PessoaCollection2 = new List<PessoaExemplo> { };

            var resultado = PessoaCollection1.Where(x => x.Id == 1).FirstOrDefault();

            var resultado1 = PessoaCollection1.Where(x => x.Nome.Contains("a")).ToList();

            var resultadoAny = PessoaCollection1.Where(x => x.Filhos != null && x.Filhos.Any()).ToList();

            var resultadoAny2 = PessoaCollection1.Any();

            var resultadoCount = PessoaCollection1.Count();

            var resultadoCount2 = PessoaCollection2.Count();

            var resultadoSelect = PessoaCollection1.Select(t => new
            {
                Nome = t.Nome,
                Id = t.Id,
                //Filhos = t.Filhos.Select(a => new
                //{
                //    Nome = a.Nome,
                //}).ToList(),
            }).OrderBy(x => x.Nome).ToList();

            foreach (var pessoa in resultadoSelect)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}");
                Console.WriteLine($"Id: {pessoa.Id}");
                Console.WriteLine($"-------------------");
            }
        }

        private void Ex1()
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
                                            DataNascimento = new DateTime(1990, 3, 15),
                                            Peso = 100.0m,
                                            Raca = "Branca",
                                            Endereco = new Endereco { Logradouro = "Rua Altair Gonçalves", Bairro = "Vila Tibério", Complemento = "Apartamento", Numero = 85 },
                                            Filhos = null
                                        }
                                    }
                },
                new Pessoa
                {
                    Id = 4,
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

            //Exiba todas as pessoas que contenha a letra “a” no nome.
            var exercicio1 = PessoaCollection.Where(x => x.Nome.Contains("a")).ToList();
            Console.WriteLine($"\nExercicio 1");
            foreach (var item in exercicio1)
            {
                Console.WriteLine($"\nId: {item.Id}");
                Console.WriteLine($"Nome: {item.Nome}");
            }

            //Exiba o Nome, a Idade e a Altura das pessoas que contenha a letra “a” no Logradouro de seu Endereço.
            var exercicio2 = PessoaCollection.Where(x => x.Endereco.Logradouro.Contains("a"))
                .Select(x => new
                {
                    Nome = x.Nome,
                    Idade = DateTime.Now.Year - x.DataNascimento.Year,
                    Altura = x.Altura
                }).ToList();
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"\nExercicio 2");
            foreach (var item in exercicio2)
            {
                Console.WriteLine($"\nNome: {item.Nome}");
                Console.WriteLine($"Idade: {item.Idade}");
                Console.WriteLine($"Altura: {item.Altura} m");
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine($"\nExercicio 3");
            //Exiba o Nome de todas as pessoas que possuem filhos
            var exercicio3 = PessoaCollection.Where(x => x.Filhos != null && x.Filhos.Any())
                .Select(x => new
                {
                    Nome = x.Nome
                }).ToList();
            foreach (var item in exercicio3)
            {
                Console.WriteLine($"Nome: {item.Nome}");
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine($"\nExercicio 4");
            /*Exiba o Nome, Data Nascimento, Peso, Logradouro, Bairro
            e o Complemento das pessoas que possuem mais de dois filhos*/
            var exercicio4 = PessoaCollection.Where(x => x.Filhos != null && x.Filhos.Count() == 2)
                .Select(x => new
                {
                    Nome = x.Nome,
                    DataNascimento = x.DataNascimento,
                    Peso = x.Peso,
                    Logradouro = x.Endereco.Logradouro,
                    Bairro = x.Endereco.Bairro,
                    Complemento = x.Endereco.Complemento
                }).ToList();
            foreach (var item in exercicio4)
            {
                Console.WriteLine($"\nNome: {item.Nome}");
                Console.WriteLine($"Data de Nascimento: {item.DataNascimento.ToString("dd/MM/yyyy")}");
                Console.WriteLine($"Peso: {item.Peso} kg");
                Console.WriteLine($"Logradouro: {item.Logradouro}");
                Console.WriteLine($"Bairro: {item.Bairro}");
                Console.WriteLine($"Complemento: {item.Complemento}");
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine($"\nExercicio 5");
            //Exiba Nome, a Idade e a Altura das pessoas que não possuem filhos
            var exercicio5 = PessoaCollection.Where(x => x.Filhos == null)
                .Select(x => new
                {
                    Nome = x.Nome,
                    Idade = DateTime.Now.Year - x.DataNascimento.Year,
                    Altura = x.Altura
                }).ToList();
            foreach (var item in exercicio5)
            {
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Idade: {item.Idade}");
                Console.WriteLine($"Altura: {item.Altura} m");
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine($"\nExercicio 6");
            //Exiba o Nome das pessoas com os seus respectivos filhos(Nome e Data de Nascimento)
            var exercicio6 = PessoaCollection.Where(x => x.Filhos != null && x.Filhos.Any())
                .Select(x => new
                {
                    Nome = x.Nome,
                    Filhos = x.Filhos.Select(f => new
                    {
                        NomeFilhos = f.Nome,
                        DataNascFilhos = f.DataNascimento
                    }).ToList(),
                }).ToList();
            foreach (var item in exercicio6)
            {
                Console.WriteLine($"\nNome: {item.Nome}");
                foreach (var itemF in item.Filhos)
                {
                    Console.WriteLine($"Nome do filho: {itemF.NomeFilhos}");
                    Console.WriteLine($"Data de nascimento do filho: {itemF.DataNascFilhos.ToString("dd/MM/yyyy")}");
                }
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"\nExercicio 7");
            //Quantidade de Pessoas que possuam Filhos maiores de 25 anos
            var exercicio7 = PessoaCollection.Count(x => x.Filhos != null && x.Filhos
            .Where(f => DateTime.Now.Year - f.DataNascimento.Year > 25).Any());

            Console.WriteLine($"Quantidade de pessoas: " + exercicio7);

            Console.WriteLine("-------------------------------");
            Console.WriteLine($"\nExercicio 8");
            //Agrupar por raça e mostrar o nome da raça e quantidade
            var exercicio8 = PessoaCollection.Where(x => x.Raca != null).Select(x => new {
                Raca = x.Raca,
                Nome = x.Nome,
            }).GroupBy(x => x.Raca).ToList();


            foreach (var grupo in exercicio8)
            {
                Console.WriteLine($"\n{grupo.Key}");
                int i = 0;

                foreach (var pessoa in grupo)
                {
                    Console.WriteLine($"Nome: {pessoa.Nome}");
                    i++;
                }
                Console.WriteLine($"Quantidade: {i}");
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine($"\nExercicio 9");
            //Mostrar a pessoa de menor peso, não precisa considerar filhos
            var exercicio9 = PessoaCollection.OrderBy(x => x.Peso).FirstOrDefault();

            Console.WriteLine($"Nome: {exercicio9.Nome}");
            Console.WriteLine($"Peso: {exercicio9.Peso}");


            Console.WriteLine("-------------------------------");
            Console.WriteLine($"\nExercicio 10");
            //Mostrar a pessoa de maior altura, não precisa considerar filhos
            var exercicio10 = PessoaCollection.OrderByDescending(x => x.Altura).FirstOrDefault();
            Console.WriteLine($"Nome: {exercicio10.Nome}");
            Console.WriteLine($"Altura: {exercicio10.Altura}m.");

            Console.WriteLine("-------------------------------");
            Console.WriteLine($"\nExercicio 11");
            //Listar todos os nomes agrupados pela primeira letra
            var exercicio11 = PessoaCollection.OrderBy(x => x.Nome).GroupBy(x => x.Nome.First()).ToList();

            foreach (var grupo in exercicio11)
            {
                Console.WriteLine($"\n{grupo.Key}");

                foreach (var nome in grupo)
                {
                    Console.WriteLine($"Nome: {nome.Nome}");
                }
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine($"\nExercicio 12");
            //Mostrar as pessoas ordenadas de menor idade para maior idade
            var exercicio12 = PessoaCollection.OrderBy(x => DateTime.Now.Year - x.DataNascimento.Year)
                .Select(x => new {
                    Nome = x.Nome,
                    Idade = DateTime.Now.Year - x.DataNascimento.Year, 
                }).ToList();

            foreach (var item in exercicio12)
            {
                Console.WriteLine($"\nNome: {item.Nome}");
                Console.WriteLine($"Idade: {item.Idade}");
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine($"\nExercicio 13");
            // Listar os nomes de todos os filhos
            var exercicio13 = PessoaCollection.Where(x => x.Filhos != null && x.Filhos.Any())
                .SelectMany(x => x.Filhos).Select(x => x.Nome).ToList();
            Console.WriteLine("\nNome dos filhos");
            foreach (var item in exercicio13)
            {
                    Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine($"\nExercicio 14");
            //Média de altura, incluindo filhos
            var exercicio14 = PessoaCollection.Union(PessoaCollection.Where(x => x.Filhos != null).SelectMany(x => x.Filhos)).Average(x => x.Altura);
            Console.WriteLine($"Média de alturas: {exercicio14}m");

        }
    }

}
