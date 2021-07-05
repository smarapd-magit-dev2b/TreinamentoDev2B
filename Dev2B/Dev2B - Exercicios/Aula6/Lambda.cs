using Aula6;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambdas
{
    public class Lambda
    {
        public List<Pessoa> PessoaCollection { get; set; }

        string resposta;

        EnumOp opcao;

        public void Execute()
        {
            Lambdas();
        }
        private void Lambdas()
        {


            PessoaCollection = new List<Pessoa>
            {
                new Pessoa
                {
                    Id = 1,

                    Nome = "José",

                    Altura = 1.9m,

                    DataNascimento = new DateTime(1993, 12, 9),

                    Idade = 28,

                    Peso = 80.0m,

                    Raca = "Branca",

                    Endereco = new Endereco { Logradouro = "Rua Altair Gonçalves", Bairro = "Vila Tibério", Complemento = "Apartamento", Numero = 85 },

                    Filhos =  new List<Pessoa>
                    {
                        new Pessoa
                        {

                            Id = 2,

                            Nome = "Felipe",

                            Altura = 1.5m,

                            DataNascimento = new DateTime(2000, 3, 3),

                            Idade = 21,

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

                            Idade = 31,

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

                    Idade = 71,

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

                            Idade = 35,

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

                            Idade = 16,

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

                            Idade = 26,

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

                    Idade = 53,

                    Peso = 92.0m,

                    Raca = "Branca",

                    Endereco = new Endereco { Logradouro = "Rua Joaquim Nabuco", Bairro = "Bairro Xis", Complemento = "Casa", Numero = 854 },

                    Filhos = null
                }
            };

            do
            {
                Console.WriteLine("\n\nMenu de Opções");
                Console.WriteLine("1) Exibir todos os nomes com que contenha a letra 'a' no nome.\n2) Exibir o nome, a idade e a altura as pessoas que tenha 'a' no logradouro.\n" +
                "3) Exibir pessoas que possuem filhos.\n4) Exibir as pessoas que possuem mais de 2 filhos.\n5) Exibir pessoas que não possuem filhos.\n6) Exibir o nome dos pais e de seus filhos.\n" +
                "7) Exibir filhos maiores de 25 anos.\n8) Agrupar por raça.\n9) Mostrar menor peso.\n10) Exibir maior altura.\n11) Exibir nomes agrupados pela letra inicial.\n" +
                "12) Exibir pessoas ordenas em ordem crescente por idade.\n13) Exibir nome dos filhos.\n14) Exibir média de todas as pessoas.\n" +
                "15) Exibir pessoas com mais de 90 anos.\n16) Exibir Idade das pessoas.");
                Console.WriteLine("\nEscolha: ");

                opcao = (EnumOp)Enum.Parse(typeof(EnumOp), Console.ReadLine());

                Console.Clear();

                switch (opcao)
                {
                    case EnumOp.ExibirA:
                        {
                            var nomesComA = PessoaCollection.Where(x => x.Nome.Contains("b")).ToList();
                            if (nomesComA.Count > 0)
                            {
                                foreach (var pessoa in nomesComA)
                                {
                                    Console.WriteLine(pessoa);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Não existe dados...");
                            }

                            break;
                        }
                    case EnumOp.ExibirEndA:
                        {
                            var endComA = PessoaCollection.Where(e => e.Endereco.Logradouro.Contains("a")).Select(e => new
                            {
                                e.Nome,
                                e.Altura,
                                e.Idade
                            }).ToList();

                            if (endComA.Count > 0)
                            {
                                foreach (var pessoa in endComA)
                                {
                                    Console.WriteLine(pessoa);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Não existem dados...");
                            }
                            break;
                        }
                    case EnumOp.ExibirPais:
                        {
                            var pais = PessoaCollection.Where(f => f.Filhos != null && f.Filhos.Any()).ToList();
                            if (pais.Count > 0)
                            {
                                foreach (var pessoa in pais)
                                {
                                    Console.WriteLine(pessoa);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Não existem dados...");
                            }
                            break;
                        }
                    case EnumOp.ExibirMaisDoisFilhos:
                        {
                            var filhos = PessoaCollection.Where(filhos => filhos.Filhos != null && filhos.Filhos.Count() > 2).Select(pessoa => new
                            {
                                pessoa.Nome,
                                pessoa.DataNascimento,
                                pessoa.Peso,
                                pessoa.Endereco.Logradouro,
                                pessoa.Endereco.Bairro,
                                pessoa.Endereco.Complemento

                            }).ToList();

                            if (filhos.Count > 0)
                            {
                                foreach (var pessoa in filhos)
                                {
                                    Console.WriteLine(pessoa);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Não existem dados...");
                            }
                            break;
                        }
                    case EnumOp.ExibirPessoaSemFilho:
                        {
                            var semFilho = PessoaCollection.Where(filhos => filhos.Filhos == null).Select(pessoa => new
                            {
                                pessoa.Nome,
                                pessoa.Idade,
                                pessoa.Altura

                            }).ToList();

                            if (semFilho.Count > 0)
                            {
                                foreach (var pessoa in semFilho)
                                {
                                    Console.WriteLine(pessoa);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Não existem dados...");
                            }
                            break;
                        }
                    case EnumOp.ExibirFamilia:
                        {
                            var familia = PessoaCollection.Where(x => x.Filhos != null && x.Filhos.Any()).Select(x => new
                            {
                                x.Nome,
                                x.Filhos

                            }).ToList();

                            if (familia.Count > 0)
                            {
                                foreach (var pessoa in familia)
                                {
                                    Console.WriteLine(pessoa.Nome);

                                    foreach (var filho in pessoa.Filhos)
                                    {
                                        Console.WriteLine(filho.Nome);
                                        Console.WriteLine(filho.DataNascimento.Date);
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Não existem dados...");
                            }

                            break;
                        }
                    case EnumOp.ExibirFilhosMaiores:
                        {
                            var filhosMaiores = PessoaCollection.Where(x => x.Filhos != null && x.Filhos.Any()).Select(x => new
                            {
                                Idade = DateTimeHelper.Date(x.DataNascimento),
                                Nome = x.Nome
                            }).Where(x => x.Idade > 25).ToList();

                            if (filhosMaiores.Count > 0)
                            {
                                foreach (var pessoas in filhosMaiores)
                                {
                                    Console.WriteLine($"Pessoas com filhos maiores: {pessoas.Nome}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Não existem dados...");
                            }
                            break;
                        }        
                    case EnumOp.ExibirAgrupamento:
                        {

                            var agrupar = PessoaCollection.GroupBy(x => x.Raca).Select(x => new { Raca = x.Key, Qntd = x.Count() }).ToList();

                            if (agrupar.Count > 0)
                            {
                                foreach (var pessoa in agrupar)
                                {
                                    Console.WriteLine($"Raça: {pessoa.Raca} - Quantidade: {pessoa.Qntd}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Não existem dados...");
                            }
                            break;
                        }
                    case EnumOp.ExibirMenorPeso:
                        {
                            var menorPeso = PessoaCollection.Where(x => x.Peso == PessoaCollection.Min(x => x.Peso)).Select(x => new { Nome = x.Nome, Peso = x.Peso }).ToList();

                            if (menorPeso.Count > 0)
                            {
                                foreach (var pessoa in menorPeso)
                                {
                                    Console.WriteLine($"{pessoa.Nome} tem o menor peso dentre as pessoas: {pessoa.Peso}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Não existem dados...");
                            }


                            break;
                        }
                    case EnumOp.ExibirMaiorAltura:
                        {
                            var maiorAltura = PessoaCollection.Where(x => x.Altura == PessoaCollection.Max(x => x.Altura)).Select(x => new { Nome = x.Nome, Altura = x.Altura }).ToList();

                            if (maiorAltura.Count > 0)
                            {
                                Console.WriteLine($"Maior altura dentre as pessoas: {maiorAltura}");
                            }
                            else
                            {
                                Console.WriteLine("Não existem dados...");
                            }
                            break;
                        }
                    case EnumOp.ExibirPrimeiraLetra:
                        {
                            var primeiraLetra = PessoaCollection.GroupBy(x => x.Nome.First()).Select(x => new { x.Key, nomes = x.ToList() }).ToList();

                            if (primeiraLetra.Count > 0)
                            {
                                foreach (var pessoa in primeiraLetra)
                                {
                                    Console.WriteLine($"Primeira letra dos nomes -> {pessoa.Key}");
                                    foreach (var nome in pessoa.nomes)
                                    {
                                        Console.WriteLine($"Nomes: {nome.Nome}");
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Não existem dados...");
                            }
                            break;
                        }
                    case EnumOp.ExibirIdadeCrescente:
                        {
                            var idadeCrescente = PessoaCollection.OrderBy(x => x.Idade).Select(x => new
                            {
                                x.Idade,
                                x.Nome
                            }).ToList();

                            if (idadeCrescente.Count > 0)
                            {
                                foreach (var pessoa in idadeCrescente)
                                {
                                    Console.WriteLine($"Idade: {pessoa.Idade} | Nome: {pessoa.Nome}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Não existem dados...");
                            }
                            break;
                        }
                    case EnumOp.ExibirNomeFilhos:
                        {
                            var listarFilhos = PessoaCollection.Where(x => x.Filhos != null).SelectMany(x => x.Filhos).ToList();

                            if (listarFilhos.Count > 0)
                            {
                                foreach (var filho in listarFilhos)
                                {
                                    Console.WriteLine($"\nNome: {filho.Nome}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Não existem dados...");
                            }
                            break;
                        }
                    case EnumOp.ExibirMediaAltura:
                        {
                            var mediaAltura = PessoaCollection.Union(PessoaCollection.Where(x => x.Filhos != null).SelectMany(x => x.Filhos));
                            var pessoa = mediaAltura.Select(x => x.Altura);
                            var media = pessoa.Average();

                            Console.WriteLine($"Média de altura das pessoas: {media.ToString("F2")}m.");

                            break;
                        }
                    case EnumOp.ExibirMaiores90:
                        {
                            try
                            {
                                var idosos = PessoaCollection.Select(x => new
                                {
                                    Idade = new DateTime((DateTime.Now - x.DataNascimento).Ticks).Year,
                                }).Where(x => x.Idade > 90).ToList();

                                throw new NegocioException();

                                foreach (var pessoa in idosos)
                                {
                                    Console.WriteLine(idosos);
                                }
                            }
                            catch(NegocioException nex)
                            {
                                int idErro = NegocioError.LogarErro(nex);
                                Console.WriteLine("Erro de negócio: não existe pessoas com mais de 90 anos.");
                                Console.WriteLine($"Codigo do erro: {idErro}");
                                
                            }
                            


                            break;
                        }
                    case EnumOp.ExibirIdade:
                        {
                            var idades = PessoaCollection.Where(x => x.Filhos != null && x.Filhos.Any()).Select(x => new
                            {
                                Nome = x.Nome,
                                Data = DateTimeHelper.Date(x.DataNascimento)
                            }).ToList();

                            foreach (var pessoa in idades)
                            {
                                Console.WriteLine($"{pessoa.Nome} tem {pessoa.Data} anos de idade.");
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Opção Invalida!");
                            break;
                        }
                }

                Console.WriteLine("\n\nDeseja fazer mais uma verificação ?");
                resposta = Console.ReadLine();

            } while (resposta != "nao");
        }
    }
}
