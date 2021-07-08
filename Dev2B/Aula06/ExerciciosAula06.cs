using Aula06_Lambdas.ClassesAula06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula06_Lambdas
{

    public class ExerciciosAula06
    {
        public void Execute()
        {
            //Exercicio01();
            //Exercicio02();
            //Exercicio03();
            //Exercicio04();
            //Exercicio05();
            //Exercicio06();
            //Exercicio07();
            //Exercicio08();
            //Exercicio09();
            //Exercicio10();
            //Exercicio11();
            //Exercicio12();
            //Exercicio13();
            //Exercicio14();
        }

        List<Pessoa> ColecaoPessoa = new List<Pessoa>

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


        private void Exercicio01()
        {

            //-	Exiba todas as pessoas que contenha a letra “a” no nome.
            var exibir = ColecaoPessoa.Where(x => x.Nome.Contains("a")).ToList();

            foreach (var pessoa in exibir)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}");
            };
        }
        private void Exercicio02()
        {
            //- Exiba o Nome, a Idade e a Altura das pessoas que contenha a letra “a” no Logradouro de seu Endereço.
            var exibir = ColecaoPessoa.Where(x => x.Endereco.Logradouro.Contains("a") || x.Endereco.Logradouro.Contains("A"))
                                        .Select(x => new
                                        {
                                            x.Nome,
                                            x.Altura,
                                            x.DataNascimento
                                        })
                                         .ToList();

            if (exibir.Count > 0)
            {

                foreach (var pessoa in exibir)
                {
                    Console.WriteLine($"Nome: {pessoa.Nome}" +
                                      $"\nIdade: {new DateTime((DateTime.Now - pessoa.DataNascimento).Ticks).Year} " +
                                      $"\nAltura {pessoa.Altura}\n");
                }
            }
            else
                Console.WriteLine("Não existem pessoas morando em logradouros com a letra a");
        }
        private void Exercicio03()
        {
            //- Exiba o Nome de todas as pessoas que possuem filhos

            var exibir = ColecaoPessoa.Where(x => x.Filhos != null).ToList();

            foreach (var pessoa in exibir)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}");
            }
        }
        private void Exercicio04()
        {
            //- Exiba o Nome, Data Nascimento, Peso, Logradouro, Bairro e o Complemento das pessoas que possuem mais de dois filhos
            var exibir = ColecaoPessoa.Where(x => x.Filhos != null && x.Filhos.Count > 2)
                                        .Select(x => new
                                        {
                                            x.Nome,
                                            x.DataNascimento,
                                            x.Peso,
                                            x.Endereco.Logradouro,
                                            x.Endereco.Bairro,
                                            x.Endereco.Complemento,
                                        })
                                        .ToList();

            if (exibir.Count > 0)
            {

                foreach (var pessoa in exibir)
                {
                    Console.WriteLine($"\nNome: {pessoa.Nome}" +
                                      $"\nIdade: {new DateTime((DateTime.Now - pessoa.DataNascimento).Ticks).Year} " +
                                      $"\nPeso: {pessoa.Peso}" +
                                      $"\nLogradouro: {pessoa.Logradouro}" +
                                      $"\nBairro: {pessoa.Bairro}" +
                                      $"\nComplemento: {pessoa.Complemento}\n");
                }
            }
            else
            {
                foreach (var pessoa in exibir)
                {
                    Console.WriteLine($"Não foi possível encontrar a informação desejada");
                }
            }
        }
        private void Exercicio05()
        {
            //- Exiba Nome, a Idade e a Altura das pessoas que não possuem filhos.
            var exibir = ColecaoPessoa.Where(x => x.Filhos == null || !x.Filhos.Any())
                                        .Select(x => new
                                        {
                                            x.Nome,
                                            x.DataNascimento,
                                            x.Altura,
                                        })
                                    .ToList();

            foreach (var pessoa in exibir)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}" +
                                      $"\nIdade: {new DateTime((DateTime.Now - pessoa.DataNascimento).Ticks).Year}" +
                                      $"\nAltura {pessoa.Altura}\n");
            }

        }
        private void Exercicio06()
        {
            //- Exiba o Nome das pessoas com os seus respectivos filhos(Nome e Data de Nascimento)
            var exibir = ColecaoPessoa.Where(x => x.Filhos != null && x.Filhos.Any())
                                        .Select(x => new
                                        {
                                            x.Nome,
                                            Filhos = x.Filhos.Select(y => new
                                            {
                                                y.Nome,
                                                y.DataNascimento,
                                            }).ToList()
                                        })
                                        .ToList();

            foreach (var pessoa in exibir)
            {
                Console.WriteLine($"Nome do pai: {pessoa.Nome}");

                foreach (var filho in pessoa.Filhos)
                {
                    Console.WriteLine($"Nome do filho: {filho.Nome}" +
                                      $"\nData de nascimento: {filho.DataNascimento.ToString("dd/MM/yyyy")}");
                }
                Console.WriteLine();
            }

        }
        private void Exercicio07()
        {
            //- Quantidade de Pessoas que possuam Filhos maiores de 25 anos

            var exibir = ColecaoPessoa.Count(x => x.Filhos != null && x.Filhos.Where(f => DateTime.Now.Year - f.DataNascimento.Year >= 25).Any());

            Console.WriteLine($"Pessoas que possuem mais de dois filhos: {exibir}");
        }
        private void Exercicio08()
        {
            //-Agrupar por raça e mostrar o nome da raça e quantidade

            var exibir = ColecaoPessoa.GroupBy(x => x.Raca);

            foreach (var grupo in exibir)
            {
                Console.WriteLine($"Raça: {grupo.Key}");
                int quantidadeRaca = 0;

                foreach (var pessoa in grupo)
                {
                    Console.WriteLine($"Nome: {pessoa.Nome}");
                    quantidadeRaca++;
                }
                Console.WriteLine($"Quantidade: {quantidadeRaca}");
                Console.WriteLine();
            }

        }
        private void Exercicio09()
        {
            //-Mostrar a pessoa de menor peso, não precisa considerar filhos

            var exibir = ColecaoPessoa.OrderBy(x => x.Peso).FirstOrDefault();

            Console.WriteLine($"Pessoa com menor peso: {exibir.Nome}");

        }
        private void Exercicio10()
        {
            //-Mostrar a pessoa de maior altura, não precisa considerar filhos.

            var exibir = ColecaoPessoa.OrderByDescending(x => x.Altura).FirstOrDefault();

            Console.WriteLine($"Pessoa com maior altura: {exibir.Nome}");
        }
        private void Exercicio11()
        {
            //-Listar todos os nomes agrupados pela primeira letra

            var exibir = ColecaoPessoa.OrderBy(y => y.Nome).GroupBy(x => x.Nome.First());

            foreach (var grupo in exibir)
            {
                Console.WriteLine($"{grupo.Key}");

                foreach (var pessoa in grupo)
                {
                    Console.WriteLine($"Nome: {pessoa.Nome}");
                }

                Console.WriteLine();

            }
        }
        private void Exercicio12()
        {
            //- Mostrar as pessoas ordenadas de menor idade para maior idade

            var exibir = ColecaoPessoa.OrderByDescending(x => x.DataNascimento);

            foreach (var pessoa in exibir)
            {
                Console.WriteLine($"Nome: {pessoa.Nome} Idade: {DateTime.Now.Year - pessoa.DataNascimento.Year}");
            }
        }
        private void Exercicio13()
        {
            //- Listar os nomes de todos os filhos

            var exibir = ColecaoPessoa.Where(x => x.Filhos != null).SelectMany(y => y.Filhos).ToList();

            foreach (var filho in exibir)
            {
                Console.WriteLine($"Nome: {filho.Nome}");
            }
        }
        private void Exercicio14()
        {
            //-Média de altura, incluindo filhos
            var exibir = ColecaoPessoa.Union(ColecaoPessoa.Where(x => x.Filhos != null)
                                        .SelectMany(y => y.Filhos))
                                        .Average(z => z.Altura);

            Console.WriteLine($"A média de altura (pais e filhos) é de: {exibir}");
        }
    }
}
