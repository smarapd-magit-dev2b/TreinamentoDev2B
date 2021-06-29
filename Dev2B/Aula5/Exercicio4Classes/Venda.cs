using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.Exercicio4Classes
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public string Vendedor { get; set; }
        public List<ItemVenda> Itens { get; set; } = new List<ItemVenda>();
    }
}
