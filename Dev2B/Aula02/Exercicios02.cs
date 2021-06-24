using System;

namespace Aula02
{
    class Program
    {
        static void Exercicio01()
        {
            Console.Write("Escrever o número do item: ");
            int NumeroItem = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escrever a descrição do item: ");
            string Descricao = (Console.ReadLine());
            Console.Write("Escrever quantidade comprada deste item: ");
            int QtdComprada = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escrever valor unitário item: ");
            decimal PrecoUnit = Convert.ToDecimal(Console.ReadLine());

            ItemVenda item1 = new ItemVenda(NumeroItem, Descricao, QtdComprada, PrecoUnit);

            item1.calculaValorTotal();
            item1.EscreverValores();
        }

        static void Exercicio02()
        {
            Console.WriteLine("Hello World");
        }

        static void Exercicio03()
        {
            Console.WriteLine("Hello World");

        }
        static void Exercicio04()
        {
            Console.WriteLine("Hello World");

        }

        static void Main(string[] args)
        {
            //Exercicio01();
            //Exercicio02();
            //Exercicio03();
            //Exercicio04();
        }
    }
}

