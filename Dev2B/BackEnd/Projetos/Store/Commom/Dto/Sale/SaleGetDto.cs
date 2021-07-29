using Commom.Dto.SaleItem;
using System;
using System.Collections.Generic;

namespace Commom.Dto.Sale
{
    public class SaleGetDto
    {
        public string Customer { get; set; }
        public string Cpf { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public IEnumerable<SaleItemGetDto> Items { get; set; }
    }
}
