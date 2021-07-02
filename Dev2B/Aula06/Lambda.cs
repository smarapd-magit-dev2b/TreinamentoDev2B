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
                    Nome = "William",
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
            Console.WriteLine("\nExiba todas as pessoas que contenha a letra “a” no nome.\n");
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
            Console.WriteLine("\nExiba o Nome, a Idade e a Altura das pessoas que contenha a letra “a” no Logradouro de seu Endereço.\n");

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
            Console.WriteLine("\nExiba o Nome de todas as pessoas que possuem filhos\n");
            var consulta3 = PessoaCollection.Where(pessoa => pessoa.Filhos != null && pessoa.Filhos.Any()).ToList();
            foreach (var pessoa in consulta3)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}");
            }
            Console.WriteLine("\n------------------\n");

            //• Exiba o Nome, Data Nascimento, Peso, Logradouro, Bairro e o Complemento das pessoas que possuem mais de dois filhos
            Console.WriteLine("\nExiba o Nome, Data Nascimento, Peso, Logradouro, Bairro e o Complemento das pessoas que possuem mais de dois filhos\n");
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
            Console.WriteLine("\nExiba Nome, a Idade e a Altura das pessoas que não possuem filhos.\n");
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
            Console.WriteLine("\nExiba o Nome das pessoas com os seus respectivos filhos(Nome e Data de Nascimento)\n");
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
            Console.WriteLine("\nQuantidade de Pessoas que possuam Filhos maiores de 25 anos\n");
            int quantidade = PessoaCollection.Count(pessoa => pessoa.Filhos != null && pessoa.Filhos.Where(filho => new DateTime((DateTime.Now - pessoa.DataNascimento).Ticks).Year > 25).Any());
            Console.WriteLine($"Quantidade: {quantidade}");


            //-Agrupar por raça e mostrar o nome da raça e quantidade
            Console.WriteLine("\nAgrupar por raça e mostrar o nome da raça e quantidade\n");
            var consulta7 = PessoaCollection.GroupBy(pessoa => pessoa.Raca).Select(g => new { raca = g.Key, quantidade = g.Count() }).ToList();
            foreach (var raca in consulta7)
            {
                Console.WriteLine($"Raça: {raca.raca}  Quantidade:{raca.quantidade}");
            }
            Console.WriteLine("\n\n-----------------\n\n");

            //-Mostrar a pessoa de menor peso, não precisa considerar filhos
            Console.WriteLine("\nMostrar a pessoa de menor peso, não precisa considerar filhos\n");
            var consulta8 = PessoaCollection.Where(pessoa => pessoa.Peso == PessoaCollection.Min(pessoa => pessoa.Peso)).Select(g => new { nome = g.Nome, peso = g.Peso }).ToList();
            foreach (var pessoa in consulta8)
            {
                Console.WriteLine($"Nome: {pessoa.nome}  Peso:{pessoa.peso}");
            }
            Console.WriteLine("\n\n-----------------\n\n");


            //-Mostrar a pessoa de maior altura, não precisa considerar filhos
            Console.WriteLine("\nMostrar a pessoa de maior altura, não precisa considerar filhos\n");
            var consulta9 = PessoaCollection.Where(pessoa => pessoa.Altura == PessoaCollection.Max(pessoa => pessoa.Altura)).Select(g => new { nome = g.Nome, altura = g.Altura }).ToList();
            foreach (var pessoa in consulta9)
            {
                Console.WriteLine($"Nome: {pessoa.nome}  Altura:{pessoa.altura}");
            }
            Console.WriteLine("\n\n-----------------\n\n");


            //-Listar todos os nomes agrupados pela primeira letra
            Console.WriteLine("\nListar todos os nomes agrupados pela primeira letra\n");

            //var listaLetras = PessoaCollection.Where(pessoa => !string.IsNullOrEmpty(pessoa.Nome)).Select(s => s.Nome[0]).Distinct().ToList();
            //var listaLetras = PessoaCollection.Select(s => s.Nome.ElementAtOrDefault(0)).ToList(); //não precisa do distinct pq o order by já vai fazer isso
            var consulta10 = PessoaCollection.GroupBy(s => s.Nome.ElementAtOrDefault(0)).Select(g => new { Letra = g.Key, Lista = g.ToList() }).ToList();
            //var consulta10 = PessoaCollection.GroupBy(s => s.Nome.First()).Select(g => new { letra = g.Key, lista = g.ToList() });                 

            foreach (var letra in consulta10)
            {
                //Console.WriteLine($"Letras: {pessoa.letra}");
                Console.WriteLine($"{letra.Letra}");

                foreach (var nome in letra.Lista)
                {
                    Console.WriteLine(nome.Nome);
                }
            }
            Console.WriteLine("\n\n-----------------\n\n");

            //- Mostrar as pessoas ordenadas de menor idade para maior idade
            Console.WriteLine("\nMostrar as pessoas ordenadas de menor idade para maior idade\n");
            var consulta11 = PessoaCollection.OrderByDescending(p => p.DataNascimento.Year).Select(g => new { g.Nome, g.DataNascimento });
            foreach (var pessoa in consulta11)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}  Idade:{new DateTime((DateTime.Now - pessoa.DataNascimento).Ticks).Year}");
            }
            Console.WriteLine("\n\n-----------------\n\n");

            //- Listar os nomes de todos os filhos
            Console.WriteLine("\nListar os nomes de todos os filhos\n");
            var consulta12 = PessoaCollection.Where(pessoa => pessoa.Filhos != null && pessoa.Filhos.Any()).SelectMany(x => x.Filhos).ToList();

            foreach (var pessoa in consulta12)
            {

                Console.WriteLine($"Nome Filho: {pessoa.Nome}");

            }
            Console.WriteLine("\n------------------\n");


            //-Média de altura, incluindo filhos
            Console.WriteLine("\nMédia de altura, incluindo filhos\n");
            var uniao = PessoaCollection.Union(PessoaCollection.Where(x => x.Filhos != null).SelectMany(x => x.Filhos));
            var media = uniao.Select(x => x.Altura).Average();
            Console.WriteLine($"Media das alturas: {media}");
            Console.WriteLine("\n------------------\n");


        }


    }
}
