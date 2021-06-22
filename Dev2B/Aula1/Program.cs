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
            //Exercicio4IF();
            //Exercicio4Switch();
            //Exercicio5For();
            //Exercicio5While();
            //Exercicio5DoWhile();
            //Exercicio6For();
            //Exercicio6While();
            //Exercicio6DoWhile();

        }

        static void Exercicio1()
        {
            Console.Write("Informe a nota: ");

            string entrada = Console.ReadLine();
            decimal nota = decimal.Parse(entrada);

            if (nota >= 7 && nota <= 10)
            {
                Console.WriteLine("Aprovado!");
            }
            else if (nota >= 4 && nota < 7)
            {
                Console.WriteLine("Exame!");
            }
            else if (nota >= 0 && nota < 4)
            {
                Console.WriteLine("Reprovado!");
            }

        }

        static void Exercicio2()
        {
            decimal menorValor = 0;
            decimal maiorValor = 0;
            decimal valor;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Informe o {i} valor: ");
                valor = decimal.Parse(Console.ReadLine());

                if (i == 0)
                {
                    maiorValor = valor;
                    menorValor = valor;
                }

                if (valor > maiorValor) maiorValor = valor;
                if (valor < menorValor) menorValor = valor;
            }


            Console.WriteLine($"Menor valor: {menorValor}");
            Console.WriteLine($"Maior valor: {maiorValor}");
        }

        static void Exercicio3()
        {
            Console.WriteLine("Informe o valor 1");
            decimal valor1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor 2");
            decimal valor2 = decimal.Parse(Console.ReadLine());


            if (valor1 % valor2 == 0)
                Console.WriteLine($"Os valores {valor1} e {valor2} são multiplos");
            else
                Console.WriteLine($"Os valores {valor1} e {valor2} não são multiplos");
        }

        static void Exercicio4IF()
        {
            Console.WriteLine("Informe o valor 1");
            decimal valor1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor 2");
            decimal valor2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Informe a operação (/ , * , - , +)");
            string operacao = Console.ReadLine();
            decimal resultado = 0;

            if (operacao == "+")
            {
                resultado = valor1 + valor2;
            }
            else if (operacao == "-")
            {
                resultado = valor1 - valor2;
            }
            else if (operacao == "*")
            {
                resultado = valor1 * valor2;
            }
            else if (operacao == "/")
            {
                resultado = valor1 / valor2;
            }

            Console.WriteLine($"O resultado a operação de {operacao} é igual a {resultado}");
        }

        static void Exercicio4Switch()
        {
            Console.WriteLine("Informe o valor 1");
            decimal valor1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor 2");
            decimal valor2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Informe a operação (/ , * , - , +)");
            string operacao = Console.ReadLine();
            decimal resultado = 0;

            switch (operacao)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "*":
                    resultado = valor1 * valor2;
                    break;
                case "/":
                    resultado = valor1 / valor2;
                    break;
                default:
                    Console.WriteLine("Operação invalida");
                    return;
            }


            Console.WriteLine($"O resultado a operação de {operacao} é igual a {resultado}");
        }

        static void Exercicio5For()
        {
            decimal somaFor = 0;



            for (int i = 1; i <= 100; i++)
            {
                somaFor += i;
            }


            Console.WriteLine($"A soma é: {somaFor}");
        }

        static void Exercicio5While()
        {
            decimal somaWhile = 0;
            int cWhile = 1;

            while (cWhile <= 100)
            {
                somaWhile += cWhile;
                cWhile++;
            }

            Console.WriteLine($"A soma é: {somaWhile}");
        }

        static void Exercicio5DoWhile()
        {
            decimal somaDoWhile = 0;
            int cDoWhile = 0;

            do
            {
                somaDoWhile += cDoWhile;
                cDoWhile++;
            } while (cDoWhile <= 100);
            Console.WriteLine($"A soma é: {somaDoWhile}");
        }

        static void Exercicio6For()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0) Console.WriteLine(i);
            }
        }

        static void Exercicio6While()
        {
            int cWhile = 1;

            while (cWhile <= 100)
            {
                if (cWhile % 3 == 0) Console.WriteLine(cWhile);
                cWhile++;
            }

        }

        static void Exercicio6DoWhile()
        {
            int cDoWhile = 0;

            do
            {
                if (cDoWhile % 3 == 0) Console.WriteLine(cDoWhile);
                cDoWhile++;
            } while (cDoWhile <= 100);
        }
    }
}
