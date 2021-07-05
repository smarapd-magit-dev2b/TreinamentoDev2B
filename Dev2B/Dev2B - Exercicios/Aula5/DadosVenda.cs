using System;
using System.Collections.Generic;
using System.Text;

namespace Aluno
{
    public class DadosVenda
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public string Vendedor { get; set; }
        public List<DadosItemVenda> Itens { get; set; } = new List<DadosItemVenda>();

        public override string ToString()
        {
            return $"\nID: {Id}. Data da venda: {DataVenda.ToString("dd/MM/yyyy")} Vendedor: {Vendedor}.\n";
        }
    }
}
