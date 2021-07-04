using Domain.Interfaces;
using System;

namespace Aula1.Exercicios
{
    public class Exercicio2 : IExecute
    {
        public int MaiorNumero { get; set; }
        public int MenorNumero { get; set; }

        public void Execute()
        {
            Console.WriteLine("Exercício 2\n\nDigite 10 números\n");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}º número: ");
                var numero = int.Parse(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        MaiorNumero = numero;
                        MenorNumero = numero;
                        break;
                    default:
                        if (numero > MaiorNumero)
                            MaiorNumero = numero;
                        else if (numero < MenorNumero)
                            MenorNumero = numero;
                        break;
                }
            }

            Console.WriteLine($"\nO maior número digitado foi o {MaiorNumero}\n");
            Console.WriteLine($"O menor número digitado foi o {MenorNumero}");
        }
    }
}
