using Calendario;
using System;

namespace Exercicios_3_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta;

            Data data = new Data(5, 10, 2021);

            Console.WriteLine($"{data.ToString()}");
            do
            {
                Console.WriteLine("Deseja consulta a data seguinte?");
                resposta = Console.ReadLine();

                if (resposta == "sim")
                {
                    data.nextDay();
                    Console.WriteLine($"{data.ToString()}");
                }
                else
                {
                   Console.WriteLine("Saindo...");
                }
            } while (resposta != "nao");
            




        }
    }
}
