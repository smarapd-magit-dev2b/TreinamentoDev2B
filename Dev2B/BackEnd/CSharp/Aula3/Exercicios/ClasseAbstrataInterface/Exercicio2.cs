using Aula3.Classes;
using Common.Interfaces;
using System;

namespace Aula3.Exercicios
{
    public class Exercicio2 : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("Classe Abstrata\n");

            Console.WriteLine($"15 + 13 = {new SomaAbstrata(15, 13).Calcular()}");
            Console.WriteLine($"15 - 13 = {new SubtracaoAbstrata(15, 13).Calcular()}");
            Console.WriteLine($"15 x 13 = {new MultiplicacaoAbstrata(15, 13).Calcular()}");
            Console.WriteLine($"15 / 13 = {new DivisaoAbstrata(15, 13).Calcular()}");

            Console.WriteLine("Interface\n");

            Console.WriteLine($"15 + 13 = {new SomaInterface(15, 13).Calcular()}");
            Console.WriteLine($"15 - 13 = {new SubtracaoInterface(15, 13).Calcular()}");
            Console.WriteLine($"15 x 13 = {new MultiplicacaoInterface(15, 13).Calcular()}");
            Console.WriteLine($"15 / 13 = {new DivisaoInterface(15, 13).Calcular()}");
        }
    }
}
