using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Dto
{
    public class VendaGetAllDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal ValorTotal { get; set; }
        public ICollection<ProdutoVendaGetDto> Produtos { get; set; }
    }
}
