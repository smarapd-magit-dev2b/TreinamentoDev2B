using System;
using System.Collections.Generic;
using System.Text;

namespace Aula1
{
    public class Estrutura
    {
        public void Execute()
        {
            Exercicio1();
            Exercicio2();
            Exercicio3();
            Exercicio4();
            Exercicio5();
            Exercicio10();
        }

        private void Exercicio1()
        {
            Console.WriteLine("Exercicio - 1");
            Console.WriteLine("Digite uma nota para verificar o futuro do aluno: ");
            int nota = Convert.ToInt32(Console.ReadLine());

            if (nota <= 10 && nota >= 7)
            {
                Console.WriteLine("\nAluno esta APROVADO!");
            }

            if (nota < 6 && nota >= 4)
            {
                Console.WriteLine("\nAluno esta de EXAME!");
            }

            if (nota < 4 && nota >= 0)
            {
                Console.WriteLine("\nAluno esta REPORVADO!");
            }

            Console.WriteLine("\n\n\n");
        }

        private void Exercicio2()
        {
            Console.WriteLine("Exercicio - 2");
            int maior = 0, menor = 0;


            Console.WriteLine("Digite os numeros: ");
            for (int i = 0; i < 10; i++)
            {
                int valor = Convert.ToInt32(Console.ReadLine());

                if (i == 0)
                {
                    maior = valor;
                    menor = valor;
                }

                if (valor > maior)
                {
                    maior = valor;
                }
                else
                {
                    if (valor < maior)
                    {
                        if (valor < menor)
                        {
                            menor = valor;
                        }
                    }
                }
            }


            Console.WriteLine("Maior numero: " + maior);
            Console.WriteLine("Menor numero: " + menor);

        }

        private void Exercicio3()
        {
            Console.WriteLine("Exercicio - 3");
            Console.WriteLine("Digite o primeiro valor: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());


            if ((valor1 % valor2) == 0)
            {
                Console.WriteLine("São multiplos");
            }
            else
            {
                Console.WriteLine("Não são multiplos...");
            }

        }

        private void Exercicio4()
        {
            Console.WriteLine("Exercicio - 4");
            Console.WriteLine("Menu de opções!\n------------------\n Digite (*) para fazer uma multiplicação.\n Digite (/) para fazer uma divisão.\n Digite (+) para fazer uma soma.\n Digite (-) para fazer uma subtração.\nEscolha: ");
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "+":
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Digite o primeiro numero: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o segundo numero: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        int soma = 0;

                        soma = num1 + num2;

                        Console.WriteLine("\n");
                        Console.WriteLine("Valor final da soma: " + soma);
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Digite o primeiro numero: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o segundo numero: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        int sub = 0;

                        sub = num1 - num2;

                        Console.WriteLine("\n");
                        Console.WriteLine("Valor final da subtração: " + sub);
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Digite o primeiro numero: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o segundo numero: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        int multi = 0;

                        multi = num1 * num2;

                        Console.WriteLine("\n");
                        Console.WriteLine("Valor final da ultiplicação: " + multi);
                        break;
                    }
                case "/":
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Digite o primeiro numero: ");
                        decimal num1 = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("Digite o segundo numero: ");
                        decimal num2 = Convert.ToDecimal(Console.ReadLine());

                        decimal div = 0;

                        div = num1 / num2;

                        Console.WriteLine("\n");
                        Console.WriteLine("Valor final da divisão: " + div);
                        break;
                    }
            }


        }

        private void Exercicio5()
        {
            Console.WriteLine("Exercicio - 5");
            int soma = 0;
            int i = 0;
            int resposta;
            do
            {
                Console.WriteLine("Opções\n1) Resolver por FOR.\n2) Resolver por WHILE.\n3) Resolver por DO WHILE.");
                resposta = Convert.ToInt32(Console.ReadLine());

                if (resposta == 1)
                {
                    for (i = 0; i < 100; i++)
                    {
                        soma += i;
                    }
                }
                if (resposta == 2)
                {
                    while (i < 100)
                    {
                        soma += i;
                        i++;
                    }
                }
                if (resposta == 3)
                {
                    do
                    {
                        soma += i;
                        i++;
                    } while (i > 100);
                }


            } while (resposta != 0);


            Console.WriteLine("Soma total de todos os numeros de 1 a 100: " + soma);
        }

        private void Exercicio10()
        {
            Console.WriteLine("Exercicio - 10");
            int resposta = 0;
            int idade = 0;
            int peso = 0;
            int contIdade = 0;
            int porcentPeso = 0;
            int contPeso = 0;
            decimal contAnalise = 0m;
            decimal mediaAltura = 0m;
            decimal alturaTotal = 0m;
            decimal altura = 0m;
            do
            {
                Console.WriteLine("Menu de opções!\n-----------------\n 1) Inserir dados pessoais.\n 2) Analisar maiores de 50 anos.\n 3) Analisar altura das pessoas entre 10 e 20 anos.\n 4) Analisar pessoas com peso inferior a 40KG.\n 0) Sair.\n-----------------\nEscolha: ");
                int escolha = Convert.ToInt32(Console.ReadLine());
                resposta = escolha;

                switch (escolha)
                {
                    case 1:
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                Console.WriteLine("Informe os dados da pessoa " + i + ":");
                                Console.WriteLine("\nIdade: ");
                                idade = Convert.ToInt32(Console.ReadLine());

                                if (idade > 50)
                                {
                                    contIdade++;
                                }
                                if (idade >= 10 && idade <= 20)
                                {
                                    contAnalise++;
                                }

                                Console.WriteLine("\naltura: ");
                                altura = Convert.ToDecimal(Console.ReadLine());
                                if (contAnalise > 0)
                                {
                                    alturaTotal += altura;
                                }
                                Console.WriteLine("\nPeso: ");
                                peso = Convert.ToInt32(Console.ReadLine());
                                if (peso < 40)
                                {
                                    contPeso++;
                                }
                                Console.Clear();
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\nO total de pessoas acima de 50 anos são: " + contIdade);
                            break;
                        }
                    case 3:
                        {
                            mediaAltura = alturaTotal / contAnalise;
                            Console.WriteLine("\nA média de altura entre 10 e 20 é de: " + mediaAltura);
                            break;
                        }
                    case 4:
                        {
                            porcentPeso = (contPeso * 100) / 5;
                            Console.WriteLine("\nO numero de pessoas abaixo de 40KG é: " + porcentPeso);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Saindo....");
                            break;
                        }
                }

            } while (resposta != 0);
        }
    }
}
