using Domain.Interfaces;
using System;

namespace Aula1.Exercicios
{
    public class Exercicio3 : IExecute
    {
        public void Cadastrar()
        {
            Console.Write("Exercício 3\n\nDigite 2 valores\n\nPrimeiro valor: ");
            var valor1 = int.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            var valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if ((valor1 % valor2) == 0)
                Console.WriteLine($"{valor1} é múltiplo de {valor2}");
            else if ((valor2 % valor1) == 0)
                Console.WriteLine($"{valor2} é múltiplo de {valor1}");
            else
                Console.WriteLine($"{valor1} e {valor2} não são múltiplos");

            Console.WriteLine();
        }
    }
}
