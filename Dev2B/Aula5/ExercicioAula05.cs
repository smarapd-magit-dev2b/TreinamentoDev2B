using Aula5.Classes.ClassesExe01;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5 {
    public class ExercicioAula05 {
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
                    Endereco = new EnderecoExemplo { Logradouro = "Rua Altair Gonçalves", Bairro = "Vila Tibério", Complemento = "Apartamento", Numero = 85 },
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
                                            Endereco = new EnderecoExemplo { Logradouro = "Rua Altair Gonçalves", Bairro = "Vila Tibério", Complemento = "Apartamento", Numero = 85 },
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
                                            Endereco = new EnderecoExemplo { Logradouro = "Rua Altair Gonçalves", Bairro = "Vila Tibério", Complemento = "Apartamento", Numero = 85 },
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
                    Endereco = new EnderecoExemplo { Logradouro = "Rua Guilherme Schmdit", Bairro = "Centro", Complemento = "Casa", Numero = 111 },
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
                                            Endereco = new EnderecoExemplo { Logradouro = "Avenida Benedito Ferreira", Bairro = "Vila Almeida", Complemento = "Apartamento", Numero = 99 },
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
                                            Endereco = new EnderecoExemplo { Logradouro = "Rua Guilherme Schmdit", Bairro = "Centro", Complemento = "Casa", Numero = 111 },
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
                                            Endereco = new EnderecoExemplo { Logradouro = "Rua Guilherme Schmdit", Bairro = "Centro", Complemento = "Casa", Numero = 111 },
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
                    Endereco = new EnderecoExemplo { Logradouro = "Rua Joaquim Nabuco", Bairro = "Bairro Xis", Complemento = "Casa", Numero = 854 },
                    Filhos = null
                }
            };

        public void Executar() {
            Exercicio01();
        }
        private void Exercicio01() {

            bool rodando = true;
            while (rodando) {
                Console.Clear();
                Console.Write("\t\t\t--------MENU--------\n" +
                              "[1] - Exibia todas as pessoas que tenha a letra 'A' no nome\n" +
                              "[2] - Exibia o Nome, Idade e Altura das pessoas que contém a letra 'A' no logradoro\n" +
                              "[3] - Exibia o Nome das pessoas que possui filhos\n" +
                              "[4] - Exiba o Nome, Data Nascimento, Peso, Logradouro, Bairro e o Complemento das pessoas que possuem mais de 2 filhos\n" +
                              "[5] - Exiba Nome, a Idade e a Altura das pessoas que não possuem filhos\n" +
                              "[6] - Exiba o Nome das pessoas com os seus respectivos filhos (Nome e Data de Nascimento)\n" +
                              "[7] - Quantidade de Pessoas que possuam Filhos maiores de 25 anos\n" +
                              "[8] - Agrupar por raça e mostrar o nome da raça e quantidade\n" +
                              "[9] - Mostrar a pessoa de menor peso, não precisa considerar filhos\n" +
                              "[10] - Mostrar a pessoa de maior altura, não precisa considerar filhos\n" +
                              "[11] - Listar todos os nomes agrupados pela primeira letra\n" +
                              "[12] - Mostrar as pessoas ordenadas de menor idade para maior idade\n" +
                              "[13] - Listar os nomes de todos os filhos\n" +
                              "[14] - Média de altura, incluindo filhos\n" +
                              "[0] - Sair\n" +
                              "Escolha: ");
                int enummenu = int.Parse(Console.ReadLine());

                switch (enummenu) {
                    case (int)EnumMenu.PESSOAS_COM_LETRA_A:
                        var resultado1 = PessoaCollection.Where(x => x.Nome.Contains("a")).ToList();

                        foreach (var pessoas in resultado1) {
                            Console.WriteLine($"-------------------\n" +
                                              $"Nome: {pessoas.Nome}\n" +
                                              $"-------------------\n");
                        }
                        Console.ReadKey();
                        break;

                    case (int)EnumMenu.NOME_IDADE_ALTURA_LETRA_A:
                        var resultado2 = PessoaCollection.Where(x => x.Endereco.Logradouro.Contains("a"))
                            .Select(x => new {
                                Nome = x.Nome,
                                Idade = DateTime.Now.Year - x.DataNascimento.Year,
                                Altura = x.Altura
                            }).ToList();

                        foreach (var pessoas in resultado2) {
                            Console.WriteLine($"-------------------\n" +
                                              $"Nome: {pessoas.Nome}\n" +
                                              $"Idade: {pessoas.Idade} anos\n" +
                                              $"Altura: {pessoas.Altura.ToString("F2", CultureInfo.InvariantCulture)} metros\n" +
                                              $"--------------------\n");
                        }
                        Console.ReadKey();
                        break;

                    case (int)EnumMenu.NOME_DAS_PESSOAS_COM_FILHOS:
                        var resultado3 = PessoaCollection.Where(x => x.Filhos != null && x.Filhos.Any());

                        foreach (var pessoas in resultado3) {
                            Console.WriteLine($"-------------------\n" +
                                              $"Nome: {pessoas.Nome}\n" +
                                              $"-------------------\n");
                        }
                        Console.ReadKey();
                        break;

                    case (int)EnumMenu.NOME_DATA_PESO_LOGRADORO_BAIRRO_COMPLEMENTO_DE_PESSOAS_COM_FILHOS:
                        var resultado4 = PessoaCollection.Where(x => x.Filhos != null && x.Filhos.Count() > 2)
                            .Select(x => new {
                                Nome = x.Nome,
                                DataNascimento = x.DataNascimento,
                                Peso = x.Peso,
                                Logradora = x.Endereco.Logradouro,
                                Bairro = x.Endereco.Bairro,
                                Complemento = x.Endereco.Complemento
                            }).ToList();

                        foreach (var pessoas in resultado4) {
                            Console.WriteLine($"-------------------\n" +
                                              $"Nome: {pessoas.Nome}\n" +
                                              $"Data de Nascimento: {pessoas.DataNascimento.ToString("dd/MM/yyyy")}\n" +
                                              $"Peso: {pessoas.Peso.ToString("F2", CultureInfo.InvariantCulture)} Kg\n" +
                                              $"Logradora: {pessoas.Logradora}\n" +
                                              $"Bairro: {pessoas.Bairro}\n" +
                                              $"Complemento: {pessoas.Complemento}\n" +
                                              $"-------------------\n");
                        }
                        Console.ReadKey();
                        break;

                    case (int)EnumMenu.NOME_IDADE_ALTURA_DE_PESSOAS_SEM_FILHOS:
                        var resultado5 = PessoaCollection.Where(x => x.Filhos == null)
                            .Select(x => new {
                                Nome = x.Nome,
                                Idade = DateTime.Now.Year - x.DataNascimento.Year,
                                Altura = x.Altura
                            });

                        foreach (var pessoas in resultado5) {
                            Console.WriteLine($"-------------------\n" +
                                              $"Nome: {pessoas.Nome}\n" +
                                              $"Idade: {pessoas.Idade} anos\n" +
                                              $"Altura: {pessoas.Altura.ToString("F2", CultureInfo.InvariantCulture)} metros\n" +
                                              $"------------------\n");
                        }
                        Console.ReadKey();
                        break;

                    case (int)EnumMenu.NOME_E_NOME_DOS_FILHOS:
                        var resultado6 = PessoaCollection.Where(x => x.Filhos != null)
                             .Select(x => new {
                                 Nome = x.Nome,
                                 Filhos = x.Filhos.Select(y => new {
                                     Nome = y.Nome,
                                     DataNascimento = y.DataNascimento
                                 }).ToList()
                             }).ToList();

                        foreach (var pessoas in resultado6) {
                            Console.WriteLine($"-------------------\n" +
                                              $"Nome do pai: {pessoas.Nome}\n");
                            foreach (var filhos in pessoas.Filhos) {
                                Console.WriteLine($"Nome do filho: {filhos.Nome}\n" +
                                                  $"Data de nascimento: {filhos.DataNascimento.ToString("dd/MM/yyyy")}\n");


                            }
                            Console.WriteLine("-------------------\n");
                        }
                        Console.ReadKey();
                        break;

                    case (int)EnumMenu.FILHOS_MAIS_25ANOS:
                        var resultado7 = PessoaCollection.Count(x => x.Filhos != null &&
                        x.Filhos.Where(y => DateTime.Now.Year - y.DataNascimento.Year > 25).Any());

                        Console.WriteLine($"Quantidade: {resultado7}");

                        Console.ReadKey();
                        break;

                    case (int)EnumMenu.AGRUPAR_POR_RACA:
                        var resultado8 = PessoaCollection.Where(x => x.Raca != null)
                            .Select(x => new {
                                Nome = x.Nome,
                                Raca = x.Raca
                            }).GroupBy(x => x.Raca).ToList();

                        foreach (var grupo in resultado8) {
                            Console.WriteLine("---------------------\n" + grupo.Key);
                            int i = 0;

                            foreach (var pessoa in grupo) {
                                Console.WriteLine($"Nome: {pessoa.Nome}");
                                i++;
                            }
                            Console.WriteLine($"Quantidade: {i}");
                        }
                        Console.ReadKey();
                        break;

                    case (int)EnumMenu.MOSTRAR_PESSOA_MENOR_PESO:
                        var resultado9 = PessoaCollection.OrderBy(x => x.Peso).FirstOrDefault();

                        Console.WriteLine($"Nome: {resultado9.Nome}");
                        Console.WriteLine($"Peso: {resultado9.Peso.ToString("F2", CultureInfo.InvariantCulture)} KG");
                        Console.ReadKey();
                        break;

                    case (int)EnumMenu.MOSTRAR_MAIOR_ALTURA:
                        var resultado10 = PessoaCollection.OrderByDescending(x => x.Altura).FirstOrDefault();

                        Console.WriteLine($"Nome: {resultado10.Nome}");
                        Console.WriteLine($"Altura: {resultado10.Altura.ToString("F2", CultureInfo.InvariantCulture)} metros");
                        Console.ReadKey();
                        break;

                    case (int)EnumMenu.AGRUPAR_NOMES_PELA_PRIMEIRA_LETRA:
                        var resultado11 = PessoaCollection.OrderBy(x => x.Nome).GroupBy(x => x.Nome.First());

                        foreach (var grupos in resultado11) {
                            Console.WriteLine("---------------------");
                            Console.WriteLine(grupos.Key);
                            foreach (var nomes in grupos) {
                                Console.WriteLine($"Nome: {nomes.Nome}");
                            }
                        }
                        Console.ReadKey();
                        break;
                    case (int)EnumMenu.MOSTRAR_ORDEM_MENOR_MAIOR_IDADE:
                        var resultado12 = PessoaCollection.OrderByDescending(x => x.DataNascimento);

                        foreach (var pessoas in resultado12) {
                            Console.WriteLine("---------------\n" +
                                              $"Nome: {pessoas.Nome}\n" +
                                              $"Idade: {DateTime.Now.Year - pessoas.DataNascimento.Year}\n");
                        }
                        Console.ReadKey();
                        break;

                    case (int)EnumMenu.LISTAR_NOMES_TODOS:
                        var resultado13 = PessoaCollection.Where(x => x.Filhos != null && x.Filhos.Any())
                            .SelectMany(x => x.Filhos).Select(x => x.Nome).ToList();

                        Console.WriteLine("---------------");
                        foreach (var item in resultado13) {
                            Console.WriteLine("Nome: " + item);
                        }

                        Console.ReadKey();
                        break;

                    case (int)EnumMenu.MEDIA_ALTURA:
                        var resultado14 = PessoaCollection.Union(PessoaCollection.Where(x => x.Filhos != null).SelectMany(y => y.Filhos)).Average(z => z.Altura);

                        Console.WriteLine($"Média das alturas: {resultado14.ToString("F2", CultureInfo.InvariantCulture)}");
                        Console.ReadKey();
                        break;

                    case (int)EnumMenu.SAIR:
                        Console.WriteLine("Saindo...");
                        rodando = false;
                        break;

                    default:
                        Console.WriteLine("Opção Invalida...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
