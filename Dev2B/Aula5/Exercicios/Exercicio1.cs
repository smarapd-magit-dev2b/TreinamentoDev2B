using Domain.Classes;
using Domain.Interfaces;
using Aula5.Classes;
using System.Collections.Generic;
using System;

namespace Aula5.Exercicios
{
    public class Exercicio1 : IExecute
    {
        public void Cadastrar()
        {
            var lista = new List<Pessoa>();

            var menu = new Menu("Lista de Pessoas");

            menu.AddItem("Adicionar Pessoa");

            var run = true;

            do
            {
                menu.PrintString();
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Pessoa pessoa = new Pessoa();
                        new Cadastro(pessoa).Cadastrar();
                        lista.Add(pessoa);
                        break;
                    case 0:
                        run = false;
                        break;
                }
                
            } while (run);

            Console.WriteLine("\nNome das Pessoas\n");

            foreach (var pessoa in lista)
                Console.WriteLine(pessoa.Nome);
        }
    }
}
