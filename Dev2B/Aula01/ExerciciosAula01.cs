using Aula01;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula01
{
    public class ExerciciosAula01
    {
        public void Execute()
        {
            //Exercicio01();
            //Exercicio02();
            //Exercicio03();
            //Exercicio04();
            //Exercicio05();
            //Exercicio06();
            //Exercicio07();
            //Exercicio08();
            //Exercicio09();
            //Exercicio10();
        }
        private void Exercicio01()
        {
            decimal media;

            Console.Write("Digite a média: ");
            media = Convert.ToDecimal(Console.ReadLine());

            if (media >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else if (media >= 4m)
            {
                Console.WriteLine("Exame");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }

        }
        private void Exercicio02()
        {
            int i; int maior; int menor; int numero = 0;

            maior = numero;
            menor = numero;

            for (i = 0; i < 10; i++)
            {
                Console.Write("Digite o " + (i + 1) + "º numero: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > maior)
                    maior = numero;
                else if (numero < menor)
                    menor = numero;

            }
            Console.WriteLine("Este eh o maior numero: " + maior);
            Console.WriteLine("Este eh o menor numero: " + menor);
        }
        private void Exercicio03()
        {
            {
                decimal num1, num2, resultado;

                Console.Write("Digite o numero 1º: ");
                num1 = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Digite o numero 2º: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                resultado = num1 % num2;
                Console.Write("\n\nO resultado da divisão = " + resultado);

                if (resultado == 0)
                    Console.Write("\n\nOs valores informados sao multiplos\n");
                else
                    Console.Write("\n\nOs valores informados nao sao multiplos\n");

            }
        }
        private void Exercicio04()
        {
            decimal num1, num2;
            decimal resultado;
            string operador;

            Console.Write("Digite o numero 1º: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o numero 2º: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escolha a operação: ");
            operador = Convert.ToString(Console.ReadLine());

            switch (operador)
            {
                case "+":
                    Console.WriteLine("\nAdicao");
                    resultado = num1 + num2;
                    Console.Write("\nO resultado da adicao = " + resultado);
                    break;
                case "-":
                    Console.WriteLine("\nSubtracao");
                    resultado = num1 - num2;
                    Console.Write("\nO resultado da adicao = " + resultado);
                    break;
                case "*":
                    Console.WriteLine("\nMultiplicacao");
                    resultado = num1 * num2;
                    Console.Write("\nO resultado da adicao = " + resultado);
                    break;
                case "/":
                    Console.WriteLine("\nDivisao");
                    resultado = num1 / num2;
                    Console.Write("\nO resultado da adicao = " + resultado);
                    break;
            }
            Console.Write("\n");
        }
        private void Exercicio05()
        {
            int i = 0, aux = 0;

            while (i <= 100)
            {
                aux += i;
                i++;
            }
            Console.WriteLine("Usando o FOR: " + aux);
            aux = 0;

            for (i = 0; i <= 100; i++)
            {
                aux += i;
            }

            Console.WriteLine("Usando o WHILE: " + aux);
            aux = 0;
            i = 0;

            do
            {
                aux += i;
                i++;
            } while (i <= 100);
            Console.WriteLine("Usando o DO-WHILE: " + aux);
        }
        private void Exercicio06()
        {
            Console.WriteLine("Hello World");
        }
        private void Exercicio07()
        {
            Console.WriteLine("Hello World");
        }
        private void Exercicio08()
        {
            Console.WriteLine("Hello World");
        }
        private void Exercicio09()
        {
            Console.WriteLine("Hello World");
        }
        private void Exercicio10()
        {
            int i, idade, idade_sup_50 = 0, pessoas_10_20 = 0, peso_inferior = 0;
            decimal altura, peso, soma_altura = 0;

            for (i = 1; i <= 5; i++)
            {
                Console.Write("Entre com a idade da " + i + "ª" + " pessoa: ");
                idade = Convert.ToInt32(Console.ReadLine());
                Console.Write("Entre com a altura da " + i + "ª" + " pessoa: ");
                altura = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Entre com o peso da " + i + "ª" + " pessoa: ");
                peso = Convert.ToDecimal(Console.ReadLine());
                if (idade > 50)
                {
                    idade_sup_50++;
                }
                if (idade >= 10 && idade <= 20)
                {
                    pessoas_10_20++;
                    soma_altura = soma_altura + altura;
                }
                if (peso < 40.00m)
                {
                    peso_inferior++;
                }
            }

            Console.WriteLine("A quantidade de pessoas com idade superior a 50 anos é " + idade_sup_50);
            if (pessoas_10_20 != 0)
            {
                Console.WriteLine("A média das alturas das pessoas com idade entre 10 a 20 anos é " + soma_altura / pessoas_10_20);
            }
            else
            {
                Console.WriteLine("Não foi cadastrada nenhuma pessoa com idade entre 10 e 20 anos");
            }
            Console.WriteLine("A porcentagem de pessoas com peso inferior a 40 kg entre todas as pessoas analisadas é " + Convert.ToDecimal(peso_inferior / 5.00m * 100.00m));

        }
    }
}
