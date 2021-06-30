using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.Exercicio6Classes
{
    public class ItemVenda
    {
        public int IdItem { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int VendaId { get; set; }

        public ItemVenda(int idItem, string descricao, int quantidade, decimal precoUnit)
        {
            IdItem = idItem;
            Descricao = descricao;
            Quantidade = quantidade;
            PrecoUnitario = precoUnit;
        }

    }
}
