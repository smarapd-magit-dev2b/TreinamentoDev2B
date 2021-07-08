using System;
using System.Collections.Generic;
using System.Text;

namespace Aula05_Lista.ClassesAula05
{
    public class Venda
    {
        public string Id { get; set; }
        public DateTime DataVenda { get; set; }
        public string Vendedor { get; set; }
        public List<ItemVenda> Itens { get; set; }

        public Venda(string id, DateTime dataVenda, string vendedor)
        {
            Id = id;
            DataVenda = dataVenda;
            Vendedor = vendedor;
            Itens = new List<ItemVenda>();
        }
    }
}