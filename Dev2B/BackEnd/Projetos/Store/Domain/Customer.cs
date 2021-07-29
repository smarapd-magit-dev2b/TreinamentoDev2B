using System;
using System.Collections.Generic;

namespace Domain
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public char? Gender { get; set; }
        public IEnumerable<Sale> Sales { get; set; }
    }
}
