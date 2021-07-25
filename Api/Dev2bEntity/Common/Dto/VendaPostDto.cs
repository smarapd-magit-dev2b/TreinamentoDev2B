using System;
using System.Collections.Generic;

namespace Common.Dto
{
    public class VendaPostDto
    {
        public int IdCliente { get; set; }
        public DateTime Data { get; set; }
        public ICollection<ProdutoDto> Produtos { get; set; }
    }
}
