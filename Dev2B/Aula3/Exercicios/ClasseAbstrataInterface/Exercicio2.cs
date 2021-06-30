using Domain.Classes.Operacao;
using Domain.Interfaces;
using System;

namespace Aula3.Exercicios
{
    public class Exercicio2 : IExecute
    {
        public void Cadastrar()
        {
            Console.WriteLine($"15 + 13 = {new Soma(15, 13).Calcular()}");
            Console.WriteLine($"15 - 13 = {new Subtracao(15, 13).Calcular()}");
            Console.WriteLine($"15 x 13 = {new Multiplicacao(15, 13).Calcular()}");
            Console.WriteLine($"15 / 13 = {new Divisao(15, 13).Calcular()}");
        }
    }
}
