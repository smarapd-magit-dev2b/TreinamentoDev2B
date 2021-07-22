using System;

namespace Commom.Dto
{
    public class PersonPostDto
    {
        public int? IdMon { get; set; }
        public int? IdDad { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public string Race { get; set; }
        public string Cpf { get; set; }
    }
}
