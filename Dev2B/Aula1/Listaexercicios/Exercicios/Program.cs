using System;

namespace Exercicios
{
	class Program
	{
		static void Main(string[] args)
		{
			//Ex1();
			Ex2();
		}

		static void Ex1() {

			decimal media;

			Console.WriteLine("Digite a média:");
			media = Convert.ToDecimal(Console.ReadLine());

			if (media >= 7 && media <= 10)
			{
				Console.WriteLine("Aprovado");
			}
			else if (media >= 4 && media < 7)
			{
				Console.WriteLine("Exame");
			}
			else if (media < 4 && media >= 0){
				Console.WriteLine("Reprovado");
			}
			else
			{
				Console.WriteLine("Media Invalida. Favor informar um valor entre 0 e 10.");
			}
		}

		static void Ex2() {

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

		}



	}
}
