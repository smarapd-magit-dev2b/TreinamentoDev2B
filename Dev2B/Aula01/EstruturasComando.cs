using System;

namespace Aula01
{
    public class EstruturasComando
    {

        public void Execute()
        {
            Ex1();
            Ex2();
            Ex2Vetor();
            Ex3();
            Ex4_1();
            Ex4_2();
            Ex5_1();
            Ex5_2();
            Ex5_3();
            Ex6_1();
            Ex6_2();
            Ex6_3();
            Ex7_1();
            Ex7_2();
            Ex7_3();
            Ex8_1();
            Ex8_2();
            Ex8_3();
            Ex9_1();
            Ex9_2();
            Ex9_3();
            Ex10();
        }

        static void Ex1()
        {
            Console.WriteLine("Entre com a média do aluno: ");
            decimal mediaAluno = Convert.ToDecimal(Console.ReadLine());

            if (mediaAluno <= 10 && mediaAluno >= 7)
            {
                Console.WriteLine("Aprovado!");
            }
            else if (mediaAluno < 7 && mediaAluno >= 4)
            {
                Console.WriteLine("Exame!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
            }
        }

        static void Ex2()
        {
            int maior = 0;
            int menor = 0;
            int num;
            int i;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Entre com o " + (i + 1) + "º número ");
                num = Convert.ToInt32(Console.ReadLine());
                if (i == 0)
                {
                    maior = num;
                    menor = num;
                }
                else
                {
                    if (num > maior)
                    {
                        maior = num;
                    }
                    if (num < menor)
                    {
                        menor = num;
                    }
                }
            }
            Console.WriteLine("O maior valor é: " + maior + " e o menor valor é: " + menor);
        }

        static void Ex2Vetor()
        {
            int[] numeros = new int[10];
            int maior = 0;
            int menor = 0;
            int i;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Entre com o " + (i + 1) + "º número ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                if (i == 0)
                {
                    maior = numeros[i];
                    menor = numeros[i];
                }
                else
                {
                    if (numeros[i] > maior)
                    {
                        maior = numeros[i];
                    }
                    if (numeros[i] < menor)
                    {
                        menor = numeros[i];
                    }
                }
            }
            Console.WriteLine("O maior valor é: " + maior + " e o menor valor é: " + menor);
        }

        static void Ex3()
        {
            int num1;
            int num2;

            Console.WriteLine("Entre com o primeiro número");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre com o segundo número");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 % num2 == 0)
            {
                Console.WriteLine("São múltiplos");
            }
            else
            {
                Console.WriteLine("NÂO são múltiplos");
            }
        }

