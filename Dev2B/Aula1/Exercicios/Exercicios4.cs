using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula1
{
    public class Exercicios4 : IExecute
    {
        public void Execute()
        {
            Exercicio4if();
            Exercicio4switch();
        }

        private void Exercicio4if()
        {
            decimal numero1, numero2;
            char? operacao = null;
            Console.WriteLine("Exercício 4 If\n\nDigite dois números e a operação que deseja realizar com eles\n\n" +
                "Operações: Soma(+), Subtração(-), Multiplicação(x), Divisão(/)\n");
            Console.Write("Primeiro número: ");
            numero1 = decimal.Parse(Console.ReadLine());
            Console.Write("Segundo número: ");
            numero2 = decimal.Parse(Console.ReadLine());
            Console.Write("Operação: ");
            try
            {
                operacao = char.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Digite apenas 1 caractere!");
            }
            if (operacao == '+')
                Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
            else if (operacao == '-')
                Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2}");
            else if (operacao == 'x')
                Console.WriteLine($"{numero1} x {numero2} = {numero1 * numero2}");
            else if (operacao == '/')
                Console.WriteLine($"{numero1} / {numero2} = {numero1 / numero2}");
            else
                Console.WriteLine($"{operacao} é uma operação inválida!");
            Console.WriteLine("\n");
        }

        private void Exercicio4switch()
        {
            decimal numero1, numero2;
            char? operacao = null;
            Console.WriteLine("Exercício 4 Switch\n\nDigite dois números e a operação que deseja realizar com eles\n\n" +
                "Operações: Soma(+), Subtração(-), Multiplicação(x), Divisão(/)\n");
            Console.Write("Primeiro número: ");
            numero1 = decimal.Parse(Console.ReadLine());
            Console.Write("Segundo número: ");
            numero2 = decimal.Parse(Console.ReadLine());
            Console.Write("Operação: ");
            try
            {
                operacao = char.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Digite apenas 1 caractere!");
            }
            switch (operacao)
            {
                case '+':
                    Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
                    break;
                case '-':
                    Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2}");
                    break;
                case 'x':
                    Console.WriteLine($"{numero1} x {numero2} = {numero1 * numero2}");
                    break;
                case '/':
                    Console.WriteLine($"{numero1} / {numero2} = {numero1 / numero2}");
                    break;
                default:
                    Console.WriteLine($"{operacao} é uma operação inválida!");
                    break;
            }
            Console.WriteLine("\n");
        }
    }
}
