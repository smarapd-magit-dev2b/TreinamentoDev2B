﻿using Aula5.Classes;
using Domain.Classes;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula5.Exercicios
{
    public class Exercicio2 : IExecute
    {
        public void Execute()
        {
            var carros = new List<Carro>();

            var menu = new Menu("Lista de Carros");

            menu.Add("Adicionar Carro");
            menu.Add("Listar Carros");
            menu.Add("Excluir Carro");

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

                            Carro carro = new Carro();
                            new Cadastro(carro).Cadastrar();
                            carros.Add(carro);
                            break;
                        case 2:
                            Console.Clear();

                            foreach (var wCarro in carros)
                                WriteTree.Propriedades(wCarro);
                            break;
                        case 3:
                            Console.Clear();

                            Console.Write("\nDigite o ID a ser excluido: ");
                            var carroASerExcluido = carros.FirstOrDefault(c => c.Id == int.Parse(Console.ReadLine()));

                            if (carroASerExcluido != null)
                                carros.Remove(carroASerExcluido);
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
