using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_5.Exercicio_1
{
    public class Exercicio1_Aula5
    {
        public void Executar_Aula5Ex1()
        {
            //Variavel----------------------

            int val;

            var listaPessoa = new List<Pessoa>();
            {
            };

            do
            {
                Console.WriteLine("\n * * * * * M E N U * * * * * ");

                Console.WriteLine("\n [1] Cadastrar nova pessoa ");

                Console.WriteLine("\n [2] Listar o nome de todas a as pessoas cadastradas");

                Console.WriteLine("\n [9] Sair ");

                Console.WriteLine("\n Digite a Opção");

                val = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (val)
                {
                    case 1:

                        Console.Write("Cadastro da pessoa");

                        Console.Write("Nome: ");
                        var nome = Console.ReadLine();

                        Console.Write("Telefone: ");
                        var telefone = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Data de Nascimento: ");
                        var datanasc = Convert.ToDateTime(Console.ReadLine());

                        Console.Write("Salario: ");
                        var salario = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Quantidade de filho: ");
                        var quantidadefilho = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Altura: ");
                        var altura = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Peso: ");
                        var peso = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Nome do Pai: ");
                        var nomepai = Console.ReadLine();

                        Console.Write("Nome da mãe: ");
                        var nomemae = Console.ReadLine();

                        Console.Clear();

                        listaPessoa.Add(new Pessoa
                        {
                            Nome = nome,
                            Telefone = telefone,
                            DataNasc = datanasc,
                            Salario = salario,
                            QuantidadeFilho = quantidadefilho,
                            Altura = altura,
                            Peso = peso,
                            NomePai = nomepai,
                            NomeMae = nomemae,
                        });

                        break;

                    case 2:

                        foreach (var pessoa in listaPessoa)
                        {

                            Console.Write($"Nome: {pessoa.Nome}");

                        }

                        break;


                }


            } while (val != 9);


        }
    
    }
}
