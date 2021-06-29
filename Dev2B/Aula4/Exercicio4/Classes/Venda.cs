using System;
using System.Collections.Generic;

namespace Aula4.Exercicio4.Classes
{
    public class Venda
    {
        public List<ItemVenda> items { get; set; }
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public string Vendedor { get; set; }

        public Venda()
        {
            items = new List<ItemVenda>();
        }
        public Venda(List<ItemVenda> items, int id, DateTime dataVenda, string vendedor)
        {
            this.items = items;
            Id = id;
            DataVenda = dataVenda;
            Vendedor = vendedor;
        }
    }
}
