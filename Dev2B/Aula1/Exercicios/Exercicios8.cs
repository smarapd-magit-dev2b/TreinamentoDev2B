using Domain.Interfaces;
using System;

namespace Aula1.Exercicios
{
    public class Exercicios8 : IExecute
    {
        public void Cadastrar()
        {
            Exercicio8for();
            Exercicio8while();
            Exercicio8do();
        }
        private void Exercicio8for()
        {
            Console.WriteLine("Exercício 8 For\n");

            for (int i = 3; i < 30; i++)
                if ((i % 3) == 0 || (i % 4) == 0)
                    Console.WriteLine(i);
        }
        
        private void Exercicio8while()
        {
            Console.WriteLine("Exercício 8 While\n");

            var i = 3;

            while (i < 30)
            {
                if ((i % 3) == 0 || (i % 4) == 0)
                    Console.WriteLine(i);

                i++;
            }
        }

        private void Exercicio8do()
        {
            Console.WriteLine("Exercício 8 Do While\n");

            var i = 3;

            do
            {
                if ((i % 3) == 0 || (i % 4) == 0)
                    Console.WriteLine(i);

                i++;
            } while (i < 30);
        }
    }
}
