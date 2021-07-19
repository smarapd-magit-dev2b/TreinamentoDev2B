using Common.Interfaces;
using System;

namespace Aula1.Exercicios
{
    public class Exercicios7 : IExecute
    {
        private int Soma { get; set; }

        public void Execute()
        {
            Exercicio7for();
            Exercicio7while();
            Exercicio7do();
        }

        private void Exercicio7for()
        {
            for (int i = 1; i <= 100; i++)
                if ((i % 3) != 0)
                    Soma += i;

            Console.WriteLine($"Exercício 7 For\n\nSoma de 1 a 100 menos os múltiplos de 3: {Soma}");
        }

        private void Exercicio7while()
        {
            var i = 1;

            while (i <= 100)
            {
                if ((i % 3) != 0)
                    Soma += i;
                i++;
            }

            Console.WriteLine($"Exercício 7 While\n\nSoma de 1 a 100 menos os múltiplos de 3: {Soma}");
        }

        private void Exercicio7do()
        {
            var i = 1;
            
            do
            {
                if ((i % 3) != 0)
                    Soma += i;
                i++;
            } while (i <= 100);

            Console.WriteLine($"Exercício 7 Do While\n\nSoma de 1 a 100 menos os múltiplos de 3: {Soma}");
        }
    }
}
