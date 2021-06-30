using Domain.Interfaces;
using System;

namespace Aula1.Exercicios
{
    public class Exercicios5 : IExecute
    {
        private int Soma { get; set; }

        public void Cadastrar()
        {
            Exercicio5for();
            Exercicio5while();
            Exercicio5do();
        }

        private void Exercicio5for()
        {
            for (int i = 1; i <= 100; i++)
                Soma += i;

            Console.WriteLine($"Exercício 5 for\n\nSoma de 1 a 100: {Soma}");
        }

        private void Exercicio5while()
        {
            var i = 1;

            while (i <= 100)
            {
                Soma += i;
                i++;
            }

            Console.WriteLine($"Exercício 5 While\n\nSoma de 1 a 100: {Soma}");
        }

        private void Exercicio5do()
        {
            var i = 1;

            do
            {
                Soma += i;
                i++;
            } while (i <= 100);

            Console.WriteLine($"Exercício 5 Do While\n\nSoma de 1 a 100: {Soma}");
        }
    }
}
