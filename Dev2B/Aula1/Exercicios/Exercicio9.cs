using Domain.Interfaces;
using System;

namespace Aula1.Exercicios
{
    public class Exercicio9 : IExecute
    {
        public void Execute()
        {
            bool run;
            do
            {
                run = true;

                Console.Write("Exercício 9 \n\nDigite um número de 1 a 100: ");
                var numero = int.Parse(Console.ReadLine());

                if (numero >= 0 && numero <= 100)
                {
                    Tabuada(numero);
                    run = false;
                }
                else
                    Console.WriteLine($"{numero} é um número inválido");
            } while (run);
        }

        private void Tabuada(int numero)
        {
            for (int i = 0; i <= 10; i++)
                Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}
