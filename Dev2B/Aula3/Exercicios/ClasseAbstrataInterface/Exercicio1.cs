﻿using Domain.Classes;
using Domain.Classes.Conta;
using Domain.Interfaces;
using System;

namespace Aula3.Exercicios.ClasseAbstrataInterface
{
    public class Exercicio1 : IExecute
    {
        public void Execute()
        {
            //Conta Corrente
            ContaCorrente corrente = new ContaCorrente();

            Console.Write("Exercício 1\n\nConta Corrente\nDigite sua Agência: ");
            corrente.Agencia = Console.ReadLine();

            Console.Write("Digite sua Conta: ");
            corrente.NumeroConta = Console.ReadLine();

            Menu menu = new Menu("Ações");

            menu.AddItem("Depositar");
            menu.AddItem("Sacar");

            bool run = true;
            do
            {
                menu.PrintString();

                Console.Write("Digite o número que deseja executar: ");

                try
                {
                    var escolha = int.Parse(Console.ReadLine());

                    switch (escolha)
                    {
                        case 1:
                            Console.Clear();
                            Console.Write("Digite o valor a ser Depositado: ");
                            corrente.Depositar(decimal.Parse(Console.ReadLine()));
                            break;
                        case 2:
                            Console.Clear();
                            Console.Write("Digite o valor a ser Sacado: ");
                            corrente.Sacar(decimal.Parse(Console.ReadLine()));
                            break;
                        case 0:
                            Console.Clear();

                            run = false;

                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine($"{escolha} não está na lista!");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Digite apenas números!\n");
                }
            } while (run);

            corrente.ImpreExtrato();

            //Conta Poupança
            ContaPoupanca poupanca = new ContaPoupanca();

            Console.Write("Exercício 1\n\nConta Poupança\nDigite sua Agência: ");
            poupanca.Agencia = Console.ReadLine();

            Console.Write("Digite sua Conta: ");
            poupanca.NumeroConta = Console.ReadLine();

            run = true;

            do
            {
                menu.PrintString();

                Console.Write("Digite o número que deseja executar: ");

                try
                {
                    var escolha = int.Parse(Console.ReadLine());

                    switch (escolha)
                    {
                        case 1:
                            Console.Clear();
                            Console.Write("Digite o valor a ser Depositado: ");
                            poupanca.Depositar(decimal.Parse(Console.ReadLine()));
                            break;
                        case 2:
                            Console.Clear();
                            Console.Write("Digite o valor a ser Sacado: ");
                            poupanca.Sacar(decimal.Parse(Console.ReadLine()));
                            break;
                        case 0:
                            Console.Clear();

                            run = false;

                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine($"{escolha} não está na lista!");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Digite apenas números!\n");
                }
            } while (run);

            poupanca.ImpreExtrato();
        }
    }
}
