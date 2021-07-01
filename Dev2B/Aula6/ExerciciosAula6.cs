using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula6
{
    public class ExerciciosAula6
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

        public void Execute()
        {
            Exercicio1();
            Exercicio2();
            Exercicio3();
            Exercicio4();
            Exercicio5();
            Exercicio6();
            Exercicio7();
            Exercicio8();
            Exercicio9();
            Exercicio10();
            Exercicio11();
            Exercicio12();
            Exercicio13();
            Exercicio14();
        }
        private void Exercicio1()
        {
            Console.WriteLine("Exercicio 1: ------------------------------------------");
            var pessoas = PessoaCollection.Where(x => x.Nome.Contains("a")).ToList();
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            };
        }
        private void Exercicio2()
        {
            Console.WriteLine("Exercicio 2: ------------------------------------------");
            var pessoas = PessoaCollection.Where(x => x.Endereco.Logradouro.Contains("a")).Select(x => new
            {
                x.Nome,
                x.DataNascimento,
                x.Altura
            });
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine(pessoa.Nome);
                Console.WriteLine(new DateTime((DateTime.Now - pessoa.DataNascimento).Ticks).Year);
                Console.WriteLine(pessoa.Altura);
            }
        }
        private void Exercicio3()
        {
            Console.WriteLine("Exercicio 3: ------------------------------------------");
            var pessoas = PessoaCollection.Where(x => x.Filhos != null).ToList();
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine(pessoa.Nome);
            }
        }
        private void Exercicio4()
        {
            Console.WriteLine("Exercicio 4: ------------------------------------------");
            var pessoas = PessoaCollection.Where(x => x.Filhos.Count() > 2).Select(x => new
            {
                x.Nome,
                x.DataNascimento.Date,
                x.Peso,
                x.Endereco.Logradouro,
                x.Endereco.Bairro,
                x.Endereco.Complemento
            });
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine(pessoa.Nome);
                Console.WriteLine(pessoa.Date);
                Console.WriteLine(pessoa.Peso);
                Console.WriteLine(pessoa.Logradouro);
                Console.WriteLine(pessoa.Bairro);
                Console.WriteLine(pessoa.Complemento);
            }
        }
        private void Exercicio5()
        {
            Console.WriteLine("Exercicio 5: ------------------------------------------");
            var pessoas = PessoaCollection.Where(x => x.Filhos != null).Select(x => new
            {
                x.Nome,
                x.DataNascimento.Date,
                x.Altura
            });
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine(pessoa.Nome);
                Console.WriteLine(pessoa.Date);
                Console.WriteLine(pessoa.Altura);
            }
        }
        private void Exercicio6()
        {
            Console.WriteLine("Exercicio 6: ------------------------------------------");
            var pessoas = PessoaCollection.Where(x => x.Filhos != null).Select(x => new
            {
                x.Nome,
                x.Filhos
            });
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine(pessoa.Nome);
                Console.WriteLine("Filhos: ------------------------------------------");
                foreach (var filho in pessoa.Filhos)
                {
                    Console.WriteLine(filho.Nome);
                    Console.WriteLine(filho.DataNascimento.Date);
                    Console.WriteLine("------------------------------------------");

                }
            }
        }
        private void Exercicio7()
        {
            Console.WriteLine("Exercicio 7: ------------------------------------------");
            var pessoas = PessoaCollection.Where(x => x.Filhos != null).Where(y => new DateTime((DateTime.Now - y.DataNascimento).Ticks).Year > 25).Count();
            Console.WriteLine("Quantidade de pessoas com filhos maiores de 25 anos: " + pessoas);
        }
        private void Exercicio8()
        {
            Console.WriteLine("Exercicio 8: ------------------------------------------");
            var pessoas = PessoaCollection.GroupBy(x => x.Raca);
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"{pessoa.Key} {pessoa.Count()}");
            }
        }
        private void Exercicio9()
        {
            Console.WriteLine("Exercicio 9: ------------------------------------------");
            var pessoas = PessoaCollection.OrderByDescending(x => x.Peso).Last();
            Console.WriteLine($"Quem tem o menor peso é: {pessoas.Nome} com {pessoas.Peso}");
        }
        private void Exercicio10()
        {
            Console.WriteLine("Exercicio 10: ------------------------------------------");
            var pessoas = PessoaCollection.OrderBy(x => x.Peso).FirstOrDefault();
            Console.WriteLine("Quem tem a maior altura é: " + pessoas.Nome);
        }
        private void Exercicio11()
        {
            Console.WriteLine("Exercicio 11: ------------------------------------------");
            var nomes = PessoaCollection.GroupBy(s => s.Nome.First())
                .Select(g => new 
                { 
                    letra = g.Key,
                    lista = g.ToList() 
                });
            foreach (var letra in nomes)
            {
                Console.WriteLine(letra.letra);
                foreach (var nome in letra.lista)
                {
                    Console.WriteLine(nome.Nome);
                }
            }

        }
        private void Exercicio12()
        {
            Console.WriteLine("Exercicio 12: ------------------------------------------");
            var pessoas = PessoaCollection.OrderByDescending(x => x.DataNascimento.Ticks);
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine(pessoa.Nome + " " + pessoa.DataNascimento.Date);
            }
        }
        private void Exercicio13()
        {
            Console.WriteLine("Exercicio 13: ------------------------------------------");
            var pessoas = PessoaCollection.Where(x => x.Filhos.Count() > 0).ToList();
            foreach (var pessoa in pessoas)
            {
                foreach (var filho in pessoa.Filhos)
                {
                    Console.WriteLine(filho.Nome);
                }
            }
        }
        private void Exercicio14()
        {
            Console.WriteLine("Exercicio 14: ------------------------------------------");
            var pessoas = PessoaCollection.Union(PessoaCollection.Where(x => x.Filhos != null).SelectMany(x => x.Filhos));
            var alturas = pessoas.Select(x =>  x.Altura );
            var media = alturas.Average();
            
            Console.WriteLine(alturas);
        }


    }

}
