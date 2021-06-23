using System;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            exercicio1();
            Console.ReadKey();
        }

        static void exercicio1()
        {
            decimal media;

            Console.Write("Digite a media do aluno: ");
            media = Convert.ToDecimal(Console.ReadLine());

            if (media >= 7.0m && media <= 10.0m)
            {
                Console.WriteLine("Aprovado!");
            }
            else if (media >= 4.0m && media <= 6.99m)
            {
                Console.WriteLine("Exame!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
            }
        }
    }
}
