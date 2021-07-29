using System;

namespace Commom.Dto.Customer
{
    public class CustomerPostDto
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public char? Gender { get; set; }
    }
}
