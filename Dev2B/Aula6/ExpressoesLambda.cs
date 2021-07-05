using Aula6.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula6
{
    public class ExpressoesLambda
    {
        public void Executar()
        {
            //Exercicio1();
            //Exercicio2();
            //Exercicio3();
            //Exercicio4();
            //Exercicio5();
            //Exercicio6();
            //Exercicio7();
            //Exercicio8();
            //Exercicio9();
            //Exercicio10();
            //Exercicio11();
            //Exercicio12();
            //Exercicio13();
            //Exercicio14();
        }

        private void Exercicio1()
        {
            Base bse = new Base();

            Console.WriteLine("----- pessoas que contenha a letra “a” no nome -----\n");

            var nomeContemA = bse.PessoaCollection.Where(x => x.Nome.Contains("a")).ToList();
            foreach (var pessoa in nomeContemA)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}");
            }

        }
        private void Exercicio2()
        {
            Base bse = new Base();

            Console.WriteLine("----- Nome, a Idade e a Altura das pessoas que contenha a letra “a” no Logradouro de seu Endereço -----\n");
            var contemALogradouro = bse.PessoaCollection.Where(x => x.Endereco.Logradouro.Contains("a"))
                .Select(p => new
                {
                    p.Nome,
                    p.Altura,
                    Idade = DateTime.Now.Year - p.DataNascimento.Year
                })
                .ToList();

            foreach (var pessoa in contemALogradouro)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}");
                Console.WriteLine($"Idade: {pessoa.Idade}");
                Console.WriteLine($"Altura: {pessoa.Altura}");
                Console.WriteLine();
            }
        }
        private void Exercicio3()
        {
            Base bse = new Base();

            Console.WriteLine("----- Nome de todas as pessoas que possuem filhos -----\n");

            var contemFilhos = bse.PessoaCollection.Where(x => x.Filhos != null && x.Filhos.Any())
                .Select(p => new
                {
                    p.Nome
                }).ToList();

            foreach (var pessoa in contemFilhos)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}\n");
            }
        }
        private void Exercicio4()
        {
            Base bse = new Base();

            Console.WriteLine("----- Nome, Data Nascimento, Peso, Logradouro, Bairro e o Complemento das pessoas que possuem mais de dois filhos -----\n");

            var contemMaisDoisFilhos = bse.PessoaCollection.Where(x => x.Filhos != null && x.Filhos.Count > 2)
                .Select(p => new
                {
                    p.Nome,
                    DataNascimento = p.DataNascimento.ToString("dd/MM/yyyy"),
                    p.Peso,
                    p.Endereco.Logradouro,
                    p.Endereco.Bairro,
                    p.Endereco.Complemento
                }).ToList();

            foreach (var pessoa in contemMaisDoisFilhos)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}");
                Console.WriteLine($"Data de Nascimento: {pessoa.DataNascimento}");
                Console.WriteLine($"Peso: {pessoa.Peso}");
                Console.WriteLine($"Logradouro: {pessoa.Logradouro}");
                Console.WriteLine($"Logradouro: {pessoa.Bairro}");
                Console.WriteLine($"Complemento: {pessoa.Complemento}\n");
            }
        }
        private void Exercicio5()
        {
            Base bse = new Base();

            Console.WriteLine("----- Nome, a Idade e a Altura das pessoas que não possuem filhos -----\n");

            var semFilhos = bse.PessoaCollection.Where(x => x.Filhos == null || !x.Filhos.Any())
                .Select(p => new
                {
                    p.Nome,
                    Idade = DateTime.Now.Year - p.DataNascimento.Year,
                    p.Altura

                }).ToList();

            foreach (var pessoa in semFilhos)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}");
                Console.WriteLine($"Idade: {pessoa.Idade}");
                Console.WriteLine($"Altura: {pessoa.Altura}\n");
            }
        }
        private void Exercicio6()
        {
            Base bse = new Base();

            Console.WriteLine("----- Nome dos pais com os seus respectivos filhos -----\n");

            var pessoaComFilho = bse.PessoaCollection.Where(x => x.Filhos != null)
                .Select(p => new
                {
                    p.Nome,
                    Filhos = p.Filhos.Select(f => new
                    {
                        f.Nome,
                        f.DataNascimento
                    }).ToList()
                })
                .ToList();

            foreach(var pessoa in pessoaComFilho)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}\n");

                foreach (var filho in pessoa.Filhos)
                {
                    Console.WriteLine($"Nome Filho: {filho.Nome}");
                    Console.WriteLine($"Data nascimento: {filho.DataNascimento.ToString("dd/MM/yyyy")}\n");
                }
                Console.WriteLine("\n\n");
            }
        }
        private void Exercicio7()
        {
            Base bse = new Base();

            Console.WriteLine("----- Quantidade de Pessoas que possuam Filhos maiores de 25 anos -----\n");

            var quantidadePessoas = bse.PessoaCollection.Count(x => x.Filhos != null
            && x.Filhos.Where(f => new DateTime((DateTime.Now - f.DataNascimento).Ticks).Year > 25).Any());

            Console.WriteLine($"{quantidadePessoas} pessoa(s) possuem filhos maiores de 25 anos.");
        }
        private void Exercicio8()
        {
            Base bse = new Base();

            Console.WriteLine("----- Agrupar por raça e mostrar o nome e quantidade -----\n");

            var agruparRaca = bse.PessoaCollection.GroupBy(x => x.Raca);

            foreach(var grupo in agruparRaca)
            {
                Console.WriteLine($"Raça: {grupo.Key}");
                int quantidadeRaca = 0;

                foreach(var pessoa in grupo)
                {
                    Console.WriteLine($"Nome: {pessoa.Nome}");
                    quantidadeRaca++;
                }
                Console.WriteLine($"Quantidade: {quantidadeRaca}");
                Console.WriteLine();
            }
        }
        private void Exercicio9()
        {
            Base bse = new Base();

            Console.WriteLine("----- Pessoa de menor peso -----\n");

            var pessoaMenorPeso = bse.PessoaCollection.OrderBy(x => x.Peso).FirstOrDefault();

            Console.WriteLine($"Pessoa com menor peso: {pessoaMenorPeso.Nome}");
        }
        private void Exercicio10()
        {
            Base bse = new Base();

            Console.WriteLine("----- Pessoa de maior altura -----\n");

            var pessoaMaiorAltura = bse.PessoaCollection.OrderByDescending(x => x.Altura).FirstOrDefault();

            Console.WriteLine($"Pessoa com maior altura: {pessoaMaiorAltura.Nome}");
        }
        private void Exercicio11()
        {
            Base bse = new Base();

            Console.WriteLine("----- Nomes agrupados pela primeira letra -----\n");

            var nomesAgrupadosPrimeiraLetra = bse.PessoaCollection.OrderBy(y => y.Nome).GroupBy(x => x.Nome.First());

            foreach(var grupo in nomesAgrupadosPrimeiraLetra)
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
            Base bse = new Base();

            Console.WriteLine("----- Pessoas ordenadas de menor idade para maior idade -----\n");

            var ordenadaDeMenorParaMaiorIdade = bse.PessoaCollection.OrderByDescending(x => x.DataNascimento);

            foreach (var pessoa in ordenadaDeMenorParaMaiorIdade)
            {
                Console.WriteLine($"Nome: {pessoa.Nome} Idade: {new DateTime((DateTime.Now - pessoa.DataNascimento).Ticks).Year}");
            }
        }
        private void Exercicio13()
        {
            Base bse = new Base();

            Console.WriteLine("----- Listar o nome de todos os filhos -----\n");

            var todosFilhos = bse.PessoaCollection.Where(x => x.Filhos != null).SelectMany(y => y.Filhos).Select(z => z.Nome).ToList();

            foreach (var filho in todosFilhos)
            {
                Console.WriteLine($"Nome: {filho}");
            }

        }
        private void Exercicio14()
        {
            Base bse = new Base();

            var mediaAltura = bse.PessoaCollection.Union(bse.PessoaCollection.Where(x => x.Filhos != null).SelectMany(y => y.Filhos)).Average(z => z.Altura);

            Console.WriteLine($"A média de altura (pais e filhos) é de: {mediaAltura}");

        }

    }
}
