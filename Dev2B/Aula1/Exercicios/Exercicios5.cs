using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula1
{
    public class Exercicios5 : IExecute
    {
        public void Execute()
        {
            Exercicio5for();
            Exercicio5while();
            Exercicio5do();
        }

        private void Exercicio5for()
        {
            int soma = 0;
            for (int i = 1; i <= 100; i++)
                soma += i;
            Console.WriteLine($"Exercício 5 for\n\nSoma de 1 a 100: {soma}");
        }

        private void Exercicio5while()
        {
            int soma = 0, i = 1;
            while (i <= 100)
            {
                soma += i;
                i++;
            }
            Console.WriteLine($"Exercício 5 While\n\nSoma de 1 a 100: {soma}");
        }

        private void Exercicio5do()
        {
            int soma = 0, i = 1;
            do
            {
                soma += i;
                i++;
            } while (i <= 100);
            Console.WriteLine($"Exercício 5 Do While\n\nSoma de 1 a 100: {soma}");
        }
    }
}
