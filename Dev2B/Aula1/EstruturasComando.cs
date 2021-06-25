using System;
using System.Collections.Generic;
using System.Text;

namespace Aula1
{
    public class EstruturasComando
    {
		public void Execute()
        {
            Ex1();
            Ex2();
            Ex3();
            Ex4_1();
			Ex4_2();
			Ex5_1();
			Ex5_2();
			Ex5_3();
			Ex10();
        }
		private void Ex1()
		{

			decimal media;

			Console.WriteLine("Digite a média:");
			media = Convert.ToDecimal(Console.ReadLine());

			if (media <= 3.99m)
			{
				Console.WriteLine("Reprovado");
			}
			else
			{
				if (media <= 6.99m)
				{
					Console.WriteLine("Exame");
				}
				else
				{
					if (media <= 10)
					{
						Console.WriteLine("Aprovado");
					}
					else
					{
						Console.WriteLine("Média Inválida.");
					}
				}
			}
			Console.ReadLine();
		}

		private void Ex2()
		{

			int num;
			int numeromaior = 0;
			int numeromenor = 0;

			Console.WriteLine("Digite 10 números: ");
			for (int i = 1; i < 11; i++)
			{
				Console.WriteLine("Inserir o número " + i);
				num = Convert.ToInt32(Console.ReadLine());
				if (num > numeromaior)
				{
					numeromaior = num;
				}
				else
				{
					numeromenor = num;
				}
			}
			Console.WriteLine("O maior número é: " + numeromaior);
			Console.WriteLine("O menor número é: " + numeromenor);

			Console.ReadLine();
		}

		private void Ex3()
		{

			Console.WriteLine("Informe o primeiro valor: ");
			int v1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Informe o segundo valor: ");
			int v2 = int.Parse(Console.ReadLine());

			if (v1 % v2 == 0)
			{
				Console.Write("Os números são multiplos");
			}
			else
			{
				Console.WriteLine("\nOs números não são multiplos");
			}
			Console.ReadLine();
		}

		private void Ex4_1()
		{
			Console.WriteLine("Informe o primeiro valor: ");
			int v1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Informe o segundo valor: ");
			int v2 = int.Parse(Console.ReadLine());

			Console.WriteLine("Informe qual a operação matemática(+, -, /, *): ");
			string operacao = Console.ReadLine();
			Console.Clear();

			if (operacao == "+")
			{
				Console.WriteLine($"O resultado de {v1} + {v2} é: " + (v1 + v2));
			}
			else if (operacao == "-")
			{
				Console.WriteLine($"O resultado de {v1} - {v2} é: " + (v1 - v2));
			}
			else if (operacao == "/")
			{
				if (v2 <= 0)
				{
					Console.WriteLine($"Não é possivel realizar a divisão com denominador zero.");
				}
				else
				{
					Console.WriteLine($"O resultado de {v1} / {v2} é: " + (v1 / v2));
				}

			}
			else if (operacao == "*")
			{
				Console.WriteLine($"O resultado de {v1} * {v2} é: " + (v1 * v2));
			}
			else
			{
				Console.WriteLine("Operação Inválida.");
			}

			Console.ReadLine();
		}

		private void Ex4_2()
        {
			Console.WriteLine("Informe o primeiro valor: ");
			int v1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Informe o segundo valor: ");
			int v2 = int.Parse(Console.ReadLine());

			Console.WriteLine("Informe qual a operação matemática(+, -, /, *): ");
			string operacao = Console.ReadLine();
			Console.Clear();

			switch (operacao)
			{
				case "+":
					Console.WriteLine($"O resultado de {v1} + {v2} é: " + (v1 + v2));
					break;
				case "-":
					Console.WriteLine($"O resultado de {v1} - {v2} é: " + (v1 - v2));
					break;
				case "/":
					Console.WriteLine($"O resultado de {v1} / {v2} é: " + (v1 / v2));
					break;
				case "*":
					Console.WriteLine($"O resultado de {v1} * {v2} é: " + (v1 * v2));
					break;
				default:
					Console.WriteLine("Operação Inválida.");
					break;
			}
			Console.ReadLine();
		}

		private void Ex5_1()
		{
			int soma = 0;
            for (int i = 1; i <= 100; i++)
            {
                soma += i;
            }
            Console.WriteLine("A soma dos números de 1 até 100 é: " + soma);

			Console.ReadLine();

        }

		private void Ex5_2()
        {
			int soma = 0, numero = 1;

			while (numero <= 100)
			{
				soma += numero;
				numero++;
			}
			Console.WriteLine("A soma dos números de 1 até 100 é: " + soma);

			Console.ReadLine();
		}

		private void Ex5_3()
        {
			int soma = 0, numero = 1;

			do
			{
				soma += numero;
				numero++;
			} while (numero <= 100);
			Console.WriteLine("A soma dos números de 1 até 100 é: " + soma);

			Console.ReadLine();
		}

		private void Ex10()
		{
			int idade50 = 0, pesoinferior40 = 0, idade1020 = 0;
			decimal media_altura = 0m, porcentagemPessoas = 0m;

			for (int i = 1; i <= 5; i++)
			{
				Console.WriteLine("Digite a idade da pessoa " + i);
				int idade = int.Parse(Console.ReadLine());
				Console.WriteLine("Digite a altura da pessoa " + i);
				decimal altura = Convert.ToDecimal(Console.ReadLine());
				Console.WriteLine("Digite o peso da pessoa " + i);
				decimal peso = Convert.ToDecimal(Console.ReadLine());

				if (idade > 50)
				{
					idade50++;
				}
				else if (idade >= 10 && idade <= 20)
				{
					idade1020++;
					media_altura += altura;
					media_altura = (media_altura / idade1020);
				}

				if (peso < 40)
				{
					pesoinferior40++;
				}
				porcentagemPessoas = (100 * pesoinferior40 / 5);
			}
			Console.WriteLine("Idade Superior a 50: " + idade50);
			Console.WriteLine("Media das alturas: " + media_altura);
			Console.WriteLine("Porcentagem peso: " + porcentagemPessoas + " %");

			Console.ReadLine();
		}
	}
}
