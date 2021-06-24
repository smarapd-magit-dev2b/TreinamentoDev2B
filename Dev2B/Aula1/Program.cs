﻿using System;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio1();
            //exercicio2();
            //exercicio3();
            //exercicio4();
            //exercicio5();
            //exercicio6();
            //exercicio7();
            //exercicio8();
            exercicio9();
            Console.ReadKey();
        }

        static void exercicio1()
        {
            decimal media;

            Console.Write("Digite a media do aluno: ");
            media = Convert.ToDecimal(Console.ReadLine());

            if (media >= 7.0m && media <= 10.0m)
            {
                Console.WriteLine("Aprovado!");
            }
            else if (media >= 4.0m && media <= 6.99m)
            {
                Console.WriteLine("Exame!");
            }
            else if (media < 4)
            {
                Console.WriteLine("Reprovado!");
            }
            else
            {
                Console.WriteLine("Inválido!");
            }
        }

        static void exercicio2()
        {
            int maior, menor, aux;
            menor = 0;
            maior = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite o " + (i + 1) + " valor: ");
                aux = Convert.ToInt32(Console.ReadLine());

                if (i == 0)
                {
                    menor = aux;
                    maior = aux;
                }
                else
                {
                    if (aux > maior)
                    {
                        maior = aux;
                    }
                    else if (aux < menor)
                    {
                        menor = aux;
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Maior número: " + maior);
            Console.WriteLine("Menor número: " + menor);
        }

        static void exercicio3()
        {
            decimal num1, num2;

            Console.Write("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());


            Console.Write("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 % num2 == 0)
            {
                Console.WriteLine("Números multiplos!");
            }
            else
            {
                if (num1 % num2 != 0)
                {
                    Console.WriteLine("Números não são multiplos!");
                }
                else
                {
                    Console.WriteLine("entrada inválida!");
                }
            }
        }

        static void exercicio4()
        {
            decimal num1, num2;
            string operacao;

            Console.Write("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());


            Console.Write("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Digite a operação desejada (+, -, *, /): ");
            operacao = Console.ReadLine();

            Console.WriteLine("\n\n USANDO SWITCH \n\n");

            if (operacao == "+")
            {
                Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
            }
            else
            {
                if (operacao == "-")
                {
                    Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
                }
                else
                {
                    if (operacao == "*")
                    {
                        Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
                    }
                    else
                    {
                        if (operacao == "/")
                        {
                            if (num1 == 0 || num2 == 0)
                            {
                                Console.WriteLine("Não existe divisão por 0!");
                            }
                            else
                            {
                                Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
                            }
                        }
                        else
                        {
                            Console.WriteLine("Operação inválida!");
                        }
                    }
                }
            }

            Console.WriteLine("\n\n USANDO SWITCH \n\n");

            switch (operacao)
            {
                case "+":
                    Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
                    break;

                case "-":
                    Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
                    break;

                case "/":
                    if (num1 == 0 || num2 == 0)
                    {
                        Console.WriteLine("Não existe divisão por 0!");
                    }
                    else
                    {
                        Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
                    }
                    break;
                default:
                    Console.WriteLine("Operador in válido!");
                    break;
            }
        }

        static void exercicio5()
        {
            int soma = 0, k = 1, j = 1;

            // utilizando FOR 
            //for (int i = 1; i < 101; i++)
            //{
            //    soma = soma + i;
            //}

            // utilizando WHILE
            //while (k < 101)
            //{
            //    soma = soma + k;
            //    k++;
            //}

            // utilizando DO WHILE
            do
            {
                soma = soma + j;
                j++;
            } while (j < 101);

            Console.WriteLine("O valor da soma de 1 a 100 é: " + soma);
        }

        static void exercicio6()
        {
            int j = 1, k = 1;

            //for (int i = 1; i >= 1 && i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i + " é multiplo de três!");
            //    }
            //}

            //while (j >= 1 && j <= 100)
            //{
            //    if (j % 3 == 0)
            //    {
            //        Console.WriteLine(j + " é multiplo de três!");
            //    }

            //    j++;
            //}

            do
            {
                if (k % 3 == 0)
                {
                    Console.WriteLine(k + " é multiplo de três!");
                }

                k++;
            } while (k >= 1 && k <= 100);
        }

        static void exercicio7()
        {
            int soma = 0, j = 1, k = 1;

            //for (int i = 1; i >= 1 && i <= 100; i++)
            //{
            //    if (i % 3 != 0)
            //    {
            //        soma = soma + i;
            //    }
            //}

            //while (j >= 1 && j <= 100)
            //{
            //    if (j % 3 != 0)
            //    {
            //        soma = soma + j;
            //    }

            //    j++;

            //};

            do
            {
                if (k % 3 != 0)
                {
                    soma = soma + k;
                }

                k++;

            } while (k >= 1 && k <= 100);

            Console.WriteLine("A soma dos valores que não são multiplos de 3 é (entre 1 e 100): " + soma);
        }

        static void exercicio8()
        {
            int j = 0, k = 0;

            //for (int i = 0; i <= 30; i++)
            //{
            //    if (i % 3 == 0 || i % 4 == 0)
            //    {
            //        Console.WriteLine(i + " é multiplos de 3 ou 4!");
            //    }
            //}

            //while (j <= 30)
            //{
            //    if (j % 3 == 0 || j % 4 == 0)
            //    {
            //        Console.WriteLine(j + " é multiplos de 3 ou 4!");
            //    }

            //    j++;
            //};

            do
            {
                if (k % 3 == 0 || k % 4 == 0)
                {
                    Console.WriteLine(k + " é multiplos de 3 ou 4!");
                }

                k++;
            } while (k <= 30);
        }

        static void exercicio9()
        {
            int num, j = 0, k = 0;

            Console.Write("Digite um valor de 0 a 100 para saber sua tabuada: ");
            num = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= 10; i++)
            //{
            //    if (num >= 0 && num <= 100)
            //    {
            //        Console.WriteLine(num + " x " + i + " = " + (num * i));
            //    }
            //    else
            //    {
            //        i = 11;
            //        Console.WriteLine("valor inválido");
            //    }
            //}

            //while (j <= 10)
            //{
            //    if (num >= 0 && num <= 100)
            //    {
            //        Console.WriteLine(num + " x " + j + " = " + (num * j));
            //        j++;
            //    }
            //    else
            //    {
            //        Console.WriteLine("valor inválido");
            //        j = 11;
            //    }
            //};

            do
            {
                if (num >= 0 && num <= 100)
                {
                    Console.WriteLine(num + " x " + k + " = " + (num * k));
                    k++;
                }
                else
                {
                    Console.WriteLine("valor inválido");
                    k = 11;
                }
            } while (k <= 10);
        }
    }
}
