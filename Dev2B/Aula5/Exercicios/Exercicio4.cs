 using Aula5.Classes;
using Domain.Classes;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula5.Exercicios
{
    public class Exercicio4 : IExecute
    {
        public void Execute()
        {
            var vendas = new List<Venda>();

            var menu = new Menu("Lista de Vendas");

            menu.AddItem("Cadastrar Venda");
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
                            Venda venda = new Venda();
                            new Cadastro(venda).Cadastrar();

                            Menu menu1 = new Menu("Itens da Venda");
                            menu1.AddItem("Adicionar Item");
                            menu1.AddItem("Listar Vendas");
                            menu1.AddItem("Excluir Venda");

                            var run1 = true;
                            do
                            {
                                menu1.PrintString();
                                try
                                {
                                    switch (int.Parse(Console.ReadLine()))
                                    {
                                        case 1:
                                            Console.Clear();
                                            Classes.ItemVenda item = new Classes.ItemVenda();
                                            new Cadastro(item).Cadastrar();

                                            venda.Items.Add(item);
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Digite apenas números!");
                                }
                            } while (run1);

                            vendas.Add(venda);
                            break;
                        case 2:
                            Console.Clear();

                            foreach (var wVenda in vendas)
                            {
                                new WriteTree(wVenda).Propriedades();
                                foreach (var wItem in wVenda.Items)
                                    new WriteTree(wItem).Propriedades();
                            }

                            break;
                        case 3:
                            Console.Clear();

                            Console.Write("\nDigite o ID da Venda a ser excluido seu Item: ");
                            var vendaASerExcluidoSeuItem = vendas
                                .FirstOrDefault
                                (
                                    v => v.Id == int.Parse(Console.ReadLine())
                                );

                            Console.Write("\nDigite o ID da Venda a ser excluido seu Item: ");
                            vendaASerExcluidoSeuItem
                                .Items
                                .Remove
                                (
                                    vendaASerExcluidoSeuItem
                                    .Items
                                    .FirstOrDefault
                                    (
                                        i => i.Id == int.Parse(Console.ReadLine())
                                    )
                                );
                            break;
                        //case 4:
                        //    Console.Clear();

                        //    Console.Write("\nDigite o ID a ser excluido: ");
                        //    var carroASerExcluido = alunos.FirstOrDefault(c => c.Id == int.Parse(Console.ReadLine()));

                        //    if (carroASerExcluido != null)
                        //        alunos.Remove(carroASerExcluido);
                        //    break;
                        //case 5:
                        //    Console.Write("\nDigite o ID do aluno a ser alterado o nome: ");
                        //    var alunoASerAlterado =
                        //    (
                        //        from a in alunos
                        //        where a.Id == int.Parse(Console.ReadLine())
                        //        select a
                        //    ).ToList();

                        //    if (alunoASerAlterado.Count != 0)
                        //    {
                        //        Console.Write("\nDigite o novo Nome: ");
                        //        alunoASerAlterado.ForEach(a => a.Nome = Console.ReadLine());
                        //        public void Execute()
                        //        {
                        //            throw new System.NotImplementedException();
                        //        }
                        //    }
                        //    break;
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
