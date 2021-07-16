using System;

namespace Ex_2Abs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor: ");
            decimal valor1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o segudo valor: ");
            decimal valor2 = Convert.ToDecimal(Console.ReadLine());

            var soma = new Soma(valor1, valor2);

            var subtração = new Subtração(valor1, valor2);

            var multiplicação = new Multiplicação(valor1, valor2);

            var divisão = new Divisão(valor1, valor2);

            Console.WriteLine($"A Soma dos valores: {soma.Calculo(valor1, valor2)}");
            Console.WriteLine($"A Subtração dos valores: {subtração.Calculo(valor1, valor2)}");
            Console.WriteLine($"A Multiplicação dos valores: {multiplicação.Calculo(valor1, valor2)}");
            Console.WriteLine($"A Divisão dos valores: {divisão.Calculo(valor1, valor2)}");
        }
    }
}
