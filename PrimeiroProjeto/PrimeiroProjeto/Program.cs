using System;

namespace PrimeiroProjeto
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
            for(int i = 1; i <= 10; i++)
            {
                Console.Write((i) + "º número: ");
                numero = int.Parse(Console.ReadLine());

                if(i == 1)
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

            if((valor1 % valor2) == 0)
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

            Console.WriteLine("Digite dois números e a operação que deseja realizar com eles\n\n"+
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

            Console.WriteLine("Digite dois números e a operação que deseja realizar com eles\n\n"+
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
	        } while(i <= 100);
            Console.WriteLine("Soma de 1 a 100: " + soma);
        }
    }
}
