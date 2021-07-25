using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Venda
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public DateTime Data { get; set; }
        public Cliente Cliente { get; set; }
        public ICollection<ItensVenda> ListItensVenda { get; set; }
    }
}
