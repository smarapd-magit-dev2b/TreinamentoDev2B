using System;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio1();
            //Exercicio2();
            Exercicio3();
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
    }
}
