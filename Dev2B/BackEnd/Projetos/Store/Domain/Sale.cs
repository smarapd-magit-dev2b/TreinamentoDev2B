using System;
using System.Collections.Generic;

namespace Domain
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<SaleItem> Items { get; set; }
    }
}
