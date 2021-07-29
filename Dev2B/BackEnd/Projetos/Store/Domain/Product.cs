using System;
using System.Collections.Generic;

namespace Domain
{
    public class Product
    {
        public int Id { get; set; }
        public DateTime InclusionDate { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public IEnumerable<Sale> Sales { get; set; }
        public IEnumerable<SaleItem> Items { get; set; }
    }
}
