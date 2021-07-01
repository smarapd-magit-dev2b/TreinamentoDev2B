using Aula05.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05
{
    public class Listas
    {
        public void Execute()
        {
            Exercicio1();
            //Exericio2();
            //Exericio3();
            //Exericio4();
            //Exericio5();
        }

        public void Exercicio1()
        {
            Pessoa pessoa = new Pessoa();

            var listaPessoas = new List<Pessoa>
            {
                new Pessoa {Nome = "Pessoa A", Telefone="11-11111111", DataNascimento = new DateTime(2001, 01, 01), Salario=1.500m, QuantidadeFilhos=1, Altura=1.74m, Peso=85.1m, NomePai="AAAA", NomeMae="AAAAA"},
                new Pessoa {Nome = "Pessoa B", Telefone="22-22222222", DataNascimento = new DateTime(2002, 02, 02), Salario=1.600m, QuantidadeFilhos=2, Altura=1.86m, Peso=65.3m, NomePai="BBBBB", NomeMae="BBBBB"},
                new Pessoa {Nome = "Pessoa C", Telefone="33-33333333", DataNascimento = new DateTime(2003, 03, 03), Salario=1.700m, QuantidadeFilhos=3, Altura=1.70m, Peso=75.4m, NomePai="CCCCC", NomeMae="CCCCC"},
                new Pessoa {Nome = "Pessoa D", Telefone="44-44444444", DataNascimento = new DateTime(2004, 04, 04), Salario=1.800m, QuantidadeFilhos=4, Altura=1.59m, Peso=68.6m, NomePai="DDDDD", NomeMae="DDDDD"},
                new Pessoa {Nome = "Pessoa E", Telefone="55-55555555", DataNascimento = new DateTime(2005, 05, 05), Salario=1.900m, QuantidadeFilhos=5, Altura=1.87m, Peso=80.7m, NomePai="EEEEE", NomeMae="EEEEE"},
            };




            int x;
            do
            {
                Console.WriteLine("1 - Listar Todas as Pessoas da lista");
                Console.WriteLine("2 - Adicionar uma Nova pessoa na lista");
                Console.WriteLine("3 - Sair ");
                Console.WriteLine("");

                bool result = int.TryParse(Console.ReadLine(), out x);

                switch (x)
                {

                    case 1:
                        {
                            listarTodasAsPessoas();
                            break;
                        }
                    case 2:
                        {
                            adicionarNovaPessoa();
                            break;
                        }
                    default:
                        {
                            if (x == 3)
                            {
                                Console.WriteLine("Thanks for using");
                            }
                            else
                            {
                                Console.WriteLine("Choose a numer from 1 to 3");
                            }
                            break;
                        }
                }
            } while (x != 3);

            void listarTodasAsPessoas()
            {
                Console.WriteLine("Mapeando todas as pessoas da lista");
                foreach (var pessoas in listaPessoas)
                {
                    Console.WriteLine("Nome: " + pessoas.Nome);
                }
            }
            //listarTodasAsPessoas();


            void adicionarNovaPessoa()
            {
                var adicionarNovaPessoa = new List<Pessoa>();

                Console.WriteLine("Nome da pessoa: ");
                pessoa.Nome = Console.ReadLine();

                Console.WriteLine("Telefone: ");
                pessoa.Telefone = Console.ReadLine();

                Console.WriteLine("Data de Nascimento: ");
                pessoa.DataNascimento = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Salário: ");
                pessoa.Salario = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Quantidade de filhos: ");
                pessoa.QuantidadeFilhos = int.Parse(Console.ReadLine());

                Console.WriteLine("Altura: ");
                pessoa.Altura = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Peso: ");
                pessoa.Peso = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Nome do Pai: ");
                pessoa.NomePai = Console.ReadLine();

                Console.WriteLine("Nome do Mãe: ");
                pessoa.NomeMae = Console.ReadLine();


                listaPessoas.Add(new Pessoa
                {
                    Nome = pessoa.Nome,
                    Telefone = pessoa.Telefone,
                    DataNascimento = pessoa.DataNascimento,
                    Salario = pessoa.Salario,
                    QuantidadeFilhos = pessoa.QuantidadeFilhos,
                    Altura = pessoa.Altura,
                    Peso = pessoa.Peso,
                    NomePai = pessoa.NomePai,
                    NomeMae = pessoa.NomeMae,
                });
            }

            //adicionarNovaPessoa();


        }
    }
}
