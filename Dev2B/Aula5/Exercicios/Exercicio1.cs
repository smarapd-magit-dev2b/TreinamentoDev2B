using Domain.Classes;
using Domain.Interfaces;
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

            menu.AddItem("Adicionar Pessoa");

            var run = true;

            do
            {
                menu.PrintString();

                Console.Write("Digite o número da Operação a ser executada: ");
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

            } while (run);

            Console.WriteLine("\nNome das Pessoas\n");

            foreach (var pessoa in pessoas)
                Console.WriteLine(pessoa.Nome);
        }
    }
}
