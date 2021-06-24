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
            bool validacao = true;

            Console.Write("Digite um dia: ");
            int dia = int.Parse(Console.ReadLine());

            do
            {
                if (dia > 0 && dia <= 30)
                {
                    data.Dia = dia;
                    validacao = false;
                }
                else
                {
                    Console.WriteLine("Dia inválido!");
                    Console.Write("Insira um dia válido: ");
                    dia = int.Parse(Console.ReadLine());
                }
            } while (validacao);

            validacao = true;

            Console.Write("Digite um mes: ");
            int mes = int.Parse(Console.ReadLine());

            do
            {
                if (mes > 0 && mes <= 12)
                {
                    data.Mes = mes;
                    validacao = false;
                }
                else
                {
                    Console.WriteLine("Mes inválido!");
                    Console.Write("Insira um mes válido: ");
                    mes = int.Parse(Console.ReadLine());
                }
            } while (validacao);

            validacao = true;

            Console.Write("Digite um ano: ");
            int ano = int.Parse(Console.ReadLine());

            do
            {
                if (ano > 0)
                {
                    data.Ano = ano;
                    validacao = false;
                }
                else
                {
                    Console.WriteLine("Ano inválido!");
                    Console.WriteLine("Insira um ano válido: ");
                    ano = int.Parse(Console.ReadLine());
                }
            } while (validacao);

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
