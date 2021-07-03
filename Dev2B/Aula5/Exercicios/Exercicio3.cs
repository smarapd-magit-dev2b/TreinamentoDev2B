using Aula5.Classes;
using Domain.Classes;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula5.Exercicios
{
    public class Exercicio3 : IExecute
    {
        public void Execute()
        {
            var alunos = new List<Aluno>();

            var menu = new Menu("Lista de Carros");

            menu.AddItem("Adicionar Aluno");
            menu.AddItem("Listar Alunos");
            menu.AddItem("Pesquisar Aluno");
            menu.AddItem("Excluir Aluno");
            menu.AddItem("Alterar Nome do Aluno");

            var run = true;

            do
            {
                menu.PrintString();
                try
                {
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            Console.Clear();

                            Aluno aluno = new Aluno();
                            new Cadastro(aluno).Cadastrar();
                            alunos.Add(aluno);
                            break;
                        case 2:
                            Console.Clear();

                            foreach (var wAluno in alunos)
                                WriteTree.Propriedades(wAluno);
                            break;
                        case 3:
                            Console.Write("\nDigite o ID do aluno a ser pesquisado: ");
                            WriteTree.Propriedades(alunos.FirstOrDefault(a => a.Id == int.Parse(Console.ReadLine())));
                            break;
                        case 4:
                            Console.Clear();

                            Console.Write("\nDigite o ID a ser excluido: ");
                            var carroASerExcluido = alunos.FirstOrDefault(c => c.Id == int.Parse(Console.ReadLine()));

                            if (carroASerExcluido != null)
                                alunos.Remove(carroASerExcluido);
                            break;
                        case 5:
                            Console.Write("\nDigite o ID do aluno a ser alterado o nome: ");
                            var alunoASerAlterado =
                            (
                                from a in alunos
                                where a.Id == int.Parse(Console.ReadLine())
                                select a
                            ).ToList();

                            if (alunoASerAlterado.Count != 0)
                            {
                                Console.Write("\nDigite o novo Nome: ");
                                alunoASerAlterado.ForEach(a => a.Nome = Console.ReadLine());
                            }
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
        }
    }
}
