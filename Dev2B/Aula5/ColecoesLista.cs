using Aula5.Exercicio1Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5
{
    public class ColecoesLista
    {
        private void Exercicio1() 
        {
            var listaPessoas = new List<Pessoa>();
            int i;

            do
            {
                Console.Clear();
                Console.WriteLine("----- MENU -----\n");
                Console.WriteLine("1 --- Cadastrar nova pessoa!");
                Console.WriteLine("2 --- Exibir lista de pessoas cadastradas!");
                Console.WriteLine("0 --- Sair!");
                Console.Write("\n Digite a opção desejada: ");
                i = int.Parse(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("----- CADASTRO DE NOVA PESSOA -----\n");
                        Console.Write("Nome: ");
                        var nome = Console.ReadLine();
                        Console.Write("Telefone: ");
                        var telefone = Console.ReadLine();
                        Console.Write("Data de nascimento: ");
                        var dataNascimento = DateTime.Parse(Console.ReadLine());
                        Console.Write("Salário: ");
                        var salario = decimal.Parse(Console.ReadLine());
                        Console.Write("Quantidade de filhos: ");
                        var qntFilhos = int.Parse(Console.ReadLine());
                        Console.Write("Altura: ");
                        var altura = decimal.Parse(Console.ReadLine());
                        Console.Write("Peso: ");
                        var peso = decimal.Parse(Console.ReadLine());
                        Console.Write("Nome do pai: ");
                        var nomeDoPai = Console.ReadLine();
                        Console.Write("Nome da Mãe: ");
                        var nomeDaMae = Console.ReadLine();

                        listaPessoas.Add(new Pessoa
                        {
                            Nome = nome,
                            Telefone = telefone,
                            DataNascimento = dataNascimento,
                            Salario = salario,
                            QntFilhos = qntFilhos,
                            Altura = altura,
                            Peso = peso,
                            NomeDoPai = nomeDoPai,
                            NomeDaMae = nomeDaMae
                        });

                        Console.WriteLine($"\n{nome} registrado(a) com sucesso!");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        if (listaPessoas.Count == 0) 
                        {
                            Console.WriteLine("----- LISTA DE PESSOAS CADASTRADAS -----\n");
                            Console.WriteLine("Lista Vazia!!");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("----- LISTA DE PESSOAS CADASTRADAS -----\n");

                            foreach (var pessoa in listaPessoas)
                            {
                                Console.WriteLine($"Nome: {pessoa.Nome}");
                            }

                            Console.ReadKey();
                        }
                        break;

                    case 0:
                        Console.Clear();
                        Console.WriteLine("Saindo do programa .....");
                        break;

                    default:
                        Console.WriteLine("\nEntrada inválida! Digite um opção existente!");
                        Console.ReadKey();
                        break;
                }
            } while (i != 0);
        }
        private void Exercicio2()
        {

        }
        private void Exercicio3()
        {

        }
        private void Exercicio4()
        {

        }
        private void Exercicio5()
        {

        }

        public void Executar()
        {
            Exercicio1();
            //Exercicio2();
            //Exercicio3();
            //Exercicio4();
            //Exercicio5();
        }

    }
}
