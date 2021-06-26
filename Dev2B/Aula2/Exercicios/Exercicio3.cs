using Domain.Classes;
using Domain.Interfaces;
using System;

namespace Aula2
{
    class Exercicio3 : IExecute
    {
        public void Execute()
        {
            Console.Write("Exercício 3\n\n" +
                "Formatador de Data\n\n" +
                "Digite o Dia: ");
            var dia = int.Parse(Console.ReadLine());

            Console.Write("Digite o Mês: ");
            var mes = int.Parse(Console.ReadLine());

            Console.Write("Digite o Ano: ");
            var ano = int.Parse(Console.ReadLine());

            Data data = new Data(dia, mes, ano);
            Console.WriteLine($"Data atual: {data.ToUserString()}");

            data.ProximoDia();
            Console.WriteLine($"Próximo dia: {data.ToUserString()}");
        }
    }
}
