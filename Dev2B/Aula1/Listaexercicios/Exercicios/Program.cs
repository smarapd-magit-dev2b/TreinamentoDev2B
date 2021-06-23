using System;

namespace Exercicios
{
	class Program
	{
		static void Main(string[] args)
		{
			//Ex1();
			//Ex2();
			//Ex3();
			//Ex4();
			//Ex5();
			//Ex10();
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

		static void Ex3() {

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
		}

		static void Ex4()
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
                if (v2 <=0)
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

    //        switch (operacao)
    //        {
				//case "+":
				//	Console.WriteLine($"O resultado de {v1} + {v2} é: " + (v1+v2));
				//	break;
				//case "-":
				//	Console.WriteLine($"O resultado de {v1} - {v2} é: " + (v1-v2));
				//	break;
				//case "/":
				//	Console.WriteLine($"O resultado de {v1} / {v2} é: " + (v1/v2));
				//	break;
				//case "*":
				//	Console.WriteLine($"O resultado de {v1} * {v2} é: " + (v1*v2));
				//	break;
				//default:
				//	Console.WriteLine("Operação Inválida.");
    //                break;
    //        }
        }

		static void Ex5()
        {
			int soma = 0, numero = 1;
            //         for (int i = 1 ; i < 101; i++)
            //         {
            //	soma += i;
            //         }
            //Console.WriteLine("A soma dos números de 1 até 100 é: " + soma);
            //         while (numero <= 100)
            //         {
            //	soma += numero;
            //	numero++;
            //}
            //Console.WriteLine("A soma dos números de 1 até 100 é: " + soma);
            do
            {
				soma += numero;
				numero++;
			} while (numero <= 100);
			Console.WriteLine("A soma dos números de 1 até 100 é: " + soma);
		}

		static void Ex10()
        {
			int contadoridade = 0, contadorpeso = 0, contadoridade2 = 0;
			decimal media_altura = 0;

			for (int i = 1; i < 6; i++)
            {
				Console.WriteLine("Digite a idade da pessoa " + i);
				int idade = int.Parse(Console.ReadLine());
				Console.WriteLine("Digite a altura da pessoa " + i);
				decimal altura = Convert.ToDecimal(Console.ReadLine());
				Console.WriteLine("Digite o peso da pessoa " + i);
				decimal peso = Convert.ToDecimal(Console.ReadLine());

				if (idade > 50)
				{
					contadoridade++;
				} else if (idade >=10  && idade <= 20 ) {
					contadoridade2++;
                    media_altura += altura;
					media_altura = (media_altura / contadoridade2);

				}

                if (peso < 40)
                {
					contadorpeso++;
                }
			}
			Console.WriteLine("Idade Superior a 50: " + contadoridade);
			Console.WriteLine("Media das alturas: " + media_altura);
			Console.WriteLine("Porcentagem peso: " + (100*contadorpeso/5));
		}

	}
}
