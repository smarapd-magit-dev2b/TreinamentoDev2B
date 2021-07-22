using System;

namespace Commom.Dto.Costummer
{
    public class CostummerPostDto
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public char Gender { get; set; }
    }
}
