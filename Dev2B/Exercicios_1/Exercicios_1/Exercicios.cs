using System;


namespace Projeto_1
{
    class Exercicios
    {
        static void Main(string[] args)
        {
            //ex1_nota();
            //ex2_maioremenor();
            //ex3_multiplos();
            //ex4_calculadora();
            //ex5_somatotal();
            //ex10_analise();
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

        static void analise()
        {
            int resposta = 0;
            int idade = 0;
            int peso = 0;
            int contIdade = 0;
            
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
                            Console.WriteLine("\nO numero de pessoas abaixo de 40KG é: " + contPeso);
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

