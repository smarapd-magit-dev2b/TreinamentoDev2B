using System;
using System.Globalization;

namespace Day01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rodando = false;
            decimal nota = 0;

            while (rodando)
            {
                Console.Write("Digite a nota do aluno: ");
                nota = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (nota > 10)
                {
                    Console.WriteLine("Nota invalida !!");
                }
                else
                {
                    rodando = true;
                }
            }

            if(nota >= 7)
            {
                Console.WriteLine("Aprovado !!");
            }
            else if(nota >= 4 && nota <= 6.99m)
            {
                Console.WriteLine("Exame !!");
            }
            else
            {
                Console.WriteLine("Reprovado !!");
            }



        }
    }
}
