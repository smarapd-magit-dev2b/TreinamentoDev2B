using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio1();
            //exercicio2();
            exercicio3();
            //exercicio4();
        }

        static void exercicio1()
        {
            //ItemVenda item = new ItemVenda(475, "Caixa de chocolate", -1, 7.80m);

            ItemVenda item = new ItemVenda();

            Console.Write("Digite o código do item: ");
            item.NumeroItem = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição do item: ");
            item.Descricao = Console.ReadLine();

            Console.Write("Digite a quatidade de item comprada: ");
            item.QuantidadeComprada = int.Parse(Console.ReadLine());

            Console.Write("Digite o preço unitário do item: ");
            item.PrecoUnitario = decimal.Parse(Console.ReadLine());

            Console.WriteLine();

            item.EscreverProduto();
 
        }

        static void exercicio2()
        {
            //Empregado empregado = new Empregado("Yuri", "Fabio", 3000m);

            Empregado empregado = new Empregado();

            Console.Write("Digite o nome do empregado: ");
            empregado.Nome = Console.ReadLine();

            Console.Write("Digite o sobrenome do empregado: ");
            empregado.SobreNome = Console.ReadLine();

            Console.Write("Digite o salário mensal do empregado: ");
            empregado.SalarioMensal = decimal.Parse(Console.ReadLine());

            empregado.EscreverEmpregado();
        }

        static void exercicio3()
        {
            Data data = new Data();

            Console.Write("Digite um dia: ");
            data.Dia = int.Parse(Console.ReadLine());

            Console.Write("Digite um mês: ");
            data.Mes = int.Parse(Console.ReadLine());

            Console.Write("Digite um ano: ");
            data.Ano = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Dia de hoje: {data.toString()}");
            data.ProximoDia();
            Console.WriteLine($"Próximo dia: {data.toString()}");
        }

        static void exercicio4()
        {

        }
    }
}
