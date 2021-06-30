using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.Exercicio6Classes
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public string Vendedor { get; set; }
        public List<ItemVenda> Itens { get; set; }

        public Venda(int id, DateTime dataVenda, string vendedor)
        {
            Id = id;
            DataVenda = dataVenda;
            Vendedor = vendedor;
            Itens = new List<ItemVenda>();
        }
    }
}
