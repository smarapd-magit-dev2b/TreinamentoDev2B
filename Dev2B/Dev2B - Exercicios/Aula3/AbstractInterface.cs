using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3
{
    public class AbstractInterface
    {
        public void Execute()
        {
            Exercicio1();
            Exercicio2();
        }

        private void Exercicio1()
        {
            ContaPoupanca poupanca = new ContaPoupanca(30000.00m);
            ContaCorrente corrente = new ContaCorrente(25000.00m);

            int agencia, resposta, tipoConta, controle = 0;

            Console.WriteLine("Informe a agencia bancaria: ");
            agencia = Convert.ToInt32(Console.ReadLine());
            poupanca.Agencia = agencia;
            corrente.Agencia = agencia;
            Console.WriteLine($"Agencia bancaria: ({agencia})");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|        Tipo da Conta         |");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1) Conta Corrente.\n2) Conta Poupança.");
            Console.WriteLine($"Escolha: {tipoConta = Convert.ToInt32(Console.ReadLine())} ");

            if (tipoConta == 1)
            {
                do
                {
                    Console.WriteLine($"Agencia bancaria: ({agencia})");
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("|    Conta Corrente - Opções disponiveis   |");
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("1) Imprimir Extrato.\n2) Efetuar Saque.\n3) Efetuar Deposito.\n4) Aplicar Rendimento.\n0) Fechar Programa.");
                    Console.WriteLine($"Escolha: {resposta = Convert.ToInt32(Console.ReadLine())} ");

                    switch (resposta)
                    {
                        case 1:
                            {
                                if (controle == 0)
                                {
                                    Console.WriteLine("Não houve movimentações!");
                                }
                                else
                                {
                                    corrente.ImpreExtrato();
                                }
                                break;
                            }
                        case 2:
                            {


                                Console.WriteLine("Sacar");
                                Console.WriteLine("----------------");
                                Console.WriteLine($"Saldo disponivel para saque: {corrente.Saldo}");

                                corrente.Sacar();
                                controle++;
                                break;
                            }
                        case 3:
                            {
                                corrente.Movimentar();
                                controle++;
                                break;
                            }
                        case 4:
                            {
                                corrente.AplicarRendimento();
                                break;
                            }

                    }
                } while (resposta != 0);
            }
            if (tipoConta == 2)
            {
                do
                {
                    Console.WriteLine($"Agencia bancaria: ({agencia})");
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("|    Conta Poupanca - Opções disponiveis   |");
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("1) Imprimir Extrato.\n2) Efetuar Saque.\n3) Efetuar Deposito.\n4) Aplicar Rendimento.\n0) Fechar Programa.");
                    Console.WriteLine($"Escolha: {resposta = Convert.ToInt32(Console.ReadLine())} ");

                    switch (resposta)
                    {
                        case 1:
                            {
                                if (controle == 0)
                                {
                                    Console.WriteLine("Não houve movimentações!");
                                }
                                else
                                {
                                    poupanca.ImpreExtrato();
                                }
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Sacar");
                                Console.WriteLine("----------------");
                                Console.WriteLine($"Saldo disponivel para saque: {poupanca.Saldo}");
                                poupanca.Sacar();
                                controle++;
                                break;
                            }
                        case 3:
                            {
                                poupanca.Movimentar();
                                controle++;
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Rendimento aplicado!");
                                poupanca.AplicarRendimento();
                                break;
                            }

                    }
                } while (resposta != 0);
            }
        }

        private void Exercicio2()
        {
            Subtracao subtracao = new Subtracao();
            Soma soma = new Soma();
            Divisao divisao = new Divisao();
            Multiplicacao multiplicacao = new Multiplicacao();

            Decimal vlr1, vlr2;

            Console.WriteLine("Informe o valor 1: ");
            vlr1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Informe o valor 2: ");
            vlr2 = Convert.ToDecimal(Console.ReadLine());

            subtracao.Valor1 = vlr1;
            subtracao.Valor2 = vlr2;
            soma.Valor1 = vlr1;
            soma.Valor2 = vlr2;
            multiplicacao.Valor1 = vlr1;
            multiplicacao.Valor2 = vlr2;
            divisao.Valor1 = vlr1;
            divisao.Valor2 = vlr2;

            Console.WriteLine("Resultado da subtração: ");
            subtracao.Calcular();
            Console.WriteLine("Resultado da soma: ");
            soma.Calcular();
            Console.WriteLine("Resultado da divisao: ");
            divisao.Calcular();
            Console.WriteLine("Resultado da multiplicação: ");
            multiplicacao.Calcular();
        }
    }
}
