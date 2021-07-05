using Aula06.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula06
{
    public class ExpressoesLambdas
    {
        public void Execute()
        {
            Exercicio01();
        }

        static void Exercicio01()
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


            int x;
            do
            {
                Console.WriteLine("______________________________________________________________________________________________________________________________");
                Console.WriteLine("1 - Exiba todas as pessoas que contenha a letra “a” no nome.");
                Console.WriteLine("2 - Exiba o Nome, a Idade e a Altura das pessoas que contenha a letra “a” no Logradouro de seu Endereço.");
                Console.WriteLine("3 - Exiba o Nome de todas as pessoas que possuem filhos ");
                Console.WriteLine("4 - Exiba o Nome, Data Nascimento, Peso, Logradouro, Bairro e o Complemento das pessoas que possuem mais de dois filhos ");
                Console.WriteLine("5 - Exiba Nome, a Idade e a Altura das pessoas que não possuem filhos. ");
                Console.WriteLine("6 - Exiba o Nome das pessoas com os seus respectivos filhos(Nome e Data de Nascimento) ");
                Console.WriteLine("7 - Quantidade de Pessoas que possuam Filhos maiores de 25 anos ");
                Console.WriteLine("8 - Agrupar por raça e mostrar o nome da raça e quantidade ");
                Console.WriteLine("9 - Mostrar a pessoa de menor peso, não precisa considerar filhos ");
                Console.WriteLine("10 - Mostrar a pessoa de maior altura, não precisa considerar filhos ");
                Console.WriteLine("11 - Listar todos os nomes agrupados pela primeira letra ");
                Console.WriteLine("12 - Mostrar as pessoas ordenadas de menor idade para maior idade ");
                Console.WriteLine("13 - Listar os nomes de todos os filhos - Existe um melhor forma de ser feito ");
                Console.WriteLine("14 - Média de altura, incluindo filhos ");
                Console.WriteLine("15 - Sair ");
                Console.WriteLine("______________________________________________________________________________________________________________________________");
                Console.WriteLine("");

                bool result = int.TryParse(Console.ReadLine(), out x);

                switch (x)
                {
                    case 1:
                        {
                            listarTodasAsPessoasComLetraA();
                            break;
                        }
                    case 2:
                        {
                            listarTodasAsPessoasComLetraAlogradouro();
                            break;
                        }
                    case 3:
                        {
                            listarTodasAsPessoasQuePossuemFilhos();
                            break;
                        }
                    case 4:
                        {
                            pessoasComMaisDeDoisFilhos();
                            break;
                        }
                    case 5:
                        {
                            pessoasQueNaoPossuemFilhos();
                            break;
                        }
                    case 6:
                        {
                            exibirPessoasComSeusRespectivosFilhos();
                            break;
                        }
                    case 7:
                        {
                            quantidadePessoasFilhosMaioresDe25Anos();
                            break;
                        }
                    case 8:
                        {
                            agruparPorRacaNomeQuantidade();              
                            break;
                        }
                    case 9:
                        {
                            mostrarPessoaComMenorPeso();
                            break;
                        }
                    case 10:
                        {
                            mostrarPessoaComMaiorAltura();
                            break;
                        }
                    case 11:
                        {
                            listarNomesAgrupadadosPelaPrimeiraLetra();
                            break;
                        }
                    case 12:
                        {
                            ordernarMenorIdadeParaMaiorIdade();
                            break;
                        }
                    case 13:
                        {
                            listarOsNomesDeTodosOsFilhos();
                            break;
                        }
                    case 14:
                        {
                            mediaDeAlturaIncluindoFilhos();
                            break;
                        }
                    default:
                        {
                            if (x == 15)
                            {
                                Console.WriteLine("Thanks for using");
                            }
                            else
                            {
                                Console.WriteLine("Choose a numer from 1 to 15");
                            }
                            break;
                        }
                }
            } while (x != 15);




            void listarTodasAsPessoasComLetraA()
            {
                Console.WriteLine("_________Todas as Pessoas com contém a letra 'a' no nome_________");
                var pesquisa1 = PessoaCollection.Select(result => new
                {
                    Nome = result.Nome
                }).ToList();
                var pessoasComLetraA = pesquisa1.Where(pessoa => pessoa.Nome.Contains("a")).ToList();
                foreach (var pessoa in pessoasComLetraA)
                {
                    Console.WriteLine($"Nome: {pessoa.Nome}");
                }
                Console.WriteLine("\n_________________________________________________________________");
            }



            void listarTodasAsPessoasComLetraAlogradouro(){
                var pesquisa2 = PessoaCollection.Where(pessoa => pessoa.Endereco.Logradouro.Contains("a")).ToList();
                foreach (var pessoa in pesquisa2)
                {
                    int idade = DateTime.Today.Year - pessoa.DataNascimento.Year;
                    if (DateTime.Today.DayOfYear < pessoa.DataNascimento.DayOfYear)
                        idade--;
                    Console.WriteLine($"Nome: {pessoa.Nome}  Idade:{idade} Altura:{pessoa.Altura}");
                }
                Console.WriteLine("\n________________________________________________________");
            }
          


            void listarTodasAsPessoasQuePossuemFilhos()
            {
                var pesquisa3 = PessoaCollection.Where(pessoa => pessoa.Filhos != null && pessoa.Filhos.Any()).ToList();
                foreach (var pessoa in pesquisa3)
                {
                    Console.WriteLine($"Nome: {pessoa.Nome}");
                }
                Console.WriteLine("\n__________________________________________________________");
            }
            


            void pessoasComMaisDeDoisFilhos()
            {
                var pesquisa4 = PessoaCollection.Where(pessoa => pessoa.Filhos != null && pessoa.Filhos.Count > 2).Select(p => new
                {
                    Nome = p.Nome,
                    DataNascimento = p.DataNascimento.ToString("dd/MM/yyyy"),
                    Peso = p.Peso,
                    Logradouro = p.Endereco.Logradouro,
                    Bairro = p.Endereco.Bairro,
                    Complemento = p.Endereco.Complemento
                }).ToList();

                foreach (var pessoa in pesquisa4)
                {
                    Console.WriteLine($"Nome: {pessoa.Nome}");
                    Console.WriteLine($"Data Nascimento: {pessoa.DataNascimento}");
                    Console.WriteLine($"Peso: {pessoa.Peso}");
                    Console.WriteLine($"Logradouro: {pessoa.Logradouro}");
                    Console.WriteLine($"Bairro: {pessoa.Bairro}");
                    Console.WriteLine($"Complemento: {pessoa.Complemento}");
                }
                Console.WriteLine("\n______________________________________");
            }
           


            void pessoasQueNaoPossuemFilhos()
            {
                var pesquisa5 = PessoaCollection.Where(pessoa => pessoa.Filhos == null || !(pessoa.Filhos.Any())).ToList();
                foreach (var pessoa in pesquisa5)
                {
                    int idade = DateTime.Today.Year - pessoa.DataNascimento.Year;
                    if (DateTime.Today.DayOfYear < pessoa.DataNascimento.DayOfYear)
                        idade--;
                    Console.WriteLine($"Nome: {pessoa.Nome}  Idade:{idade} Altura:{pessoa.Altura}");
                }
            }
            


            void exibirPessoasComSeusRespectivosFilhos()
            {
                var pesquisa6 = PessoaCollection.Where(pessoa => pessoa.Filhos != null && pessoa.Filhos.Any())
                .Select(p => new
                {
                    p.Nome,
                    p.DataNascimento,
                    Filhos = p.Filhos.Select(f => new
                    {
                        f.Nome,
                        f.DataNascimento
                    }).ToList()
                }).ToList();

                foreach (var pessoa in pesquisa6)
                {
                    Console.WriteLine($"Nome: {pessoa.Nome}");
                    Console.WriteLine($"Data nascimento: {pessoa.DataNascimento.ToString("dd/MM/yyyy")}");

                    foreach (var filho in pessoa.Filhos)
                    {
                        Console.WriteLine($"Nome Filho: {filho.Nome}");
                        Console.WriteLine($"Data Nascimento: {filho.DataNascimento.ToString("dd/MM/yyyy")}");
                    }
                }
            }
            

            void quantidadePessoasFilhosMaioresDe25Anos()
            {
                var pesquisa7 = PessoaCollection.Count(x => x.Filhos != null && x.Filhos.Any(y => new DateTime((DateTime.Now - y.DataNascimento).Ticks).Year > 25));
                if (pesquisa7 != 0)
                {
                    Console.WriteLine($"Resultado: {pesquisa7}\n");
                }
                else
                {
                    Console.WriteLine("Nenhuma pessoa com filho com mais de 25 anos foi encontrada!}");
                }
            }

           
            void agruparPorRacaNomeQuantidade()
            {
                var pesquisa8 = PessoaCollection.GroupBy(x => x.Raca).ToList();

                foreach (var item in pesquisa8)
                {
                    Console.WriteLine($"Raca: {item.Key}");
                    var count = 0;
                    foreach (var n in item)
                    {
                        Console.WriteLine($"- Nome: {n.Nome}");
                        count++;
                    }

                    Console.WriteLine($"Quantidade: {count}");
                }
            }


            void mostrarPessoaComMenorPeso()
            {
                Console.WriteLine("________________( Menor Peso )________________");

                var pesquisa9 = PessoaCollection.OrderByDescending(x => x.Peso).Last();
                Console.WriteLine($"menor peso é: {pesquisa9.Nome} com {pesquisa9.Peso}");
            }


            void mostrarPessoaComMaiorAltura()
            {
                Console.WriteLine("________________( Maior Altura )________________");
                var pesquisa10 = PessoaCollection.OrderByDescending(x => x.Altura).FirstOrDefault();

                Console.WriteLine($"Pessoa com maior altura: {pesquisa10.Nome}");
            }
            

            void listarNomesAgrupadadosPelaPrimeiraLetra()
            {
                Console.WriteLine("\n_____________Listar todos os nomes agrupados pela primeira letra_____________");

                var pesquisa11 = PessoaCollection.GroupBy(x => x.Nome.First()).Select(x => new { x.Key, nomes = x.ToList() }).ToList();

                foreach (var pessoa in pesquisa11)
                {
                    Console.WriteLine($"Primeira letra dos nomes -> {pessoa.Key}");
                    foreach (var nome in pessoa.nomes)
                    {
                        Console.WriteLine($"Nomes: {nome.Nome}");
                    }
                }
            }


            void ordernarMenorIdadeParaMaiorIdade()
            {
                Console.WriteLine("\n___________menor idade para maior idade______________");
                var pesquisa12 = PessoaCollection.OrderByDescending(p => p.DataNascimento.Year).Select(g => new { g.Nome, g.DataNascimento });
                foreach (var pessoa in pesquisa12)
                {
                    Console.WriteLine($"Nome: {pessoa.Nome}  Idade:{new DateTime((DateTime.Now - pessoa.DataNascimento).Ticks).Year}");
                }
            }


            void listarOsNomesDeTodosOsFilhos()
            {
                Console.WriteLine("Nome de Todos os Filhos");
                var pesquisa13 = PessoaCollection.Where(pessoa => pessoa.Filhos != null && pessoa.Filhos.Any())
                   .Select(p => new
                   {
                       Filhos = p.Filhos.Select(f => new
                       {
                           f.Nome,
                       }).ToList()
                   }).ToList();

                foreach (var pessoa in pesquisa13)
                {
                    foreach (var filho in pessoa.Filhos)
                    {
                        Console.WriteLine($"Nome Filho: {filho.Nome}");
                    }
                }
            }

           
            void mediaDeAlturaIncluindoFilhos()
            {
                Console.WriteLine("__________( Média de Altura )__________");

                var pesquisa14 = PessoaCollection.Union(PessoaCollection
                        .Where(pessoa1 => pessoa1.Filhos != null)
                        .SelectMany(a => a.Filhos)).Average(x => x.Altura);

                Console.WriteLine($"Média de Altura e: {pesquisa14}");
            }
        }

        public List<Pessoa> PessoaCollection { get; set; }


    }
}
