using System;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio1();
            exercicio2();
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
            else if (media < 4)
            {
                Console.WriteLine("Reprovado!");
            }
            else
            {
                Console.WriteLine("Inválido!");
            }
        }

        static void exercicio2()
        {
            int maior, menor, aux;
            menor = 0;
            maior = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite o " + (i + 1) + " valor: ");
                aux = Convert.ToInt32(Console.ReadLine());

                if (i == 0)
                {
                    menor = aux;
                    maior = aux;
                }
                else
                {
                    if (aux > maior)
                    {
                        maior = aux;
                    }
                    else if (aux < menor)
                    {
                        menor = aux;
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Maior número: " + maior);
            Console.WriteLine("Menor número: " + menor);
        }
    }
}
