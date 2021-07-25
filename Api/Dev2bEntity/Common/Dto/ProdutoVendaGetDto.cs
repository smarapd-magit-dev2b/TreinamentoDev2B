using System;


namespace Common.Dto
{
    public class ProdutoVendaGetDto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
    }
}
