using Common.Classes;
using Common.Interfaces;
using Aula5.Classes;
using System.Collections.Generic;
using System;

namespace Aula5.Exercicios
{
    public class Exercicio1 : IExecute
    {
        public void Execute()
        {
            var pessoas = new List<Pessoa>();

            var menu = new Menu("Lista de Pessoas");

            menu.Add("Adicionar Pessoa");

            var run = true;

            do
            {
                menu.WriteString();
                try
                {
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            Console.Clear();

                            Pessoa pessoa = new Pessoa();
                            new Cadastro(pessoa).Cadastrar();
                            pessoas.Add(pessoa);
                            break;
                        case 0:
                            Console.Clear();

                            run = false;
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Digite apenas números!");
                }
            } while (run);

            Console.WriteLine("\nNome das Pessoas\n");

            foreach (var pessoa in pessoas)
                Console.WriteLine(pessoa.Nome);
        }
    }
}
