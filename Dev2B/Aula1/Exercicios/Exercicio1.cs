using Domain.Interfaces;
using System;

namespace Aula1.Exercicios
{
    public class Exercicio1 : IExecute
    {
        public void Execute()
        {
            Console.Write("Exercício 1\n\nDigite sua nota: ");
            decimal numero = decimal.Parse(Console.ReadLine());

            if (numero <= 10 && numero >= 7)
                Console.WriteLine("Aprovado");
            else if (numero < 7)
                Console.WriteLine("Exame");
            else if (numero < 4)
                Console.WriteLine("Reprovado");
            else
                Console.WriteLine("Média Inválida");
        }
    }
}
