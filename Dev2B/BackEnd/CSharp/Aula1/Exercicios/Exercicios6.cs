using Common.Interfaces;
using System;

namespace Aula1.Exercicios
{
    public class Exercicios6 : IExecute
    {
        public void Execute()
        {
            Exercicio6for();
            Exercicio6while();
            Exexercicio6do();
        }

        private void Exercicio6for()
        {
            Console.WriteLine("Exercício 6 For\n");

            for (int i = 3; i < 100; i += 3)
                Console.WriteLine(i);
        }

        private void Exercicio6while()
        {
            Console.WriteLine("Exercício 6 While\n");

            var i = 3;

            while (i < 100)
            {
                Console.WriteLine(i);
                i += 3;
            }
        }

        private void Exexercicio6do()
        {
            Console.WriteLine("Exercício 6 Do While\n");

            int i = 3;

            do
            {
                Console.WriteLine(i);
                i += 3;
            } while (i < 100);
        }
    }
}
