using System;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio1();
            //Exercicio2();
            //Exercicio3();
            //Exercicio4a();
            //Exercicio4b();
            //Exercicio5a();
            //Exercicio5b();
            //Exercicio5c();
            //Exercicio10();
        }

        static void Exercicio1()
        {
            decimal media = decimal.Parse(Console.ReadLine());

            if (media >= 7 && media <= 10)
            {
                Console.WriteLine("Aprovado");
                Console.ReadLine();
            }
            if (media >= 4 && media < 7)
            {
                Console.WriteLine("Exame");
                Console.ReadLine();
            }
            if (media < 4)
            {
                Console.WriteLine("Aprovado");
                Console.ReadLine();
            }
        }

        static void Exercicio2()
        {
            int maior = 0;
            int menor = 0;
            int num = 0;

            for (int i = 0; i <= 5; i++)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (maior == 0 && menor == 0)
                {
                    maior = num;
                    menor = num;
                }
                if (num > maior)
                    maior = num;
                if (num < menor)
                    menor = num;
            }

            Console.WriteLine("O numero maior é: " + maior + "\n");
            Console.WriteLine("O numero menor é: " + menor + "\n");
            Console.ReadLine();
        }

        static void Exercicio3()
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Digite o primeiro numero:\n");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo numero:\n");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 % num2 == 0)
                {
                    Console.WriteLine("Os dois numeros sao multiplos!\n");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Os dois numeros não sao multiplos!\n");
                    Console.ReadLine();
                }
            }
            else
            {
                if (num2 % num1 == 0)
                {
                    Console.WriteLine("Os dois numeros sao multiplos!\n");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Os dois numeros não sao multiplos!\n");
                    Console.ReadLine();
                }
            }
        }

        static void Exercicio4a()
        {
            int num1 = 0;
            int num2 = 0;
            string operacao;

            Console.WriteLine("Digite o primeiro numero:\n");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo numero:\n");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDigite a operação desejada:\n");
            operacao = Console.ReadLine();

            switch (operacao)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    Console.ReadLine();
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    Console.ReadLine();
                    break;
                case "/":
                    if (num2 == 0)
                        Console.WriteLine("Não existe divisão por zero!");
                    Console.WriteLine(num1 / num2);
                    Console.ReadLine();
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    Console.ReadLine();
                    break;
            }
        }

        static void Exercicio4b()
        {
            int num1 = 0;
            int num2 = 0;
            string operacao;

            Console.WriteLine("Digite o primeiro numero:\n");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo numero:\n");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDigite a operação desejada:\n");
            operacao = Console.ReadLine();

            if (operacao == "+")
            {
                Console.WriteLine(num1 + num2);
                Console.ReadLine();
            }
            if (operacao == "-")
            {
                Console.WriteLine(num1 - num2);
                Console.ReadLine();
            }
            if (operacao == "/")
            {
                if (num2 == 0)
                    Console.WriteLine("Não existe divisão por zero!");
                Console.WriteLine(num1 / num2);
                Console.ReadLine();
            }
            if (operacao == "*")
            {
                Console.WriteLine(num1 * num2);
                Console.ReadLine();
            }
        }

        static void Exercicio5a()
        {
            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                soma += i;
            }
            Console.WriteLine("A soma de 1 a 100 é igual a: " + soma);
            Console.ReadLine();
        }

        static void Exercicio5b()
        {
            int soma = 0;
            int i = 1;

            while (i <= 100)
            {
                soma += i;
                i++;
            }
            Console.WriteLine("A soma de 1 a 100 é igual a: " + soma);
            Console.ReadLine();
        }

        static void Exercicio5c()
        {
            int soma = 0;
            int i = 1;

            do
            {
                soma += i;
                i++;
            } while (i <= 100);

            Console.WriteLine("A soma de 1 a 100 é igual a: " + soma);
            Console.ReadLine();
        }

        static void Exercicio10()
        {
            int i = 0;
            int IdadeSuperior = 0;
            int PesoInferior = 0;
            int n = 0;
            decimal SomaAltura = 0;
            decimal media = 0;
            decimal porcentagem = 0;

            while (i < 5)
            {
                Console.WriteLine("\nDigite a idade da pessoa: ");
                int idade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nDigite a altura da pessoa: ");
                decimal altura = decimal.Parse(Console.ReadLine());

                Console.WriteLine("\nDigite o peso da pessoa: ");
                decimal peso = decimal.Parse(Console.ReadLine());

                if (idade > 50)
                    IdadeSuperior++;

                if (idade >= 10 && idade <= 20)
                {
                    SomaAltura += altura;
                    n++;
                }

                if (peso < 40)
                    PesoInferior++;
                i++;
            }

            Console.WriteLine($"A quantidade de pessoas acima de 50 anos é: {IdadeSuperior}\n");
            Console.WriteLine($"A média das alturas das pessoas com idade entre 10 a 20 anos é: {SomaAltura / n}\n");
            Console.WriteLine($"A porcentagem de pessoas com peso inferior a 40kg é: {100 * PesoInferior / 5}% \n");
            Console.ReadLine();
        }
    }
}
