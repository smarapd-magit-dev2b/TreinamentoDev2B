using System;

namespace Domain
{
    public class Product
    {
        public int Id { get; set; }
        public DateTime InclusionDate { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
