using Domain.Interfaces;
using System;

namespace Aula1.Exercicios
{
    public class Exercicios4 : IExecute
    {
        private char Operacao { get; set; }

        public void Execute()
        {
            Exercicio4if();
            Exercicio4switch();
        }

        private void Exercicio4if()
        {
            Console.Write("Exercício 4 If\n\nDigite dois números e a operação que deseja realizar com eles\n\n" +
                "Operações: Soma(+), Subtração(-), Multiplicação(x), Divisão(/)\n\n" +
                "Primeiro número: ");
            var numero1 = decimal.Parse(Console.ReadLine());

            Console.Write("Segundo número: ");
            var numero2 = decimal.Parse(Console.ReadLine());

            Console.Write("Operação: ");
            try
            {
                Operacao = char.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Digite apenas 1 caractere!");
            }

            if (Operacao == '+')
                Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
            else if (Operacao == '-')
                Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2}");
            else if (Operacao == 'x')
                Console.WriteLine($"{numero1} x {numero2} = {numero1 * numero2}");
            else if (Operacao == '/')
                Console.WriteLine($"{numero1} / {numero2} = {numero1 / numero2}");
            else
                Console.WriteLine($"{Operacao} é uma operação inválida!");
        }

        private void Exercicio4switch()
        {
            Console.WriteLine("Exercício 4 Switch\n\nDigite dois números e a operação que deseja realizar com eles\n\n" +
                "Operações: Soma(+), Subtração(-), Multiplicação(x), Divisão(/)\n\n" +
                "Primeiro número: ");
            var numero1 = decimal.Parse(Console.ReadLine());

            Console.Write("Segundo número: ");
            var numero2 = decimal.Parse(Console.ReadLine());

            Console.Write("Operação: ");
            try
            {
                Operacao = char.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Digite apenas 1 caractere!");
            }

            switch (Operacao)
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
                    Console.WriteLine($"{Operacao} é uma operação inválida!");
                    break;
            }
        }
    }
}
