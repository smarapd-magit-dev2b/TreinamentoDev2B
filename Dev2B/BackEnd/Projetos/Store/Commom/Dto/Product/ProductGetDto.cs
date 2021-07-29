using System;

namespace Commom.Dto.Product
{
    public class ProductGetDto
    {
        public int Id { get; set; }
        public DateTime InclusionDate { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
    }
}
