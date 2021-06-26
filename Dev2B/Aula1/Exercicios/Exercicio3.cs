using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula1
{
    public class Exercicio3 : IExecute
    {
        public void Execute()
        {
            int valor1, valor2;
            Console.WriteLine("Exercício 3\n\nDigite 2 valores\n\nPrimeiro valor: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());
            if ((valor1 % valor2) == 0)
                Console.WriteLine($"{valor1} é múltiplo de {valor2}");
            else if ((valor2 % valor1) == 0)
                Console.WriteLine($"{valor2} é múltiplo de {valor1}");
            else
                Console.WriteLine($"{valor1} e {valor2} não são múltiplos");
        }
    }
}
