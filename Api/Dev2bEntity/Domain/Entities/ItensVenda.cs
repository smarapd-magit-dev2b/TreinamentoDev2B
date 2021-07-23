using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class ItensVenda
    {
        public int IdVenda { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorTotal { get; set; }
        public Venda Venda { get; set; }
        public Produto Produto { get; set; }
    }
}
