using System.Collections.Generic;

namespace Domain.Entities
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public ICollection<Pessoa> Pessoas { get; set; }
    }
}
