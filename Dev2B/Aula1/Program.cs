using System;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4if();
            //Ex4switch();
            //Ex5for();
            //Ex5while();
            //Ex5do();
            //Ex6for();
            //Ex6while();
            //Ex6do();
            //Ex7for();
            //Ex7while();
            //Ex7do();
            //Ex8for();
            //Ex8while();
            //Ex8do();
            Ex9();
            //Ex10();
        }

        static void Ex1()
        {
            Console.WriteLine("Digite sua nota:");
            decimal numero = decimal.Parse(Console.ReadLine());
            if (numero <= 10 && numero >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else if (numero < 7)
            {
                Console.WriteLine("Exame");
            }
            else if (numero < 4)
            {
                Console.WriteLine("Reprovado");
            }
            else
            {
                Console.WriteLine("Média Inválida");
            }
        }
        static void Ex2()
        {
            int maiorNumero = 0, menorNumero = 0;
            int numero;

            Console.WriteLine("Digite 10 números\n");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write((i) + "º número: ");
                numero = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    maiorNumero = numero;
                    menorNumero = numero;
                }
                else if (numero > maiorNumero)
                {
                    maiorNumero = numero;
                }
                else if (numero < menorNumero)
                {
                    menorNumero = numero;
                }
            }
            Console.WriteLine("o maior número digitado foi o " + maiorNumero);
            Console.WriteLine("o menor número digitado foi o " + menorNumero);
        }

        static void Ex3()
        {
            int valor1, valor2;

            Console.WriteLine("Digite 2 valores\n");
            Console.Write("Primeiro valor: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());

            if ((valor1 % valor2) == 0)
            {
                Console.WriteLine(valor1 + " é múltiplo de " + valor2);
            }
            else if ((valor2 % valor1) == 0)
            {
                Console.WriteLine(valor2 + " é múltiplo de " + valor1);
            }
            else
            {
                Console.WriteLine(valor1 + " e " + valor2 + " não são múltiplos");
            }
        }

        static void Ex4if()
        {
            decimal numero1, numero2;
            char operacao;

            Console.WriteLine("Digite dois números e a operação que deseja realizar com eles\n\n" +
                "Operações: Soma(+), Subtração(-), Multiplicação(x), Divisão(/)\n");

            Console.Write("Primeiro número: ");
            numero1 = decimal.Parse(Console.ReadLine());

            Console.Write("Segundo número: ");
            numero2 = decimal.Parse(Console.ReadLine());

            Console.Write("Operação: ");
            operacao = char.Parse(Console.ReadLine());

            if (operacao == '+')
            {
                Console.WriteLine(numero1 + " + " + numero2 + " = " + (numero1 + numero2));
            }
            else if (operacao == '-')
            {
                Console.WriteLine(numero1 + " - " + numero2 + " = " + (numero1 - numero2));
            }
            else if (operacao == 'x')
            {
                Console.WriteLine(numero1 + " x " + numero2 + " = " + (numero1 * numero2));
            }
            else if (operacao == '/')
            {
                Console.WriteLine(numero1 + " / " + numero2 + " = " + (numero1 / numero2));
            }
            else
            {
                Console.WriteLine(operacao + " é uma operação inválida");
            }
        }

        static void Ex4switch()
        {
            decimal numero1, numero2;
            char operacao;

            Console.WriteLine("Digite dois números e a operação que deseja realizar com eles\n\n" +
                "Operações: Soma(+), Subtração(-), Multiplicação(x), Divisão(/)\n");

            Console.Write("Primeiro número: ");
            numero1 = decimal.Parse(Console.ReadLine());

            Console.Write("Segundo número: ");
            numero2 = decimal.Parse(Console.ReadLine());

            Console.Write("Operação: ");
            operacao = char.Parse(Console.ReadLine());

            switch (operacao)
            {
                case '+':
                    Console.WriteLine(numero1 + " + " + numero2 + " = " + (numero1 + numero2));
                    break;
                case '-':
                    Console.WriteLine(numero1 + " - " + numero2 + " = " + (numero1 - numero2));
                    break;
                case 'x':
                    Console.WriteLine(numero1 + " x " + numero2 + " = " + (numero1 * numero2));
                    break;
                case '/':
                    Console.WriteLine(numero1 + " / " + numero2 + " = " + (numero1 / numero2));
                    break;
                default:
                    Console.WriteLine(operacao + " é uma operação inválida");
                    break;
            }
        }

        static void Ex5for()
        {
            int soma = 0;
            for (int i = 1; i <= 100; i++)
            {
                soma += i;
            }
            Console.WriteLine("Soma de 1 a 100: " + soma);
        }

        static void Ex5while()
        {
            int soma = 0, i = 1;

            while (i <= 100)
            {
                soma += i;
                i++;
            }
            Console.WriteLine("Soma de 1 a 100: " + soma);
        }

        static void Ex5do()
        {
            int soma = 0, i = 1;

            do
            {
                soma += i;
                i++;
            } while (i <= 100);
            Console.WriteLine("Soma de 1 a 100: " + soma);
        }

        static void Ex6for()
        {
            for (int i = 3; i < 100; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        static void Ex6while()
        {
            int i = 3;
            while (i < 100)
            {
                Console.WriteLine(i);
                i += 3;
            }
        }
        static void Ex6do()
        {
            int i = 3;
            do
            {
                Console.WriteLine(i);
                i += 3;
            } while (i < 100);
        }

        static void Ex7for()
        {
            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3) != 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine("Soma de 1 a 100 menos os múltiplos de 3: " + soma);
        }

        static void Ex7while()
        {
            int soma = 0, i = 1;
            while (i <= 100)
            {
                if ((i % 3) != 0)
                {
                    soma += i;
                }
                i++;
            }
            Console.WriteLine("Soma de 1 a 100 menos os múltiplos de 3: " + soma);
        }

        static void Ex7do()
        {
            int soma = 0, i = 1;
            do
            {
                if ((i % 3) != 0)
                {
                    soma += i;
                }
                i++;
            } while (i <= 100);
            Console.WriteLine("Soma de 1 a 100 menos os múltiplos de 3: " + soma);
        }

        static void Ex8for()
        {
            for (int i = 3; i < 30; i++)
            {
                if ((i % 3) == 0 || (i % 4) == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Ex8while()
        {
            int i = 3;
            while (i < 30)
            {
                if ((i % 3) == 0 || (i % 4) == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }

        static void Ex8do()
        {
            int i = 3;
            do
            {
                if ((i % 3) == 0 || (i % 4) == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            } while (i < 30);
        }

        static void Ex9()
        {
            int numero;
            bool run = true;
            do
            {
                Console.Write("Digite um número de 1 a 100: ");
                numero = int.Parse(Console.ReadLine());
                if (numero >= 0 && numero <= 100)
                {
                    tabuada(numero);
                    run = false;
                }
                else
                {
                    Console.WriteLine(numero + " é um número inválido");
                }
            } while (run);
        }

        static void tabuada(int numero)
        {
            for (int i = 0; i <= 10 ; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            }
        }

        static void Ex10()
        {
            int pessoa50 = 0, dezA20 = 0;
            decimal media10a20 = 0, porcentagem40, alturas10a20 = 0, pesos40 = 0;

            for (int i = 1; i <= 5; i++)
            {
                Pessoa pessoa = new Pessoa();
                Console.Write("Digite a idade da " + i + "º pessoa: ");
                pessoa.idade = int.Parse(Console.ReadLine());
                Console.Write("Digite a altura da " + i + "º pessoa: ");
                pessoa.altura = decimal.Parse(Console.ReadLine());
                Console.Write("Digite o peso da " + i + "º pessoa: ");
                pessoa.peso = decimal.Parse(Console.ReadLine());

                //Regras de negócio
                if (pessoa.idade > 50)
                {
                    pessoa50++;
                }
                if (pessoa.idade >= 10 && pessoa.idade <= 20)
                {
                    dezA20++;
                    alturas10a20 += pessoa.altura;
                }
                if (pessoa.peso < 40)
                {
                    pesos40++;
                }
            }
            //Regras de negócio
            if (dezA20 != 0)
            {
                media10a20 = alturas10a20 / dezA20;
            }
            porcentagem40 = pesos40 / 5;

            Console.WriteLine("Há " + pessoa50 + " pessoas com idade superior a 50 anos");
            Console.WriteLine("A média das alturas das pessoas entre 10 e 20 anos é " + media10a20);
            Console.WriteLine("A porcentagem das pessoas com peso inferior a 40 kilos é " + (porcentagem40 * 100) + "%");
        }
    }
}
