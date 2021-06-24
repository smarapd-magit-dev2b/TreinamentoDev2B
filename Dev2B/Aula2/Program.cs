using Domain;
using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            Ex3();
        }
        private static void Ex1()
        {
            ItemVenda ps5 = new ItemVenda(23, "PS5", 99, 5999.9m);
            Console.WriteLine($"O valor total do produto será de R${ps5.CalcularValorTotal()}");
        }
        private static void Ex2()
        {
            Empregado manuel = new Empregado("Manoel", "Robson", 15200);
            Console.WriteLine($"O salário anual de {manuel.Nome} é R${manuel.CalcularSalarioAtual()}");
            manuel.reajustarSalario(0.15m);
            Console.WriteLine($"Com um aumento de 15%, seu salário mensal será {manuel.Salario}");
        }
        private static void Ex3()
        {
            //Retornar Data invalida
            Data data = new Domain.Data(31, 2, 2014);
            Console.WriteLine($"Data atual: {data.toString()}");

            //Retornar data válida e pular de ano
            data.Dia = 31;
            data.Mes = 12;
            data.Ano = 2021;
            Console.WriteLine($"Data atual: {data.toString()}");
            data.ProximoDia();
            Console.WriteLine($"Data atual: {data.toString()}");
        }
    }
}
