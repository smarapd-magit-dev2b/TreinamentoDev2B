using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula1
{
    public class Exercicio2 : IExecute
    {
        public void Execute()
        {
            int maiorNumero = 0, menorNumero = 0;
            int numero;
            Console.WriteLine("Exercício 2\n\nDigite 10 números\n");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}º número: ");
                numero = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    maiorNumero = numero;
                    menorNumero = numero;
                }
                else if (numero > maiorNumero)
                    maiorNumero = numero;
                else if (numero < menorNumero)
                    menorNumero = numero;
            }
            Console.WriteLine($"O maior número digitado foi o {maiorNumero}");
            Console.WriteLine($"O menor número digitado foi o {menorNumero}");
        }
    }
}
