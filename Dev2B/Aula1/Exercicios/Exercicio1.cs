using System;
using System.Collections.Generic;
using System.Text;

namespace Aula1
{
    public class Exercicio1
    {
        public Exercicio1()
        {
            Console.Write("Exercício 1\n\nDigite sua nota: ");
            decimal numero = decimal.Parse(Console.ReadLine());

            if (numero <= 10 && numero >= 7)
                Console.WriteLine("Aprovado");
            else if (numero < 7)
                Console.WriteLine("Exame");
            else if (numero < 4)
                Console.WriteLine("Reprovado");
            else
                Console.WriteLine("Média Inválida\n");
        }
    }
}
