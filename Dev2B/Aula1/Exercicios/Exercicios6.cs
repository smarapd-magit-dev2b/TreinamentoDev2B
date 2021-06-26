using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula1
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
            Console.WriteLine("\n");
        }

        private void Exercicio6while()
        {
            Console.WriteLine("Exercício 6 While\n");
            int i = 3;
            while (i < 100)
            {
                Console.WriteLine(i);
                i += 3;
            }
            Console.WriteLine("\n");
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
            Console.WriteLine("\n");
        }
    }
}
