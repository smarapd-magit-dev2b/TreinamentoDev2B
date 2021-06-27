using Domain.Interfaces;
using System;

namespace Aula1.Exercicios
{
    public class Exercicio2 : IExecute
    {
        public int MaiorNumero { get; set; }
        public int MenorNumero { get; set; }
        public int Numero { get; set; }

        public void Execute()
        {
            Console.WriteLine("Exercício 2\n\nDigite 10 números\n");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}º número: ");
                Numero = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    MaiorNumero = Numero;
                    MenorNumero = Numero;
                }
                else if (Numero > MaiorNumero)
                    MaiorNumero = Numero;
                else if (Numero < MenorNumero)
                    MenorNumero = Numero;
            }
            Console.WriteLine($"\nO maior número digitado foi o {MaiorNumero}\n");
            Console.WriteLine($"O menor número digitado foi o {MenorNumero}");
        }
    }
}
