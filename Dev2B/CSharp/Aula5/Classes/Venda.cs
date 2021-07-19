using System;
using System.Collections.Generic;

namespace Aula5.Classes
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public string Vendedor { get; set; }
        public List<ItemVenda> Items { get; set; }
    }
}