        static void Ex4_1()
        {
            decimal num1;
            decimal num2;
            char operador;
            decimal resultado = 0;

            Console.WriteLine("Entre com o primeiro número");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Entre com o segundo número");
            num2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Entre com o sinal da operação que deseja realizar *  /  +  -");
            operador = Convert.ToChar(Console.ReadLine());

            if (operador == '/')
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Impossível realizar essa operação! Entre com um valor não nulo para o segundo número");
                }
                else
                {
                    resultado = num1 / num2;
                    Console.WriteLine("O resultado da operação é: " + resultado);
                }

            }
            else if (operador == '*')
            {
                resultado = num1 * num2;
                Console.WriteLine("O resultado da operação é: " + resultado);
            }
            else if (operador == '+')
            {
                resultado = num1 + num2;
                Console.WriteLine("O resultado da operação é: " + resultado);
            }
            else if (operador == '-')
            {
                resultado = num1 - num2;
                Console.WriteLine("O resultado da operação é: " + resultado);
            }
            else
            {
                Console.WriteLine("Operador inválido");
            }

        }

        static void Ex4_2()
        {
            decimal num1;
            decimal num2;
            string operador;
            decimal resultado = 0;

            Console.WriteLine("Entre com o primeiro número");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Entre com o segundo número");
            num2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Entre com o sinal da operação que deseja realizar *  /  +  -");
            operador = Console.ReadLine();

            switch (operador)
            {
                case ("/"):
                    if (num2 == 0)
                    {
                        Console.WriteLine("Impossível realizar essa operação! Entre com um valor não nulo para o segundo número");
                    }
                    else
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("O resultado da operação é: " + resultado);
                    }
                    break;
                case ("*"):
                    resultado = num1 * num2;
                    Console.WriteLine("O resultado da operação é: " + resultado);
                    break;
                case ("+"):
                    resultado = num1 + num2;
                    Console.WriteLine("O resultado da operação é: " + resultado);
                    break;
                case ("-"):
                    resultado = num1 - num2;
                    Console.WriteLine("O resultado da operação é: " + resultado);
                    break;
                default:
                    Console.WriteLine("Operador inválido");
                    break;
            }

        }

        static void Ex5_1()
        {
            int i;
            int soma = 0;
            for (i = 1; i <= 100; i++)
            {
                soma = soma + i;
            }
            Console.WriteLine("A soma é: " + soma);
        }

        static void Ex5_2()
        {
            int i = 1;
            int soma = 0;
            while (i <= 100)
            {
                soma = soma + i;
                i++;
            }
            Console.WriteLine("A soma é: " + soma);
        }

        static void Ex5_3()
        {
            int i = 1;
            int soma = 0;
            do
            {
                soma = soma + i;
                i++;
            } while (i <= 100);
            Console.WriteLine("A soma é: " + soma);
        }

        static void Ex6_1()
        {
            int i;
            for (i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Ex6_2()
        {
            int i = 1;
            while (i <= 100)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }

        static void Ex6_3()
        {
            int i = 1;
            do
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            } while (i <= 100);
        }

        static void Ex7_1()
        {
            int i;
            int soma = 0;
            for (i = 1; i <= 100; i++)
            {
                if (i % 3 != 0)
                {
                    soma = soma + i;
                }

            }
            Console.WriteLine("A soma é: " + soma);
        }

        static void Ex7_2()
        {
            int i = 1;
            int soma = 0;
            while (i <= 100)
            {
                if (i % 3 != 0)
                {
                    soma = soma + i;
                }
                i++;
            }
            Console.WriteLine("A soma é: " + soma);
        }

        static void Ex7_3()
        {
            int i = 1;
            int soma = 0;
            do
            {
                if (i % 3 != 0)
                {
                    soma = soma + i;
                }
                i++;
            } while (i <= 100);
            Console.WriteLine("A soma é: " + soma);
        }

        static void Ex8_1()
        {
            int i;
            for (i = 0; i <= 30; i++)
            {
                if (i % 3 == 0 || i % 4 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Ex8_2()
        {
            int i = 0;
            while (i <= 30)
            {
                if (i % 3 == 0 || i % 4 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }

        static void Ex8_3()
        {
            int i = 0;
            do
            {
                if (i % 3 == 0 || i % 4 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            } while (i <= 30);
        }

        static void Ex9_1()
        {
            int num;
            Console.WriteLine("Entre com um número de 0 a 100 ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0 && num <= 100)
            {
                int i;
                for (i = 0; i <= 10; i++)
                {
                    Console.WriteLine(num + " * " + i + " = " + (num * i) + "\n");
                }
            }
            else
            {
                Console.WriteLine("Numero invalido");
            }
        }

        static void Ex9_2()
        {
            int num;
            Console.WriteLine("Entre com um número de 0 a 100 ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0 && num <= 100)
            {
                int i = 0;
                while (i <= 10)
                {
                    Console.WriteLine(num + " * " + i + " = " + (num * i) + "\n");
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Numero invalido");
            }
        }

        static void Ex9_3()
        {
            int num;
            Console.WriteLine("Entre com um número de 0 a 100 ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0 && num <= 100)
            {
                int i = 0;
                do
                {
                    Console.WriteLine(num + " * " + i + " = " + (num * i) + "\n");
                    i++;
                } while (i <= 10);
            }
            else
            {
                Console.WriteLine("Numero invalido");
            }
        }

        static void Ex10()
        {
            int i;
            int idade;
            decimal altura;
            decimal peso;
            int idade_sup_50 = 0;
            decimal soma_altura = 0;
            int pessoas_10_20 = 0;
            int peso_inferior = 0;

            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine("Entre com a idade da pessoa " + i);
                idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entre com a altura da pessoa " + i);
                altura = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Entre com o peso da pessoa " + i);
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
