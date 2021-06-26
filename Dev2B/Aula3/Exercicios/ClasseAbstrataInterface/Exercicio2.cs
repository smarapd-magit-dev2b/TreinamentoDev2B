using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Exercicios.ClasseAbstrataInterface
{
    public class Exercicio2 : IExecute
    {
        public void Execute()
        {
            Console.WriteLine($"15 + 13 = {new Soma(15, 13).Calcular()}");
            Console.WriteLine($"15 - 13 = {new Subtracao(15, 13).Calcular()}");
            Console.WriteLine($"15 x 13 = {new Multiplicacao(15, 13).Calcular()}");
            Console.WriteLine($"15 / 13 = {new Divisao(15, 13).Calcular()}");
        }
    }
}
