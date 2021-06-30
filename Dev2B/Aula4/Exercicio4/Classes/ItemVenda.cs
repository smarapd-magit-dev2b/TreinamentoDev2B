using System;

namespace Aula4.Exercicio4.Classes
{
    public class ItemVenda
    {
        public ItemVenda()
        {
            Console.WriteLine("Informe o id do produto");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a descricao do produto");
            Descricao = Console.ReadLine();
            Console.WriteLine("Informe a quantidade do produto");
            Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o preco do produto");
            Preco = decimal.Parse(Console.ReadLine());
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
    }
}