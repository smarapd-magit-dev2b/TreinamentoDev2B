using System;


namespace Projeto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //nota();
            maioremenor();
            //multiplos();
            //calculadora();
            //somatotal();
        }

        static void nota()
        {
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

        static void maioremenor()
        {
            int maior = 0, menor = 0;
            int controle = 0;

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

        static void multiplos()
        {


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

        static void calculadora()
        {

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

        static void somatotal()
        {
            int soma = 0;
            int i = 0;

            //for (int i = 0; i < 100; i++)
            // {
            //     soma += i;
            // }
            while (i < 100)
            {
                soma += i;
                i++;
            }
            Console.WriteLine("Soma total de todos os numeros de 1 a 100: " + soma);
        }
    }
}

