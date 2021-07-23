using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public DateTime DataInclusao { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public ICollection<ItensVenda> ItensVenda { get; set; }

    }
}
