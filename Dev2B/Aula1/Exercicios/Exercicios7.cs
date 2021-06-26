using Domain;
using System;

namespace Aula1
{
    public class Exercicios7 : IExecute
    {
        public void Execute()
        {
            Exercicio7for();
            Exercicio7while();
            Exercicio7do();
        }

        private void Exercicio7for()
        {
            int soma = 0;
            for (int i = 1; i <= 100; i++)
                if ((i % 3) != 0)
                    soma += i;
            Console.WriteLine($"Exercício 7 For\n\nSoma de 1 a 100 menos os múltiplos de 3: {soma}");
        }

        private void Exercicio7while()
        {
            int soma = 0, i = 1;
            while (i <= 100)
            {
                if ((i % 3) != 0)
                    soma += i;
                i++;
            }
            Console.WriteLine($"Exercício 7 While\n\nSoma de 1 a 100 menos os múltiplos de 3: {soma}");
        }

        private void Exercicio7do()
        {
            int soma = 0, i = 1;
            do
            {
                if ((i % 3) != 0)
                    soma += i;
                i++;
            } while (i <= 100);
            Console.WriteLine($"Exercício 7 Do While\n\nSoma de 1 a 100 menos os múltiplos de 3: {soma}");
        }
    }
}
