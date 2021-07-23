using System;

namespace Common.Dto
{
    public class ProdutoGetAllDto
    {
        public int Id { get; set; }
        public DateTime DataInclusao { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
    }
}
