using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula_6.Exercicio_Geral
{
    public class Exercicio
    {

        public void Executar_Aula6Ger()
        {

            Base resultado = new Base();

            //Exercicio 1-------------------

            Console.WriteLine(" \n\n * * * E X E R C I C I O 1 * * * ");

            Console.WriteLine("\n Exibir todas as Pessoas com a letra A no nome\n\n ");

            var letraA = resultado.PessoaCollection.Where(x => x.Nome.Contains("a")).ToList();

            foreach (var grupo in letraA)
            {
                Console.Write($"\n  Nome: {grupo.Nome} ");
            }


            //Exercicio 2-------------------

            Console.WriteLine(" \n\n * * * E X E R C I C I O 2 * * * ");

            Console.WriteLine("\n\n Exiba o Nome, a Idade e a Altura das pessoas que contenha a letra “a” no Logradouro de seu Endereço.\n\n");

            var Exibir = resultado.PessoaCollection.Where(x => x.Nome.Contains("a")).Select(n => new

            {
                n.Nome,
                n.Altura,
                Idade = DateTime.Now.Year - n.DataNascimento.Year,

            });

            foreach (var exibir in Exibir)
            {

                Console.WriteLine($" \n Nome: {exibir.Nome}");
                Console.WriteLine($" \n  Altura: {exibir.Altura}");
                Console.WriteLine($" \n Idade: {exibir.Idade}");


            }

            //Exercicio 3-------------------

            Console.WriteLine(" \n * * * E X E R C I C I O 3 * * * ");

            Console.WriteLine("\n\n Exiba o Nome de todas as pessoas que possuem filhos\n\n");

            var Filho = resultado.PessoaCollection.Where(x => x.Filhos != null && x.Filhos.Any()).ToList();


            foreach (var mostrar in Filho)
            {

                Console.WriteLine($" \n Nome: {mostrar.Nome}");

            }

            //Exercicio 4-------------------

            Console.WriteLine(" \n * * * E X E R C I C I O 4 * * * ");

            Console.WriteLine("\n\n Exiba o Nome, Data Nascimento, Peso, Logradouro, Bairro e o Complemento das pessoas que possuem mais de dois filhos\n\n");

            var Doisfilho = resultado.PessoaCollection.Where(x => x.Filhos != null && x.Filhos.Count > 2).Select(n => new

            {
                n.Nome,
                n.DataNascimento,
                n.Peso,
                n.Endereco.Logradouro,
                n.Endereco.Bairro,
                n.Endereco.Complemento,
            });

            foreach (var mostrar in Doisfilho)
            {

                Console.WriteLine($" \n Nome: {mostrar.Nome}");
                Console.WriteLine($" \n Data de nascimento: {mostrar.DataNascimento}");
                Console.WriteLine($" \n Peso: {mostrar.Peso}");
                Console.WriteLine($" \n Logradouro: {mostrar.Logradouro}");
                Console.WriteLine($" \n Bairro: {mostrar.Bairro}");
                Console.WriteLine($" \n Complemento: {mostrar.Complemento}");

            }

            //Exercicio 5-------------------

            Console.WriteLine(" \n * * * E X E R C I C I O 5 * * * ");

            Console.WriteLine("\n\n Exiba Nome, a Idade e a Altura das pessoas que não possuem filhos.\n\n");

            var SemFilho = resultado.PessoaCollection.Where(x => x.Filhos == null || !x.Filhos.Any()).Select(n => new
            {

                n.Nome,
                Idade = DateTime.Now.Year - n.DataNascimento.Year,
                n.Altura,


            });

            foreach (var mostrar in SemFilho)
            {

                Console.WriteLine($" \n Nome: {mostrar.Nome}");
                Console.WriteLine($" \n Idade: {mostrar.Idade}");
                Console.WriteLine($" \n Altura: {mostrar.Altura}");

            }

            //Exercicio 6-------------------

            Console.WriteLine(" \n * * * E X E R C I C I O 6 * * * ");

            Console.WriteLine("\n\n Exiba o Nome das pessoas com os seus respectivos filhos (Nome e Data de Nascimento).\n\n");

            var NomeFilho = resultado.PessoaCollection.Where(x => x.Filhos != null).Select(n => new
            {
                n.Nome,
                n.DataNascimento,

                VarFilhos = n.Filhos.Select(f => new
                {
                    f.Nome,
                    f.DataNascimento,

                })

            }).ToList();

            foreach (var mostrarp in NomeFilho)
            {

                Console.WriteLine($" \n Nome: {mostrarp.Nome}");

                foreach (var mostrarf in mostrarp.VarFilhos)
                {
                    Console.WriteLine($" \n Nome filho: {mostrarf.Nome}");
                    Console.WriteLine($" \n Data de Nascimento: {mostrarf.DataNascimento}");

                }

            }

            //Exercicio 7-------------------

            Console.WriteLine(" \n * * * E X E R C I C I O 7 * * *");

            Console.WriteLine("\n\n Quantidade de Pessoas que possuam Filhos maiores de 25 anos\n\n");

            var Maiorde25 = resultado.PessoaCollection.Count(x => x.Filhos != null && x.Filhos.Where(f => DateTime.Now.Year - f.DataNascimento.Year > 25).Any());

            Console.WriteLine($" Quantidade: {Maiorde25}");

            //Exercicio 8-------------------

            Console.WriteLine(" \n * * * E X E R C I C I O 8 * * *");

            Console.WriteLine("\n\n Agrupar por raça e mostrar o nome da raça e quantidade\n\n");

            var Raça = resultado.PessoaCollection.GroupBy(x => x.Raca);

            foreach (var mostrar in Raça)
            {
                Console.WriteLine($"\n Raça: {mostrar.Key}");
                int quantidade = 0;

                foreach (var nome in mostrar)
                {
                    Console.WriteLine($"\n Nome: {nome.Nome}");
                    quantidade++;
                }

                Console.WriteLine($"\n Quantidade: {quantidade}");
                Console.WriteLine();
            }

            //Exercicio 9-------------------

            Console.WriteLine(" \n * * * E X E R C I C I O 9 * * *");

            Console.WriteLine("\n\n Mostrar a pessoa de menor peso, não precisa considerar filhos \n\n");

            var Peso = resultado.PessoaCollection.OrderBy(x => x.Peso).FirstOrDefault();

            Console.WriteLine($"Pessoa com menor peso: {Peso.Nome}\n\n ");

            //Exercicio 10-------------------

            Console.WriteLine(" \n * * * E X E R C I C I O 10 * * *");

            Console.WriteLine("\n\n Mostrar a pessoa de maior altura, não precisa considerar filhos \n\n");

            var Altura = resultado.PessoaCollection.OrderByDescending(x => x.Altura).FirstOrDefault();

            Console.WriteLine($"Pessoa com menor peso: {Altura.Nome}");

            //Exercicio 11-------------------

            Console.WriteLine(" \n * * * E X E R C I C I O 11 * * *");

            Console.WriteLine("\n\n Listar todos os nomes agrupados pela primeira letra \n\n");

            var Primeira = resultado.PessoaCollection.OrderBy(x => x.Nome)
                .GroupBy(x => x.Nome.First());

            foreach (var grupo in Primeira)
            {
                Console.WriteLine($"{grupo.Key}");

                foreach (var pessoa in grupo)
                {
                    Console.WriteLine($"Nome: {pessoa.Nome}");
                }

            }


            //Exercicio 12------------------

            Console.WriteLine(" \n * * * E X E R C I C I O 12 * * *");

            Console.WriteLine("\n\n  Mostrar as pessoas ordenadas de menor idade para maior idade \n\n");

            var Idade = resultado.PessoaCollection.OrderByDescending(x => x.DataNascimento);

            foreach (var mostrar in Idade)
            {

                Console.WriteLine(mostrar.Nome);

            }

            //Exercicio 13------------------

            Console.WriteLine(" \n * * * E X E R C I C I O 13 * * *");

            Console.WriteLine("\n\n Listar os nomes de todos os filhos \n\n");

            var NomeF = resultado.PessoaCollection.Where(x => x.Filhos != null).Select(y => new
            {

                y.Filhos,

            });

            foreach (var mostrar in NomeF)
            {

                foreach (var mostrar2 in mostrar.Filhos)
                {

                    Console.WriteLine(mostrar2.Nome);

                }
            }


            //Exercicio 14-------------------

            Console.WriteLine(" \n * * * E X E R C I C I O 14 * * *");

            Console.WriteLine("\n\n Média de altura, incluindo filhos \n\n");

            var Media = resultado.PessoaCollection.Where(x => x.Filhos != null).SelectMany(x => x.Filhos).Average(x => x.Altura);

            Console.WriteLine($"Média de alturas: {Media}m");





        }


    }


}

