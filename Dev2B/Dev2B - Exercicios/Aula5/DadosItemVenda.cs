using System;
using System.Collections.Generic;
using System.Text;

namespace Aluno
{
    public class DadosItemVenda
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int QntdVendida { get; set; }
        public decimal PrecoUnitario { get; set; }

        public override string ToString()
        {
            return $"| ID do produto: {Id} | Descrição do produto: {Descricao} | Quantidade vendida: {QntdVendida} | Preço unitario: {PrecoUnitario} |";
        }
    }
}
