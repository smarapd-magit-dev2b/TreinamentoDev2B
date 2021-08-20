using System.Collections.Generic;

namespace Domain
{
    public class Address
    {
        public int Id { get; set; }
        public string Cep { get; set; }
        public string Street { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Number { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }
    }
}
