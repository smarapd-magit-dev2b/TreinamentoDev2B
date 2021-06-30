using System;
using System.Collections.Generic;

namespace Aula4.Exercicio4.Classes
{
    public class Venda
    {
        public Venda(int id)
        {
            Id = id;
            items = new List<ItemVenda>();
            Console.WriteLine("Informe a data de venda");
            DataVenda = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do vendedor");
            Vendedor = Console.ReadLine();
        }

        public List<ItemVenda> items { get; set; }
        public int Id { get; }
        public DateTime DataVenda { get; set; }
        public string Vendedor { get; set; }
    }
}