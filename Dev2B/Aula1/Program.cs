using System;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio1();
        }

        static void Exercicio1()
        {
            Console.Write("Informe a nota: ");

            string entrada = Console.ReadLine();
            decimal nota = decimal.Parse(entrada);

            if (nota >= 7 && nota <= 10)
            {
                Console.WriteLine("Aprovado!");
            }
            else if (nota >= 4 && nota < 7)
            {
                Console.WriteLine("Exame!");
            }
            else if (nota >= 0 && nota < 4)
            {
                Console.WriteLine("Reprovado!");
            }

        }
    }
}
